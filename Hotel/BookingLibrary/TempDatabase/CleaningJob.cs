using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary.TempDatabase
{
    public class CleaningJob
    {

        public CleaningJob(long id, int selectedRoomID, string description)
        {
            this.Id = id;
            this.RoomId = selectedRoomID;
            Description = description;
            Console.WriteLine(id + " " + selectedRoomID + " " + description);
        }

        public long Id { get; set; }
        public int RoomId { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Id} {RoomId} {Description}";
        }
    }

}
