using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModels.ClassLib.Interface.UserAccountInformation
{
    /// <summary>
    /// An email address
    /// </summary>
    public interface IEmailAddress
    {
        /// <summary>
        /// An email address for an account
        /// </summary>
        string EmailAddress { get; set; }
    }
}
