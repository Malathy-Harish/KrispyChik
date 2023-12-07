using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KrispyChik.Entities
{
    [Table("AUTH")]
    public class Auth
    {
        [Key]
        [Column("AUTHID")]
        public int AuthId { get; set; }
        [Column("USERID")]
        public int UserId { get; set; }
        [Column("PASSWORD")]
        public string Password { get; set; }
    }
}
