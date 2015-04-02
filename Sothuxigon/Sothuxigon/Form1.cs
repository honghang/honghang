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

namespace Sothuxigon
{
    public partial class SoThu : Form
    {
        public SoThu()
        {
            InitializeComponent();
        }

        private void ListBox_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            int index = lb.IndexFromPoint(e.X, e.Y);
            lb.DoDragDrop(lb.Items[index].ToString(), DragDropEffects.Move);            
        }

        private void ListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.Move;
        }

        private void listDS_DragDrop(object sender, DragEventArgs e)
        {
            //kiemt tra du lieu sao chep co dung k
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                ListBox lb = (ListBox)sender;

                lb.Items.Add(e.Data.GetData(DataFormats.Text));
            }
         
        }

        private void Save(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("danhsachsothu.txt");
            if (writer == null) return;

            foreach (var item in listDS.Items)
                writer.WriteLine(item.ToString());

            writer.Close();
        }

        
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            l3.Text = string.Format("Bay gio la {0}:{1}:{2} ngay {3} thang {4} nam {5}", DateTime.Now.Hour, DateTime.Now.Minute,DateTime.Now.Second, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year); ;
        }

        private void tảiDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("C:/thumoi");
            if (reader == null) return;

            string input = null;
            while ((input = reader.ReadLine()) != null)
            {
                listThumoi.Items.Add(input);
            }
            reader.Close();

            using (StreamReader rs = new StreamReader("danhsahcthu.txt"))
            {
                input = null;
                while ((input = rs.ReadLine()) != null)
                {
                    listThumoi.Items.Add(input);
                }
            }

        }

        private void listDS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SoThu_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            l3.Text = string.Format("Bay gio : {0}:{1}:{2}  ngay {3} thang {4} nam {5}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year); ;
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes) { this.Close(); }

        }

       
        

       
    }
}
