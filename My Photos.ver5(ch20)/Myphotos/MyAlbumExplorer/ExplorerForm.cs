using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Manning.MyPhotoAlbum;
using Manning.MyPhotoControls;

namespace MyAlbumExplorer
{
    public partial class ExplorerForm : Form
    {
        private MyListViewComparer _comparer;
        private MyListViewComparer MyComparer
        { get { return _comparer; } }
        private Photograph _currentPhoto = null;
        private void albumTree_BeforeSelect(
          object sender,
          TreeViewCancelEventArgs e)
        {
            if (_currentPhoto != null)
            {
                spbxPhoto.Image = null;
                _currentPhoto.ReleaseImage();
                _currentPhoto = null;
            }
        }
        public ExplorerForm()
        {
            InitializeComponent();
        }

        private void ExplorerForm_Load(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            // Assign title bar
            Version v = new Version(Application.
                                ProductVersion);
            _comparer = new MyListViewComparer(
                    lvAlbumList);
            lvAlbumList.ListViewItemSorter = MyComparer;
            this.Text = String.Format(
                "MyAlbumExplorer {0:#}.{1:#}",
                v.Major, v.Minor);
            base.OnLoad(e);
        
        }
        private void lvAlbumList_ColumnClick(
    object sender, ColumnClickEventArgs e)
        {
            if (e.Column == MyComparer.SortColumn)
            {
                // Switch the sort order for this column
                if (lvAlbumList.Sorting
                        == SortOrder.Ascending)
                    lvAlbumList.Sorting = SortOrder.Descending;
                else
                    lvAlbumList.Sorting = SortOrder.Ascending;
            }
            else
            {
                // Define new sort column and order
                MyComparer.SortColumn = e.Column;
                lvAlbumList.Sorting = SortOrder.Ascending;
            }
            lvAlbumList.Sort();
        }
        private void albumTree_AfterSelect(
      object sender, TreeViewEventArgs e)
        {
            try
            {
                bool oldShowingAlbums = ShowingAlbums;
                lvAlbumList.BeginUpdate();
                lvAlbumList.Clear();
                if (e.Node is AlbumDirectoryNode)
                    ListAlbumData(e.Node
                        as AlbumDirectoryNode);
                else if (e.Node is AlbumNode)
                    ListPhotoData(e.Node as AlbumNode);
                else if (e.Node is PhotoNode)
                    DisplayPhoto(e.Node as PhotoNode);
                else
                    throw new ArgumentException(
                                  "Unrecognized node");
                if (lvAlbumList.Visible
      && ShowingAlbums != oldShowingAlbums)
                {
                    // Columns changed, so reset sorting
                    MyComparer.SortColumn = 0;
                    lvAlbumList.Sorting = SortOrder.Ascending;
                }
            }
            finally
            {
                lvAlbumList.EndUpdate();
            }
        }
        private void menuEditProperties_Click(
    object sender, EventArgs e)
        {
            // Note: picture box cannot receive focus
            if (lvAlbumList.Focused)
                DisplayListItemProperties();
            else if (albumTree.Focused)
                DisplayTreeNodeProperties();
        }
        private void DisplayTreeNodeProperties()
        {
            TreeNode node = albumTree.SelectedNode;
            if (node is AlbumNode)
            {
                AlbumNode aNode = (AlbumNode)node;
                AlbumManager mgr = aNode.GetManager(true);
                if (mgr != null)
                    DisplayAlbumProperties(mgr);
            }
            else if (node is PhotoNode)
            {
                PhotoNode pNode = (PhotoNode)node;
                DisplayPhotoProperties(pNode.Photograph);
            }
            // Preserve and display any changes

        }
          private void DisplayListItemProperties()
  {
    if (lvAlbumList.SelectedItems.Count == 1)
    {
      ListViewItem item
          = lvAlbumList.SelectedItems[0];
      if (item.Tag is AlbumManager)
      {
        AlbumManager mgr = (AlbumManager)item.Tag;
        DisplayAlbumProperties(mgr);
        AssignSubItems(item, mgr.FullName, mgr);
        if (mgr.Album.HasChanged)
          mgr.Save();
      }

      else if (item.Tag is Photograph)
      {
        Photograph photo = (Photograph)item.Tag;
        DisplayPhotoProperties(photo);
        if (photo.HasChanged)
        {
          AssignSubItems(item, photo);
        
        }
      }
      else
          MessageBox.Show("The properties for this"
              + " item cannot be displayed.");
    }
  }
          private void menuEdit_DropDownOpening(
      object sender, EventArgs e)
          {
              menuEditLabel.Enabled = true;
              if (lvAlbumList.Focused)
                  menuEditLabel.Text = "Captio&n";
              else if (albumTree.Focused)
                  menuEditLabel.Text = "&Name";
              else
                  menuEditLabel.Enabled = false;
          }
          private void menuEditLabel_Click
              (object sender, EventArgs e)
          {
              if (lvAlbumList.Focused)
              {
                  if (lvAlbumList.FocusedItem != null)
                      lvAlbumList.FocusedItem.BeginEdit();
              }
              else if (albumTree.Focused)
              {
                  if (albumTree.SelectedNode != null)
                      albumTree.SelectedNode.BeginEdit();
              }
          }
          private void lvAlbumList_AfterLabelEdit
      (object sender, LabelEditEventArgs e)
  {
    if (String.IsNullOrEmpty(e.Label))
    {
      e.CancelEdit = true;
      return;
    }
    ListViewItem item = lvAlbumList.Items[e.Item];
    if (item.Tag is Photograph)
    {
      Photograph photo = (Photograph)item.Tag;
      photo.Caption = e.Label;
      if (photo.HasChanged)
          e.CancelEdit = true;
      return;
    }
    else
    {
      RenameAlbum(item, e.Label);
    }
  }
  private void RenameAlbum(
      ListViewItem item, string newName)
  {
    try
    {
      string oldPath = null;
      string newPath = null;
      if (item.Tag is AlbumManager)
      {
        AlbumManager mgr = (AlbumManager)item.Tag;
        oldPath = mgr.FullName;
     
        newPath = mgr.FullName;
      }
           else if (item.Tag is string)
   {
     // Presume tag is album path
     oldPath = (string)item.Tag;

     item.Tag = newPath;
   }
  
    }
    catch (ArgumentException aex)
    {
        MessageBox.Show("Unable to rename album. ["
          + aex.Message + "]");
    }
  }
  private void lvAlbumList_ItemActivate(
object sender, EventArgs e)
  {
      // ListViewItem is visible and selected
      ListViewItem item
          = lvAlbumList.SelectedItems[0];
      TreeNode node = null;
      if (ShowingAlbums)
      {
          string albumPath;
          AlbumManager mgr = item.Tag as AlbumManager;
          if (mgr == null)
              albumPath = item.Tag as string;
          else
              albumPath = mgr.FullName;
          if (albumPath != null)

          { }
      }
      else
      {
          Photograph photo = item.Tag as Photograph;
          if (photo != null)
          { }
      }
      if (node != null)
          albumTree.SelectedNode = node;
  }
          private void lvAlbumList_KeyDown(
              object sender, KeyEventArgs e)
          {
              if (e.KeyCode == Keys.F2)
              {
                  if (lvAlbumList.FocusedItem != null)
                      lvAlbumList.FocusedItem.BeginEdit();
                  e.Handled = true;
              }
          }
          private void DisplayAlbumProperties(
      AlbumManager mgr)
          {
              using (AlbumEditDialog dlg
                         = new AlbumEditDialog(mgr))
              {
                  dlg.ShowDialog();
              }
          }
          private void DisplayPhotoProperties(
              Photograph photo)
          {
              using (PhotoEditDialog dlg
                         = new PhotoEditDialog(photo))
              {
                  dlg.ShowDialog();
              }
          }
        private void DisplayPhoto(
          PhotoNode photoNode)
        {
            spbxPhoto.Visible = true;
            lvAlbumList.Visible = false;
            _currentPhoto = photoNode.Photograph;
            spbxPhoto.Image = _currentPhoto.Image;
        }
         private bool _showingAlbums = true;
 private bool ShowingAlbums
 {
   get { return _showingAlbums; }
   set { _showingAlbums = value; }
 }
 private void ListAlbumData(
     AlbumDirectoryNode dirNode)
 {
   // Show albums in list view
   spbxPhoto.Visible = false;
   lvAlbumList.Visible = true;
   ShowingAlbums = true;
   // Presume list cleared, so recreate columns
   lvAlbumList.Columns.Add("Name", 80);
   lvAlbumList.Columns.Add("Title", 120);
   lvAlbumList.Columns.Add("Size", 40,
       HorizontalAlignment.Center);
   // Add the albums for given node
   foreach (AlbumNode aNode
                in dirNode.AlbumNodes)
   {
       string text
           = Path.GetFileNameWithoutExtension(
                      aNode.AlbumPath);
       ListViewItem item
           = lvAlbumList.Items.Add(text);
       AlbumManager mgr = aNode.GetManager(false);
       item.ImageKey = aNode.ImageKey;
       AssignSubItems(item, aNode.AlbumPath, mgr);
   }
 }
 private void AssignSubItems(ListViewItem item,
string path, AlbumManager mgr)
 {
     item.SubItems.Clear();
     item.Text = Path.
         GetFileNameWithoutExtension(path);
     ListViewItem.ListViewSubItem subitem;
     if (mgr == null)
     {
         item.Tag = path;
         item.SubItems.Add("");
         subitem = item.SubItems.Add("?");
         subitem.Tag = 999;
     }
     else
     {
         PhotoAlbum album = mgr.Album;
         int count = album.Count;
         item.Tag = mgr;
         item.SubItems.Add(album.Title);
         subitem = item.SubItems.Add(
                           count.ToString());
         subitem.Tag = count;
     }
 }
 private void ListPhotoData(AlbumNode albumNode)
 {
     // Show photographs in list view
     spbxPhoto.Visible = false;
     lvAlbumList.Visible = true;
     ShowingAlbums = false;
     // Presume contents cleared, so recreate columns
     lvAlbumList.Columns.Add("Caption", 120);
     lvAlbumList.Columns.Add("Photographer", 100);
     lvAlbumList.Columns.Add("Taken", 80,
         HorizontalAlignment.Center);
     lvAlbumList.Columns.Add("File Name", 200);
     // Add the photos for given node
     AlbumManager mgr = albumNode.GetManager(true);
     if (mgr != null)
     {
         foreach (Photograph p in mgr.Album)
         {
             ListViewItem item
               = new ListViewItem(p.Caption, "Photo");
             AssignSubItems(item, p);
             lvAlbumList.Items.Add(item);
         }
     }
 }
 private void AssignSubItems(
ListViewItem item, Photograph photo)
 {
     item.SubItems.Clear();
     item.Text = photo.Caption;
     item.Tag = photo;
     ListViewItem.ListViewSubItem subitem;
     item.SubItems.Add(photo.Photographer);
     subitem = item.SubItems.Add(
         photo.DateTaken.ToString("dd MMM yyyy"));
     subitem.Tag = photo.DateTaken;
     item.SubItems.Add(photo.FileName);
 }
        private void menuView_DropDownOpening( object sender, EventArgs e)
        {

        }
        private void menuView_DropDownItemClicked(
          object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuView_DropDownOpening_1(object sender, EventArgs e)
        {
            {
                View v = lvAlbumList.View;
                menuViewLarge.Checked = (v == View.LargeIcon);
                menuViewSmall.Checked = (v == View.SmallIcon);
                menuViewList.Checked = (v == View.List);
                menuViewDetails.Checked = (v == View.Details);
                menuViewTiles.Checked = (v == View.Tile);
            }
        }
 
    }
}
