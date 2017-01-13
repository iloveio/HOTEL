// ***********************************************************************
// Assembly         : Hotel
// Author           : Flurrih
// Created          : 01-06-2017
//
// Last Modified By : Flurrih
// Last Modified On : 01-06-2017
// ***********************************************************************
// <copyright file="StaffManager.cs" company="">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************


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
    /// <summary>
    /// Class StaffManager.
    /// </summary>
    public class StaffManager
    {
        /// <summary>
        /// Gets or sets the director list.
        /// </summary>
        /// <value>The director list.</value>
        public List<Director> directorList { get; set; }

        /// <summary>
        /// Gets or sets the jobs list.
        /// </summary>
        /// <value>The jobs list.</value>
        public List<Job> jobsList { get; set; }

        /// <summary>
        /// Gets or sets the subordinates list.
        /// </summary>
        /// <value>The subordinates list.</value>
        public List<Subordinate> subordinatesList { get; set; }

        /// <summary>
        /// Gets or sets the supervisor list.
        /// </summary>
        /// <value>The supervisor list.</value>
        public List<Supervisor> supervisorList { get; set; }

        /// <summary>
        /// Gets or sets the employee list.
        /// </summary>
        /// <value>The employee list.</value>
        public List<Employee> employeeList { get; set; }

        /// <summary>
        /// Gets or sets the user list.
        /// </summary>
        /// <value>The user list.</value>
        public List<User> userList { get; set; }




        /// <summary>
        /// Initializes a new instance of the <see cref="StaffManager"/> class.
        /// </summary>
        public StaffManager()
        {
            directorList = new List<Director>();
            jobsList = new List<Job>();
            subordinatesList = new List<Subordinate>();
            supervisorList = new List<Supervisor>();
            employeeList = new List<Employee>();
            userList = new List<User>();
            
            FillDataWithAllDirectors();
            FillDataWithAllJobs();
            FillDataWithAllSubordinates();
            FillDataWithAllSupervisor();
            //FillDataWithAllEmployee();
            //FillDataWithAllUser();
        }

        /// <summary>
        /// Fills the data with all directors.
        /// </summary>
        public void FillDataWithAllDirectors()
        {


            MyXmlSerializer<List<Director>> serialzier = new MyXmlSerializer<List<Director>>();
            directorList = serialzier.ReadObject(@"./directorXML.xml");
           
        }

        /// <summary>
        /// Fills the data with all jobs.
        /// </summary>
        public void FillDataWithAllJobs()
        {
            //Deserialize
            MyXmlSerializer<List<Job>> serialzier = new MyXmlSerializer<List<Job>>();
            jobsList = serialzier.ReadObject(@"./jobsXML.xml");
        }

        /// <summary>
        /// Fills the data with all subordinates.
        /// </summary>
        public void FillDataWithAllSubordinates()
        {
            MyXmlSerializer<List<Subordinate>> serialzier = new MyXmlSerializer<List<Subordinate>>();
            subordinatesList = serialzier.ReadObject(@"./subordinatesXML.xml");
        }

        /// <summary>
        /// Fills the data with all supervisor.
        /// </summary>
        public void FillDataWithAllSupervisor()
        {

            MyXmlSerializer<List<Supervisor>> serialzier = new MyXmlSerializer<List<Supervisor>>();
            supervisorList = serialzier.ReadObject(@"./supervisorsXML.xml");
        }

        /// <summary>
        /// Fills the data with all employee.
        /// </summary>
        public void FillDataWithAllEmployee()
        {
            MyXmlSerializer<List<Employee>> serialzier = new MyXmlSerializer<List<Employee>>();
            employeeList = serialzier.ReadObject(@"./employeeXML.xml");
        }

        /// <summary>
        /// Fills the data with all user.
        /// </summary>
        public void FillDataWithAllUser()
        {
            MyXmlSerializer<List<User>> serialzier = new MyXmlSerializer<List<User>>();
            userList = serialzier.ReadObject(@"./userXML.xml");
        }

        /// <summary>
        /// Serializes the directors.
        /// </summary>
        public void SerializeDirectors()
        {

            MyXmlSerializer<List<Director>> ser = new MyXmlSerializer<List<Director>>();
            ser.WriteObject(@"./directorXML.xml", directorList); 

        }

        /// <summary>
        /// Serializes the jobs.
        /// </summary>
        public void SerializeJobs()
        {
            
            MyXmlSerializer<List<Job>> ser = new MyXmlSerializer<List<Job>>();
            ser.WriteObject(@"./jobsXML.xml", jobsList);
        }

        /// <summary>
        /// Serializes the subordinates.
        /// </summary>
        public void SerializeSubordinates()
        {

            MyXmlSerializer<List<Subordinate>> ser = new MyXmlSerializer<List<Subordinate>>();
            ser.WriteObject(@"./subordinatesXML.xml", subordinatesList);
        }

        /// <summary>
        /// Serializes the supervisor.
        /// </summary>
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

        /// <summary>
        /// Serializes the employee.
        /// </summary>
        public void SerializeEmployee()
        {
            //XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
            //using (TextWriter writer = new StreamWriter(@"./employeeXML.xml"))
            //{
            //    serializer.Serialize(writer, employeeList);
            //}
            MyXmlSerializer<List<Employee>> ser = new MyXmlSerializer<List<Employee>>();
            ser.WriteObject(@"./employeeXML.xml", employeeList);
        }

        /// <summary>
        /// Serializes the user.
        /// </summary>
        public void SerializeUser()
        {
            //XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            //using (TextWriter writer = new StreamWriter(@"./userXML.xml"))
            //{
            //    serializer.Serialize(writer, employeeList);
            //}
            MyXmlSerializer<List<User>> ser = new MyXmlSerializer<List<User>>();
            ser.WriteObject(@"./userXML.xml", userList);
        }

        /// <summary>
        /// Adds the new director.
        /// </summary>
        /// <param name="dir">The dir.</param>
        public void AddNewDirector(Director dir)
        {
            directorList.Add(dir);
            SerializeDirectors();
        }

        /// <summary>
        /// Adds the new job.
        /// </summary>
        /// <param name="job">The job.</param>
        public void AddNewJob(Job job)
        {
            jobsList.Add(job);
            SerializeJobs();
        }

        /// <summary>
        /// Adds the new subordinate.
        /// </summary>
        /// <param name="sub">The sub.</param>
        public void AddNewSubordinate(Subordinate sub)
        {
            subordinatesList.Add(sub);
            SerializeSubordinates();
        }

        /// <summary>
        /// Adds the new supervisor.
        /// </summary>
        /// <param name="sup">The sup.</param>
        public void AddNewSupervisor(Supervisor sup)
        {
            supervisorList.Add(sup);
            SerializeSupervisor();
        }

        /// <summary>
        /// Adds the new employee.
        /// </summary>
        /// <param name="emp">The emp.</param>
        public void AddNewEmployee(Employee emp)
        {
            employeeList.Add(emp);
            SerializeEmployee();
        }

        /// <summary>
        /// Adds the new user.
        /// </summary>
        /// <param name="user">The user.</param>
        public void AddNewUser(User user)
        {
            userList.Add(user);
            SerializeUser();
        }

        /// <summary>
        /// Deletes the director.
        /// </summary>
        /// <param name="dir">The dir.</param>
        public void DeleteDirector(Director dir)
        {
            directorList.Remove(dir);
            SerializeDirectors();
        }

        /// <summary>
        /// Deletes the job.
        /// </summary>
        /// <param name="job">The job.</param>
        public void DeleteJob(Job job)
        {
            jobsList.Remove(job);
            SerializeJobs();
        }

        /// <summary>
        /// Deletes the subordinate.
        /// </summary>
        /// <param name="sub">The sub.</param>
        public void DeleteSubordinate(Subordinate sub)
        {
            subordinatesList.Remove(sub);
            SerializeSubordinates();
        }

        /// <summary>
        /// Deletes the supervisor.
        /// </summary>
        /// <param name="sup">The sup.</param>
        public void DeleteSupervisor(Supervisor sup)
        {
            supervisorList.Remove(sup);
            SerializeSupervisor();
        }

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="emp">The emp.</param>
        public void DeleteEmployee(Employee emp)
        {
            employeeList.Remove(emp);
            SerializeEmployee();
        }

        /// <summary>
        /// Deletes the user.
        /// </summary>
        /// <param name="user">The user.</param>
        public void DeleteUser(User user)
        {
            userList.Remove(user);
            SerializeUser();
        }

        /// <summary>
        /// Updates the director.
        /// </summary>
        /// <param name="dir">The dir.</param>
        /// <param name="newVal">The new value.</param>
        public void UpdateDirector(Director dir, Director newVal)
        {
            directorList[directorList.IndexOf(dir)] = newVal;
            SerializeDirectors();
        }

        /// <summary>
        /// Updates the job.
        /// </summary>
        /// <param name="job">The job.</param>
        /// <param name="newVal">The new value.</param>
        public void UpdateJob(Job job, Job newVal)
        {
            jobsList[jobsList.IndexOf(job)] = newVal;
            SerializeJobs();
        }

        /// <summary>
        /// Updates the subordinate.
        /// </summary>
        /// <param name="sub">The sub.</param>
        /// <param name="newVal">The new value.</param>
        public void UpdateSubordinate(Subordinate sub, Subordinate newVal)
        {
            subordinatesList[subordinatesList.IndexOf(sub)] = newVal;
            SerializeSubordinates();
        }

        /// <summary>
        /// Updates the supervisor.
        /// </summary>
        /// <param name="sup">The sup.</param>
        /// <param name="newVal">The new value.</param>
        public void UpdateSupervisor(Supervisor sup, Supervisor newVal)
        {
            supervisorList[supervisorList.IndexOf(sup)] = newVal;
            SerializeSupervisor();
        }

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="emp">The emp.</param>
        /// <param name="newVal">The new value.</param>
        public void UpdateEmployee(Employee emp, Employee newVal)
        {
            employeeList[employeeList.IndexOf(emp)] = newVal;
            SerializeEmployee();
        }

        /// <summary>
        /// Updates the user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="newVal">The new value.</param>
        public void UpdateUser(User user, User newVal)
        {
            userList[userList.IndexOf(user)] = newVal;
            SerializeUser();
        }

        /// <summary>
        /// Adds the new directors.
        /// </summary>
        /// <param name="dir">The dir.</param>
        public void AddNewDirectors(Director dir)
        {
            directorList.Add(dir);
            SerializeDirectors();
        }

        /// <summary>
        /// Adds the new jobs.
        /// </summary>
        /// <param name="job">The job.</param>
        public void AddNewJobs(IEnumerable<Job> job)
        {
            jobsList.AddRange(job);
            SerializeJobs();
        }

        /// <summary>
        /// Adds the new subordinates.
        /// </summary>
        /// <param name="sub">The sub.</param>
        public void AddNewSubordinates(IEnumerable<Subordinate> sub)
        {
            subordinatesList.AddRange(sub);
            SerializeSubordinates();
        }

        /// <summary>
        /// Adds the new supervisors.
        /// </summary>
        /// <param name="sup">The sup.</param>
        public void AddNewSupervisors(IEnumerable<Supervisor> sup)
        {
            supervisorList.AddRange(sup);
            SerializeSupervisor();
        }

        /// <summary>
        /// Adds the new employees.
        /// </summary>
        /// <param name="emp">The emp.</param>
        public void AddNewEmployees(IEnumerable<Employee> emp)
        {
            employeeList.AddRange(emp);
            SerializeEmployee();
        }

        /// <summary>
        /// Adds the new users.
        /// </summary>
        /// <param name="user">The user.</param>
        public void AddNewUsers(IEnumerable<User> user)
        {
            userList.AddRange(user);
            SerializeEmployee();
        }

    }
}
