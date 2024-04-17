using System.ComponentModel.DataAnnotations;

namespace sasha.addclasses
{
        public class Card
        {
            [Key] public int Accnumber { get; set; }
            public string CardName { get; set; }
            public int Pincode { get; set; }
            public DateTime DataDii { get; set; }
            public int CVV { get; set; }
            public decimal Balance { get; set; }
            public string AccLink { get; set; }
            public Guid AccountId { get; set; }
            public Account Account { get; set; }
    }
}

