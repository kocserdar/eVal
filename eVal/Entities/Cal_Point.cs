using eVal.Core.Enums;
using eVal.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVal.Core.Entities
{
    public class Cal_Point : IBaseEntity
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Direction { get; set; }

        public double? Reference_Value { get; set; }

        public double? Test_Value { get; set; }

        public string? MPE { get; set; }

        public string? Cal_Status { get; set; }

        //Implement
        public DateTime CreatedAt { get; set; }

        public AppUser CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public AppUser? UpdatedBy { get; set; }

        public DateTime? PassivedAt { get; set; }

        public AppUser? PassivedBy { get; set; }

        public Status Status { get; set; }

        //Navigation
        public int Cal_ParameterId { get; set; }
        
        public virtual Cal_Parameter Cal_Parameter { get; set; }

        public int SensorId { get; set; }
        
        public virtual Sensor Sensor { get; set; }

    }
}
