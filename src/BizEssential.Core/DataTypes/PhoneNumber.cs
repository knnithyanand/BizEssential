using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizEssential.Core.DataTypes
{
    public class PhoneNumber
    {
		public ushort CountryCode { get; set; }
		public string AreaCode { get; set; }
		public string Number { get; set; }
		public string Extention { get; set; }

		public override string ToString ()
		{
			return $"+{CountryCode.ToString()} {AreaCode} {Number} x {Extention}";
		}
	}
}
