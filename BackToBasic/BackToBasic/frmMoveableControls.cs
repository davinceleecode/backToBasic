using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackToBasic
{
    public partial class frmMoveableControls : Form
    {
        private Point pointMouse = new Point();
        private Control ctrlMoved = new Control();
        private bool bMoving = false;
        public frmMoveableControls()
        {
            InitializeComponent();
        }



        public class XXX
        {
             
        }

        private void frmMoveableControls_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            DataTable dt = new DataTable();
            dt.Columns.Add("col_name", typeof(double));
            dt.Columns.Add("col_address", typeof(string));
            dt.Columns.Add("colSelect", typeof(bool));

            dt.Rows.Add(8.2323232323323232, "USA", "false");
            dt.Rows.Add(8.2323232323323232, "THAILAND", "false");
            dt.Rows.Add(8.2323232323323232, "PHILIPPINES", "false");






            dataGridView1.DataSource = dt;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            //if not left mouse button, exit
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            // save cursor location
            pointMouse = e.Location;
            //remember that we're moving
            bMoving = true;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            bMoving = false;

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //if not being moved or left mouse button not used, exit
            if (!bMoving || e.Button != MouseButtons.Left)
            {
                return;
            }
            //get control reference
            ctrlMoved = (Control)sender;
            //set control's position based upon mouse's position change
            ctrlMoved.Left += e.X - pointMouse.X;
            ctrlMoved.Top += e.Y - pointMouse.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = null;

           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
 
            if (e.RowIndex >= 0)
    
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
                row.Cells["colSelect"].Value = false;

            this.dataGridView1.Rows[e.RowIndex].Cells["colSelect"].Value = true;


            var count = from hasValue in dataGridView1.Rows.Cast<DataGridViewRow>()
                        where Convert.ToBoolean(hasValue.Cells["colSelect"].Value) == true
                        select hasValue;


            if (count.Count() <= 0)
                this.dataGridView1.Rows[e.RowIndex].Cells["colSelect"].Value = true;
        }

      
    }
}
