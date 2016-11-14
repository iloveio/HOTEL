using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesLib
{
    public interface IJob
    {
        int id { get; set; }
    }
    public interface IJob<T> : IJob
    {
        void ModifyJob(T job);
        T CreateJob();
        void DeleteJob();
    }
}
