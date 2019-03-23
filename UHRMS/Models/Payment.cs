namespace UHRMS.Models
{
    public class Payment
    {
        public int paymentId { get; set; }


        public ApplicationUser Staff { get; set; }

        public int studentId { get; set; }

        public int amount { get; set; }

        public string cardtype { get; set; }

        public int accountnumber { get; set; }


        public int expirationMonth { get; set; }

        public int expirationYear { get; set; }


        public int CSV { get; set; }
    }
}