using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SuperSocket.SocketBase;
using SuperSocket.Common;
using SuperSocket.SocketEngine;
using CommonUtils.Logger;
using CallSysServicce.ClientSocket;

namespace CallSysServicce
{
    /// <summary>
    /// CallService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://callSystem.service/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class CallService : System.Web.Services.WebService
    {

        /// <summary>
        /// 转发智能发药通知上屏/下屏指令
        /// </summary>
        /// <param name="patientID">病人ID</param>
        /// <param name="patientName">病人姓名</param>
        /// <param name="counterID">取药窗口</param>
        /// <param name="action">1-上屏，0-下屏</param>
        /// <returns></returns>
        [WebMethod]
        public string callAndRecalPatient(string patientID,string patientName,string counterID,int action)
        {
            //收到上屏或下屏指令，通知屏幕显示上屏/下屏
            //连接服务，发送成功后，返回1
            //直接发送到客户端，若发送失败，重新连接后再发送，最终返回发送结果

            if (!SuperEasyClient.client.IsConnected)
            {
                SuperEasyClient.ConnectServer();
            }
            else
            {
                SuperEasyClient.SendMessage();
            }
            return "1";
        }
    }
}
