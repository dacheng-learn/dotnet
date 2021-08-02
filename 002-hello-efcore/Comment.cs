using System.ComponentModel.DataAnnotations.Schema;

namespace HelloEFCore
{
    [Table("comment")]
    public class Comment
    {
        // [Column("id")]
        public int Id { get; set; }

        // [Column("content")]
        public string Content { get; set; }
    }
}