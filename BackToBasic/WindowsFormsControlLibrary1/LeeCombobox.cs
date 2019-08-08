using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsControlLibrary1
{

    public partial class LeeCombobox : UserControl
    {
        public event EventHandler SelectIndexChangeEnteng;

        public LeeCombobox()
        {
            InitializeComponent();
            this.Load += new EventHandler(myComboBox_Load);
            this.comboBox1.SelectedIndexChanged += new EventHandler(cmbName_SelectedIndexChange);
        }   

        private void myComboBox_Load(object sender, EventArgs e)
        {
            this.BindData();
        }

        void cmbName_SelectedIndexChange(object sender, EventArgs e)
        {

            EventHandler Handler = SelectIndexChangeEnteng;
            ComboBox cb = (ComboBox)sender;
            if (!cb.Focused)
                return;


            if (Handler != null)
                Handler(sender, e);
        }

        void BindData()
        {
           
            DataTable dt = new DataTable();
            dt.Columns.Add("Column1");
            dt.Columns.Add("Column2");

            dt.Rows.Add("Vincent", "1");
            dt.Rows.Add("Flores", "2");
            dt.Rows.Add("Lee", "3");
            this.comboBox1.DataSource = dt;
            this.comboBox1.ValueMember = "Column1";
            this.comboBox1.DisplayMember = "Column2";
        }

        public string GetValue
        {
            get {return this.comboBox1.SelectedValue.ToString();}
        }

        public string GetDisplay
        {
            get { return this.comboBox1.Text; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        
    }
}
