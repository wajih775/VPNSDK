using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPNSDK
{
    public interface SDKUtility
    {
        void startConnection();
        void StopConnection();
        void FindPort();
    }
}
