using eVal.Core.Enums;
using eVal.Core.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVal.Core.Entities
{
    public class AppUser:IdentityUser, IBaseEntity
    {
        private string _ImagePath = "defaultuser_512px.png";

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ImagePath 
        {
            get { return _ImagePath; }
            set
            {
                if(value != null)
                {
                    _ImagePath = value;
                }
            } 
        }

        public DateTime CreatedAt { get; set; }

        public AppUser CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public AppUser? UpdatedBy { get; set; }

        public DateTime? PassivedAt { get; set; }

        public AppUser? PassivedBy { get; set; }

        public Status Status { get; set; }
    }
}
