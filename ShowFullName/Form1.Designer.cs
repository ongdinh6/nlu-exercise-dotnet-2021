
namespace ShowFullName
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHoLot = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHoTen = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHoTen
            // 
            this.lblHoTen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblHoTen.Location = new System.Drawing.Point(0, 0);
            this.lblHoTen.MinimumSize = new System.Drawing.Size(385, 50);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(385, 50);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHoTen.Click += new System.EventHandler(this.lblHoTen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ lót:";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(102, 68);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(236, 23);
            this.txtHo.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.SystemColors.Info;
            this.txtTen.Location = new System.Drawing.Point(102, 114);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(236, 23);
            this.txtTen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên:";
            // 
            // btnHoLot
            // 
            this.btnHoLot.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnHoLot.Location = new System.Drawing.Point(30, 157);
            this.btnHoLot.Name = "btnHoLot";
            this.btnHoLot.Size = new System.Drawing.Size(75, 35);
            this.btnHoLot.TabIndex = 5;
            this.btnHoLot.Text = "Họ Lót";
            this.btnHoLot.UseVisualStyleBackColor = false;
            this.btnHoLot.Click += new System.EventHandler(this.btnHoLot_Click);
            // 
            // btnTen
            // 
            this.btnTen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTen.Location = new System.Drawing.Point(163, 157);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(75, 35);
            this.btnTen.TabIndex = 6;
            this.btnTen.Text = "Tên";
            this.btnTen.UseVisualStyleBackColor = false;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHoTen
            // 
            this.btnHoTen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnHoTen.Location = new System.Drawing.Point(278, 157);
            this.btnHoTen.Name = "btnHoTen";
            this.btnHoTen.Size = new System.Drawing.Size(75, 35);
            this.btnHoTen.TabIndex = 7;
            this.btnHoTen.Text = "Họ Và Tên";
            this.btnHoTen.UseVisualStyleBackColor = false;
            this.btnHoTen.Click += new System.EventHandler(this.btnHoTen_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnThoat.Location = new System.Drawing.Point(127, 209);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(144, 40);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát Chương Trình";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHoTen);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnHoLot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHoTen);
            this.Name = "Form1";
            this.Text = "Bài Tập Họ Tên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHoLot;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHoTen;
        private System.Windows.Forms.Button btnThoat;
    }
}

