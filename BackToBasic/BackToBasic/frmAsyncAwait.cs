using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace BackToBasic
{
    public partial class frmAsyncAwait : Telerik.WinControls.UI.RadForm
    {
        int x = 0;
        public frmAsyncAwait()
        {
            InitializeComponent();
        }

        
        private async void btnProcess_Click(object sender, EventArgs e)
        {

            Task<int> task = new Task<int>(Count);
            task.Start();
            radLabel1.Text = "Processing....";
            int _count = await task;
            MessageBox.Show(_count.ToString());
            radLabel1.Text = "Processing....";

            //int _count = 0;
            //Thread thread = new Thread(() =>
            //{
            //    _count = Count();
            //    //MessageBox.Show(_count.ToString());
                
            //    Action action = () => MessageBox.Show(_count.ToString());
            //    this.BeginInvoke(action);
            //});
            //thread.Start();
            //radLabel1.Text = "Processing....";
        }

        private int Count()
        {
            Thread.Sleep(5000);
            x++;
            return x;
           
        }


        CancellationTokenSource tokenSource = new CancellationTokenSource();
        private void radButton1_Click(object sender, EventArgs e)
        {
            if (radButton1.Text == "Start") {
                radButton1.Text = "Stop";
            tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            Task t1 = Task.Factory.StartNew(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.Write("* ");
                    Thread.Sleep(5000);
                    Action x = () => { btnProcess.Enabled = false; };
                    this.BeginInvoke(x);

                }
            },
            token);
            }
            else { tokenSource.Cancel(); radButton1.Text = "Start"; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        private void frmAsyncAwait_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1; 
        }
    }

   
}
