namespace ScrollablePictureBoxTest
{
    partial class TestForm
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
            this.comboSizeMode = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.spbxImage = new Manning.MyPhotoControls.ScrollablePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // comboSizeMode
            // 
            this.comboSizeMode.FormattingEnabled = true;
            this.comboSizeMode.Items.AddRange(new object[] {
            "AutoSize\t",
            "CenterImage",
            "Normal",
            "StrecthImage",
            "Zoom"});
            this.comboSizeMode.Location = new System.Drawing.Point(95, 14);
            this.comboSizeMode.Name = "comboSizeMode";
            this.comboSizeMode.Size = new System.Drawing.Size(177, 21);
            this.comboSizeMode.TabIndex = 4;
            this.comboSizeMode.Text = "Normal";
            this.comboSizeMode.SelectedIndexChanged += new System.EventHandler(this.comboSizeMode_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(13, 13);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // spbxImage
            // 
            this.spbxImage.AllowScrollBars = true;
            this.spbxImage.Location = new System.Drawing.Point(12, 52);
            this.spbxImage.Name = "spbxImage";
            this.spbxImage.Size = new System.Drawing.Size(260, 207);
            this.spbxImage.TabIndex = 6;
            this.spbxImage.TabStop = false;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.spbxImage);
            this.Controls.Add(this.comboSizeMode);
            this.Controls.Add(this.btnLoad);
            this.Name = "TestForm";
            this.Text = "ScrollablePictureBoxTest";
            ((System.ComponentModel.ISupportInitialize)(this.spbxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSizeMode;
        private System.Windows.Forms.Button btnLoad;
        private Manning.MyPhotoControls.ScrollablePictureBox spbxImage;
    }
}

