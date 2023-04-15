using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

//This script using for connect, handle select, update, insert, delete into database
namespace Oracle_FinalProj
{
    internal class DataConnect
    {
        public string connectString = "Data Source=XE;DBA Privilege=SYSDBA;User Id=SYS;Password=admin";

        //Khởi tạo connect đến database
        public OracleConnection OpenConnect()
        {
            OracleConnection conn = new OracleConnection(connectString);
            conn.Open();
            Console.WriteLine("Connected");
            return conn;
        }

        //Đóng connect đến database
        public OracleConnection CloseConnect(OracleConnection conn)
        {
            conn.Close();
            conn.Dispose();
            Console.WriteLine("Disconnect");
            return conn;
        }

        //Câu lệnh select, trả về là một dataset, có thể được chuyển đổi sang kiểu tùy ý thông qua foreach và gán manual
        public DataSet ReturnSelectData(string command, OracleConnection conn)
        {
            Console.WriteLine(command);
            DataSet returnData = new DataSet();

            OracleCommand cmd = new OracleCommand(command, conn);
            OracleDataAdapter oda = new OracleDataAdapter(cmd);

            oda.Fill(returnData);

            return returnData;
        }

        //Câu lệnh insert
        public void InsertIntoTable(string command, OracleConnection conn)
        {
            OracleCommand cmd = new OracleCommand(command, conn);
            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            try
            {
                int insertRow = cmd.ExecuteNonQuery();
                MessageBox.Show(insertRow + " rows were affected.");
            }
            catch
            {
                MessageBox.Show("Error encountered during INSERT operation.");
            }
        }

        //Câu lệnh update
        public bool UpdateIntoTable(string command, OracleConnection conn)
        {
            OracleCommand cmd = new OracleCommand(command, conn);
            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return false;
            }
        }

        //Câu lệnh Delete, nếu có, phần này chỉ nên thay bằng update cờ deletion

    }
}
