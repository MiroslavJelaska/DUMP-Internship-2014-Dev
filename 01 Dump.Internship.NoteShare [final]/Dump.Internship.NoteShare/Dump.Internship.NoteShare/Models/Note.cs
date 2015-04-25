using System;
using System.ComponentModel.DataAnnotations;

namespace Dump.Internship.NoteShare.Models
{
    public class Note
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title should not be empty")]
        [MinLength(5, ErrorMessage = "Title should at least 5 characters long")]
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Text should not be empty")]
        public string Text { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}