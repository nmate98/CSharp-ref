using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Notesz.Models
{
    public class NoteModel
    {
        [Display(Name = "Cím")]
        public string cim { get; set; }
        [Display(Name = "Jegyzet")]
        public string tartalom { get; set; }
    }
}