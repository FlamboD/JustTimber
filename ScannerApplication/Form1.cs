using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustTimber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (JobCardStatus jcs in Enum.GetValues(typeof(JobCardStatus)))
                ctlStatus.Items.Add(jcs);

            //ctlStatus.Items.Add(JobCardStatus.NotStarted);
            //ctlStatus.Items.Add(JobCardStatus.Cutting);
            //ctlStatus.Items.Add(JobCardStatus.Edging);
            //ctlStatus.Items.Add(JobCardStatus.Packing);
            //ctlStatus.Items.Add(JobCardStatus.Delivery);
            //ctlStatus.Items.Add(JobCardStatus.Done);
        }

        private void ctlUpdateButton_Click(object sender, EventArgs e)
        {
            string jobID = ctlJobID.Text;
            string worker = ctlWorker.Text;

            using (var session = DocumentStoreHolder.Store.OpenSession())
            {
                JobCard jc = session.Load<JobCard>(jobID);

                jc.AddWork(DateTime.Now, worker);

                session.SaveChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctlStatus.Enabled = !ctlStatus.Enabled;
            ctlWorker.Enabled = !ctlWorker.Enabled;
        }
    }
}
