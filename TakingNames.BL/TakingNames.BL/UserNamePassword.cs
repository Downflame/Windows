using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakingNames.BL
{
    public class UserNamePassword
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string password1 { get; set; }

        public string password2 { get; set; }


        //public string PasswordValidater
        //{
            
        //    get
        //    {
                

        //        if (password1 == password2)
        //        {
        //            return Password;

        //        }

        //        if(!string.IsNullOrWhiteSpace(Password))
        //        {
        //            return Password += "*";

        //        }

        //        return Password;
        //    }

        //}

        public bool ValidatePassword()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Password)) isValid = false;
            if (string.IsNullOrWhiteSpace(password1)) isValid = false;
            if (string.IsNullOrWhiteSpace(password2)) isValid = false;
            if (password1 == password2) isValid = true;

            return isValid;
        }
    }
}
