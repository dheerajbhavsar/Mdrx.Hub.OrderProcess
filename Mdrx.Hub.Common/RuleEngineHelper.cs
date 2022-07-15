using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mdrx.Hub.Common
{
    public class RuleEngineHelper
    {
        public RuleEngineHelper()
        {

        }
        public static bool IsDeclined(float orderTotal) => orderTotal > 5000;

        public static bool IsValidCustomer(string customerName) => customerName.Contains("VAL");
    }
}
