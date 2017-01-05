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
using System.Runtime.Serialization;

namespace Hotel.Database
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Manager for staffs. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class StaffManager
    { 
        public List<Director> directorList { get; set; }

        public List<Job> jobsList { get; set; }

        public List<Subordinate> subordinatesList { get; set; }

        public List<Supervisor> supervisorList { get; set; }

        public List<Employee> employeeList { get; set; }

        public List<User> userList { get; set; }




        public StaffManager()
        {
            directorList = new List<Director>();
            //employeeStatusList = new List<EmployeeStatus>();
            jobsList = new List<Job>();
            subordinatesList = new List<Subordinate>();
            supervisorList = new List<Supervisor>();
            employeeList = new List<Employee>();
            userList = new List<User>();
            
            //FillDataWithAllDirectors();
            ////FillDataWithAllEmployeeStatus();
            //FillDataWithAllJobs();
            //FillDataWithAllSubordinates();
            //FillDataWithAllSupervisor();
            //FillDataWithAllEmployee();
            //FillDataWithAllUser();
        }

        public void FillDataWithAllDirectors()
        {


            MyXmlSerializer<List<Director>> serialzier = new MyXmlSerializer<List<Director>>();
            directorList = serialzier.ReadObject(@"./directorXML.xml");
           
        }
                
        public void FillDataWithAllJobs()
        {
            //Deserialize
            MyXmlSerializer<List<Job>> serialzier = new MyXmlSerializer<List<Job>>();
            jobsList = serialzier.ReadObject(@"./jobsXML.xml");
        }
        
        public void FillDataWithAllSubordinates()
        {
            //Deserialize
            //XmlSerializer deserializer = new XmlSerializer(typeof(List<Subordinate>));
            //TextReader reader = new StreamReader(@"./subordinatesXML.xml");
            //object obj = deserializer.Deserialize(reader);
            //subordinatesList = (List<Subordinate>)obj;
            //reader.Close();

            MyXmlSerializer<List<Subordinate>> serialzier = new MyXmlSerializer<List<Subordinate>>();
            subordinatesList = serialzier.ReadObject(@"./subordinatesXML.xml");
        }
        
        public void FillDataWithAllSupervisor()
        {

            MyXmlSerializer<List<Supervisor>> serialzier = new MyXmlSerializer<List<Supervisor>>();
            supervisorList = serialzier.ReadObject(@"./supervisorsXML.xml");
        }

        public void FillDataWithAllEmployee()
        {
            //Deserialize
            //XmlSerializer deserializer = new XmlSerializer(typeof(List<Employee>));
            //TextReader reader = new StreamReader(@"./employeeXML.xml");
            //object obj = deserializer.Deserialize(reader);
            //employeeList = (List<Employee>)obj;
            //reader.Close();
        }

        public void FillDataWithAllUser()
        {
            //Deserialize
            //XmlSerializer deserializer = new XmlSerializer(typeof(List<User>));
            //TextReader reader = new StreamReader(@"./userXML.xml");
            //object obj = deserializer.Deserialize(reader);
            //userList = (List<User>)obj;
            //reader.Close();
        }
        
        public void SerializeDirectors()
        {

            MyXmlSerializer<List<Director>> ser = new MyXmlSerializer<List<Director>>();
            ser.WriteObject(@"./directorXML.xml", directorList); 

        }
        
        public void SerializeJobs()
        {
            
            MyXmlSerializer<List<Job>> ser = new MyXmlSerializer<List<Job>>();
            ser.WriteObject(@"./jobsXML.xml", jobsList);
        }

        public void SerializeSubordinates()
        {

            MyXmlSerializer<List<Subordinate>> ser = new MyXmlSerializer<List<Subordinate>>();
            ser.WriteObject(@"./subordinatesXML.xml", subordinatesList);
        }

        public void SerializeSupervisor()
        {
            //XmlSerializer serializer = new XmlSerializer(typeof(List<Supervisor>));
            //using (TextWriter writer = new StreamWriter(@"./supervisorsXML.xml"))
            //{
            //    serializer.Serialize(writer, supervisorList);
            //}
            MyXmlSerializer<List<Supervisor>> ser = new MyXmlSerializer<List<Supervisor>>();
            ser.WriteObject(@"./supervisorsXML.xml", supervisorList);
        }

        public void SerializeEmployee()
        {
            //XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
            //using (TextWriter writer = new StreamWriter(@"./employeeXML.xml"))
            //{
            //    serializer.Serialize(writer, employeeList);
            //}
        }

        public void SerializeUser()
        {
            //XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            //using (TextWriter writer = new StreamWriter(@"./userXML.xml"))
            //{
            //    serializer.Serialize(writer, employeeList);
            //}
        }

        public void AddNewDirector(Director dir)
        {
            directorList.Add(dir);
            SerializeDirectors();
        }
        
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

        public void AddNewDirectors(Director dir)
        {
            directorList.Add(dir);
            SerializeDirectors();
        }
        
        public void AddNewJobs(IEnumerable<Job> job)
        {
            jobsList.AddRange(job);
            SerializeJobs();
        }

        public void AddNewSubordinates(IEnumerable<Subordinate> sub)
        {
            subordinatesList.AddRange(sub);
            SerializeSubordinates();
        }

        public void AddNewSupervisors(IEnumerable<Supervisor> sup)
        {
            supervisorList.AddRange(sup);
            SerializeSupervisor();
        }

        public void AddNewEmployees(IEnumerable<Employee> emp)
        {
            employeeList.AddRange(emp);
            SerializeEmployee();
        }

        public void AddNewUsers(IEnumerable<User> user)
        {
            userList.AddRange(user);
            SerializeEmployee();
        }

    }
}
