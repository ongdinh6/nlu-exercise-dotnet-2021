using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formater
{
    public partial class Form1 : Form
    {
        Font fontChanged;
        static bool bold = false, italic = false, underline = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            string message = "Bạn muốn thoát chương trình?";
            string caption = "Thoát chương trình!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            string ten = this.txtNhapTen.Text;
            this.lblLapTrinh.Text = ten;
        }

        private void rdoRed_CheckedChanged(object sender, EventArgs e)
        {
            this.lblLapTrinh.ForeColor = Color.Red;
        }

        private void rdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            this.lblLapTrinh.ForeColor = Color.Green;
        }

        private void rdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            this.lblLapTrinh.ForeColor = Color.Blue;
        }

        private void rdoBlack_CheckedChanged(object sender, EventArgs e)
        {
            this.lblLapTrinh.ForeColor = Color.Black;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBold.CheckState == CheckState.Checked)
            {
                bold = true;
                changeByFont(bold, italic, underline);
            }
            if(chkBold.CheckState == CheckState.Unchecked)
            {
                bold = false;
                changeByFont(bold, italic, underline);
            }
           

        }

        private void chkGachChan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGachChan.CheckState == CheckState.Checked)
            {
                underline = true;
                changeByFont(bold, italic, underline);
            }
            if (chkGachChan.CheckState == CheckState.Unchecked)
            {
                underline = false;
                changeByFont(bold, italic, underline);
            }
        }

        private void changeByFont(bool bold, bool italic, bool underline)
        {
            if (!bold && !italic && !underline) fontChanged = new Font(new FontFamily("Segoe UI"), 9.0f, FontStyle.Regular);
            if (bold) fontChanged = new Font(new FontFamily("Segoe UI"), 9.0f, FontStyle.Bold);
            if (italic) fontChanged = new Font(new FontFamily("Segoe UI"), 9.0f, FontStyle.Italic);
            if (underline) fontChanged = new Font(new FontFamily("Segoe UI"), 9.0f, FontStyle.Underline);
            if (bold && italic) fontChanged = new Font(new FontFamily("Segoe UI"), 9.0f, FontStyle.Bold | FontStyle.Italic);
            if (bold && underline) fontChanged = new Font(new FontFamily("Segoe UI"), 9.0f, FontStyle.Bold | FontStyle.Underline);
            if (italic && underline) fontChanged = new Font(new FontFamily("Segoe UI"), 9.0f, FontStyle.Italic | FontStyle.Underline);
            if (bold && italic && underline) fontChanged = new Font(new FontFamily("Segoe UI"), 9.0f, FontStyle.Bold | FontStyle.Italic| FontStyle.Underline);
           
            this.lblLapTrinh.Font = fontChanged;
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItalic.CheckState == CheckState.Checked)
            {
                italic = true;
                changeByFont(bold, italic, underline);
            }
            if (chkItalic.CheckState == CheckState.Unchecked)
            {
                italic = false;
                changeByFont(bold, italic, underline);
            }
        }
    }
}
