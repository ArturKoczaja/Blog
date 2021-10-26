using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace BlogBackend.DataTransferObject.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]

        public string Title { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        [Required]

        public string Text { get; set; }

        public string Cover { get; set; }
        [Column(TypeName = "DateTime2")]

        public DateTime CreateDate { get; set; }
        [ForeignKey("UserId")]
        public virtual User User{ get; set; }



    }
}
