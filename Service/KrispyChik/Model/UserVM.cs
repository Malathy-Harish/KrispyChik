using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KrispyChik.Model
{
    public class UserVM
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNum { get; set; }
        public string RoleId { get; set; }

    }
}
