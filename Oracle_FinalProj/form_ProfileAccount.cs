using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oracle_FinalProj
{
    public partial class form_ProfileAccount : Form
    {
        DataSet dsInfo;
        string userPass;
        string newPass;
        string userName;
        string userID;
        form_TableManager previous_form;
        public form_ProfileAccount(DataSet _dsInfo, form_TableManager _previous_form)
        {
            //Lưu trữ thông tin từ dataset của form trước vào form này
            InitializeComponent();
            this.dsInfo = _dsInfo;
            this.previous_form = _previous_form;
        }

        private void Label_Username_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void form_ProfileAccount_Load(object sender, EventArgs e)
        {
            //Load thông tin từ dataset lên
            foreach (DataRow dr in dsInfo.Tables[0].Rows)
            {
                userID      = dr["USER_ID"].ToString();
                userPass    = dr["USER_PASS"].ToString();
                userName    = dr["USER_NAME"].ToString();
                txtBox_usernameID.Text      = userID;
                txtBox_usernameDisplay.Text = userName;
                txtBox_password.Text        = userPass;
            }
        }

        private void btn_updateProf_Click(object sender, EventArgs e)
        {
            //Triển khai check trước khi update
            if (txtBox_usernameDisplay.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống phần tên hiển thị", "Warning", MessageBoxButtons.OK);
                return;
            }

            if (txtBox_password.Text != userPass)
            {
                MessageBox.Show("Mật Khẩu sai", "Warning", MessageBoxButtons.OK);
                return;
            }

            if (txtBox_newPassword.Text.Length != 0 && txtBox_passwordAgain.Text.Length != 0)
            {
                if (txtBox_passwordAgain.Text != txtBox_newPassword.Text)
                {
                    MessageBox.Show("Mật Khẩu mới và nhập lại nó không giống nhau, kiểm tra lại", "Warning", MessageBoxButtons.OK);
                    return;
                }
            }
            //Check hoàn tất, tiến hành thiết lập để update
            userName = txtBox_usernameDisplay.Text;
            newPass = txtBox_newPassword.Text;
            Console.Write(newPass + " " + userID + " " + userName);
            bool isSuccess = HandleMethod.HandleUpdateUserInfo(userID, userName, newPass);
            if (isSuccess)
            {
                MessageBox.Show("Cập nhật thành công", "Cập nhật thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (DataRow dr in dsInfo.Tables[0].Rows)
                {
                    dr["USER_PASS"] = newPass;
                    dr["USER_NAME"] = userName;
                }
                previous_form.setDsInfo(dsInfo);
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công, vui lòng thử lại trong giây lát", "Cập nhật thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBox_usernameDisplay_TextChanged(object sender, EventArgs e)
        {
            
        }

        //Button cập nhật chỉ mở khi có thay đổi data của 1 trong 4 trường bên dưới
        private void txtBox_usernameDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            btn_updateProf.Enabled = true;
        }

        private void txtBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            btn_updateProf.Enabled = true;
        }

        private void txtBox_newPassword_KeyDown(object sender, KeyEventArgs e)
        {
            btn_updateProf.Enabled = true;
        }

        private void txtBox_passwordAgain_KeyDown(object sender, KeyEventArgs e)
        {
            btn_updateProf.Enabled = true;
        }
    }
}
