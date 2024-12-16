using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoListAPI.Models
{
    public class Task
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        [Column(TypeName = "date")]
        public DateOnly Due_Date { get; set; }
        [Column(TypeName = "date")]
        public DateOnly Creation_Date { get; set; }
        public string status { get; set; }
        public string priority { get; set; }
    }
}
