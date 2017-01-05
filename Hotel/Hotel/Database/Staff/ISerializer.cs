using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Database
{
    public interface ISerializer<T> where T : class, new()
    {
        T ReadObject(string fileName);
        void WriteObject(string filename, T Object);
    }
}
