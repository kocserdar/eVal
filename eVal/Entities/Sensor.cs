using eVal.Core.Enums;
using eVal.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVal.Core.Entities
{
    public class Sensor:IBaseEntity
    {
        public int SensorId { get; set; }
        
        public string? SensorName { get; set; }

        public string? SensorBrand { get; set; }

        public string? SensorModel { get; set; }

        public string? SensorSerialNo { get; set; }

        public SensorType SensorType { get; set; }

        //Implementation
        public DateTime CreatedAt { get; set; }

        public AppUser CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public AppUser? UpdatedBy { get; set; }

        public DateTime? PassivedAt { get; set; }

        public AppUser? PassivedBy { get; set; }

        public Status Status { get; set; }

        //Navigation

        public virtual List<Cal_Parameter> Cal_Parameters { get; set; }
        
        public virtual List<Cal_Point> Cal_Points { get; set; }
    }
}
