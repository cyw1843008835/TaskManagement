using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    class ReadPropertyFile
    {
        public static Dictionary<string,string> getDbInfo()
        {
            Dictionary<string, string> dbInfo = new Dictionary<string, string>();
            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../propertyFile.xml");
            var nodes = doc.GetElementsByTagName("DBINFO");
            foreach (XmlNode node in nodes)
            {
                try
                {
                    var host = node.ChildNodes.Cast<XmlNode>().FirstOrDefault(x => x.Name == "HOST").InnerText;
                    var port = node.ChildNodes.Cast<XmlNode>().FirstOrDefault(x => x.Name == "PORT").InnerText;
                    var service_name = node.ChildNodes.Cast<XmlNode>().FirstOrDefault(x => x.Name == "SERVICE_NAME").InnerText;
                    var user = node.ChildNodes.Cast<XmlNode>().FirstOrDefault(x => x.Name == "USER").InnerText;
                    var password = node.ChildNodes.Cast<XmlNode>().FirstOrDefault(x => x.Name == "PASSWORD").InnerText;
                    dbInfo.Add("HOST", host);
                    dbInfo.Add("PORT", port);
                    dbInfo.Add("SERVICE_NAME", service_name);
                    dbInfo.Add("USER", user);
                    dbInfo.Add("PASSWORD", password);
                }
                catch { }
            }
            return dbInfo;
        }
        public static string getOraConnStr()
        {
            Dictionary<string, string> dbInfoDic = new Dictionary<string, string>();
            dbInfoDic =getDbInfo();
            string oraConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=" + dbInfoDic["HOST"] + ")(PORT=" + dbInfoDic["PORT"] + "))(CONNECT_DATA=(SERVICE_NAME=" + dbInfoDic["SERVICE_NAME"] + ")));Persist Security Info=True;User ID=" + dbInfoDic["USER"] + ";Password=" + dbInfoDic["PASSWORD"];
            return oraConnStr;
        }

    }
}
