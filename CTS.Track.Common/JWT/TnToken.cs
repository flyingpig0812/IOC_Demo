using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTS.Track.Api.JWT
{
    public class TnToken
    {
        /// <summary>
        /// token
        /// </summary>
        public string TokenStr { get; set; }
        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime Expires { get; set; }
    }
}
