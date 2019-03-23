namespace UHRMS.Models
{
    public class Dorm
    {
        public int dormId { get; set; }


        public ApplicationUser Staff { get; set; }

        public string dormtype { get; set; }

        public int numberOfRooms { get; set; }


        public int numberOfBathrooms { get; set; }


        public string dormDetails { get; set; }


    }
}