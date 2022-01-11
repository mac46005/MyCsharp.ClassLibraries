using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModels.ClassLib.Interface.PersonInformation
{
    public interface IAddress
    {
        string AddressLine_One { get; set; }
        string AddressLine_Two { get; set; }
        string AddressCity { get; set; }
        string Address_ZipCode { get; set; }
    }
}
