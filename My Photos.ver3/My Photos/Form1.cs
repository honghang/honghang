using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_Photos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pbxPhoto_Click(object sender, EventArgs e)
        {

        }

        

        private void mnuLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = " open photo";
            dlg.Filter = "jpg files(*.jpg)|*.jpg|All file(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {//dlg.OpenFile();dlg.FileName();}
                //kiểm tra dạng file
                try { pbxPhoto.Image = new Bitmap(dlg.OpenFile()); SetStatusStrip(dlg.FileName); }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("koh the load file:" + ex.Message);
                    pbxPhoto.Image = null;
                }
                // pbxPhoto.Image=new Bitmap(dlg.OpenFile());
            }
            dlg.Dispose();


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes) { this.Close(); }
        }

        private void ProcessPhoto(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            string enumVal = item.Tag as string;
            if (enumVal != null)
            { pbxPhoto.SizeMode = (PictureBoxSizeMode)Enum.Parse(typeof(PictureBoxSizeMode), enumVal); }
        }

       

        private void mnuImage_DropDownOpening(object sender, EventArgs e)
        {
            ToolStripDropDownItem parent = (ToolStripDropDownItem)sender;
            if (parent != null)
            { string enumVal = pbxPhoto.SizeMode.ToString();// đưa ra dạng chuỗi các giá trị của 1 đối tượng nào đó
            foreach (ToolStripMenuItem item in parent.DropDownItems)
            { item.Enabled = (pbxPhoto.Image != null);
            item.Checked = item.Tag.Equals(enumVal);
            }
            }

        }

        private void SetStatusStrip(string path)
        {
            if (pbxPhoto.Image != null)
            { sttInfo.Text = path;
            sttImageSize.Text = string.Format("{0:#} x {1:#}", pbxPhoto.Image.Width, pbxPhoto.Image.Height);
            }
            else
            {sttImageSize=null;sttInfo=null;sttAlbumPos=null;}
        }



    }
}
