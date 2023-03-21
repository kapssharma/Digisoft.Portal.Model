﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigisoftPortal.Model.Models.Response;

public class InterviewMediums
{
    public int Id { get; set; }
    [DataType("nvarchar(20)")]
    [Required]
    public string? Description { get; set; }
}
