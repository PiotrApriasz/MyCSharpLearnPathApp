using System;
using System.Collections.Generic;
using ApplicationCore;
using System.Xml;
using System.IO;
using System.Text;

namespace DataAccess
{
    public static class RegisterService
    {
        public static bool RegisterInXml(User user)
        {
            var xd = new XmlDocument();
            FileStream lfile = new FileStream("/Database/CSharpLearnPathData.xml", FileMode.Open);
            xd.Load(lfile);
            XmlElement cl = xd.CreateElement("User");
            
            cl.SetAttribute("Login", user.Login);
            XmlElement na1 = xd.CreateElement("Password");
            XmlText na1Text = xd.CreateTextNode(user.Password);
            na1.AppendChild(na1Text);
            cl.AppendChild(na1);
            
            XmlElement na2 = xd.CreateElement("Name");
            XmlText na2Text = xd.CreateTextNode(user.Name);
            na2.AppendChild(na2Text);
            cl.AppendChild(na2);
            
            XmlElement na3 = xd.CreateElement("Surname");
            XmlText na3Text = xd.CreateTextNode(user.Surname);
            na3.AppendChild(na3Text);
            cl.AppendChild(na3);

            xd.DocumentElement.AppendChild(cl);
            lfile.Close();
            xd.Save("/Database/CSharpLearnPathData.xml");

            return true;
        }
    }
}