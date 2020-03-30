using System;
using System.Collections.Generic;
using System.Text;

namespace AceInsPepscProxy.Api.Models.Interfaces
{
    interface IModel
    {
        /// <summary>
        /// Does the work or clean up that is needed after the deserialization has completed.
        /// </summary>
        void DoPostSerializationWork();
    }
}
