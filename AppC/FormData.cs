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
        }
        void FormData_Load(object sender, EventArgs e)
        {
            this.LoadDataList();// Load du lieu data tu database
        }
        private void LoadDataList()
        {
            Data2Entities db = new Data2Entities(); 
            datagridview1.DataSource = db.data.ToList(); //Load dữ liệu từ database
        }
        
    }
}
