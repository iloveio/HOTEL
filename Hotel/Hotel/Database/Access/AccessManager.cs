using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggingApp;
using System.Xml.Serialization;
using System.IO;
using Hotel.Database.Staff;

namespace Hotel.Database.Access
{
    class AccessManager
    {
        public List<Logging> loggingList;

        public AccessManager()
        {
            loggingList = new List<Logging>();

            DeserializeLogging();
        }

        public void DeserializeLogging()
        {
            /*XmlSerializer deserializer = new XmlSerializer(typeof(List<Logging>));
            TextReader reader = new StreamReader(@"./loggingXML.xml");
            object obj = deserializer.Deserialize(reader);
            loggingList = (List<Logging>)obj;
            reader.Close();*/

            try
            {
                MyXmlSerializer<List<Logging>> serialzier = new MyXmlSerializer<List<Logging>>();
                loggingList = serialzier.ReadObject(@"loggingXML.xml");
            }
            catch (Exception ex)
            {

            }
        }

        public void SerializeLogging()
        {
            //XmlSerializer serializer = new XmlSerializer(typeof(List<Logging>));
            //using (TextWriter writer = new StreamWriter(@"./loggingXML.xml"))
            //{
            //    serializer.Serialize(writer, loggingList);
            //}

            MyXmlSerializer<List<Logging>> ser = new MyXmlSerializer<List<Logging>>();
            ser.WriteObject(@"loggingXML.xml", loggingList);
        }

        public void AddNewLogging(Logging log)
        {
            loggingList.Add(log);
            SerializeLogging();
        }

        public string GetPassword(Logging log)
        {
            return log.Password;
        }

        public Logging CheckAuthorization(string login, string password)
        {
            foreach (var item in loggingList)
            {
                if (item.Login == login)
                    if (item.Password == password)
                        return item;
            }
            return null;
        }
    }
}
