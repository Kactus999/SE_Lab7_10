using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWinform
{
    public partial class Purchase : Form
    {
        string strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        SqlConnection Conn;
        public Purchase()
        {
            InitializeComponent();
            Conn = new SqlConnection(strConn);
            Conn.Open();
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            int itemID;
            Random rnd = new Random();
            int orderID = rnd.Next(0, 9999);
            int ID = rnd.Next(0, 9999);
            int quantity = int.Parse(tb_quantity.Text);
            DateTime date = DateTime.Now;
            SqlCommand findDB = new SqlCommand("SELECT ItemID FROM Items Where ItemName='"+comboBox1.Text+"'", Conn);
            SqlCommand insertDetailDB = new SqlCommand("INSERT INTO OrderDetails(ID,OrderID,ItemID,Quantity) VALUES (@ID,@OrderID,@ItemID,@Quantity)",Conn);
            SqlCommand insertPurchase = new SqlCommand("INSERT INTO Orders(OrderID,OrderDate,AgentID) VALUES (@PID,@PDate,@AgentID)", Conn);
            findDB.Parameters.AddWithValue("@itemName", comboBox1.SelectedItem.ToString());
            SqlDataReader read = findDB.ExecuteReader();
            read.Read();
            itemID = read.GetInt32(0);
            read.Close();
            insertDetailDB.Parameters.AddWithValue("@ID", ID);
            insertDetailDB.Parameters.AddWithValue("@OrderID", orderID);
            insertDetailDB.Parameters.AddWithValue("@Quantity", quantity);
            insertDetailDB.Parameters.AddWithValue("@ItemID", itemID);

            insertPurchase.Parameters.AddWithValue("@PID", orderID);
            insertPurchase.Parameters.AddWithValue("@PDate", date);
            insertPurchase.Parameters.AddWithValue("@AgentID", 1);
            insertPurchase.ExecuteNonQuery();
            insertDetailDB.ExecuteNonQuery();

            MessageBox.Show($"Ordered {quantity} {comboBox1.Text}");

        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            string sSql = "SELECT * FROM Items";
            SqlCommand cmd = new SqlCommand(sSql, Conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "ItemName";
            comboBox1.ValueMember = "ItemID";
        }
    }
}
