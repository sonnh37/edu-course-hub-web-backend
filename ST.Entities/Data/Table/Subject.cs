﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST.Entities.Data.Table
{
    [Table("Subject")]
    public class Subject
    {
        [Key]
        public Guid Id { get; set; }

        public string SubjectName { get; set; }
        public Guid CategoryID { get; set; }
        public string? CreateBy { get; set; }

        public DateTime CreateDate { get; set; }
        [Required]
        public DateTime LastUpdatedDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Course>Courses { get; set; }
    }
}