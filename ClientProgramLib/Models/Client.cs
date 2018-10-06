using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientProgramLib.Models
{
    public class Client
    {
        [Key]
        public int Client_Id { get; set; }
        [Required]
        public int Client_Code { get; set; }
        [Required]
        public string Client_Name { get; set; }
        [Required]
        public string Client_City { get; set; }
    }
}
