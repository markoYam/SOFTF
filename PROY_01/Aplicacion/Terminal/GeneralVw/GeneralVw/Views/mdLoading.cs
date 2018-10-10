using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralVw.Views
{
    public partial class mdLoading : Form
    {

        public Action worker { get; set; }
        Task task;
        loading load;
        //ResponseObjectVM response;

        public mdLoading(Action Worker)
        {
            InitializeComponent();
            this.worker = Worker;
        }

        public interface loading
        {

            //ResponseObjectVM load(ResponseObjectVM response, int type);
        }

        private void mdLoading_Load(object sender, EventArgs e)
        {
            
        }

        public void textMessage(string text)
        {
            if (!string.IsNullOrEmpty(text))
                lblMessage.Text = text;
        }

        CancellationTokenSource cancelSurce = new CancellationTokenSource();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            CancellationToken token = cancelSurce.Token;
            task = Task.Factory.StartNew(worker, token).ContinueWith(x =>
             this.cancel());

        }

        public void cancel()
        {
            cancelSurce.Cancel();
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        Close();
                    });
                }
                else this.Close();                
            }
            catch (Exception e)
            {
            }

        }
    }
}
