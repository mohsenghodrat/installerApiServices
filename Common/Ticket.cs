using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Ticket
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string TicketId { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Tajhizat { get; set; }
        public string ErtefaaeSakhteman { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreatedTicketDateTime { get; set; }
    }
}
