﻿using DigisoftPortal.Model.Models.Shared;

namespace DigisoftPortal.Model.Models.Response;

public class QuestionResponse
{
    public Pagination? Pagination { get; set; }
    public List<Questions>? Questions { get; set; }
}
