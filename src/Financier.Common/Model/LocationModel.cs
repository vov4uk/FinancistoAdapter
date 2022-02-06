﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Financier.Common.Model
{
    public class LocationModel : BaseModel
    {
        [Column("_id")]
        public long? Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("resolved_address")]
        public string Address { get; set; }

        [Column("is_active")]
        public long IsActive { get; set; }
    }
}
