using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalCakeShop_Models.CakeModels
{
    public class CakeShop
    {
        public Guid Id { get; set; }
        public string ShopName { get; set; } = string.Empty;
        public string ShoDescription { get; set; } = string.Empty;
        public string CreatedOn { get; set; } = string.Empty;
    }
}

