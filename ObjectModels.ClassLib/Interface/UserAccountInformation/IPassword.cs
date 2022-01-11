using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModels.ClassLib.Interface.UserAccountInformation
{
    /// <summary>
    /// A password for an account
    /// </summary>
    public interface IPassword
    {
        /// <summary>
        /// Get and Setter for a password
        /// </summary>
        string Password { get; set; }
    }
}
