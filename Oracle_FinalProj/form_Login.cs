using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oracle_FinalProj
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tiến hành check trước khi login
            if (txtBox_Username.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Warning", MessageBoxButtons.OK);
            }
            else if (txtBox_Password.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                //Check thành công, tiến hành kiểm tra trên database
                if (HandleMethod.HandleLogin(txtBox_Username.Text, txtBox_Password.Text))
                {
                    form_TableManager managerForm = new form_TableManager(txtBox_Username.Text);
                    this.Hide();
                    managerForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Create a popup windows for confirm if user want to exit this program
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
