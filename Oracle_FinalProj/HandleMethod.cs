using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// This Class using for handle all action from the form of the program
namespace Oracle_FinalProj
{
    internal class HandleMethod
    {
        //Xử lý khi login
        public static bool HandleLogin(string userID, string userPassword)
        {
            //Check nếu valid
            if (userID.Length != 0 && userPassword.Length != 0)
            {
                //Tạo connect
                DataConnect newConnect = new DataConnect();
                OracleConnection conn = newConnect.OpenConnect();

                //Tạo command string
                string selectCommand = "Select * from SYS.EMPLOYEES_MANAGER where USER_ID = '" + userID + "' and USER_PASS = '" + userPassword + "'";

                //Tạo dataset để lưu trữ
                DataSet ds = new DataSet();
                ds = newConnect.ReturnSelectData(selectCommand, conn);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    //Console.WriteLine("has data");
                    conn = newConnect.CloseConnect(conn);
                    
                    return true;
                }

                conn = newConnect.CloseConnect(conn);
            }
            return false;
        }

        //Xử lý khi load MainForm, tức tablemanager
        public static DataSet HandleLoadMainForm(string userID)
        {
            DataConnect newConnect = new DataConnect();
            OracleConnection conn = newConnect.OpenConnect();

            string selectCommand = "Select * from SYS.EMPLOYEES_MANAGER where USER_ID = '" + userID + "'";

            DataSet ds = new DataSet();
            ds = newConnect.ReturnSelectData(selectCommand, conn);
            conn = newConnect.CloseConnect(conn);
            return ds;
        }

        //Xử lý khi xảy ra việc update thông tin user
        public static bool HandleUpdateUserInfo(string userID, string userName, string newPass)
        {
            DataConnect newConnect = new DataConnect();
            OracleConnection conn = newConnect.OpenConnect();
            string updateCommand;
            if (newPass.Length > 0) { 
                updateCommand = "UPDATE SYS.EMPLOYEES_MANAGER SET USER_NAME = '" + userName + "', USER_PASS = '" + newPass + "' WHERE USER_ID = '" + userID + "'";
            }
            else
            {
                updateCommand = "UPDATE SYS.EMPLOYEES_MANAGER SET USER_NAME = '" + userName + "' WHERE USER_ID = '" + userID + "'";
            }
            Console.Write(updateCommand);

            bool isSuccess = newConnect.UpdateIntoTable(updateCommand, conn);
            if (isSuccess)
            {
                conn = newConnect.CloseConnect(conn);
                return true;
            }

            conn = newConnect.CloseConnect(conn);
            return false;
        }

        //Xử lý lấy thông tin toàn bộ table khả dụng trong database
        public static List<TBLS_MANAGER> HandleGetListTable()
        {
            List<TBLS_MANAGER> lsTable = new List<TBLS_MANAGER>();

            DataConnect newConnect = new DataConnect();
            OracleConnection conn = newConnect.OpenConnect();

            string selectCommand = "SELECT * FROM TBLS_MANAGER";

            DataSet ds = new DataSet();
            ds = newConnect.ReturnSelectData(selectCommand, conn);
            conn = newConnect.CloseConnect(conn);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                TBLS_MANAGER tmp = new TBLS_MANAGER();
                tmp.table_id = dr["TABLE_ID"].ToString();
                tmp.customer_id = dr["CUSTOMER_ID"].ToString();
                tmp.status = dr["STATUS"].ToString();
                tmp.date_created = dr["DATE_CREATED"].ToString();
                lsTable.Add(tmp);
            }

            return lsTable;
        }
    }
}
