using eVal.Core.Enums;
using eVal.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVal.Core.Entities
{
    public class UTL:IBaseEntity
    {
        public int UTLId { get; set; }

        public string? UTLName { get; set; }

        public virtual List<Cal_Parameter>? cal_Parameters { get; set; }

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
