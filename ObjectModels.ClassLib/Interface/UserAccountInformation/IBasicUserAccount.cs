using ObjectModels.ClassLib.Interface.PersonInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModels.ClassLib.Interface.UserAccountInformation
{
    public interface IBasicUserAccount : IEmailAddress,IPassword,IName,IDateOfBirth
    {
    }
}
