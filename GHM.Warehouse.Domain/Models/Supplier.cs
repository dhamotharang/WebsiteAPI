﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GHM.Warehouse.Domain.Models
{
    /// <summary>
    /// Model mapping với bảng trong database.
    /// </summary>

    public class Supplier
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string UnsignName { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public bool IsDelete { get; set; }

        public DateTime CreateTime { get; set; }

        public string ConcurrencyStamp { get; set; }

        public string Address { get; set; }

        public string TenantId { get; set; }

        public string CreatorId { get; set; }

        public string CreatorFullName { get; set; }

        public string LastUpdateUserId { get; set; }

        public string LastUpdateFullName { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        public Supplier()
        {
            Id = Guid.NewGuid().ToString();
            Name = "";
            UnsignName = "";
            IsActive = false;
            IsDelete = false;
            CreateTime = DateTime.Now;
            ConcurrencyStamp = "";
            TenantId = "";
            CreatorId = "";
            CreatorFullName = "";
        }
    }

}
