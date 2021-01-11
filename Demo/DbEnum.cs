using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class DbEnum
    {
        public enum OrderStateType
        {

            [Description("未提交")]//索引已0开始
            SubmitNull = 0,
            [Description("已提交，未支付")]
            PayNull = 1,
            [Description("已取消")]
            Cancel = 9999,
            [Description("已提交支付，但未回调（如果有跑任务，发现订单状态为10，订单超过半小时，更新状态为9999，取消状态）")]
            CallBackNull = 10,
            [Description("支付回调，支付失败")]
            PayFailing = 14,
            [Description("支付回调，支付成功")]
            PaySuccess = 18,
            [Description("已接单")]
            TakeOrder = 21,
            [Description("制作完成")]
            MakeOver = 26,
            [Description("已到店")]
            ArriveStore = 31,
            [Description("已取餐")]
            TakeFood = 36,
            [Description("已送出")]
            SendOut = 41,
            [Description("确认送达")]
            SendOver = 46,
            [Description("订单完成")]
            OrderOver = 101,
            [Description("申请退款")]
            Refund = 110,
            [Description("申请退款拒绝")]
            RefundNull = 114,
            [Description("退款完成")]
            RefundOver = 118,

        }
    }
}
