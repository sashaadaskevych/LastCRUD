using System.ComponentModel.DataAnnotations;

namespace sasha.addclasses
{
    public class Transaction
    { 
        [Key]
        public Guid transactionId { get; set; }
        public string transactionName { get; set; }
        public string transactionType { get; set; }
        public string transactionData { get; set; }


    }
}
