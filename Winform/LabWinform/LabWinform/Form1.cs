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
using System.Threading;
namespace LabWinform
{
    public partial class Form1 : Form
    {
        string strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        SqlConnection Conn;
        Thread th;
        public Form1()
        {
            InitializeComponent();
            Conn = new SqlConnection(strConn);
            Conn.Open();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String sSQL = "SELECT * FROM Items";
            SqlCommand cmd = new SqlCommand(sSQL, Conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No data");
            }
        }

        private void Purchase_form_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opennewform()
        {
            Application.Run(new Purchase());
        }
    }
}
