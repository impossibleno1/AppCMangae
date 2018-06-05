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
            this.Load += new EventHandler(FormData_Load);
            this.mn_crud.Click += new EventHandler(mn_crud_Click);
        }
        void FormData_Load(object sender, EventArgs e)
        {
            this.LoadDataList();// Load du lieu data tu database
        }
        private void LoadDataList()
        {
            DataCEntities db = new DataCEntities(); 
            datagridview1.DataSource = db.data2.ToList(); //Load dữ liệu từ database
        }

        private void mn_crud_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSettings Add = new FormSettings();
            Add.ShowDialog();
            this.Close();
        }


        
    }
}
