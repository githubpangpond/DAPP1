using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAPP.Models
{
    public class LOSDATCollatApprValue
    {
        [Key]
        public long ValueD { get; set; }

        [Required]
        public long CollatID { get; set; }

        public long ApprID { get; set; }

    }
}
