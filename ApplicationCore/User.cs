using System;

namespace ApplicationCore
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        /// <summary>
        /// Function to login user to system
        /// </summary>
        /// <returns></returns>
        public bool ToLogIn()
        {
            return true;
        }

        /// <summary>
        /// Function To register user to the system
        /// </summary>
        /// <returns></returns>
        public bool ToRegister()
        {
            return false;
        }
    }
}