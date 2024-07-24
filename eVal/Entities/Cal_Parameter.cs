using eVal.Core.Enums;
using eVal.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVal.Core.Entities
{
    public class Cal_Parameter : IBaseEntity
    {
        public int Cal_ParameterId { get; set; }
        
        public string? Cal_ParameterName { get; set; }
        
        //Navgation
        public virtual List<Cal_Point>? Cal_Points { get; set; }

        public int UTLId { get; set; }
        
        public virtual UTL UTL { get; set; }


        //Implementation
        public DateTime CreatedAt { get; set; }

        public AppUser CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public AppUser? UpdatedBy { get; set; }

        public DateTime? PassivedAt { get; set; }

        public AppUser? PassivedBy { get; set; }

        public Status Status { get; set; } = Status.Active;



    }
}
