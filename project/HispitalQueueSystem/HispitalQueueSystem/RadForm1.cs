using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WindowsFormTelerik.ControlCommon;
using SuperSocket.SocketBase;
using CommonUtils.Logger;

namespace HispitalQueueSystem
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        private AppServer appServer;
        public RadForm1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            RadGridViewProperties.SetRadGridViewProperty(this.radGridView1, true,true,0);
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
    }
}
