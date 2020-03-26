using System;

namespace CallSysServicce.ClientSocket.AppBase
{


    /// <summary>
    /// STENT信号
    /// </summary>
    public enum StentSignalEnum 
    {
        [Description("登陆")]
        Login = 1,
        [Description("请求数据头")]
        RequestHead = 0Xff,
        [Description("请求发送通道1数据/header")]
        RequestDataCh1 = 0X01aa,
        [Description("请求发送通道2数据/header")]
        RequestDataCh2 = 0X02aa,
        [Description("请求停止发送通道1数据")]
        StopDataCh1 = 0Xbb01,
        [Description("请求停止发送通道2数据")]
        StopDataCh2 = 0Xbb02
    }

    public class DescriptionAttribute : Attribute
    {
        public DescriptionAttribute(string des)
        {
            Description = des;
        }
        public string Description { get; set; }
    }

    public static class EnumUtil
    {
        public static string GetDescription(this Enum value, bool nameInstead = true)
        {
            var type = value.GetType();
            var name = Enum.GetName(type, value);
            if (name == null)
                return null;

            var field = type.GetField(name);
            var attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;

            if (attribute == null && nameInstead)
                return name;
            return attribute?.Description;
        }
    }
}
