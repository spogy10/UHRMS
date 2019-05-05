using System.Collections.Generic;

namespace UHRMS.Models
{
    public class Dorm
    {
        public string dormId { get; set; }


        public ApplicationUser Staff { get; set; }

        public string dormtype { get; set; }

        public int numberOfRooms { get; set; }


        public int numberOfBathrooms { get; set; }


        public string dormDetails { get; set; }

        public static IList<string> HallList = new List<string>()
        {
            "Garvey Hall",
            "Farquharson Hall",
            "Hall A",
            "Hall B",
            "Hall E",
            "Hall F",
            "Dennis Johnson Hall"
        };


    }
}