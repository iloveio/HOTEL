using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using Hotel.Database.Staff;
using HumanResourcesLib;

namespace Hotel.Database.Access
{
    class AccessManager
    {
        public List<HumanResourcesLib.User> userList { get; set; }

        public AccessManager()
        {
            userList = new List<HumanResourcesLib.User>();
            StaffManager mgr = new StaffManager();
            userList.AddRange(mgr.directorList);
            userList.AddRange(mgr.employeeList);
            userList.AddRange(mgr.subordinatesList);
            userList.AddRange(mgr.supervisorList);
        }

        public string GetPassword(HumanResourcesLib.User log)
        {
            return log.Password;
        }

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
