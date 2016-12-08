using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Database.Transportation
{
    class TransportationManager
    {
        List<Transportation> transportationsList;

        //----Methods to fill lists----
        /// <summary>
        /// Method to fill transportations list with data from database, 
        /// works as update (should be called whenever data in database has been changed
        /// </summary>
        public void FillDataWithAllTransportations()
        {
            using (var db = new TransportationContext())
            {
                var query = from b in db.Transportations
                            select b;
                transportationsList = query.ToList<Transportation>();
            }
        }

        //----Methods to manage database----
        /// <summary>
        /// Method to add new transportation record to database
        /// </summary>
        /// <param name="trans"></param>
        /// Transportation object to be added into databae
        public void AddNewTransportationT(Transportation trans)
        {
            using (var db = new TransportationContext())
                db.Transportations.Add(trans);
        }

        /// <summary>
        /// Method to delete transportation record from database
        /// </summary>
        /// <param name="trans"></param>
        /// Object to be deleted
        public void DeleteTransportationByObject(Transportation trans)
        {
            using (var db = new TransportationContext())
                db.Transportations.Remove(trans);
        }

        /// <summary>
        /// Method to update employee in existing record
        /// </summary>
        /// <param name="trans"></param>
        /// Object to be updated
        /// <param name="emp"></param>
        /// New emloyee to be replaced
        public void UpdateTransportationEmployee(Transportation trans, Employee emp)
        {
            using (var db = new TransportationContext())
            {
                Transportation toUpdate = db.Transportations.Find(trans);
                toUpdate.employee = emp;
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Method to update description in exsisting record
        /// </summary>
        /// <param name="trans"></param>
        /// Object to be updated
        /// <param name="desc"></param>
        /// New description to be replaced
        public void UpdateTransportationDescription(Transportation trans, string desc)
        {
            using (var db = new TransportationContext())
            {
                Transportation toUpdate = db.Transportations.Find(trans);
                toUpdate.description = desc;
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Method to update date in existing record
        /// </summary>
        /// <param name="trans"></param>
        /// Object to be updated
        /// <param name="date"></param>
        /// New date to be replaced
        public void UpdateTransportationDate(Transportation trans, DateTime date)
        {
            using (var db = new TransportationContext())
            {
                Transportation toUpdate = db.Transportations.Find(trans);
                toUpdate.date = date;
                db.SaveChanges();
            }
        }

        //----Methods to get data----
        /// <summary>
        /// This method will be heavly reworked in future
        /// </summary>
        /// <returns></returns>
        public List<Transportation> GetTransportationList()
        {
            return transportationsList;
        }

    }
}
