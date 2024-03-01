namespace wintership_2024_dotNET.DAL.Dtos
{
    public class TransactionLogDto
    {
        public required string Sender { get; set; }
        public required string Receiver { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
