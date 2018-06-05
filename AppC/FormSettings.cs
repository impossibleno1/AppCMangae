using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppC
{
    public partial class FormSettings : Form
    {
        DataCEntities db = new DataCEntities();
        public FormSettings()
        {
            InitializeComponent();
            LoadData();
            AddBinding();
        }
        

        #region methods

        void AddBinding()
        {
            
            et_name.DataBindings.Add(new Binding("Text", datagridview2.DataSource, "fullname", true, DataSourceUpdateMode.Never));
            et_thon.DataBindings.Add(new Binding("Text", datagridview2.DataSource, "thon", true, DataSourceUpdateMode.Never));
            et_tram.DataBindings.Add(new Binding("Text", datagridview2.DataSource, "matram", true, DataSourceUpdateMode.Never));
            et_ctdong.DataBindings.Add(new Binding("Text", datagridview2.DataSource, "dong", true, DataSourceUpdateMode.Never));
            et_ctpha.DataBindings.Add(new Binding("Text", datagridview2.DataSource, "pha", true, DataSourceUpdateMode.Never));
            et_mact.DataBindings.Add(new Binding("Text", datagridview2.DataSource, "mahieucongto", true, DataSourceUpdateMode.Never));
            dt_dky.DataBindings.Add(new Binding("DateTime", datagridview2.DataSource, "ngaykiemdinh", true, DataSourceUpdateMode.Never));
            dt_hhan.DataBindings.Add(new Binding("DateTime", datagridview2.DataSource, "hankiemdinh", true, DataSourceUpdateMode.Never));
            et_ghichu.DataBindings.Add(new Binding("Text", datagridview2.DataSource, "ghichu", true, DataSourceUpdateMode.Never));
        }


        void LoadData()
        {
            
            datagridview2.DataSource = db.data2.ToList();
        }

        void Add()
        {
            {
                data2 dt = new data2()
                {
                    
                    fullname = et_name.Text,
                    thon = et_thon.Text,
                    matram = et_tram.Text,
                    dong = et_ctdong.Text,
                    pha = et_ctpha.Text,
                    mahieucongto = et_mact.Text,
                    ngaykiemdinh = dt_dky.DateTime,
                    hankiemdinh = dt_hhan.DateTime,
                    ghichu = et_ghichu.Text
                };
                db.data2.Add(dt);
                db.SaveChanges();
                
            }
        }

        void Delete()
        {

            
            data2 dt = db.data2.Where(p => p.mahieucongto == et_mact.Text).SingleOrDefault();
            db.data2.Remove(dt);
            db.SaveChanges();
            
        }

        void Edit()
        {
            int id1 = Convert.ToInt32(datagridview2.SelectedCells[0].OwningRow.Cells["STT"].Value.ToString());
            data2 dt = db.data2.Find(id1);
            dt.fullname = et_name.Text;
            dt.thon = et_thon.Text;
            dt.matram = et_tram.Text;
            dt.dong = et_ctdong.Text;
            dt.pha = et_ctpha.Text;
            dt.mahieucongto = et_mact.Text;
            dt.ngaykiemdinh = dt_dky.DateTime;
            dt.hankiemdinh = dt_hhan.DateTime;
            dt.ghichu = et_ghichu.Text;
            db.SaveChanges();
        }

        #endregion

        #region Events

        private void bt_load_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bt_create_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        #endregion

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormData Add2 = new FormData();
            Add2.ShowDialog();
            this.Close();
        }

    }
}
