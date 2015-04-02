namespace Sothuxigon
{
    partial class SoThu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hồSơToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tảiDanhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuDanhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.kếtThúcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaĐổiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cắtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.listThumoi = new System.Windows.Forms.ListBox();
            this.listDS = new System.Windows.Forms.ListBox();
            this.l3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hồSơToolStripMenuItem,
            this.sửaĐổiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hồSơToolStripMenuItem
            // 
            this.hồSơToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tảiDanhSáchToolStripMenuItem,
            this.lưuDanhSáchToolStripMenuItem,
            this.toolStripSeparator1,
            this.kếtThúcToolStripMenuItem});
            this.hồSơToolStripMenuItem.Name = "hồSơToolStripMenuItem";
            this.hồSơToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.hồSơToolStripMenuItem.Text = "Hồ sơ";
            // 
            // tảiDanhSáchToolStripMenuItem
            // 
            this.tảiDanhSáchToolStripMenuItem.Name = "tảiDanhSáchToolStripMenuItem";
            this.tảiDanhSáchToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.tảiDanhSáchToolStripMenuItem.Text = "Tải danh sách";
            this.tảiDanhSáchToolStripMenuItem.Click += new System.EventHandler(this.tảiDanhSáchToolStripMenuItem_Click);
            // 
            // lưuDanhSáchToolStripMenuItem
            // 
            this.lưuDanhSáchToolStripMenuItem.Name = "lưuDanhSáchToolStripMenuItem";
            this.lưuDanhSáchToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.lưuDanhSáchToolStripMenuItem.Text = "Lưu danh sách";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // kếtThúcToolStripMenuItem
            // 
            this.kếtThúcToolStripMenuItem.Name = "kếtThúcToolStripMenuItem";
            this.kếtThúcToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kếtThúcToolStripMenuItem.Text = "Kết thúc";
            this.kếtThúcToolStripMenuItem.Click += new System.EventHandler(this.kếtThúcToolStripMenuItem_Click);
            // 
            // sửaĐổiToolStripMenuItem
            // 
            this.sửaĐổiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saoToolStripMenuItem,
            this.cắtToolStripMenuItem,
            this.dánToolStripMenuItem});
            this.sửaĐổiToolStripMenuItem.Name = "sửaĐổiToolStripMenuItem";
            this.sửaĐổiToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sửaĐổiToolStripMenuItem.Text = "Sửa đổi";
            // 
            // saoToolStripMenuItem
            // 
            this.saoToolStripMenuItem.Name = "saoToolStripMenuItem";
            this.saoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.saoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.saoToolStripMenuItem.Text = "Copy";
            // 
            // cắtToolStripMenuItem
            // 
            this.cắtToolStripMenuItem.Name = "cắtToolStripMenuItem";
            this.cắtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.cắtToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cắtToolStripMenuItem.Text = "Cut";
            // 
            // dánToolStripMenuItem
            // 
            this.dánToolStripMenuItem.Name = "dánToolStripMenuItem";
            this.dánToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.dánToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.dánToolStripMenuItem.Text = "Paste";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listThumoi, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listDS, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.l3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnLuu, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.85149F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.14851F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 284);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "danh sách con thú";
            // 
            // listThumoi
            // 
            this.listThumoi.AllowDrop = true;
            this.listThumoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listThumoi.FormattingEnabled = true;
            this.listThumoi.Items.AddRange(new object[] {
            "Khi",
            "Meo",
            "Cop",
            "Su tu",
            "Beo",
            "Ran",
            "Ho",
            "Vuon"});
            this.listThumoi.Location = new System.Drawing.Point(3, 35);
            this.listThumoi.Name = "listThumoi";
            this.listThumoi.Size = new System.Drawing.Size(179, 173);
            this.listThumoi.TabIndex = 2;
            this.listThumoi.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.listThumoi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // listDS
            // 
            this.listDS.AllowDrop = true;
            this.listDS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listDS.FormattingEnabled = true;
            this.listDS.Location = new System.Drawing.Point(188, 35);
            this.listDS.Name = "listDS";
            this.listDS.Size = new System.Drawing.Size(179, 173);
            this.listDS.TabIndex = 3;
            this.listDS.SelectedIndexChanged += new System.EventHandler(this.listDS_SelectedIndexChanged);
            this.listDS.DragDrop += new System.Windows.Forms.DragEventHandler(this.listDS_DragDrop);
            this.listDS.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.l3, 2);
            this.l3.Location = new System.Drawing.Point(3, 221);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(193, 13);
            this.l3.TabIndex = 4;
            this.l3.Text = "Bây giờ: 8 h ngày 25 tháng 3 năm 2015";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thú mới";
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::Sothuxigon.Properties.Resources.images;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(373, 224);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(77, 28);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu DS";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnLuu, "Lưu danh sách");
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // SoThu
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 338);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SoThu";
            this.Text = "Sở thú Sài Gòn";
            this.Load += new System.EventHandler(this.SoThu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hồSơToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tảiDanhSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuDanhSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem kếtThúcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaĐổiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cắtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dánToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listThumoi;
        private System.Windows.Forms.ListBox listDS;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Button btnLuu;
    }
}

