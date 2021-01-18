using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Track.Common.Helper
{
    public static class ExtendMethod
    {
        /// <summary>
        /// 格式化
        /// </summary>
        /// <param name="val"></param>
        /// <returns>'{0}',</returns>
        public static string FormatSqlValue(this string value)
        {
            return string.Format("'{0}',", value);
        }

    }
}
