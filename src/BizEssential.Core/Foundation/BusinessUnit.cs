using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BizEssential.Core.DataTypes;

namespace BizEssential.Core.Foundation
{
	public class BusinessUnit : BaseEntity
	{
		public PartyType PartyType { get; set; }
		public string OrganizationName { get; set; }
		public string FullName { get; set; }
		public Dictionary<string, string> EmailAddresses { get; set; }
		public Dictionary<string, PhoneNumber> PhoneNumbers { get; set; }
		public Uri Website { get; set; }
		public string TaxIdIssuer { get; set; }
		public string TaxIdNumner { get; set; }
		public bool IsEmailContactAllowed { get; set; }
		public bool IsPhoneContactAllowed { get; set; }
		public string Description { get; set; }
		public string BusinessUnitId { get; set; }
		public RecordStatus Status { get; set; }
		public bool IsDefaultForOrganization { get; set; }

		public Dictionary<string, PostalAddress> PostalAddresses { get; set; }
	}
}
