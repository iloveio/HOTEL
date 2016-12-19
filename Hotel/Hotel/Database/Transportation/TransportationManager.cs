////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Database\Transportation\TransportationManager.cs
//
// summary:	Implements the transportation manager class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Database.Transportation
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Manager for transportations. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class TransportationManager
    {
        /// <summary>   List of transportations. </summary>
        List<Transportation> transportationsList;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public TransportationManager()
        {
            transportationsList = new List<Transportation>();
        }

        //----Methods to fill lists----

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Method to fill transportations list with data from database, works as update (should be
        /// called whenever data in database has been changed.
        /// </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

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

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Method to add new transportation record to database. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="trans">    . </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void AddNewTransportation(Transportation trans)
        {
            using (var db = new TransportationContext())
            {
                db.Transportations.Add(trans);
                db.SaveChanges();
            }
            FillDataWithAllTransportations();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Method to delete transportation record from database. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="trans">    . </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DeleteTransportationByObject(Transportation trans)
        {
            using (var db = new TransportationContext())
            {
                db.Transportations.Remove(trans);
                db.SaveChanges();
            }


            FillDataWithAllTransportations();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Method to update employee in existing record. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="trans">    . </param>
        /// <param name="emp">      . </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void UpdateTransportationEmployee(Transportation trans, Employee emp)
        {
            using (var db = new TransportationContext())
            {
                Transportation toUpdate = db.Transportations.Find(trans);
                toUpdate.employee = emp;
                db.SaveChanges();
            }
            FillDataWithAllTransportations();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Method to update description in exsisting record. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="trans">    . </param>
        /// <param name="desc">     . </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void UpdateTransportationDescription(Transportation trans, string desc)
        {
            using (var db = new TransportationContext())
            {
                Transportation toUpdate = db.Transportations.Find(trans);
                toUpdate.description = desc;
                db.SaveChanges();
            }
            FillDataWithAllTransportations();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Method to update date in existing record. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="trans">    . </param>
        /// <param name="date">     . </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void UpdateTransportationDate(Transportation trans, DateTime date)
        {
            using (var db = new TransportationContext())
            {
                Transportation toUpdate = db.Transportations.Find(trans);
                toUpdate.date = date;
                db.SaveChanges();
            }
            FillDataWithAllTransportations();
        }

        //----Methods to get data----

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   This method will be heavly reworked in future. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <returns>   The transportation list. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public List<Transportation> GetTransportationList()
        {
            return transportationsList;
        }

    }
}
