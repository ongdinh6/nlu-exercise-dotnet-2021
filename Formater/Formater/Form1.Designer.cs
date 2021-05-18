
namespace Formater
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNhapTen = new System.Windows.Forms.Label();
            this.txtNhapTen = new System.Windows.Forms.TextBox();
            this.groupBoxColorPanel = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoBlack = new System.Windows.Forms.RadioButton();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.rdoGreen = new System.Windows.Forms.RadioButton();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkGachChan = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblLapTrinh = new System.Windows.Forms.Label();
            this.groupBoxColorPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNhapTen
            // 
            this.labelNhapTen.AutoSize = true;
            this.labelNhapTen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNhapTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNhapTen.ForeColor = System.Drawing.Color.Gold;
            this.labelNhapTen.Location = new System.Drawing.Point(13, 13);
            this.labelNhapTen.Name = "labelNhapTen";
            this.labelNhapTen.Size = new System.Drawing.Size(62, 15);
            this.labelNhapTen.TabIndex = 0;
            this.labelNhapTen.Text = "Nhập Tên:";
            // 
            // txtNhapTen
            // 
            this.txtNhapTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNhapTen.Location = new System.Drawing.Point(82, 10);
            this.txtNhapTen.Name = "txtNhapTen";
            this.txtNhapTen.Size = new System.Drawing.Size(290, 23);
            this.txtNhapTen.TabIndex = 1;
            this.txtNhapTen.TextChanged += new System.EventHandler(this.txtNhapTen_TextChanged);
            // 
            // groupBoxColorPanel
            // 
            this.groupBoxColorPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxColorPanel.Controls.Add(this.panel1);
            this.groupBoxColorPanel.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBoxColorPanel.Location = new System.Drawing.Point(13, 50);
            this.groupBoxColorPanel.Name = "groupBoxColorPanel";
            this.groupBoxColorPanel.Size = new System.Drawing.Size(130, 148);
            this.groupBoxColorPanel.TabIndex = 2;
            this.groupBoxColorPanel.TabStop = false;
            this.groupBoxColorPanel.Text = "Color";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdoBlack);
            this.panel1.Controls.Add(this.rdoBlue);
            this.panel1.Controls.Add(this.rdoGreen);
            this.panel1.Controls.Add(this.rdoRed);
            this.panel1.Location = new System.Drawing.Point(7, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 120);
            this.panel1.TabIndex = 0;
            // 
            // rdoBlack
            // 
            this.rdoBlack.AutoSize = true;
            this.rdoBlack.ForeColor = System.Drawing.Color.Black;
            this.rdoBlack.Location = new System.Drawing.Point(7, 88);
            this.rdoBlack.Name = "rdoBlack";
            this.rdoBlack.Size = new System.Drawing.Size(55, 19);
            this.rdoBlack.TabIndex = 3;
            this.rdoBlack.TabStop = true;
            this.rdoBlack.Text = "Black";
            this.rdoBlack.UseVisualStyleBackColor = true;
            this.rdoBlack.CheckedChanged += new System.EventHandler(this.rdoBlack_CheckedChanged);
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.ForeColor = System.Drawing.Color.Blue;
            this.rdoBlue.Location = new System.Drawing.Point(7, 62);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(50, 19);
            this.rdoBlue.TabIndex = 2;
            this.rdoBlue.TabStop = true;
            this.rdoBlue.Text = "Blue";
            this.rdoBlue.UseVisualStyleBackColor = true;
            this.rdoBlue.CheckedChanged += new System.EventHandler(this.rdoBlue_CheckedChanged);
            // 
            // rdoGreen
            // 
            this.rdoGreen.AutoSize = true;
            this.rdoGreen.ForeColor = System.Drawing.Color.Green;
            this.rdoGreen.Location = new System.Drawing.Point(7, 36);
            this.rdoGreen.Name = "rdoGreen";
            this.rdoGreen.Size = new System.Drawing.Size(60, 19);
            this.rdoGreen.TabIndex = 1;
            this.rdoGreen.TabStop = true;
            this.rdoGreen.Text = "Green";
            this.rdoGreen.UseVisualStyleBackColor = true;
            this.rdoGreen.CheckedChanged += new System.EventHandler(this.rdoGreen_CheckedChanged);
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.ForeColor = System.Drawing.Color.Red;
            this.rdoRed.Location = new System.Drawing.Point(7, 10);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(47, 19);
            this.rdoRed.TabIndex = 0;
            this.rdoRed.TabStop = true;
            this.rdoRed.Text = "Red";
            this.rdoRed.UseVisualStyleBackColor = true;
            this.rdoRed.CheckedChanged += new System.EventHandler(this.rdoRed_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(173, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 148);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Font";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.chkGachChan);
            this.panel2.Controls.Add(this.chkItalic);
            this.panel2.Controls.Add(this.chkBold);
            this.panel2.ForeColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(7, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 120);
            this.panel2.TabIndex = 0;
            // 
            // chkGachChan
            // 
            this.chkGachChan.AutoSize = true;
            this.chkGachChan.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.chkGachChan.Location = new System.Drawing.Point(10, 88);
            this.chkGachChan.Name = "chkGachChan";
            this.chkGachChan.Size = new System.Drawing.Size(83, 19);
            this.chkGachChan.TabIndex = 2;
            this.chkGachChan.Text = "Gạch chân";
            this.chkGachChan.UseVisualStyleBackColor = true;
            this.chkGachChan.CheckedChanged += new System.EventHandler(this.chkGachChan_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.chkItalic.Location = new System.Drawing.Point(10, 51);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(107, 19);
            this.chkItalic.TabIndex = 1;
            this.chkItalic.Text = "Nghiêng Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(10, 9);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(80, 19);
            this.chkBold.TabIndex = 0;
            this.chkBold.Text = "Đậm Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(13, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lập Trình Bởi:";
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(260, 229);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 37);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseMnemonic = false;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblLapTrinh
            // 
            this.lblLapTrinh.AutoSize = true;
            this.lblLapTrinh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblLapTrinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLapTrinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLapTrinh.ForeColor = System.Drawing.Color.Black;
            this.lblLapTrinh.Location = new System.Drawing.Point(101, 234);
            this.lblLapTrinh.MaximumSize = new System.Drawing.Size(140, 25);
            this.lblLapTrinh.MinimumSize = new System.Drawing.Size(140, 25);
            this.lblLapTrinh.Name = "lblLapTrinh";
            this.lblLapTrinh.Size = new System.Drawing.Size(140, 25);
            this.lblLapTrinh.TabIndex = 7;
            this.lblLapTrinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 278);
            this.Controls.Add(this.lblLapTrinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxColorPanel);
            this.Controls.Add(this.txtNhapTen);
            this.Controls.Add(this.labelNhapTen);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Form1";
            this.Text = "Định dạng (Formater)";
            this.groupBoxColorPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNhapTen;
        private System.Windows.Forms.TextBox txtNhapTen;
        private System.Windows.Forms.GroupBox groupBoxColorPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoBlack;
        private System.Windows.Forms.RadioButton rdoBlue;
        private System.Windows.Forms.RadioButton rdoGreen;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkGachChan;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblLapTrinh;
    }
}

