using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModels.ClassLib.Interface.PersonInformation
{
    public interface IName
    {
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}
