﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST.Entities.Data.Table
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public Guid Id { get; set; }

        public string? RoleName { get; set; }

<<<<<<< HEAD
        public virtual ICollection<User> Users { get; set; }
=======

        public virtual ICollection<User>? Users { get; set; }
>>>>>>> c33481cb1ec6d4aef2fd4a0267e507cbfe68cbee
    }
}

