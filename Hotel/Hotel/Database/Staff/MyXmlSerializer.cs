using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;

namespace Hotel.Database.Staff
{
    public class MyXmlSerializer<T> : ISerializer<T> where T : class, new()
    {
        private DataContractSerializer serializer;
        

        public MyXmlSerializer()
        {

            serializer = new DataContractSerializer(typeof(T));
        }

        public T ReadObject(string fileName)
        {
            T deserializedObject;
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
               deserializedObject = (T) serializer.ReadObject(fs);
            }
            return deserializedObject;
        }

        public void WriteObject(string filename, T Object)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                serializer.WriteObject(fs, Object);
            }
        }
    }
}
