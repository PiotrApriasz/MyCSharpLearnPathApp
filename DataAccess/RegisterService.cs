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
        /// <summary>
        /// Add new user to XML data base
        /// </summary>
        /// <param name="user">Object of user created while registration</param>
        /// <returns></returns>
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
            
            /*XmlElement na2 = xd.CreateElement("Name");
            XmlText na2Text = xd.CreateTextNode(user.Name);
            na2.AppendChild(na2Text);
            cl.AppendChild(na2);
            
            XmlElement na3 = xd.CreateElement("Surname");
            XmlText na3Text = xd.CreateTextNode(user.Surname);
            na3.AppendChild(na3Text);
            cl.AppendChild(na3);*/

            xd?.DocumentElement?.AppendChild(cl);
            lfile.Close();
            xd.Save("/Database/CSharpLearnPathData.xml");

            return true;
        }

        /// <summary>
        /// Check if in data base is the user with the same login as new user want
        /// </summary>
        /// <param name="login">Login which new user want to register</param>
        /// <returns></returns>
        public static bool IsLoginSameAsRegisteredBefore(string login)
        {
            var xdoc = new XmlDocument();
            var up = new FileStream("/Database/CSharpLearnPathData.xml", FileMode.Open);
            xdoc.Load(up);
            XmlNodeList list = xdoc.GetElementsByTagName("User");

            for (int i = 0; i < list.Count; i++) 
            {
                XmlElement cu = (XmlElement) xdoc.GetElementsByTagName("User")[i];

                if (cu?.GetAttribute("Login") == login)
                {
                    up.Close();
                    return true;
                }
            }

            up.Close();
            return false;
        }
    }
}