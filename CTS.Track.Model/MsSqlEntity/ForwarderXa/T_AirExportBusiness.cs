using System;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using SqlSugar;

namespace CTS.Track.Model.MsSqlEntity.ForwarderXa
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_AirExportBusiness")]
    public partial class T_AirExportBusiness
    {
        public T_AirExportBusiness()
        {


        }
        /// <summary>
        /// Desc:空运出口业务编号
        /// Default:
        /// Nullable:False
        /// </summary>           
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public long AirExportBusinessId { get; set; }

        /// <summary>
        /// Desc:接单日期
        /// Default:
        /// Nullable:True
        /// </summary>            
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Desc:业务编号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string BusinessNumber { get; set; }

        /// <summary>
        /// Desc:委托编号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string ConsignmentNumber { get; set; }

        /// <summary>
        /// Desc:委托单位
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string ConsignmentUnitId { get; set; }

        /// <summary>
        /// Desc:委托单位代码
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string ConsignmentUnitCode { get; set; }

        /// <summary>
        /// Desc:委托单位名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string ConsignmentUnitName { get; set; }

        /// <summary>
        /// Desc:结算单位
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SettlementUnitId { get; set; }

        /// <summary>
        /// Desc:结算单位代码
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SettlementUnitCode { get; set; }

        /// <summary>
        /// Desc:结算单位名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SettlementUnitName { get; set; }

        /// <summary>
        /// Desc:航空代理是航空公司
        /// Default:
        /// Nullable:True
        /// </summary>           
        public bool AirTransportAgentIsAirCarrier { get; set; }

        /// <summary>
        /// Desc:航空代理
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string AirTransportAgentId { get; set; }

        /// <summary>
        /// Desc:航空代理代码
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string AirTransportAgentCode { get; set; }

        /// <summary>
        /// Desc:航空代理名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string AirTransportAgentName { get; set; }

        /// <summary>
        /// Desc:海外代理
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string OverseasAgentId { get; set; }

        /// <summary>
        /// Desc:海外代理代码
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string OverseasAgentCode { get; set; }

        /// <summary>
        /// Desc:海外代理
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string OverseasAgentName { get; set; }

        /// <summary>
        /// Desc:经营单位
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string TenCode { get; set; }

        /// <summary>
        /// Desc:经营单位名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Consignor { get; set; }

        /// <summary>
        /// Desc:航空公司代码
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string CarrierCode { get; set; }

        /// <summary>
        /// Desc:航空公司3字码
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string CarrierCode3 { get; set; }

        /// <summary>
        /// Desc:航空公司名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string CarrierName { get; set; }

        /// <summary>
        /// Desc:操作员
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int OperatorId { get; set; }

        /// <summary>
        /// Desc:操作员姓名
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string OperatorName { get; set; }

        /// <summary>
        /// Desc:销售人员
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int SellerId { get; set; }

        /// <summary>
        /// Desc:销售人员姓名
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SellerName { get; set; }

        /// <summary>
        /// Desc:业务部门
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int BusinessDepartmentId { get; set; }

        /// <summary>
        /// Desc:业务部门名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string BusinessDepartmentName { get; set; }

        /// <summary>
        /// Desc:商务人员
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int VouchingClerkId { get; set; }

        /// <summary>
        /// Desc:商务人员姓名
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string VouchingClerkName { get; set; }

        /// <summary>
        /// Desc:客服人员
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int ClientSupportId { get; set; }

        /// <summary>
        /// Desc:客服人员姓名
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string ClientSupportName { get; set; }

        /// <summary>
        /// Desc:预订航班
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SubscribeFlightNumber { get; set; }

        /// <summary>
        /// Desc:预订航班日期
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime SubscribeFlightDate { get; set; }

        /// <summary>
        /// Desc:实际/订舱航班
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string FlightNumber { get; set; }

        /// <summary>
        /// Desc:实际/订舱航班日期
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime FlightDate { get; set; }

        /// <summary>
        /// Desc:到港时间
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime ArrivalDate { get; set; }

        /// <summary>
        /// Desc:始发港
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string OriginPortCode { get; set; }

        /// <summary>
        /// Desc:始发港名
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string OriginPortName { get; set; }

        /// <summary>
        /// Desc:二程港口
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string TransferPortCode { get; set; }

        /// <summary>
        /// Desc:三程港口
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string TransferPortCode1 { get; set; }

        /// <summary>
        /// Desc:目的港
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string DestinationPortCode { get; set; }

        /// <summary>
        /// Desc:目的港名
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string DestinationPortName { get; set; }

        /// <summary>
        /// Desc:目的地
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string DestinationCity { get; set; }

        /// <summary>
        /// Desc:二程航班
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string TransferFlightNumber { get; set; }

        /// <summary>
        /// Desc:二程航班日期
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime TransferFlightDate { get; set; }

        /// <summary>
        /// Desc:三程航班
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string TransferFlightNumber1 { get; set; }

        /// <summary>
        /// Desc:三程航班日期
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime TransferFlightDate1 { get; set; }

        /// <summary>
        /// Desc:运单方式
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string BookingModeKey { get; set; }

        /// <summary>
        /// Desc:运单方式名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string BookingModeName { get; set; }

        /// <summary>
        /// Desc:付款方式
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string PaymentTypeKey { get; set; }

        /// <summary>
        /// Desc:付款方式名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string PaymentTypeName { get; set; }

        /// <summary>
        /// Desc:卖价
        /// Default:
        /// Nullable:True
        /// </summary>           
        public decimal SellingPrice { get; set; }

        /// <summary>
        /// Desc:成本
        /// Default:
        /// Nullable:True
        /// </summary>           
        public decimal CostPrice { get; set; }

        /// <summary>
        /// Desc:运价等级
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string TransportPriceLevel { get; set; }

        /// <summary>
        /// Desc:前程运单号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string PreviousMawbNumber { get; set; }

        /// <summary>
        /// Desc:主运单编号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public long MasterBillId { get; set; }

        /// <summary>
        /// Desc:主运单号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string MawbNumber { get; set; }

        /// <summary>
        /// Desc:分运单号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string HawbNumber { get; set; }

        /// <summary>
        /// Desc:核销单号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string WriteOffNumber { get; set; }

        /// <summary>
        /// Desc:委托他人
        /// Default:
        /// Nullable:True
        /// </summary>           
        public bool IsOther { get; set; }

        /// <summary>
        /// Desc:报关方式
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string CustomsModeKey { get; set; }

        /// <summary>
        /// Desc:报关方式名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string CustomsModeName { get; set; }

        /// <summary>
        /// Desc:报关行
        /// Default:
        /// Nullable:True
        /// </summary>           
        public long CustomsBrokerId { get; set; }

        /// <summary>
        /// Desc:报关行名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string BrokerName { get; set; }

        /// <summary>
        /// Desc:中文品名分类
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string GoodsNameClass { get; set; }

        /// <summary>
        /// Desc:中文品名
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string GoodsCode { get; set; }

        /// <summary>
        /// Desc:中文品名
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string GoodsName { get; set; }

        /// <summary>
        /// Desc:分批货
        /// Default:
        /// Nullable:True
        /// </summary>           
        public bool IsPartial { get; set; }

        /// <summary>
        /// Desc:件数
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int Packages { get; set; }

        /// <summary>
        /// Desc:小件数
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public int Pieces { get; set; }

        /// <summary>
        /// Desc:包装种类
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string PackageCode { get; set; }

        /// <summary>
        /// Desc:包装种类名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string PackageName { get; set; }

        /// <summary>
        /// Desc:货物种类
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string GoodsTypeKey { get; set; }

        /// <summary>
        /// Desc:货物种类名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string GoodsTypeName { get; set; }

        /// <summary>
        /// Desc:预订重量
        /// Default:
        /// Nullable:True
        /// </summary>           
        public decimal EstimateWeight { get; set; }

        /// <summary>
        /// Desc:预订体积
        /// Default:
        /// Nullable:True
        /// </summary>           
        public decimal EstimateVolume { get; set; }

        /// <summary>
        /// Desc:过磅重量
        /// Default:
        /// Nullable:True
        /// </summary>           
        public decimal ActualWeight { get; set; }

        /// <summary>
        /// Desc:计费重量
        /// Default:
        /// Nullable:True
        /// </summary>           
        public decimal ChargeableWeight { get; set; }

        /// <summary>
        /// Desc:过磅体积
        /// Default:
        /// Nullable:True
        /// </summary>           
        public decimal Volume { get; set; }

        /// <summary>
        /// Desc:进仓编号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string KeepInNumber { get; set; }

        /// <summary>
        /// Desc:货物来源
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string CargoSourceKey { get; set; }

        /// <summary>
        /// Desc:货物来源名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string CargoSourceName { get; set; }

        /// <summary>
        /// Desc:送货时间
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// Desc:操作库区
        /// Default:
        /// Nullable:True
        /// </summary>           
        public long WarehouseId { get; set; }

        /// <summary>
        /// Desc:操作库区
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string WarehouseName { get; set; }

        /// <summary>
        /// Desc:订舱备注
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string BookingRemark { get; set; }

        /// <summary>
        /// Desc:操作备注
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string OperateRemark { get; set; }

        /// <summary>
        /// Desc:财务备注
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string FinancialRemark { get; set; }

        /// <summary>
        /// Desc:订舱服务
        /// Default:
        /// Nullable:True
        /// </summary>           
        public bool IsSupplyBooking { get; set; }

        /// <summary>
        /// Desc:报关服务
        /// Default:
        /// Nullable:True
        /// </summary>           
        public bool IsSupplyCustoms { get; set; }

        /// <summary>
        /// Desc:报检服务
        /// Default:
        /// Nullable:True
        /// </summary>           
        public bool IsSupplyCommodity { get; set; }

        /// <summary>
        /// Desc:国内运输
        /// Default:
        /// Nullable:True
        /// </summary>           
        public bool IsSupplyInlandTransport { get; set; }

        /// <summary>
        /// Desc:拍照类型
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string PhotoTypeKey { get; set; }

        /// <summary>
        /// Desc:拍照类型名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string PhotoTypeName { get; set; }

        /// <summary>
        /// Desc:航线代码
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string AirLineKey { get; set; }

        /// <summary>
        /// Desc:航线名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string AirLineName { get; set; }

        /// <summary>
        /// Desc:是否吃泡
        /// Default:
        /// Nullable:True
        /// </summary>           
        public bool IsLight { get; set; }

        /// <summary>
        /// Desc:吃泡重量
        /// Default:
        /// Nullable:True
        /// </summary>           
        public decimal LightWeight { get; set; }

        /// <summary>
        /// Desc:收客户泡重
        /// Default:
        /// Nullable:True
        /// </summary>           
        public decimal AccountLightWeight { get; set; }

        /// <summary>
        /// Desc:订舱确认时间
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime BookingConfirmDate { get; set; }

        /// <summary>
        /// Desc:订舱确认人
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int BookingConfirmUserId { get; set; }

        /// <summary>
        /// Desc:订舱确认人姓名
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string BookingConfirmUserName { get; set; }

        /// <summary>
        /// Desc:P/N
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string PartNumber { get; set; }

        /// <summary>
        /// Desc:P/O
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string PartOrderNumber { get; set; }

        /// <summary>
        /// Desc:已订舱
        /// Default:
        /// Nullable:True
        /// </summary>           
        public bool IsBooking { get; set; }

        /// <summary>
        /// Desc:已进舱
        /// Default:
        /// Nullable:True
        /// </summary>           
        public bool IsCabined { get; set; }

        /// <summary>
        /// Desc:制总单时间
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime MakeMawbDate { get; set; }

        /// <summary>
        /// Desc:制分单时间
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime MakeHawbDate { get; set; }

        /// <summary>
        /// Desc:发货人代码
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string DeliverUserCode { get; set; }

        /// <summary>
        /// Desc:发货人信息
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string DeliverUserInfo { get; set; }

        /// <summary>
        /// Desc:收货人代码
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string ReceiverUserCode { get; set; }

        /// <summary>
        /// Desc:收货人信息
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string ReceiverUserInfo { get; set; }

        /// <summary>
        /// Desc:通知人信息
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string NoticeUserInfo { get; set; }

        /// <summary>
        /// Desc:货物描述
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string GoodsRemark { get; set; }

        /// <summary>
        /// Desc:唛头
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string MarkTitle { get; set; }

        /// <summary>
        /// Desc:附加信息
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string OtherInfo { get; set; }

        /// <summary>
        /// Desc:尺寸及备注信息
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Remark { get; set; }

        /// <summary>
        /// Desc:成交方式
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string DeliverMethod { get; set; }

        /// <summary>
        /// Desc:业务制单完成
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public bool IsMakeBillFinished { get; set; }

        /// <summary>
        /// Desc:收入制单完成
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public bool IsIncomeBillFinished { get; set; }

        /// <summary>
        /// Desc:支出制单完成
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public bool IsCostBillFinished { get; set; }

        /// <summary>
        /// Desc:费用确认完成
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public bool IsFeeConfirmFinished { get; set; }

        /// <summary>
        /// Desc:费用备注
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string FeeRemark { get; set; }

        /// <summary>
        /// Desc:财务备注
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string FinanceRemark { get; set; }

        /// <summary>
        /// Desc:核销完毕
        /// Default:
        /// Nullable:True
        /// </summary>           
        public bool IsWriteOffed { get; set; }

        /// <summary>
        /// Desc:已退关
        /// Default:
        /// Nullable:True
        /// </summary>           
        public bool IsShutOut { get; set; }

        /// <summary>
        /// Desc:创建者编号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int CreateUserId { get; set; }

        /// <summary>
        /// Desc:创建者姓名
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string CreateUserName { get; set; }

        /// <summary>
        /// Desc:创建日期
        /// Default:DateTime.Now
        /// Nullable:True
        /// </summary>           
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// Desc:更新者编号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int UpdateUserId { get; set; }

        /// <summary>
        /// Desc:更新者姓名
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string UpdateUserName { get; set; }

        /// <summary>
        /// Desc:更新日期
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// Desc:已删除
        /// Default:
        /// Nullable:True
        /// </summary>           
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Desc:删除日期
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime DeleteTime { get; set; }

        /// <summary>
        /// Desc:删除者编号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int DeleteUserId { get; set; }

        /// <summary>
        /// Desc:删除者姓名
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string DeleteUserName { get; set; }

        /// <summary>
        /// Desc:同年月序号
        /// Default:1
        /// Nullable:True
        /// </summary>           
        public int BusinessIndex { get; set; }

        /// <summary>
        /// Desc:分单数量
        /// Default:
        /// Nullable:True
        /// </summary>           
        public short HouseBillCount { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string GoodsNameRemark { get; set; }

        /// <summary>
        /// Desc:
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public bool IsIncomeLock { get; set; }

        /// <summary>
        /// Desc:
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public bool IsCostLock { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string oldConsignmentUnitId { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string oldSettlementUnitId { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string oldOverseasAgentId { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string oldAirTransportAgentId { get; set; }

        /// <summary>
        /// Desc:
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public bool IsInvoiced { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int LastInvoiceUserId { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string LastInvoiceUserName { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime LastInvoiceDateTime { get; set; }

        /// <summary>
        /// Desc:
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public bool IsPrejudication { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int LastPrejudicationUserId { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string LastPrejudicationUserName { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime LastPrejudicationDateTime { get; set; }

        /// <summary>
        /// Desc:
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public bool IsDischarged { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string NoticeUserCode { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime FeeConfirmFinishedDate { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime TallyingTime { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime PickUpTime { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime SpecialAreaTime { get; set; }

        /// <summary>
        /// Desc:
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public bool IsSubstitute { get; set; }

        /// <summary>
        /// Desc:
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public bool IsSubInvoiced { get; set; }

        /// <summary>
        /// Desc:业务来源：M-manual A-auto
        /// Default:M
        /// Nullable:True
        /// </summary>           
        public string BizSource { get; set; }

        /// <summary>
        /// Desc:成本公开的编号，同步编号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public long CostOpenId { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string BuildSource { get; set; }

        /// <summary>
        /// Desc:是可编辑
        /// Default:1
        /// Nullable:True
        /// </summary>           
        public bool IsEditable { get; set; }

        /// <summary>
        /// Desc:
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public bool IsReadOnlyOfPartial { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public decimal TotalIncome { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public decimal TotalCost { get; set; }

    }
}
