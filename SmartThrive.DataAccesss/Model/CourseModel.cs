﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD.DataAccesss.Model
{
    public class CourseModel
    {
        public Guid SubjectId { get; set; }

        public Guid? ProviderId { get; set; }

        public Guid LocationId { get; set; }
        public string? Code { get; set; }

        public string? CourseName { get; set; }
        public string? CreateBy { get; set; }

        public DateTime? CreateDate { get; set; }
        [Required]
        public DateTime? LastUpdatedDate { get; set; }
        public string? LastUpdatedBy { get; set; }

        public string? Description { get; set; }
        public Decimal? Price { get; set; }

        public int? Quantity { get; set; }

        public int? Sold_product { get; set; }

        public int? TotalSlot { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public bool? IsApproved { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsDeleted { get; set; }
    }
}