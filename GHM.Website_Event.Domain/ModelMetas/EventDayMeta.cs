﻿
using System;
using System.Collections.Generic;

namespace GHM.Website.Event.Domain.ModelMetas
{
    public class EventDayMeta
    {
        public string EventId { get; set; }
        public bool IsActive { get; set; }
        public string ConcurrencyStamp { get; set; }
        public byte? StartHour { get; set; }
        public byte? StartMinute { get; set; }
        public byte? EndHour { get; set; }
        public byte? EndMinute { get; set; }
        public int? LimitedUsers { get; set; }
        public bool StaffOnly { get; set; }
        public DateTime EventDate { get; set; }
        public bool? IsAllowAccompanyPerson { get; set; }
        public int? LimitedAccompanyPersons { get; set; }
        public List<EventDayTranslationMeta> EventDayTranslations { get; set; }
    }
}
