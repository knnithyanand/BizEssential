using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizEssential.Core.DataTypes
{
    public class PostalAddress
    {
		public string UnitNo { get; set; }
		public string Building { get; set; }
		public string Street { get; set; }
		public string Area { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Country { get; set; }
		public string PostalCode { get; set; }
	}
}
