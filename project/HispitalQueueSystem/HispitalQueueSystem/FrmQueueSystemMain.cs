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
using System.Speech.Synthesis;

namespace HispitalQueueSystem
{
    public partial class FrmQueueSystemMain : Telerik.WinControls.UI.RadForm
    {
        private AppServer appServer;

        public FrmQueueSystemMain()
        {
            InitializeComponent();
        }

        private void SpeechTest()
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();
            speech.Rate = -2;
            GetLocalVoice(speech);
            var voice = "Microsoft Huihui Desktop";
            speech.SelectVoice(voice);//设置播音员（中文）
                                                 //speech.SelectVoice("Microsoft Anna"); //英文
            speech.Volume = 100;
            speech.SpeakAsync("请张三到20088号窗口");//语音阅读方法
            //speech.SpeakAsyncCancelAll();
            speech.SpeakCompleted += Speech_SpeakCompleted;
        }

        private string GetLocalVoice(SpeechSynthesizer speech)
        {
            ////获取本机上所安装的所有的Voice的名称
            string voicestring = "";
            foreach (InstalledVoice iv in speech.GetInstalledVoices())
            {
                voicestring += iv.VoiceInfo.Name + ",";
            }
            return voicestring;
        }

        private void Speech_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            MessageBox.Show("播报完成！");
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

            SpeechTest();
        }
    }
}
