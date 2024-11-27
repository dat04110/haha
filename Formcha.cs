using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asmsql
{
    public partial class Formcha : Form
    {
        public Formcha()
        {
            InitializeComponent();
        }
        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pictureBox2.Visible = true;
            
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());
            
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3());        
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void Formcha_Load(object sender, EventArgs e)
        {
            menumanage.Enabled = false;
            menupro.Enabled = true;
            txtpass.Visible = true;
            btlg.Visible = true;
        }

        private void doNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1());
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
        }

        private void foodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1());
        }

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form5());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void staticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form6());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtpass.Text == "123")
            {
                menufull.Enabled =true;
                menupro.Enabled =true;
                menumanage.Enabled = true;
            }
            if (txtpass.Text == "111")
            {
                menufull.Enabled =true;
                menupro.Enabled =true;
                menumanage.Enabled =false;
                menustatic.Enabled =false;
            }
        }
    }
}
