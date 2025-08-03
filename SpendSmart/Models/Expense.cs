using System.ComponentModel.DataAnnotations;

namespace SpendSmart.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
//The ? Means allow null value

        [Required]
        public string? Description { get; set; }

    }
}
