using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizEssential.Core.DataTypes
{
    public class BaseEntity
    {
		public Guid GUID { get; set; }
		public string EntityPrefix { get; set; }
		public ulong RecordId { get; set; }
		public string Id { get; set; }
		public string CreatedBy { get; set; }
		public DateTime CreatedAt { get; set; }
		public string ModifiedBy { get; set; }
		public DateTime ModifiedAt { get; set; }
		public string DeletedBy { get; set; }
		public DateTime DeletedAt { get; set; }
		public bool IsDeleted { get; set; }
		public int VersionNo { get; set; }
		public string Checksum { get; set; }
	}
}
