using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Transpport
{
    class Transport
    {
        public Object employee;
        public DateTime data;
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

    }
}
