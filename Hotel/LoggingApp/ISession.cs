using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LoggingApp
{
    public interface ISession<out T> where T: class
    {
        T Session { get; }
        void StartSession();
        void EndSession();
    }
}
