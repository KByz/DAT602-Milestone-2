using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dust2dustpart3
{
    public delegate void Then();
    public class User
    {
        private string? _username;
        private string? _email;
        private string? _password;
        private string? _firstName;
        private string? _accountType;
        private string? _status;
        private int _attempts;



        // Class statics
        public static User? CurrentUser { get; set; }

        public static List<User> lcUsers = new List<User>();

        // Control
        public Boolean Update = false;
        public Then? then;

        // Properties
        public string? username
        {
            get { return _username; }
            set
            {
                _username = value;
                if (Update) updateData();
            }
        }
        public string email
        {
            get { return _email; }
            set
            {
                _email = value;
                if (Update) updateData();
            }
        }

        public string? password
        {
            get { return _password; }
            set
            {
                _password = value;
                if (Update) updateData();
            }
        }

        public string firstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                if (Update) updateData();
            }
        }
        public string accountType
        {
            get { return _accountType; }
            set
            {
                _accountType = value;
                if (Update) updateData();
            }
        }

        public string status
        {
            get { return _status; }
            set
            {
                _status = value;
                if (Update) updateData();
            }
        }

        public int attempts
        {
            get { return _attempts; }
            set
            {
                _attempts = value;
                if (Update) updateData();
            }
        }
        // Editor GUI
        public void Edit(Then pRunNext)
        {
            then = pRunNext;
            EditAccount editor = new EditAccount();
            editor.Show();
        }

        public void UpdateData()
        {
            if (this.Update == true)
            {
                this.updateData();
                if (this.username == User.CurrentUser.username)
                {
                    User.CurrentUser.Update = false;
                    User.CurrentUser.username = this.username;
                    User.CurrentUser.email = this.email;
                    User.CurrentUser.password = this.password;
                    User.CurrentUser.firstName = this.firstName;
                    User.CurrentUser.accountType = this.accountType;
                    User.CurrentUser.status = this.status;
                    User.CurrentUser.attempts = this.attempts;
                }
                this.Update = false;
            }
        }
        // Private Methods
        private void updateData()
        {
            if (_username != null && _password != null)
            {
                clsUserDAO dbAccess = new clsUserDAO();
                dbAccess.Update(_username, _email, _password, _firstName, _accountType, _status, _attempts);
            }

        }

    }
}