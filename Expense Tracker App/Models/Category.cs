using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker_App.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string Icon { get; set; } = ""; //understand why it is an empty string

        [Column(TypeName = "nvarchar(10)")]
        public string Type { get; set; } = "Expense"; //understand why it is specified as expense
    }
}
