﻿//	Copyright (c) 2016 Nithyanand K N
//
//	Licensed under the Apache License, Version 2.0 (the "License");
//	you may not use this file except in compliance with the License.
//	You may obtain a copy of the License at
//
//		http://www.apache.org/licenses/LICENSE-2.0
//
//	Unless required by applicable law or agreed to in writing, software
//	distributed under the License is distributed on an "AS IS" BASIS,
//	WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//	See the License for the specific language governing permissions and
//	limitations under the License.

using System;
using System.Collections.Generic;
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
