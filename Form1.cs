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

namespace proiect
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Cabinet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select count(*) from LogIn where username='"+tbUsername.Text+"' and password='"+tbPassword.Text+"'", con);
            adapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1") {
                this.Hide();
                Dashboard form = new Dashboard();
                form.Show();
            }
            else
            {
                MessageBox.Show("username sau parola incorecta");
            }
            con.Close();
           
        }
    }
}
