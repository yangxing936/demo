using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_DosOrm.Models
{
    public class order_info : Entity
    {
        /// <summary>
        /// 
        /// </summary>
        public System.String Id { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        public string TenantId { get; set; }
        /// <summary>
        /// 订单ID
        /// </summary>
        public string OrderId { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary>
        public string OrderCode { get; set; }
        /// <summary>
        /// 门店id
        /// </summary>
        public string StoreId { get; set; }
        /// <summary>
        /// 门店编号
        /// </summary>
        public string StoreCode { get; set; }
        /// <summary>
        /// 订单类型
        /// </summary>
        public int? OrderType { get; set; }
        /// <summary>
        /// 是否签到
        /// </summary>
        public int? IsSign { get; set; }
        /// <summary>
        /// 取餐号
        /// </summary>
        public string TakeNumber { get; set; }
        /// <summary>
        /// 取餐类型
        /// </summary>
        public int? TakeType { get; set; }
        /// <summary>
        /// 支付方式
        /// </summary>
        public int? PayMent { get; set; }
        /// <summary>
        /// 订单金额
        /// </summary>
        public decimal OrderTotal { get; set; }
        /// <summary>
        /// 实付总金额
        /// </summary>
        public decimal? PayTotal { get; set; }
        /// <summary>
        /// 优惠金额
        /// </summary>
        public decimal? DiscountTotal { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? CreateDateTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string CreateUserId { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public System.DateTime? UpdateDateTime { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public string UpdateUserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Extend01 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Extend02 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Extend03 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Extend04 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Extend05 { get; set; }
        /// <summary>
        /// pos关台金额
        /// </summary>
        public decimal? PosPayTotal { get; set; }
        /// <summary>
        /// 支付渠道 1线上 2线下
        /// </summary>
        public int? PayChannel { get; set; }
        /// <summary>
        /// 配送费
        /// </summary>
        public decimal? DeliveryFee { get; set; }
        /// <summary>
        /// 终端会员号
        /// </summary>
        public string MemberId { get; set; }
        /// <summary>
        /// 终端会员名称
        /// </summary>
        public string MemberName { get; set; }
        /// <summary>
        /// 终端会员手机号
        /// </summary>
        public string MemberPhone { get; set; }
        /// <summary>
        /// 台号
        /// </summary>
        public string TableId { get; set; }
        /// <summary>
        /// 包装费
        /// </summary>
        public decimal? PackingFee { get; set; }

        /// <summary>
        /// 预计送达时间
        /// </summary>
        public DateTime? AppointmentTime { get; set; }
    }
}