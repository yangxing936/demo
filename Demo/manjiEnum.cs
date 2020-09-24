using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class manjiEnum
    {
        public enum orderStatus
        {
            [Description("支付成功")]
            PAY_SUC,
            [Description("退款成功")]
            REFUND_SUC,
            [Description("订单关闭")]
            CLOSED,
            [Description("订单撤销")]
            REVERSED,
            [Description("订单支付失败")]
            PAY_FAIL
        }
    }
}
