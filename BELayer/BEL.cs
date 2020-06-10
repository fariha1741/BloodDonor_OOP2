using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BELayer
{
    public class BEL
    {
        public string _userName;
        public string _password;
        public string _phone;
        public string _bloodGroup;
        public string _address;
        public string _activity;
        public string _requested;

        public string userName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string bloodGroup
        {
            get { return _bloodGroup; }
            set { _bloodGroup = value; }
        }
        public string address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string activity
        {
            get { return _activity; }
            set { _activity = value; }
        }

        public string requested
        {
            get { return _requested; }
            set { _requested = value; }
        }
    }
}
