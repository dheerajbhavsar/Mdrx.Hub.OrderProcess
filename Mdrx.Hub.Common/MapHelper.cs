using System;

namespace Mdrx.Hub.Common
{
    public class MapHelper
    {
        public static string GenerateGuid()
        {
            return Guid.NewGuid().ToString();
        }

        public static string ConvertToDateTime(string dateAsString)
        {
            return Convert.ToDateTime(dateAsString).ToString("O");
        }
    }
}
