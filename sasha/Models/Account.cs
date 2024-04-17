using System.ComponentModel.DataAnnotations;

namespace sasha.addclasses
{
    public class Account
    {
        [Key]
        public Guid id { get; set; }
        public string accountname { get; set; }
        public string Balance { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Card>? Cards { get; set; }



    }
}
