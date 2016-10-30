using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BizEssential.Core.DataTypes;

namespace BizEssential.Core.Foundation
{
    public class CostCenter:BaseEntity
	{
		public string Name { get; set; }
		public string Description { get; set; }
		//public Lookup<Organization> Organization { get; set; }
		public Lookup<CostCenter> ParentCostCenter { get; set; }
	}
}
