using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Installer
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [Range(6,13)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreatedUserDateTime { get; set; }
    }
}
