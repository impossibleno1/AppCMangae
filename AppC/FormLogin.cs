using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace AppC
{
    public partial class FormLogin : Form
    {
        string strConnection = @"Data Source=DESKTOP-7ITNCUT\SQLEXPRESS;Initial Catalog=demologin;Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;
        public FormLogin()
        {
            InitializeComponent();


        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strConnection);
                conn.Open();
                string sql = "Select Count(*) From [demologin].[dbo].[login] Where account =@acc And password=@pass";
                command = new SqlCommand(sql, conn);
                command.Parameters.Add(new SqlParameter("@acc", txtusername.Text));
                command.Parameters.Add(new SqlParameter("@pass", txtpassword.Text));
                int x = (int)command.ExecuteScalar();
                if (x == 1)
                {
                    //dang nhap thanh cong
                    MessageBox.Show("Login Succeed", "Nofitication");
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
