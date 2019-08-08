using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BackToBasic
{
    public partial class frmReflection : Form
    {
        public frmReflection()
        {
            InitializeComponent();
        }

        private void frmReflection_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDiscoverTypeInfo_Click(object sender, EventArgs e)
        {
            ClearData();
            string TypeName = txtTypeName.Text;
            Type T = Type.GetType(TypeName);


            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                this.listMethods.Items.Add(method.ReturnType.Name + "  " + method.Name);
            }

            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                this.listProperties.Items.Add(property.Name);
            }

            ConstructorInfo[] Constructors = T.GetConstructors();
            foreach (ConstructorInfo Constructor in Constructors)
            {
                this.listConstructors.Items.Add(Constructor.ToString());
            }
        }

        private void ClearData()
        {
            this.listConstructors.Items.Clear();
            this.listMethods.Items.Clear();
            this.listProperties.Items.Clear();
        }
    }
}
