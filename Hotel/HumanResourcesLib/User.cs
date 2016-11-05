using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderTest
{
    public abstract class User
    {
        protected string name;
        protected string lastName;
        protected uint id;
        
        public User(string name, string lastName, uint id)
        {
            this.id = id;
            this.lastName = lastName;
            this.name = name;
        }
    }
}