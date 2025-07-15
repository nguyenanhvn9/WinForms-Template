using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegForm
{
    public class User
    {
        private String FirstName;
        private String LastName;
        private String Mobile;
        private String Address;
        private String UserName;
        private String Password;
        private String Email;

        public String GetFirstName()
        {
            return FirstName;
        }
        public String GetLastName()
        {
            return LastName;
        }
        public String GetMobile()
        {
            return Mobile;
        }
        public String GetAddress()
        {
            return Address;
        }
        public String GetUserName()
        {
            return UserName;
        }
        public String GetPassword()
        {
            return Password;
        }
        public String GetEmail()
        {
            return Email;
        }
        public void SetFirstName(String firstName)
        {
            FirstName = firstName;
        }
        public void SetLastName(String lastName)
        {
            LastName = lastName;
        }
        public void SetMobile(String mobile)
        {
            Mobile = mobile;
        }
        public void SetAddress(String address)
        {
            Address = address;
        }
        public void SetUserName(String userName)
        {
            UserName = userName;
        }
        public void SetPassword(String password)
        {
            Password = password;
        }
        public void SetEmail(String email)
        {
            Email = email;
        }

        public User() { }

        public User(String firstName, String lastName, String mobile, String address, String userName, String password, String email)
        {
            FirstName = firstName;
            LastName = lastName;
            Mobile = mobile;
            Address = address;
            UserName = userName;
            Password = password;
            Email = email;
        }
    }
}
