using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Hotel.Transpport
{
    public class Transport
    {
        public Object employee;
        public DateTime date;
        public float cost;
        public Transport(){

        }
        public void AddEmplye(Object emplye)
        {
            employee = emplye;
        }
        public void SetCost(float cost)
        {
            this.cost = cost;
        }
        public bool Save()
        {
            return false;
        }

    }
}
