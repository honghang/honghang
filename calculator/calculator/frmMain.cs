using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class frmMain : Form
    {
        private bool isTypingNumber = false;
        enum PhepTinh { Cong,Tru,Nhan,Chia,PhanTram,sqrt,Phanso,Xoa1}
        PhepTinh pheptinh;
        double nho = 0.0;
        
        public frmMain()
        {
            InitializeComponent();
        }
        
         private void btnCong_Click(object sender, EventArgs e)
        {
            isTypingNumber = false;
            pheptinh = PhepTinh.Cong;
            this.Bang_Click(sender, e);
            nho = double.Parse(label1.Text);

        }
        private void btnNhan_Click(object sender, EventArgs e)
         {
             nho = double.Parse(label1.Text);
            isTypingNumber = false;
            pheptinh = PhepTinh.Nhan;
            this.Bang_Click(sender, e);
            
            
        }
        private void btnChia_Click(object sender, EventArgs e)
        {
            isTypingNumber = false;
            pheptinh = PhepTinh.Chia;
            this.Bang_Click(sender, e);
            nho = double.Parse(label1.Text);
        }
        private void btnTru_Click(object sender, EventArgs e)
        {
            isTypingNumber = false;
            pheptinh = PhepTinh.Tru;
            this.Bang_Click(sender, e);
            nho = double.Parse(label1.Text);
        }
        private void button1_Click(object sender, EventArgs e)//%
        {
            isTypingNumber = false;
            pheptinh = PhepTinh.PhanTram;
            this.Bang_Click(sender, e);
            nho = double.Parse(label1.Text);

        }

        private void tinhketqua()
        { double ketqua = 0.0;
        switch (pheptinh)
        {
            case PhepTinh.Phanso: ketqua = double.Parse(label1.Text); break;
            case PhepTinh.Cong: ketqua = double.Parse(label1.Text); break;
            case PhepTinh.Tru: ketqua = double.Parse(label1.Text); break;
            case PhepTinh.Nhan: ketqua = double.Parse(label1.Text); break;
            case PhepTinh.Chia: ketqua = double.Parse(label1.Text); break;
            case PhepTinh.PhanTram: ketqua = double.Parse(label1.Text); break;
            case PhepTinh.sqrt: ketqua = double.Parse(label1.Text); break;
            case PhepTinh.Xoa1: ketqua = double.Parse(label1.Text); break;
        } label1.Text = ketqua.ToString();
        }
    
        private void nhappheptoan(object sender, EventArgs e)
        {isTypingNumber = false;
            switch(((Button)sender).Text)
            { case "+":pheptinh = PhepTinh.Cong;break;
                case "/":pheptinh = PhepTinh.Chia;break;
                case "*":pheptinh = PhepTinh.Nhan;break;
                case "-":pheptinh = PhepTinh.Tru;break;
                case "%": pheptinh = PhepTinh.PhanTram; break;
                case "sqrt": pheptinh = PhepTinh.sqrt; break;
                case "1/x": pheptinh = PhepTinh.Phanso; break;
                case "<--": pheptinh = PhepTinh.Xoa1; break;
            }
            //this.btnBang_Click_1(sender, e);
            tinhketqua();
            nho = double.Parse(label1.Text);
        
        }
        private void nhapso(object sender, EventArgs e)
        { nhapso(((Button)sender).Text); }

        private void nhapso(string so)
        {
            if (isTypingNumber)
            {

                label1.Text = label1.Text + so;
            }

            else
            {
                label1.Text = so;
                isTypingNumber = true;
            }


        }
        //private void nhapso(object sender, EventArgs e)
        //{
           // if (isTypingNumber)
           // {
               
            //    label1.Text = label1.Text + ((Button)sender).Text;
            //}

            //else
            //{
             //   label1.Text = ((Button)sender).Text;
             //   isTypingNumber = true;
           // }

       
      //  }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void Bang_Click(object sender, EventArgs e)
        {

            isTypingNumber = false;
            double ketqua=0;
            //PhepTinh pt;
            switch (pheptinh)
            {
                case PhepTinh.Cong: ketqua = nho+double.Parse(label1.Text); break;
                case PhepTinh.Tru: ketqua = nho-double.Parse(label1.Text); break;
                case PhepTinh.Nhan: ketqua = nho*double.Parse(label1.Text); break;
                case PhepTinh.Chia: ketqua = nho/double.Parse(label1.Text); break;
                case PhepTinh.PhanTram: ketqua =double.Parse(label1.Text)/100; break;
                case PhepTinh.sqrt: ketqua = Math.Sqrt(double.Parse(label1.Text)); break;
                case PhepTinh.Phanso: ketqua = 1/double.Parse(label1.Text); break;
                case PhepTinh.Xoa1: ketqua = (int)(double.Parse(label1.Text)/10); break;                                                        
            }

            label1.Text = ketqua.ToString();
        }

      

       private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
       {switch (e.KeyChar)
       {case '0':
           case '1':
           case '2':
           case'3':
           case'4':
               nhapso("" + e.KeyChar);break;
       }

       }

       private void button13_Click(object sender, EventArgs e)// sqrt
       {
           isTypingNumber = false;
           pheptinh = PhepTinh.sqrt;
           this.Bang_Click(sender, e);
           nho = double.Parse(label1.Text);

       }

       private void btnPhanSo_Click(object sender, EventArgs e)
       {
           isTypingNumber = false;
           pheptinh = PhepTinh.Phanso;
           this.Bang_Click(sender, e);
           nho = double.Parse(label1.Text);

       }

       private void btnmuiten_Click(object sender, EventArgs e)
       {
           isTypingNumber = false;
           pheptinh = PhepTinh.Xoa1;
           this.Bang_Click(sender, e);
           nho = double.Parse(label1.Text);

       }

       private void btnC_Click(object sender, EventArgs e)
       {
           isTypingNumber = false;
          // pheptinh = PhepTinh.Xoa1;
           //this.Bang_Click(sender, e);
           nho = 0;
           label1.Text = "0.0";

       }
        }
    }


           
        
    

