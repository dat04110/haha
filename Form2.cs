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

namespace asmsql
{
    public partial class Form2 : Form
    {
        string connectstring = @"Data Source=DESKTOP-8BKIVC4\SQLEXPRESS01;Initial Catalog=asm;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;
        public Form2()
        {
            InitializeComponent();
        }
        private void ClearInputFields()
        {
            txtid.Text = "";
            txtname.Text = "";
            txtposition.Text = "";
            txtauthority.Text = "";
            txtgmail.Text = "";
        }
        private void LoadData()
        {
            con = new SqlConnection(connectstring);
            con.Open();
            cmd = new SqlCommand("select * from Employee", con);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            dtgrv.DataSource = dttb;
            con.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectstring);
        }

        private void btshow_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectstring);
            con.Open();
            cmd = new SqlCommand("Select * from Employee", con);
            adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            dtgrv.DataSource = dt;
            con.Close();
        }

        

        private void btadd_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectstring);
            con.Open();
            cmd = new SqlCommand("insert into Employee(Employee_ID, Employee_Name, Position, Authority, Gmail) values(@Employee_ID, @Employee_Name, @Position, @Position, @Gmail)", con);
            cmd.Parameters.AddWithValue("@Employee_ID", txtid.Text);
            cmd.Parameters.AddWithValue("@Employee_Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Position", txtposition.Text);
            cmd.Parameters.AddWithValue("@Authority", txtauthority.Text);
            cmd.Parameters.AddWithValue("@Gmail", txtgmail.Text);
            cmd.ExecuteNonQuery();
            LoadData();
            con.Close();
            ClearInputFields();
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectstring);
            con.Open();
            string edit = ("Update Employee Set Employee_ID = @Employee_ID, Employee_Name = @Employee_Name, Position = @Position, Authority = @Authority, Gmail = @Gmail where Employee_ID = @Employee_ID");
            cmd = new SqlCommand(edit, con);
            cmd.Parameters.AddWithValue("@Employee_ID", txtid.Text);
            cmd.Parameters.AddWithValue("@Employee_Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Position", txtposition.Text);
            cmd.Parameters.AddWithValue("@Authority", txtauthority.Text);
            cmd.Parameters.AddWithValue("@Gmail", txtgmail.Text);
            cmd.ExecuteNonQuery();
            LoadData();
            con.Close();
            ClearInputFields();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectstring);
            con.Open();
            string delete = ("Delete from Employee where Employee_ID = @Employee_ID");
            cmd = new SqlCommand(delete, con);
            cmd.Parameters.AddWithValue("@Employee_ID", txtid.Text);
            cmd.ExecuteNonQuery();
            LoadData();
            con.Close();
            ClearInputFields();
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectstring);
            con.Open();
            string search = ("select * from Employee where Employee_ID = @Employee_ID");
            cmd = new SqlCommand(search, con);
            cmd.Parameters.AddWithValue("@Employee_ID", txtid.Text);
            adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtname.Text = dt.Rows[0]["Employee_Name"].ToString();
                txtposition.Text = dt.Rows[0]["Position"].ToString();
                txtauthority.Text = dt.Rows[0]["Authority"].ToString();
                txtgmail.Text = dt.Rows[0]["Gmail"].ToString();
            }
            else
            {
                MessageBox.Show("Employee does not exist");
            }
            LoadData();
            con.Close();
        }

        private void dtgrv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgrv.CurrentRow.Index;
            txtid.Text = dtgrv.Rows[i].Cells[0].Value.ToString();
            txtname.Text = dtgrv.Rows[i].Cells[1].Value.ToString();
            txtposition.Text = dtgrv.Rows[i].Cells[2].Value.ToString();
            txtauthority.Text = dtgrv.Rows[i].Cells[3].Value.ToString();
            txtgmail.Text = dtgrv.Rows[i].Cells[4].Value.ToString();
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
