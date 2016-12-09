using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResourcesLib
{
    public abstract partial class User
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

        public string nameProperty { get { return name; } set { name = value; } }
        public string lastNameProperty { get { return lastName; } set { lastName = value; } }
        public uint idProperty { get { return id; } set { } }
    }
}