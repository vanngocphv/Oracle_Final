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
    public partial class form_TableManager : Form
    {
        string userID;                  //Id User

        DataSet dsInfo;                 //Dataset Thông tin user

        int buttonWidth = 120;          //Độ rộng của nút

        int buttonHeight = 120;         //Độ cao của nút

        public form_TableManager(string _userID)
        {
            InitializeComponent();
            this.userID = _userID;
            //Thực hiện load data của bàn khi được gọi đến form
            LoadTable();
        }
        
        #region SettingMethod
        public void setDsInfo(DataSet _dsInfo)
        {
            //Lưu thữ thông tin của dataset Info user
            dsInfo = _dsInfo;
        }

        void LoadTable()
        {
            List<TBLS_MANAGER> listTable = HandleMethod.HandleGetListTable();
            foreach (TBLS_MANAGER table in listTable)
            {
                //Tiến hành tạo thêm button để tươgn tác với mấy cái bàn
                Button btn = new Button() { Width = buttonWidth, Height = buttonHeight };
                btn.Text = table.table_id + Environment.NewLine;
                if (table.status.ToString() == "0")
                {
                    btn.BackColor = Color.Aqua;
                    btn.Text += "Trống";
                }
                else
                {
                    btn.BackColor = Color.LightPink;
                    btn.Text += "Đã có người";
                }
                btn.Click += btn_Click;
                //Lưu trữ data của bàn vào Tag
                btn.Tag = table;
                flowlayout_tableManager.Controls.Add(btn);
            }
        }

        void ShowBill(string tableID)
        {
            //Triển khải show bill ở đây
        }

        #endregion SettingMethod


        #region Event
        private void form_TableManager_Load(object sender, EventArgs e)
        {
            //Thiết lập show button Admin hay không
            dsInfo = HandleMethod.HandleLoadMainForm(userID);
            foreach (DataRow dr in dsInfo.Tables[0].Rows) {
                if (dr["ROLE_ID"].ToString() == "ADMIN")
                {
                    admin_TStripMenu.Visible = true;
                }
            }
        }
        private void btn_addFood_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserInfo_TStripMenu_Click(object sender, EventArgs e)
        {
            form_ProfileAccount profForm = new form_ProfileAccount(dsInfo, this);
            profForm.ShowDialog();
        }

        private void admin_TStripMenu_Click(object sender, EventArgs e)
        {
            form_Admin admForm = new form_Admin();
            admForm.ShowDialog();  
        }

        private void Logout_TStripMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btn_Click(object sender, EventArgs e)
        {
            //Triển khai khi có 1 trong các button về bàn được click vào
            string tableID = ((sender as Button).Tag as TBLS_MANAGER).table_id;
            string tableStatus = ((sender as Button).Tag as TBLS_MANAGER).status;
            Console.WriteLine("Bill from " + tableID);
            if (tableStatus == "0")
            {
                Console.WriteLine("Book Table: " + tableID);
                if (MessageBox.Show("Khách đặt bàn này?", "Khách đặt bàn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
                {
                    //Gọi sang phương thức book bàn

                    //Tự động chuyển status local => 1 => "Đã có người"
                }
            }
            else
            {
                Console.WriteLine("Bill from " + tableID);
                //Gọi sang phương thức show hóa đơn
                ShowBill(tableID);
            }
        }
        
        #endregion Event
    }
}
