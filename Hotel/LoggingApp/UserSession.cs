using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanResourcesLib;
using Hotel.Database;


namespace LoggingApp
{
    public class UserSession : ISession<User>
    {
        public UserSession()
        {
            accesManager = new AccessManager();
        }
        private User user;

        public string Login { get; set; }
        public string Password { get; set; }

        private AccessManager accesManager;

        public AccessManager AccesManager
        {
            get { return accesManager; }
            set { accesManager = value; }
        }


        public User Session
        {
            get
            {
                return user;
            }

        }

        public void EndSession()
        {
            user = null;
        }

        public void StartSession()
        {
            user = FindMatchingUserDataInDB();
        }
        
        private User FindMatchingUserDataInDB()
        {
            var user = AccesManager.userList.Where(u => u.Login == Login).Where(u => u.Password == Password).FirstOrDefault();
            if(user == null)
            {
                throw new NullReferenceException();
            }
            return user;
        }


    }
}
