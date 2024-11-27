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

namespace asmsql
{
    public partial class Form3 : Form
    {
        string connectstring = @"Data Source=DESKTOP-8BKIVC4\SQLEXPRESS01;Initial Catalog=asm;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sql;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dtb;
        public Form3()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            sql = new SqlConnection(connectstring);
            sql.Open();
            cmd = new SqlCommand("select * from Customer", sql);
            adt = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            adt.Fill(dtb);
            dtgrv.DataSource = dtb;
            sql.Close();
        }
        private void ClearInputFields()
        {
            txtid.Text = "";
            txtname.Text = "";
            txtphone.Text = "";
            txtaddress.Text = "";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            sql = new SqlConnection(connectstring);
        }

        private void btshow_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(connectstring);
            sql.Open();
            cmd = new SqlCommand("Select * from Customer", sql);
            adt = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            adt.Fill(dtb);
            dtgrv.DataSource = dtb;
            sql.Close();
            ClearInputFields();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(connectstring);
            sql.Open();
            cmd = new SqlCommand("insert into Customer(Customer_ID, Customer_Name, Phone_Number, Address) values(@Customer_ID, @Customer_Name, @Phone_Number, @Address)", sql);
            cmd.Parameters.AddWithValue("@Customer_ID", txtid.Text);
            cmd.Parameters.AddWithValue("@Customer_Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Phone_Number", txtphone.Text);
            cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
            cmd.ExecuteNonQuery();
            LoadData();
            sql.Close ();
            ClearInputFields ();
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(connectstring);
            sql.Open();
            string edit = ("Update Customer set Customer_ID = @Customer_ID, Customer_Name = @Customer_Name, Phone_Number = @Phone_Number, Address = @Address where Customer_ID = @Customer_ID");
            cmd = new SqlCommand(edit, sql);
            cmd.Parameters.AddWithValue("@Customer_ID", txtid.Text);
            cmd.Parameters.AddWithValue("@Customer_Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Phone_Number", txtphone.Text);
            cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
            cmd.ExecuteNonQuery();
            LoadData();
            sql.Close ();
            ClearInputFields();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(connectstring);
            sql.Open();
            string delete = ("Delete from Customer where Customer_ID = @Customer_ID");
            cmd = new SqlCommand(delete, sql);
            cmd.Parameters.AddWithValue("@Customer_ID", txtid.Text);
            cmd.ExecuteNonQuery();
            LoadData();
            sql.Close();
            ClearInputFields();
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(connectstring);
            sql.Open();
            string search = ("select * from Customer where Customer_ID = @Customer_ID");
            cmd = new SqlCommand(search, sql);
            cmd.Parameters.AddWithValue("@Customer_ID", txtid.Text);
            adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtname.Text = dt.Rows[0]["Customer_Name"].ToString();
                txtphone.Text = dt.Rows[0]["Phone_Number"].ToString();
                txtaddress.Text = dt.Rows[0]["Address"].ToString();
            }
            else
            {
                MessageBox.Show("Customer does not exist");
            }
            LoadData();
            sql.Close();
        }

        private void dtgrv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgrv.CurrentRow.Index;
            txtid.Text = dtgrv.Rows[i].Cells[0].Value.ToString();
            txtname.Text = dtgrv.Rows[i].Cells[1].Value.ToString();
            txtphone.Text = dtgrv.Rows[i].Cells[2].Value.ToString();
            txtaddress.Text = dtgrv.Rows[i].Cells[3].Value.ToString();
            LoadData();
        }

        private void btback_Click(object sender, EventArgs e)
        {
            Formcha formcha = new Formcha();
            formcha.Show();
            this.Hide();
        }
    }
}
