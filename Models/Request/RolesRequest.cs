﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigisoftPortal.Model;


public class RolesRequest
{   
    [Required]
    [StringLength(100)]
    public string Name { get; set; }
}

