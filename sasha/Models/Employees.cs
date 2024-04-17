using System.ComponentModel.DataAnnotations;

namespace sasha.addclasses
{
    public class Employee
    {
        [Key]
        public Guid employeesId { get; set; }
        public string firstName { get;set; }
        public string lastName { get;set; }
        public string email { get;set; }
        public string phone { get;set; }
        public string city { get;set; }
        public string state { get;set; }
    }
}
