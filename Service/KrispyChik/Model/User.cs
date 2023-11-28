using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KrispyChik.Model
{
    [Table("USER")]
    public class User
    {
        [Key]
        [Column("USERID")]
        public int UserId { get; set; }
        [Column("NAME")]
        public string Name { get; set; }
        [Column("ADDRESS")]
        public string Address { get; set; }
        [Column("PHONENUM")]
        public string PhoneNum { get; set; }
        [Column("ROLEID")]
        public string RoleId { get; set; }

    }
}
