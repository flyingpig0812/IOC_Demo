using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTS.Track.Model
{
    public class ResponseEntity
    {
        /// <summary>
        /// 返回码
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// 消息
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        /// 数据
        /// </summary>
        public object Data { get; set; }

    }
}

