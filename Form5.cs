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
    public partial class Form5 : Form
    {
        string connectstring = @"Data Source=DESKTOP-8BKIVC4\SQLEXPRESS01;Initial Catalog=asm;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dttb;
        public Form5()
        {
            InitializeComponent();
        }
        private void ClearInputFields()
        {
            txtid.Text = "";
            txtname.Text = "";
            txtsp.Text = "";
            txtquantity.Text = "";
            txtip.Text = "";
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectstring);
        }
        private void LoadData()
        {
            conn = new SqlConnection(connectstring);
            conn.Open();
            cmd = new SqlCommand("select Drinks_ID, Drinks_Name, Selling_Price, Inventory_Quantity from Drinks", conn);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            dtgrv.DataSource = dttb;
            conn.Close();
        }

        private void btshow_Click_1(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectstring);
            conn.Open();
            cmd = new SqlCommand("select Drinks_ID, Drinks_Name, Selling_Price, Inventory_Quantity from Drinks", conn);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            dtgrv.DataSource = dttb;
            conn.Close();
        }

        private void btadd_Click_1(object sender, EventArgs e)
        {
            int pricesp;
            int priceip;
            if (!int.TryParse(txtsp.Text, out pricesp))
            {
                MessageBox.Show("Input fail", "Error", MessageBoxButtons.OK);
            }
            if (!int.TryParse(txtip.Text, out priceip))
            {
                MessageBox.Show("Input fail", "Error", MessageBoxButtons.OK);
            }
            double money = pricesp - priceip;

            conn = new SqlConnection(connectstring);
            conn.Open();
            cmd = new SqlCommand("insert into Drinks(Drinks_ID, Drinks_Name, Selling_Price, Inventory_Quantity, Import_Price) values(@Drinks_ID, @Drinks_Name, @Selling_Price, @Inventory_Quantity, @Import_Price)", conn);
            cmd.Parameters.AddWithValue("@Drinks_ID", txtid.Text);
            cmd.Parameters.AddWithValue("@Drinks_Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Selling_Price", txtsp.Text);
            cmd.Parameters.AddWithValue("@Inventory_Quantity", txtquantity.Text);
            cmd.Parameters.AddWithValue("@Import_Price", txtip.Text);
            cmd.ExecuteNonQuery();
            LoadData();
            conn.Close();
            ClearInputFields();
        }

        private void btedit_Click_1(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectstring);
            conn.Open();
            string edit = ("Update Drinks set Drinks_ID = @Drinks_ID, Drinks_Name = @Drinks_Name, Selling_Price = @Selling_Price, Inventory_Quantity = @Inventory_Quantity, Import_Price = @Import_Price where Drinks_ID = @Drinks_ID");
            cmd = new SqlCommand(edit, conn);
            cmd.Parameters.AddWithValue("@Drinks_ID", txtid.Text);
            cmd.Parameters.AddWithValue("@Drinks_Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Selling_Price", txtsp.Text);
            cmd.Parameters.AddWithValue("@Inventory_Quantity", txtquantity.Text);
            cmd.Parameters.AddWithValue("@Import_Price", txtip.Text);
            cmd.ExecuteNonQuery();
            LoadData();
            conn.Close();
            ClearInputFields();
        }

        private void btdelete_Click_1(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectstring);
            conn.Open();
            string delete = ("Delete from Drinks where Drinks_ID = @Drinks_ID");
            cmd = new SqlCommand(delete, conn);
            cmd.Parameters.AddWithValue("@Drinks_ID", txtid.Text);
            cmd.ExecuteNonQuery();
            LoadData();
            conn.Close();
            ClearInputFields();
        }

        private void btsearch_Click_1(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectstring);
            conn.Open();
            string search = ("select * from Drinks where Drinks_ID = @Drinks_ID");
            cmd = new SqlCommand(search, conn);
            cmd.Parameters.AddWithValue("@Drinks_ID", txtid.Text);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            if (dttb.Rows.Count > 0)
            {
                txtname.Text = dttb.Rows[0]["Drinks_Name"].ToString();
                txtsp.Text = dttb.Rows[0]["Selling_Price"].ToString();
                txtquantity.Text = dttb.Rows[0]["Inventory_Quantity"].ToString();
                txtip.Text = dttb.Rows[0]["Import_Price"].ToString();
            }
            else
            {
                MessageBox.Show("Drinks does not exist");
            }
            LoadData();
            conn.Close();
        }

        private void dtgrv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgrv.CurrentRow.Index;
            txtid.Text = dtgrv.Rows[i].Cells[0].Value.ToString();
            txtname.Text = dtgrv.Rows[i].Cells[1].Value.ToString();
            txtsp.Text = dtgrv.Rows[i].Cells[2].Value.ToString();
            txtquantity.Text = dtgrv.Rows[i].Cells[3].Value.ToString();
            txtip.Text = dtgrv.Rows[i].Cells[4].Value.ToString();
            LoadData();
        }
    }
}