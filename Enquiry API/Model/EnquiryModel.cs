﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Enquiry_API.Model

{
    [Table("Enquiry")]
    public class EnquiryModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int enquiryId { get; set; }
        [Required]
        public int enquiryTypeId { get; set; }
        public int enquiryStatusId { get; set; }
        public string customerName { get; set; } = string.Empty;
        public string mobileNo { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string message { get; set; } = string.Empty;
        public DateTime createdDate { get; set; }
        public string resolution { get; set; } = string.Empty;

    }
}
