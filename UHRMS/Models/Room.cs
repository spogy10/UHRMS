namespace UHRMS.Models
{
    public class Room
    {
        public int roomId { get; set; }


        public ApplicationUser Staff { get; set; }

        public int dormNumber { get; set; }


        public int currentOccupancy { get; set; }


        public int maxOccupancy { get; set; }

        public int feeNo { get; set; }


        public string roomDescription { get; set; }


        // public string roomImage { get; set; }
    }
}