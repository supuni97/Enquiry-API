﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Enquiry_API.Model
{
    public class EnquiryStatus
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int statusId { get; set; }
        [Required]
        public string status { get; set; } = string.Empty;
    }
}
