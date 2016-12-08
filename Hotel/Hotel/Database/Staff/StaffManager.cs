using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Database.Staff
{
    public class StaffManager
    {
        List<Director> directorList;
        List<EmployeeStatus> employeeStatusList;
        List<Job> jobsList;
        List<Subordinate> subordinatesList;
        List<Supervisor> supervisorList;

        public void FillDataWithAllDirectors()
        {
            using (var db = new StaffContext())
            {
                var query = from b in db.Directors
                            select b;
                directorList = query.ToList<Director>();
            }
        }
        public void FillDataWithAllEmployeeStatus()
        {
            using (var db = new StaffContext())
            {
                var query = from b in db.EmployeeStatuses
                            select b;
                employeeStatusList = query.ToList<EmployeeStatus>();
            }
        }
        public void FillDataWithAllJobs()
        {
            using (var db = new StaffContext())
            {
                var query = from b in db.Jobs
                            select b;
                jobsList = query.ToList<Job>();
            }
        }
        public void FillDataWithAllSubordinates()
        {
            using (var db = new StaffContext())
            {
                var query = from b in db.Subordinates
                            select b;

                subordinatesList = query.ToList<Subordinate>();

            }
        }
        public void FillDataWithAllSupervisor()
        {
            using (var db = new StaffContext())
            {
                var query = from b in db.Supervisors
                            select b;

                supervisorList = query.ToList<Supervisor>();

            }
        }

        public void AddNewDirector(Director dir)
        {
            using (var db = new StaffContext())
            {
                db.Directors.Add(dir);
                db.SaveChanges();
            }
            FillDataWithAllDirectors();
        }
        public void AddNewEmployeeStatus(EmployeeStatus status)
        {
            using (var db = new StaffContext())
            {
                db.EmployeeStatuses.Add(status);
                db.SaveChanges();
            }
            FillDataWithAllEmployeeStatus();
        }
        public void AddNewJob(Job job)
        {
            using (var db = new StaffContext())
            {
                db.Jobs.Add(job);
                db.SaveChanges();
            }
            FillDataWithAllJobs();
        }
        public void AddNewSubordinate(Subordinate sub)
        {
            using (var db = new StaffContext())
            {
                db.Subordinates.Add(sub);
                db.SaveChanges();
            }
            FillDataWithAllSubordinates();
        }
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
