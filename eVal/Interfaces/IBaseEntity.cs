using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eVal.Core.Entities;
using eVal.Core.Enums;
using Microsoft.AspNetCore.Identity;

namespace eVal.Core.Interfaces
{
    public interface IBaseEntity
    {
        public DateTime CreatedAt { get; set; }
        
        public AppUser CreatedBy { get; set; }
        
        public DateTime? UpdatedAt { get; set; }
        
        public AppUser? UpdatedBy { get; set; }

        public DateTime? PassivedAt { get; set; }
        
        public AppUser? PassivedBy { get; set; }

        public Status Status { get; set; }
    }
}
    