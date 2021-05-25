using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhDatHang
{
    public partial class Form1 : Form
    {
        ISet<string> listOrderItems = new HashSet<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string i in listBoxMenu.SelectedItems)
            {
                listOrderItems.Add(i.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMenuItems();
        }

        void LoadMenuItems()
        {
            listBoxMenu.SelectionMode = SelectionMode.MultiSimple;
            List<string> menus = new List<string>();
            menus.Add("Doraemon");
            menus.Add("Kính Vạn Hoa");
            menus.Add("Harry Potter");
            //load data form db
            foreach (string item in menus)
            {
                listBoxMenu.Items.Add(item);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            LoadDataConsumer();
        }

        void LoadDataConsumer()
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string message = "Vui lòng điền đầy đủ thông tin";
            string caption = "Warning";
            DialogResult result;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (name == null || name.Equals("") || name.Length == 0 || phone.Length == 0)
            {
                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                if (listOrderItems.Count == 0)
                {
                    message = "Vui lòng chọn mặt hàng mà bạn muốn đặt.";
                    result = MessageBox.Show(message, caption, buttons);
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Thông tin đặt hàng\n");
                    sb.Append("Khách hàng: " + name + "\n");
                    sb.Append("Điện thoại: " + phone + "\n");
                    sb.Append("Sản phẩm đặt mua: " + "\n");
                    foreach (string myOrder in listOrderItems)
                    {
                        sb.Append("- " + myOrder + "\n");
                    }
                    listOrderItems.Clear();
                    lblShow.Text = sb.ToString();
                    txtName.Clear();
                    txtPhone.Clear();
                    listBoxMenu.SelectedItems.Clear();
                }
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string caption = "Warning";
            DialogResult result;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string phone = txtPhone.Text;
            try
            {
                foreach(char c in phone.ToCharArray())
                if (!phone.Equals("") && Char.IsLetter(c)) throw new FormatException("Số điện thoại không hợp lệ");
            }catch(FormatException ex) 
            {
                string message = ex.Message;
                result = MessageBox.Show(message, caption, buttons);
                txtPhone.Clear();
            }
        }
    }
}
