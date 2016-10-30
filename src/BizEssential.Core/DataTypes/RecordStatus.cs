using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizEssential.Core.DataTypes
{
    public enum RecordStatus
    {
		Draft,
		New,
		Active,
		InActive,
		MarkedToArchive,
		Archived,
		MarkedToDelete,
		Deleted,
		Locked
    }
}
