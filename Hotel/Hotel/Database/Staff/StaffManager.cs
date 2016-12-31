////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Database\Staff\StaffManager.cs
//
// summary:	Implements the staff manager class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using HumanResourcesLib;

namespace Hotel.Database.Staff
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Manager for staffs. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class StaffManager
    {
        /// <summary>   List of directors. </summary>
        List<Director> directorList;
        ///// <summary>   List of employee status. </summary>
        //List<EmployeeStatus> employeeStatusList;
        /// <summary>   List of jobs. </summary>
        List<Job> jobsList;
        /// <summary>   List of subordinates. </summary>
        List<Subordinate> subordinatesList;
        /// <summary>   List of supervisors. </summary>
        List<Supervisor> supervisorList;

        List<Employee> employeeList;

        List<User> userList;

        public StaffManager()
        {
            directorList = new List<Director>();
            //employeeStatusList = new List<EmployeeStatus>();
            jobsList = new List<Job>();
            subordinatesList = new List<Subordinate>();
            supervisorList = new List<Supervisor>();
            employeeList = new List<Employee>();
            userList = new List<User>();

            FillDataWithAllDirectors();
            //FillDataWithAllEmployeeStatus();
            FillDataWithAllJobs();
            FillDataWithAllSubordinates();
            FillDataWithAllSupervisor();
            FillDataWithAllEmployee();
            FillDataWithAllUser();
        }

        public void FillDataWithAllDirectors()
        {
            //Deserialize
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Director>));
            TextReader reader = new StreamReader(@"./directorXML.xml");
            object obj = deserializer.Deserialize(reader);
            directorList = (List<Director>)obj;
            reader.Close();
        }
        
        //public void FillDataWithAllEmployeeStatus()
        //{
        //    //Deserialize
        //    XmlSerializer deserializer = new XmlSerializer(typeof(List<EmployeeStatus>));
        //    TextReader reader = new StreamReader(@"./employeeStatusXML.xml");
        //    object obj = deserializer.Deserialize(reader);
        //    employeeStatusList = (List<EmployeeStatus>)obj;
        //    reader.Close();
        //}
        
        public void FillDataWithAllJobs()
        {
            //Deserialize
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Job>));
            TextReader reader = new StreamReader(@"./jobsXML.xml");
            object obj = deserializer.Deserialize(reader);
            jobsList = (List<Job>)obj;
            reader.Close();
        }
        
        public void FillDataWithAllSubordinates()
        {
            //Deserialize
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Subordinate>));
            TextReader reader = new StreamReader(@"./subordinatesXML.xml");
            object obj = deserializer.Deserialize(reader);
            subordinatesList = (List<Subordinate>)obj;
            reader.Close();
        }
        
        public void FillDataWithAllSupervisor()
        {
            //Deserialize
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Supervisor>));
            TextReader reader = new StreamReader(@"./supervisorsXML.xml");
            object obj = deserializer.Deserialize(reader);
            supervisorList = (List<Supervisor>)obj;
            reader.Close();
        }

        public void FillDataWithAllEmployee()
        {
            //Deserialize
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Employee>));
            TextReader reader = new StreamReader(@"./employeeXML.xml");
            object obj = deserializer.Deserialize(reader);
            employeeList = (List<Employee>)obj;
            reader.Close();
        }

        public void FillDataWithAllUser()
        {
            //Deserialize
            XmlSerializer deserializer = new XmlSerializer(typeof(List<User>));
            TextReader reader = new StreamReader(@"./userXML.xml");
            object obj = deserializer.Deserialize(reader);
            userList = (List<User>)obj;
            reader.Close();
        }
        
        public void SerializeDirectors()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Director>));
            using (TextWriter writer = new StreamWriter(@"./directorXML.xml"))
            {
                serializer.Serialize(writer, directorList);
            }
        }

        //public void SerializeEmployeeStatus()
        //{
        //    XmlSerializer serializer = new XmlSerializer(typeof(List<EmployeeStatus>));
        //    using (TextWriter writer = new StreamWriter(@"./employeeStatusXML.xml"))
        //    {
        //        serializer.Serialize(writer, employeeStatusList);
        //    }
        //}

        public void SerializeJobs()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Job>));
            using (TextWriter writer = new StreamWriter(@"./jobsXML.xml"))
            {
                serializer.Serialize(writer, jobsList);
            }
        }

        public void SerializeSubordinates()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Subordinate>));
            using (TextWriter writer = new StreamWriter(@"./subordinatesXML.xml"))
            {
                serializer.Serialize(writer, subordinatesList);
            }
        }

        public void SerializeSupervisor()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Supervisor>));
            using (TextWriter writer = new StreamWriter(@"./supervisorsXML.xml"))
            {
                serializer.Serialize(writer, supervisorList);
            }
        }

        public void SerializeEmployee()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
            using (TextWriter writer = new StreamWriter(@"./employeeXML.xml"))
            {
                serializer.Serialize(writer, employeeList);
            }
        }

        public void SerializeUser()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            using (TextWriter writer = new StreamWriter(@"./userXML.xml"))
            {
                serializer.Serialize(writer, employeeList);
            }
        }

        public void AddNewDirector(Director dir)
        {
            directorList.Add(dir);
            SerializeDirectors();
        }

        //public void AddNewEmployeeStatus(EmployeeStatus status)
        //{
        //    employeeStatusList.Add(status);
        //    SerializeEmployeeStatus();
        //}

        public void AddNewJob(Job job)
        {
            jobsList.Add(job);
            SerializeJobs();
        }

        public void AddNewSubordinate(Subordinate sub)
        {
            subordinatesList.Add(sub);
            SerializeSubordinates();
        }
        
        public void AddNewSupervisor(Supervisor sup)
        {
            supervisorList.Add(sup);
            SerializeSupervisor();
        }

        public void AddNewEmployee(Employee emp)
        {
            employeeList.Add(emp);
            SerializeEmployee();
        }

        public void AddNewUser(User user)
        {
            userList.Add(user);
            SerializeEmployee();
        }

        public void DeleteDirector(Director dir)
        {
            directorList.Remove(dir);
            SerializeDirectors();
        }

        //public void DeleteEmployeeStatus(EmployeeStatus status)
        //{
        //    employeeStatusList.Remove(status);
        //}

        public void DeleteJob(Job job)
        {
            jobsList.Remove(job);
            SerializeJobs();
        }

        public void DeleteSubordinate(Subordinate sub)
        {
            subordinatesList.Remove(sub);
            SerializeSubordinates();
        }

        public void DeleteSupervisor(Supervisor sup)
        {
            supervisorList.Remove(sup);
            SerializeSupervisor();
        }

        public void DeleteEmployee(Employee emp)
        {
            employeeList.Remove(emp);
            SerializeEmployee();
        }

        public void DeleteUser(User user)
        {
            userList.Remove(user);
            SerializeUser();
        }

        public void UpdateDirector(Director dir, Director newVal)
        {
            directorList[directorList.IndexOf(dir)] = newVal;
            SerializeDirectors();
        }

        public void UpdateJob(Job job, Job newVal)
        {
            jobsList[jobsList.IndexOf(job)] = newVal;
            SerializeJobs();
        }

        public void UpdateSubordinate(Subordinate sub, Subordinate newVal)
        {
            subordinatesList[subordinatesList.IndexOf(sub)] = newVal;
            SerializeSubordinates();
        }

        public void UpdateSupervisor(Supervisor sup, Supervisor newVal)
        {
            supervisorList[supervisorList.IndexOf(sup)] = newVal;
            SerializeSupervisor();
        }

        public void UpdateEmployee(Employee emp, Employee newVal)
        {
            employeeList[employeeList.IndexOf(emp)] = newVal;
            SerializeEmployee();
        }

        public void UpdateUser(User user, User newVal)
        {
            userList[userList.IndexOf(user)] = newVal;
            SerializeUser();
        }
    }
}
