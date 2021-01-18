using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Track.Model
{
    public class ThirdTrackResponse
    {
        public List<DataItem> data { get; set; }
        public string ack { get; set; }
    }

    public class TrackDetailsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string business_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string country_code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string system_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string track_content { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string track_createdate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string track_date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string track_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string track_kind { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string track_location { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string track_signdate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string track_signperson { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string track_substate { get; set; }
    }

    public class DataItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string businessId { get; set; }
        /// <summary>
        /// 签收
        /// </summary>
        public string businessStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string business_customerweightf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string business_grossweight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string business_pieces { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string business_seqinvoicecode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string business_serveweightf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string consigneeCountry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string consignee_address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string consignee_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string customer_code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string order_customnote { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string productKindName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string referenceNumber { get; set; }
        /// <summary>
        /// 签收Proof of Delivery
        /// </summary>
        public string trackContent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string trackDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<TrackDetailsItem> trackDetails { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string trackLocation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string trackSignperson { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string trackingNumber { get; set; }
    }







}
