using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace asmsql
{
    public partial class Form4 : Form
    {
        string connectstring = @"Data Source=DESKTOP-8BKIVC4\SQLEXPRESS01;Initial Catalog=asm;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sql;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;

        public Form4()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            sql = new SqlConnection(connectstring);
            sql.Open();
            cmd = new SqlCommand("Select * From Information", sql);
            adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            sql.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
         
        }

        private void btlogin_Click_1(object sender, EventArgs e)
        {
            sql = new SqlConnection(connectstring);
            sql.Open();
            string login = ("Select * from Information where LoginName = @LoginName and PassWord = @PassWord");
            cmd = new SqlCommand(login, sql);
            cmd.Parameters.AddWithValue("@LoginName", txtname.Text);
            cmd.Parameters.AddWithValue("@PassWord", txtpass.Text);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                System.Windows.Forms.MessageBox.Show("Success");
                Formcha f = new Formcha();
                f.Show();
                this.Hide();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Account does not exist");
            }
            rdr.Close();
            sql.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.PasswordChar = '\0';
                txtpass.PasswordChar = '\0';
            }
            else
            {
                txtpass.PasswordChar = '*';
                textBox1.PasswordChar = '*';
            }
        }

        private void btcr_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            textBox1.Visible = true;
            btcrr.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpass.Text == textBox1.Text)
            {
                sql = new SqlConnection(connectstring);
                sql.Open();
                cmd = new SqlCommand("Insert into Information(LoginName, PassWord) values(@LoginName, @PassWord)", sql);
                cmd.Parameters.AddWithValue("@LoginName", txtname.Text);
                cmd.Parameters.AddWithValue("@PassWord", txtpass.Text);
                cmd.ExecuteNonQuery();
                LoadData();
                sql.Close();
            }
            btcrr.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
        }
    }
}