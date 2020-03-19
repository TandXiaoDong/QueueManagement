using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueServiceTest
{
    public partial class Form1 : Form
    {
        private CalQueueService.CallServiceSoapClient queueService;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            queueService = new CalQueueService.CallServiceSoapClient();

            this.btn_addScreen.Click += Btn_addScreen_Click;
            this.btn_removeScreen.Click += Btn_removeScreen_Click;
        }

        private void Btn_removeScreen_Click(object sender, EventArgs e)
        {
            this.tb_reponse.Text = queueService.callAndRecalPatient(this.tb_patientID.Text.Trim(), this.tb_patientName.Text.Trim(), this.tb_counterID.Text.Trim(), 0);
        }

        private void Btn_addScreen_Click(object sender, EventArgs e)
        {
            this.tb_reponse.Text = queueService.callAndRecalPatient(this.tb_patientID.Text.Trim(),this.tb_patientName.Text.Trim(),this.tb_counterID.Text.Trim(),1);
        }
    }
}
