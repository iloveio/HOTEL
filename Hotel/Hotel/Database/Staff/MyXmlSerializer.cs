using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;

namespace Hotel.Database
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
                    deserializedObject = (T)serializer.ReadObject(fs);
                }
                return deserializedObject;

        }

        public void WriteObject(string fileName, T Object)
        {
            if (fileName == null)
                throw new ArgumentNullException(nameof(fileName));
            if (Object == null)
                throw new ArgumentNullException(nameof(Object));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                serializer.WriteObject(fs, Object);
            }
        }
    }
}
