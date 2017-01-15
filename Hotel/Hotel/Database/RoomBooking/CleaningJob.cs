using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Database
{
    [DataContract]
    public class CleaningJob
    {

        public CleaningJob(long id, int selectedRoomID, string description)
        {
            this.Id = id;
            this.RoomId = selectedRoomID;
            Description = description;
            Console.WriteLine(id + " " + selectedRoomID + " " + description);
        }

        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public int RoomId { get; set; }
        [DataMember]
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Id} {RoomId} {Description}";
        }
    }

}