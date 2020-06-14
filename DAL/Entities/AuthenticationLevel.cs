﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    public class AuthenticationLevel
    {
        [Key]
        public Int32 AuthId { get; set; }
        [Required]
        public string AuthName { get; set; }
        [ForeignKey("AuthLevelRefId")]
        public ICollection<User> Users { get; set; }
    }
}
