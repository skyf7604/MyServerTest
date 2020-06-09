using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace aspTest3.Models
{
    public class Note
    {
       
        [Key]
        public int NoteNo { get; set; }

        [Required]
        public string NoteTitle { get; set; }

        [Required]
        public string NoteContents { get; set; }

        [Required]
        public int UserNo { get; set; }

        //Join하기
        [ForeignKey("UserNo")]  //UserNo가 외래키
        public virtual User user { get; set; }

    }
}
