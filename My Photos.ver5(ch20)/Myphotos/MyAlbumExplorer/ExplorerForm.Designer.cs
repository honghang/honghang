namespace MyAlbumExplorer
{
    partial class ExplorerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExplorerForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewTiles = new System.Windows.Forms.ToolStripMenuItem();
            this.albumTree = new System.Windows.Forms.TreeView();
            this.lvAlbumList = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuEditProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.spbxPhoto = new Manning.MyPhotoControls.ScrollablePictureBox();
            this.labelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spbxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.albumTree);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.spbxPhoto);
            this.splitContainer1.Panel2.Controls.Add(this.lvAlbumList);
            this.splitContainer1.Size = new System.Drawing.Size(483, 330);
            this.splitContainer1.SplitterDistance = 160;
            this.splitContainer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEditLabel,
            this.menuView});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(160, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(92, 22);
            this.menuFileExit.Text = "E&xit";
            // 
            // menuEditLabel
            // 
            this.menuEditLabel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditProperties,
            this.labelToolStripMenuItem});
            this.menuEditLabel.Name = "menuEditLabel";
            this.menuEditLabel.Size = new System.Drawing.Size(39, 20);
            this.menuEditLabel.Text = "&Edit";
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewLarge,
            this.menuViewSmall,
            this.menuViewList,
            this.menuViewDetails,
            this.menuViewTiles});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(44, 20);
            this.menuView.Text = "&View";
            this.menuView.DropDownOpening += new System.EventHandler(this.menuView_DropDownOpening_1);
            // 
            // menuViewLarge
            // 
            this.menuViewLarge.Name = "menuViewLarge";
            this.menuViewLarge.Size = new System.Drawing.Size(152, 22);
            this.menuViewLarge.Tag = "LargeIcon";
            this.menuViewLarge.Text = "Lar&ge Icons";
            // 
            // menuViewSmall
            // 
            this.menuViewSmall.Name = "menuViewSmall";
            this.menuViewSmall.Size = new System.Drawing.Size(152, 22);
            this.menuViewSmall.Tag = "SmallIcon";
            this.menuViewSmall.Text = "S&mall Icons";
            // 
            // menuViewList
            // 
            this.menuViewList.Name = "menuViewList";
            this.menuViewList.Size = new System.Drawing.Size(152, 22);
            this.menuViewList.Tag = "List";
            this.menuViewList.Text = "&List";
            // 
            // menuViewDetails
            // 
            this.menuViewDetails.Name = "menuViewDetails";
            this.menuViewDetails.Size = new System.Drawing.Size(152, 22);
            this.menuViewDetails.Tag = "Details";
            this.menuViewDetails.Text = "&Details";
            // 
            // menuViewTiles
            // 
            this.menuViewTiles.Name = "menuViewTiles";
            this.menuViewTiles.Size = new System.Drawing.Size(152, 22);
            this.menuViewTiles.Tag = "Tile";
            this.menuViewTiles.Text = "&Tiles";
            // 
            // albumTree
            // 
            this.albumTree.Location = new System.Drawing.Point(0, 25);
            this.albumTree.Name = "albumTree";
            this.albumTree.ShowNodeToolTips = true;
            this.albumTree.Size = new System.Drawing.Size(160, 302);
            this.albumTree.TabIndex = 0;
            // 
            // lvAlbumList
            // 
            this.lvAlbumList.FullRowSelect = true;
            this.lvAlbumList.LabelEdit = true;
            this.lvAlbumList.LargeImageList = this.imageList1;
            this.lvAlbumList.Location = new System.Drawing.Point(0, 25);
            this.lvAlbumList.Name = "lvAlbumList";
            this.lvAlbumList.Size = new System.Drawing.Size(319, 281);
            this.lvAlbumList.TabIndex = 0;
            this.lvAlbumList.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "photo");
            this.imageList1.Images.SetKeyName(1, "Album");
            this.imageList1.Images.SetKeyName(2, "AlbumSelect");
            this.imageList1.Images.SetKeyName(3, "AlbumLock");
            this.imageList1.Images.SetKeyName(4, "AlbumError");
            this.imageList1.Images.SetKeyName(5, "AlbumDir");
            // 
            // imageListLarge
            // 
            this.imageListLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // menuEditProperties
            // 
            this.menuEditProperties.Name = "menuEditProperties";
            this.menuEditProperties.Size = new System.Drawing.Size(152, 22);
            this.menuEditProperties.Text = "&Properties";
            // 
            // spbxPhoto
            // 
            this.spbxPhoto.AllowScrollBars = true;
            this.spbxPhoto.Image = null;
            this.spbxPhoto.Location = new System.Drawing.Point(0, 22);
            this.spbxPhoto.Name = "spbxPhoto";
            this.spbxPhoto.Size = new System.Drawing.Size(319, 305);
            this.spbxPhoto.TabIndex = 1;
            this.spbxPhoto.TabStop = false;
            // 
            // labelToolStripMenuItem
            // 
            this.labelToolStripMenuItem.Name = "labelToolStripMenuItem";
            this.labelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.labelToolStripMenuItem.Text = "&Label";
            // 
            // ExplorerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 330);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExplorerForm";
            this.Text = "Album Explorer";
            this.Load += new System.EventHandler(this.ExplorerForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spbxPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.ListView lvAlbumList;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TreeView albumTree;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuEditLabel;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuViewLarge;
        private System.Windows.Forms.ToolStripMenuItem menuViewSmall;
        private System.Windows.Forms.ToolStripMenuItem menuViewList;
        private System.Windows.Forms.ToolStripMenuItem menuViewDetails;
        private System.Windows.Forms.ToolStripMenuItem menuViewTiles;
        private Manning.MyPhotoControls.ScrollablePictureBox spbxPhoto;
        private System.Windows.Forms.ToolStripMenuItem menuEditProperties;
        private System.Windows.Forms.ToolStripMenuItem labelToolStripMenuItem;
    }
}

