﻿using System.ComponentModel.DataAnnotations;

namespace DigisoftPortal.Model.Models.Response;

public class Leaves
{
    public int Id { get; set; }
    public int LeavesDaysId { get; set; }
    [Required]
    public int UserLeavesId { get; set; }
    public string? EmployeeName { get; set; }
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? StartFrom { get; set; }
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? StartEnd { get; set; }
    public int TotalDays { get; set; }
    public string? LeaveType { get; set; }
    public string? LeaveReasons { get; set; }
    public bool IsApproved { get; set; }
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? ApprovedAt { get; set; }
    public string? ApprovedBy { get; set; }
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? CreatedOn { get; set; }
    public bool IsActive { get; set; }
}