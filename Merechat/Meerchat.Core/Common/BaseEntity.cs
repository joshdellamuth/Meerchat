﻿namespace Meerchat.Api.Core.Common
{
    public class BaseEntity
    {
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
