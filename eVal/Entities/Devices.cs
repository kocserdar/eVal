using eVal.Core.Enums;
using eVal.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace eVal.Core.Entities
{
    public class Devices:IBaseEntity
    {
        public int DeviceId { get; set; }

        public DeviceType? DeviceType { get; set; }

        public string? DeviceName { get; set; }

        public string? DeviceBrand { get; set; }

        public string? DeviceModel { get; set; }
        
        public string? DeviceSerialNo { get; set; }
        
        public int? DeviceCalIntervalMonth { get; set; }

        public DateTime? ValidCalDate { get; set; }


        //Implementation
        public DateTime CreatedAt { get; set; }

        public AppUser CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public AppUser? UpdatedBy { get; set; }

        public DateTime? PassivedAt { get; set; }

        public AppUser? PassivedBy { get; set; }

        public Status Status { get; set; }
    }
}
