using KrispyChik.Model;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KrispyChik.Entities
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
