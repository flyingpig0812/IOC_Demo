using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Track.Model
{

    public class TrackResponse<T>
    {
        public string code { get; set; }
        public TrackData<T> data { get; set; }
    }

    /// <summary>
    /// 跟踪信息返回
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TrackData<T>
    {
        public List<T> accepted { get; set; }
        public List<TrackRejected> rejected { get; set; }
    }

    /// <summary>
    /// number 跟踪单号
    /// carrier 运输商
    /// tag 自定义标识
    /// </summary>
    public class NumberInfo
    {


        public string number { get; set; }
        public string carrier { get; set; }
        public string tag { get; set; }


    }

    /// <summary>
    /// 错误信息
    /// </summary>
    public class TrackRejected
    {
        public string number { get; set; }
        public ErrorInfo error { get; set; }
    }

    /// <summary>
    /// 错误信息详细内容
    /// </summary>
    public class ErrorInfo
    {

        public string code { get; set; }
        public string message { get; set; }
    }

    /// <summary>
    /// 跟踪信息
    /// </summary>
    public class TrackInfo
    {
        /// <summary>
        /// 跟踪单号，需满足单号格式要求
        /// </summary>
        public string number { get; set; }
        /// <summary>
        /// 自定义注册标识，最长100个字符
        /// </summary>
        public string tag { get; set; }
        /// <summary>
        /// 跟踪信息
        /// </summary>
        public TrackDetail track { get; set; }
    }

    /// <summary>
    /// 跟踪详情
    /// </summary>
    public class TrackDetail
    {
        /// <summary>
        /// 发件国家地区编码
        /// </summary>
        public string b { get; set; }
        /// <summary>
        /// 目的国家地区编码
        /// </summary>
        public string c { get; set; }
        /// <summary>
        /// 第一运输商编号
        /// </summary>
        public string w1 { get; set; }
        /// <summary>
        /// 第二运输商编号
        /// </summary>
        public string w2 { get; set; }
        /// <summary>
        /// 第一运输商事件信息集合,顺序全部以降序存放
        /// </summary>
        public List<CarrierTrackDescription> z1 { get; set; }
        /// <summary>
        /// 第二运输商事件信息集合,顺序全部以降序存放
        /// </summary>
        public List<CarrierTrackDescription> z2 { get; set; }
        /// <summary>
        /// 联合运输商事件信息集合,顺序全部以降序存放
        /// </summary>
        public List<CarrierTrackDescription> z9 { get; set; }
        ///// <summary>
        ///// 最后采集时间(第一运输商)，2079-01-01表示该时间无效
        ///// </summary>
        //public string ylt1 { get; set; }
        ///// <summary>
        ///// 最后采集时间(第二运输商)，2079-01-01表示该时间无效
        ///// </summary>
        //public string ylt2 { get; set; }
        ///// <summary>
        ///// 最后采集时间(联合运输商)，2079-01-01表示该时间无效
        ///// </summary>
        //public string ylt9 { get; set; }
        //public TrackDetailExtend zex { get; set; }
    }

    /// <summary>
    /// 运输商事件信息集合,顺序全部以降序存放
    /// </summary>
    public class CarrierTrackDescription
    {
        /// <summary>
        /// 事件时间(可能不是有效的时间格式数据,需要按字符串处理)
        /// </summary>
        public string a { get; set; }
        /// <summary>
        /// 地理位置坐标(暂未使用)
        /// </summary>
        public string b { get; set; }
        /// <summary>
        /// 事件发生地点
        /// </summary>
        public string c { get; set; }
        /// <summary>
        /// 事件发生地点扩展(暂未使用)
        /// </summary>
        public string d { get; set; }
        /// <summary>
        /// 事件内容描述
        /// </summary>
        public string z { get; set; }

    }


    public class v_Track
    {
        public string TrackNo { get; set; }
        public string Tag { get; set; }
        public string CarrierName { get; set; }
        public string LastDesc { get; set; }
        public List<v_TrackDetail> TrackDetails { get; set; }
    }

    public class v_TrackDetail
    {
        public string TrackTime { get; set; }
        public string Location { get; set; }
        public string TrackContent { get; set; }
    }



}
