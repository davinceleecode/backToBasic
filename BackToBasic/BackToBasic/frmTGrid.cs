using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Net;
using System.IO;

namespace BackToBasic
{
    public partial class frmTGrid : Telerik.WinControls.UI.RadForm
    {
        public frmTGrid()
        {
            InitializeComponent();
        }

        private void frmTGrid_Load(object sender, EventArgs e)
        {

         



            DataTable dt = new DataTable();
            dt.Columns.Add("FullName");
            dt.Columns.Add("Address");
            dt.Columns.Add("ContactNumber");

            dt.Rows.Add("Vincent Lee Flores", "Ormoc City", "09078121415");
            dt.Rows.Add("Rio Cinco", "Ormoc City", "09078121415");
            dt.Rows.Add("Glenn Amora", "Ormoc City", "09078121415");
            dt.Rows.Add("Romeo Patindol", "Ormoc City", "09078121415"); dt.Rows.Add("Vincent Lee Flores", "Ormoc City", "09078121415");
            dt.Rows.Add("Rio Cinco", "Ormoc City", "09078121415");
            dt.Rows.Add("Glenn Amora", "Ormoc City", "09078121415");
            dt.Rows.Add("Romeo Patindol", "Ormoc City", "09078121415"); dt.Rows.Add("Vincent Lee Flores", "Ormoc City", "09078121415");
            dt.Rows.Add("Rio Cinco", "Ormoc City", "09078121415");
            dt.Rows.Add("Glenn Amora", "Ormoc City", "09078121415");
            dt.Rows.Add("Romeo Patindol", "Ormoc City", "09078121415");

            
            //MasterTemplate.AutoGenerateColumns = false;
            MasterTemplate.DataSource = dt;
            
            
        }

        private void MasterTemplate_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                radTextBox1.Text = MasterTemplate.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                radTextBox2.Text = MasterTemplate.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                radTextBox3.Text = MasterTemplate.Rows[e.RowIndex].Cells["ContactNumber"].Value.ToString();
            }
         
        }
    }
}
