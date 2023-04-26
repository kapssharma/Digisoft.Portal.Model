﻿
using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model;

public class UserAddress
{
    public int ID { get; set; }
    [Required]
    public string? Address1 { get; set; }
    [Required]
    public string? Address2 { get; set; }
    [Required]
    public string? Country { get; set; }
    [Required]
    public string? StateId { get; set; }
    [Required]
    public string? City { get; set; }
    [Required(ErrorMessage = "Zip is Required")]
    [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip")]
    public string? ZipCode { get; set; }
    public bool IsPermanent { get; set; }
}