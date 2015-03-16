using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospiceWebPortal.Models
{
    public class Resource
    {
        public int ID { get; set; }
        [Required(ErrorMessage="Please add a description")]
        [StringLength(100,ErrorMessage="No longer than 100 characters please!")]
        public string Description { get; set; }
        [Required(ErrorMessage = "You cannot leave the name of the file blank.")]
        [StringLength(100, ErrorMessage = "The name of the file cannot be more than 100 characters")]
        public string FileName { get; set; }
        public DateTime CreatedOn { get; set; }
        [Required]
        public byte[] FileContent { get; set; }
        [Required]
        [StringLength(256)]
        public string MimeType { get; set; }
        
    }
    public class ResourceViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please add a description")]
        [StringLength(100, ErrorMessage = "No longer than 100 characters please!")]
        public string Description { get; set; }
        [Required(ErrorMessage = "You cannot leave the name of the file blank.")]
        [StringLength(100, ErrorMessage = "The name of the file cannot be more than 100 characters")]
        public string FileName { get; set; }
        public DateTime CreatedOn { get; set; }
        [Required]
        [StringLength(256)]
        public string MimeType { get; set; }
    }
}