﻿using DigisoftPortal.Model.Models.Shared;

namespace DigisoftPortal.Model.Models.Response;

public class AnnouncementResponse
{
    public Pagination? Pagination { get; set; }
    public List<Announcements>? Announcements { get; set; }
}
