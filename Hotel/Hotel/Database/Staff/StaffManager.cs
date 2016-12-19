////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Database\Staff\StaffManager.cs
//
// summary:	Implements the staff manager class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        /// <summary>   List of employee status. </summary>
        List<EmployeeStatus> employeeStatusList;
        /// <summary>   List of jobs. </summary>
        List<Job> jobsList;
        /// <summary>   List of subordinates. </summary>
        List<Subordinate> subordinatesList;
        /// <summary>   List of supervisors. </summary>
        List<Supervisor> supervisorList;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Fill data with all directors. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void FillDataWithAllDirectors()
        {
            using (var db = new StaffContext())
            {
                var query = from b in db.Directors
                            select b;
                directorList = query.ToList<Director>();
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Fill data with all employee status. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void FillDataWithAllEmployeeStatus()
        {
            using (var db = new StaffContext())
            {
                var query = from b in db.EmployeeStatuses
                            select b;
                employeeStatusList = query.ToList<EmployeeStatus>();
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Fill data with all jobs. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void FillDataWithAllJobs()
        {
            using (var db = new StaffContext())
            {
                var query = from b in db.Jobs
                            select b;
                jobsList = query.ToList<Job>();
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Fill data with all subordinates. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void FillDataWithAllSubordinates()
        {
            using (var db = new StaffContext())
            {
                var query = from b in db.Subordinates
                            select b;

                subordinatesList = query.ToList<Subordinate>();

            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Fill data with all supervisor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void FillDataWithAllSupervisor()
        {
            using (var db = new StaffContext())
            {
                var query = from b in db.Supervisors
                            select b;

                supervisorList = query.ToList<Supervisor>();

            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Adds a new director. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="dir">  The dir. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void AddNewDirector(Director dir)
        {
            using (var db = new StaffContext())
            {
                db.Directors.Add(dir);
                db.SaveChanges();
            }
            FillDataWithAllDirectors();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Adds a new employee status. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="status">   The status. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void AddNewEmployeeStatus(EmployeeStatus status)
        {
            using (var db = new StaffContext())
            {
                db.EmployeeStatuses.Add(status);
                db.SaveChanges();
            }
            FillDataWithAllEmployeeStatus();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Adds a new job. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="job">  The job. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void AddNewJob(Job job)
        {
            using (var db = new StaffContext())
            {
                db.Jobs.Add(job);
                db.SaveChanges();
            }
            FillDataWithAllJobs();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Adds a new subordinate. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sub">  The sub. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void AddNewSubordinate(Subordinate sub)
        {
            using (var db = new StaffContext())
            {
                db.Subordinates.Add(sub);
                db.SaveChanges();
            }
            FillDataWithAllSubordinates();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Adds a new supervisor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="sup">  The sup. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void AddNewSupervisor(Supervisor sup)
        {
            using (var db = new StaffContext())
            {
                db.Supervisors.Add(sup);
                db.SaveChanges();
            }
            FillDataWithAllSupervisor();
        }
    }
}
