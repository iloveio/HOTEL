using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using Hotel.Database;
using HumanResourcesLib;

namespace Hotel.Database
{
    /// <summary>
    /// Class AccessManager.
    /// </summary>
    public class AccessManager
    {
        /// <summary>
        /// Gets or sets the user list.
        /// </summary>
        /// <value>The user list.</value>
        public List<HumanResourcesLib.User> userList { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessManager"/> class.
        /// </summary>
        public AccessManager()
        {
            userList = new List<HumanResourcesLib.User>();
            StaffManager mgr = new StaffManager();
            userList.AddRange(mgr.directorList);
            userList.AddRange(mgr.employeeList);
            userList.AddRange(mgr.subordinatesList);
            userList.AddRange(mgr.supervisorList);
            userList.AddRange(mgr.userList);
        }

        /// <summary>
        /// Gets the password.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>System.String.</returns>
        public string GetPassword(HumanResourcesLib.User user)
        {
            return user.Password;
        }

        /// <summary>
        /// Checks the authorization.
        /// </summary>
        /// <param name="login">The login.</param>
        /// <param name="password">The password.</param>
        /// <returns>HumanResourcesLib.User.</returns>
        public HumanResourcesLib.User CheckAuthorization(string login, string password)
        {
            foreach (var item in userList)
            {
                if (item.Login == login)
                    if (item.Password == password)
                        return item;
            }
            return null;
        }
    }
}
