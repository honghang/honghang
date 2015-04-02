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
                try { pbxPhoto.Image = new Bitmap(dlg.OpenFile()); }
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
    }
}
