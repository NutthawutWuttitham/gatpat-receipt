using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project_1610705186
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            connection = new SqlConnection(conStr);
            connection.Open();
            selectData();
        }

        private SqlConnection connection;
        private DataSet dataSt;

        private void selectData()
        {
            string sql = "SELECT  * FROM  Customer";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            dataSt = new DataSet();
            adapter.Fill(dataSt, "Cust");

            comboBox1.Items.Clear();
            comboBox1.Text = "เลือกรหัสใบสมัคร";
            for (int i = 0; i < dataSt.Tables["Cust"].Rows.Count; i++)
            {
                comboBox1.Items.Add(dataSt.Tables["Cust"].Rows[i]["id"].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql2 = @"SELECT * FROM Customer WHERE id = @oldid";

            SqlCommand command = new SqlCommand(sql2, connection);

            command.Parameters.Clear();
            command.Parameters.AddWithValue("oldid", comboBox1.SelectedItem.ToString());
            command.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            dataSt = new DataSet();
            adapter.Fill(dataSt, "Cust");
            selectData();
            //dataGridView1.DataSource = dataSt.Tables["Cust"];
            label7.Text = dataSt.Tables["Cust"].Rows[0][1].ToString();
            label38.Text = dataSt.Tables["Cust"].Rows[0][2].ToString();
            label39.Text = dataSt.Tables["Cust"].Rows[0][3].ToString();
            label40.Text = dataSt.Tables["Cust"].Rows[0][21].ToString();
            label41.Text = dataSt.Tables["Cust"].Rows[0][20].ToString();
            label42.Text = dataSt.Tables["Cust"].Rows[0][4].ToString();
            label43.Text = dataSt.Tables["Cust"].Rows[0][6].ToString();
            label44.Text = dataSt.Tables["Cust"].Rows[0][7].ToString();
            label45.Text = dataSt.Tables["Cust"].Rows[0][8].ToString();
            label46.Text = dataSt.Tables["Cust"].Rows[0][9].ToString();
            label47.Text = dataSt.Tables["Cust"].Rows[0][10].ToString();
            label49.Text = dataSt.Tables["Cust"].Rows[0][11].ToString();
            label50.Text = dataSt.Tables["Cust"].Rows[0][12].ToString();
            label51.Text = dataSt.Tables["Cust"].Rows[0][13].ToString();
            label52.Text = dataSt.Tables["Cust"].Rows[0][14].ToString();
            label53.Text = dataSt.Tables["Cust"].Rows[0][15].ToString();
            label54.Text = dataSt.Tables["Cust"].Rows[0][16].ToString();
            label55.Text = dataSt.Tables["Cust"].Rows[0][17].ToString();
            label56.Text = dataSt.Tables["Cust"].Rows[0][18].ToString();
            //label57.Text = dataSt.Tables["Cust"].Rows[0][5].ToString();
            label58.Text = dataSt.Tables["Cust"].Rows[0][19].ToString();

        }
    }
}
