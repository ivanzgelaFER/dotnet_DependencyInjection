namespace wintership_2024_dotNET.DAL.Dtos
{
    public class TransactionDto
    {
        public int Id { get; set; }
        public int SenderAccountId { get; set; }
        public int ReceiverAccountId { get; set; }
        public decimal Amount {get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
