
using System.Drawing;
using System.Windows.Forms;

namespace GiaiPTBacHai
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTextA = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelTextB = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelTextC = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.labelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(89, 25);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(287, 34);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Giải phương trình bậc 2";
            // 
            // labelTextA
            // 
            this.labelTextA.AutoSize = true;
            this.labelTextA.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTextA.Location = new System.Drawing.Point(30, 91);
            this.labelTextA.Name = "labelTextA";
            this.labelTextA.Size = new System.Drawing.Size(78, 15);
            this.labelTextA.TabIndex = 1;
            this.labelTextA.Text = "Nhập hệ số A";
            this.labelTextA.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(114, 88);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(282, 23);
            this.textBoxA.TabIndex = 2;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // labelTextB
            // 
            this.labelTextB.AutoSize = true;
            this.labelTextB.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTextB.Location = new System.Drawing.Point(30, 140);
            this.labelTextB.Name = "labelTextB";
            this.labelTextB.Size = new System.Drawing.Size(77, 15);
            this.labelTextB.TabIndex = 3;
            this.labelTextB.Text = "Nhập hệ số B";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 23);
            this.textBox1.TabIndex = 4;
            // 
            // labelTextC
            // 
            this.labelTextC.AutoSize = true;
            this.labelTextC.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTextC.Location = new System.Drawing.Point(30, 190);
            this.labelTextC.Name = "labelTextC";
            this.labelTextC.Size = new System.Drawing.Size(78, 15);
            this.labelTextC.TabIndex = 5;
            this.labelTextC.Text = "Nhập hệ số C";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(283, 23);
            this.textBox2.TabIndex = 6;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(181, 232);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 7;
            this.buttonSubmit.Text = "Thực hiện";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 261);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(365, 127);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelTextC);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelTextB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelTextA);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Label labelTitle;
        private Label labelTextA;
        private TextBox textBoxA;
        private Label labelTextB;
        private TextBox textBox1;
        private Label labelTextC;
        private TextBox textBox2;
        private Button buttonSubmit;
        private RichTextBox richTextBox1;
    }
}

