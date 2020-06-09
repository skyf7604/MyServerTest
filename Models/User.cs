using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace aspTest3.Models
{
    public class User
    {
        [Key] //Primary Key 설정
        public int UserNo { get; set; }

        [Required] //Not Null 설정
        public string UserName { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public string UserPassword { get; set; }

    }
}
