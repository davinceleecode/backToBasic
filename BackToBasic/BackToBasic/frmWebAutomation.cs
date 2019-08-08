using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Automation;

namespace BackToBasic
{
    public partial class frmWebAutomation : Form
    {
        //string pass = "3";
        public frmWebAutomation()
        {
            InitializeComponent();
        }

        private void frmWebAutomation_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            #region Login FB
            webBrowser1.Navigate(@"https://www.facebook.com/");
            this.LoadWait();
            //webBrowser1.Document.GetElementById("email").SetAttribute("value", "wiz_vincent@yahoo.com");
            //webBrowser1.Document.GetElementById("pass").SetAttribute("value", pass);

            ////webBrowser1.Document.GetElementById("u_0_q").InvokeMember("Click");
            //foreach (var item in webBrowser1.Document.GetElementsByTagName("input"))
            //{
            //    if (((HtmlElement)item).GetAttribute("value") == "Log In")
            //    {
            //        ((HtmlElement)item).InvokeMember("Click");
            //    }
            //}



            webBrowser1.Navigate(@"http://www.facebook.com/logout.php?confirm=1");
            
            this.LoadWait();

          
            


            #endregion



            #region Search Animal
            //webBrowser1.Navigate(@"https://google.com");
            //this.LoadWait();


            //foreach (HtmlElement elem in webBrowser1.Document.GetElementsByTagName("input"))
            //{
            //    if (elem.GetAttribute("name") == "q")
            //    {
            //        elem.SetAttribute("value", "Animals");
            //    }
            //}

            //SendKeys.SendWait("{ENTER}");
            //webBrowser1.Navigate(@"https://en.wikipedia.org/wiki/Animal");
            //this.LoadWait();


            //string value = string.Empty;
            //foreach (HtmlElement element in webBrowser1.Document.GetElementsByTagName("div"))
            //{
            //    if (element.GetAttribute("id") == "mw-content-text")
            //    {
            //        foreach (var item in element.Document.GetElementsByTagName("p"))
            //        {
            //            value = ((HtmlElement)item).InnerText;
            //            break;
            //        }
            //    }
            //}

            //MessageBox.Show(value);
            #endregion
        }

        private void LoadWait()
        {
            do
            {
                Application.DoEvents();
            } while (!(webBrowser1.ReadyState == WebBrowserReadyState.Complete));
        }
    }
}
