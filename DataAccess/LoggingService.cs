using System;
using ApplicationCore;
using System.Xml;
using System.IO;

namespace DataAccess
{
    public static class LoggingService
    {
        /// <summary>
        /// Sign in user to his account
        /// </summary>
        /// <param name="login">Login that user entered</param>
        /// <param name="password">Password that user entered</param>
        /// <returns></returns>
        public static bool LoginXml(string  login, string password)
        {
            bool foundLogin = false;
            bool foundPassword = false;
            
            var xdoc = new XmlDocument();
            var up = new FileStream("/Database/CSharpLearnPathData.xml", FileMode.Open);
            xdoc.Load(up);
            XmlNodeList list = xdoc.GetElementsByTagName("User");

            for (int i = 0; i < list.Count; i++) 
            {
                XmlElement cu = (XmlElement) xdoc.GetElementsByTagName("User")[i];

                if (cu?.GetAttribute("Login") == login)
                {
                    foundLogin = true;
                    
                    XmlElement pass = (XmlElement) xdoc.GetElementsByTagName("Password")[i];

                    if (pass?.InnerText == password) foundPassword = true;
                }
            }
            up.Close();

            return foundLogin && foundPassword;
        }
    }
}