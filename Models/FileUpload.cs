using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace File_Hosting.Models
{
    public class FileUpload
    {
        [Required]
        public string FileName { get; set; }

        [Required]
        public long Size { get; set; }

        [Required]
        public DateTime DateLoad { get; set; }
    }
}
