using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizEssential.Core.DataTypes
{
    public class Lookup<T> where T : BaseEntity
    {
		public Guid GUID { get; set; }
		public string Id { get; set; }
		public T Entity { get; set; }
	}
}
