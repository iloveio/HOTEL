using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hotel.Database;
using HumanResourcesLib;
using System.Collections.Generic;

namespace HumanResourcesLibTests
{
    [TestClass]
    public class SuperVisorTests
    {
        [TestMethod]
        public void SerializeSupervisoWithSubordinateinList()
        {

            Director dyr = new Director("asd", "asda", 1, new List<Employee>(), "asd", "asda");
            dyr.HireAnEmployee("1123", "qweq", 1, new EmployeeStatus(EmployeeStatusName.ErnedLeave, DateTime.Now, DateTime.Now), 11f, new List<Job>(), "aaa", "aa", Postion.Accounting);
            IManager sup = (Supervisor)dyr.GetSupervisors()[0];
            sup.HireAnEmployee("qwer", "asd", 1, new EmployeeStatus(EmployeeStatusName.ErnedLeave, DateTime.Now, DateTime.Now), 12f, new List<Job>(), "11234", "1234", Postion.Accounting);
            StaffManager man = new StaffManager();
            man.AddNewDirector(dyr);
            man.AddNewSupervisor((Supervisor)dyr.GetSupervisors()[0]);
        }
    }
}
