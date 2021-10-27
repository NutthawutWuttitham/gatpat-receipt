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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            connection = new SqlConnection(conStr);
            connection.Open();
            selectData();

            dataGridView1.DataSource = dataSt.Tables["Cust"];
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
            comboBox1.Text = "เลือกชื่อ";
            for (int i = 0; i < dataSt.Tables["Cust"].Rows.Count; i++)
            {
                comboBox1.Items.Add(dataSt.Tables["Cust"].Rows[i]["fname"].ToString());
            }

            comboBox2.Items.Clear();
            comboBox2.Text = "เลือกชื่อผู้สมัคร";
            for (int i = 0; i < dataSt.Tables["Cust"].Rows.Count; i++)
            {
                comboBox2.Items.Add(dataSt.Tables["Cust"].Rows[i]["fname"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string id = textBox1.Text;
            string term = textBox3.Text;
            string fname = textBox2.Text;
            string lname = textBox4.Text;
            string idthai = textBox5.Text;
            if (radioButton6.Checked == true)
            {
                label6.Text = "Male";
            }
            else if (radioButton7.Checked == true)
            {
                label6.Text = "Female";
            }
            string sex = label6.Text;
            string address = textBox6.Text;
            string tel = textBox7.Text;
            string email = textBox9.Text;
            string school = textBox8.Text;
            if (checkBox1.Checked == true)
            {
                label13.Text = checkBox1.Text;
            }
            else if (checkBox1.Checked == false)
            {
                label13.Text = null;
            }
            string gat = label13.Text;
            if (checkBox2.Checked == true)
            {
                label14.Text = checkBox2.Text;
            }
            else if (checkBox2.Checked == false)
            {
                label14.Text = null;
            }
            string pat1 = label14.Text;
            if (checkBox3.Checked == true)
            {
                label15.Text = checkBox3.Text;
            }
            else if (checkBox3.Checked == false)
            {
                label15.Text = null;
            }
            string pat2 = label15.Text;
            if (checkBox4.Checked == true)
            {
                label16.Text = checkBox4.Text;
            }
            else if (checkBox4.Checked == false)
            {
                label16.Text = null;
            }
            string pat3 = label16.Text;
            if (checkBox5.Checked == true)
            {
                label17.Text = checkBox5.Text;
            }
            else if (checkBox5.Checked == false)
            {
                label17.Text = null;
            }
            string pat4 = label17.Text;
            if (checkBox6.Checked == true)
            {
                label18.Text = checkBox6.Text;
            }
            else if (checkBox6.Checked == false)
            {
                label18.Text = null;
            }
            string pat5 = label18.Text;
            if (checkBox7.Checked == true)
            {
                label19.Text = checkBox7.Text;
            }
            else if (checkBox7.Checked == false)
            {
                label19.Text = null;
            }
            string pat6 = label19.Text;
            if (radioButton11.Checked == true)
            {
                label20.Text = radioButton11.Text;
            }
            else if (radioButton12.Checked == true)
            {
                label20.Text = radioButton12.Text;
            }
            else if (radioButton13.Checked == true)
            {
                label20.Text = radioButton13.Text;
            }
            else if (radioButton14.Checked == true)
            {
                label20.Text = radioButton14.Text;
            }
            else if (radioButton15.Checked == true)
            {
                label20.Text = radioButton15.Text;
            }
            else if (radioButton16.Checked == true)
            {
                label20.Text = radioButton16.Text;
            }
            else if (radioButton17.Checked == true)
            {
                label20.Text = radioButton17.Text;
            }
            else if(radioButton11.Checked == false && radioButton12.Checked == false && radioButton13.Checked == false && radioButton14.Checked == false && radioButton15.Checked == false && radioButton16.Checked == false && radioButton17.Checked == false)
            {
                label20.Text = null;
            }
            string pat7 = label20.Text;
            string birth = dateTimePicker1.Value.ToString();
            if(radioButton8.Checked == true)
            {
                label21.Text = "Tiers M 6";
            }
            else if (radioButton9.Checked == true)
            {
                label21.Text = "Higher Education";
            }
            else if (radioButton10.Checked == true)
            {
                label21.Text = "General public";
            }
            string degree = label21.Text;
            //string age = textBox10.Text;
            if (textBox10.Text == "1")
            {
                label23.Text = "140.00";
            }
            else if (textBox10.Text == "2")
            {
                label23.Text = "280.00";
            }
            else if (textBox10.Text == "3")
            {
                label23.Text = "420.00";
            }
            else if (textBox10.Text == "4")
            {
                label23.Text = "560.00";
            }
            else if (textBox10.Text == "5")
            {
                label23.Text = "700.00";
            }
            else if (textBox10.Text == "6")
            {
                label23.Text = "840.00";
            }
            else if (textBox10.Text == "7")
            {
                label23.Text = "980.00";
            }
            else if (textBox10.Text == "8")
            {
                label23.Text = "1120.00";
            }
            else 
            {
                label23.Text = null;
            } 
            string allmoney = label23.Text;
            string sql = "INSERT INTO Customer (id,term,fname,lname,sex,address,birth,tel,email,school,idthai,gat,pat1,pat2,pat3,pat4,pat5,pat6,pat7,degree,allmoney)VALUES(@id, @term, @fname, @lname, @sex, @address, @birth, @tel, @email, @school, @idthai, @gat, @pat1, @pat2, @pat3, @pat4, @pat5 , @pat6, @pat7, @degree, @allmoney)";

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("term", term);
            command.Parameters.AddWithValue("fname", fname);
            command.Parameters.AddWithValue("lname", lname);
            command.Parameters.AddWithValue("sex", sex);
            command.Parameters.AddWithValue("tel", tel);
            command.Parameters.AddWithValue("address", address);
            command.Parameters.AddWithValue("school", school);
            command.Parameters.AddWithValue("email", email);
            command.Parameters.AddWithValue("idthai", idthai);
            command.Parameters.AddWithValue("gat", gat);
            command.Parameters.AddWithValue("pat1", pat1);
            command.Parameters.AddWithValue("pat2", pat2);
            command.Parameters.AddWithValue("pat3", pat3);
            command.Parameters.AddWithValue("pat4", pat4);
            command.Parameters.AddWithValue("pat5", pat5);
            command.Parameters.AddWithValue("pat6", pat6);
            command.Parameters.AddWithValue("pat7", pat7);
            command.Parameters.AddWithValue("birth", birth);
            command.Parameters.AddWithValue("degree", degree);
            command.Parameters.AddWithValue("allmoney", allmoney);
            //command.Parameters.AddWithValue("age", age);

            command.ExecuteNonQuery();

            selectData();
            dataGridView1.DataSource = dataSt.Tables["Cust"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false; 
            radioButton12.Checked = false; 
            radioButton13.Checked = false; 
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            radioButton16.Checked = false;
            radioButton17.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fn = comboBox1.SelectedItem.ToString();

            string sql = "DELETE FROM Customer WHERE (fname = @fname)";
            SqlCommand command = new SqlCommand(sql, connection);


            command.Parameters.Clear();
            command.Parameters.AddWithValue("fname", fn);

            command.ExecuteNonQuery();


            selectData();

            dataGridView1.DataSource = dataSt.Tables["Cust"];
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql2 = "SELECT * FROM Customer WHERE fName = @oldFN";

            SqlCommand command = new SqlCommand(sql2, connection);

            command.Parameters.Clear();
            command.Parameters.AddWithValue("oldFN", comboBox2.SelectedItem.ToString());

            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            dataSt = new DataSet();
            adapter.Fill(dataSt, "Cust");

            textBox11.Text = dataSt.Tables["Cust"].Rows[0][2].ToString();
            textBox12.Text = dataSt.Tables["Cust"].Rows[0][3].ToString();
            textBox13.Text = dataSt.Tables["Cust"].Rows[0][7].ToString();
            textBox14.Text = dataSt.Tables["Cust"].Rows[0][8].ToString();
            textBox15.Text = dataSt.Tables["Cust"].Rows[0][10].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql2 = @"UPDATE Customer SET fname = @NewFN, lname = @NewLN, tel = @Newtel, email = @Newemail, school = @Newschool WHERE fname = @oldFN";

            SqlCommand command = new SqlCommand(sql2, connection);

            command.Parameters.Clear();
            command.Parameters.AddWithValue("oldFN", comboBox2.SelectedItem.ToString());
            command.Parameters.AddWithValue("NewFN", textBox11.Text);
            command.Parameters.AddWithValue("NewLN", textBox12.Text);
            command.Parameters.AddWithValue("Newtel", textBox13.Text);
            command.Parameters.AddWithValue("Newemail", textBox14.Text);
            command.Parameters.AddWithValue("Newschool", textBox15.Text);

            command.ExecuteNonQuery();

            selectData();
            dataGridView1.DataSource = dataSt.Tables["Cust"];

            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
