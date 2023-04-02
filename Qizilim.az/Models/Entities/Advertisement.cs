using Qizilim.az.AppCode.InfraStructure;
using Qizilim.az.Models.Entities.Membreship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qizilim.az.Models.Entities
{
    public class Advertisement : BaseEntity
    {
        public string Image { get; set; }
        public string Link { get; set; }
        public int ShopId { get; set; }
    }
}
