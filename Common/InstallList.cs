using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Common
{
    public class InstallList
    {
        [Key]
        public  long Id { get; set; }
        [Required]
        public string TicketId { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }        
        public string ErtefayeSakhteman { get; set; }
        public bool TajhezatDara { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreatedInstallListDateTime { get; set; }


    }
}
