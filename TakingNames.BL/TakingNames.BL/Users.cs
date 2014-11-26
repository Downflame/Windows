using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakingNames.BL
{
    public class Users
    {

       public string LastName { get; set; }

        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

        public int CustomerID { get; set; }

        public string FullName
        {
            get
            { 
                string fullname = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullname))
                    {
                        fullname += ", ";
                    }
                    fullname += FirstName;
                }
                return fullname;
            }
        }

        public Users Retrieve(int customerId)
        {
            return new Users();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }

}
