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

namespace AppC
{
    public partial class FormData : Form
    {
        public FormData()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-7ITNCUT\SQLEXPRESS;Initial Catalog=demologin;Integrated Security=True");
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select * from data";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            datagridview1.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void FormData_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }
    }
}
