using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using SuperSocket.SocketBase;
using CommonUtils.Logger;
using WindowsFormTelerik.ControlCommon;

namespace HispitalQueueSystem
{
    public partial class FrmQueueSystemMain : Telerik.WinControls.UI.RadForm
    {
        private AppServer appServer;

        public FrmQueueSystemMain()
        {
            InitializeComponent();
        }

        private void AppServer()
        {
            appServer = new AppServer();

            //Setup the appServer
            if (!appServer.Setup(10011)) //Setup with listening port
            {
                LogHelper.Log.Info("Failed to setup port!");
                return;
            }

            //Try to start the appServer
            if (!appServer.Start())
            {
                LogHelper.Log.Info("Failed to start server!");
                return;
            }

            LogHelper.Log.Info("The server started successfully!");
        }

        private void FrmQueueSystemMain_Load(object sender, EventArgs e)
        {
            RadGridViewProperties.SetRadGridViewProperty(this.radGridView1,false,true,0);
            this.radGridView1.MasterTemplate.ShowHeaderCellButtons = false;

            this.radGridView1.Rows.AddNew();
            this.radGridView1.Rows[0].Cells[0].Value = "12号";
            this.radGridView1.Rows[0].Cells[1].Value = "黄忠华";
            this.radGridView1.Rows[0].Cells[2].Value = "3号";
        }
    }
}
