﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCGames.Domains
{
    public class BaseDomain
    {
        [Key]
        public Guid Id { get; set; }

        public BaseDomain()
        {
            Id = Guid.NewGuid();
        }
    }
}
