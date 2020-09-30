using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class StoreUrlModel
    {
        #region 点餐平台调用门店pos接口

        public static string Url = "http://ip:port/";
        /// <summary>
        /// 总部基础数据
        /// </summary>
        public static string baseInfo = "posapi/basic/baseInfo";
        /// <summary>
        /// 门店基础数据
        /// </summary>
        public static string shopBaseInfo = "posapi/shop/shopBaseInfo";
        /// <summary>
        /// 门店营业状态
        /// </summary>
        public static string shopStatus = "posapi/shop/shopStatus";
        /// <summary>
        /// 沽清菜品接口
        /// </summary>
        public static string clearDish = "posapi/shop/clearDish";
        /// <summary>
        /// 先付预结(下单)
        /// </summary>
        public static string orderPrecheck = "posapi/shop/orderPrecheck";
        /// <summary>
        /// 先付结帐(清台)
        /// </summary>
        public static string firstPay = "posapi/shop/firstPay";
        /// <summary>
        /// 查询桌台
        /// </summary>
        public static string getOrderinfor = "posapi/shop/getOrderinfor";
        /// <summary>
        /// 查询桌态接口
        /// </summary>
        public static string tableStatus = "posapi/shop/tableStatus";
        /// <summary>
        /// 后付下单
        /// </summary>
        public static string order = "posapi/shop/order";
        /// <summary>
        /// 后付预结(支付上传订单)
        /// </summary>
        public static string uploadOrders = "posapi/shop/uploadOrders";
        /// <summary>
        /// 后付结帐(清台)
        /// </summary>
        public static string payOrder = "posapi/shop/payOrder";
        /// <summary>
        /// 取消支付
        /// </summary>
        public static string unlockOrder = "order/api/unlockOrder";

        #endregion


        #region 门店pos调用点餐平台接口

        public static string Url_Program = "https://ordermeal.welcrm.com/";
        public static string Url_Beta = "https://ordermeal.beta.welcrm.com/";
        /// <summary>
        /// 结账通知接口
        /// </summary>
        public static string completeOrder = "api/Order/completeOrder";
        /// <summary>
        /// 上传订单接口
        /// </summary>
        public static string uploadOrder = "api/Order/uploadOrder";
        /// <summary>
        /// 解锁订单接口
        /// </summary>
        public static string unlockOrder_Program = "api/Order/unlockOrder";
        /// <summary>
        /// 门店转台接口
        /// </summary>
        public static string changeTable = "api/Order/changeTable";
        /// <summary>
        /// 门店并台接口
        /// </summary>
        public static string combineTable = "api/Order/combineTable";
        /// <summary>
        /// 门店估清接口
        /// </summary>
        public static string sold_out = "api/Order/sold_out";
        /// <summary>
        /// 取消估清接口
        /// </summary>
        public static string calcel = "api/sold_out/calcel";
        /// <summary>
        /// 门店退单接口
        /// </summary>
        public static string orderQuit = "api/Order/orderQuit";
        /// <summary>
        /// 门店退款接口
        /// </summary>
        public static string refund = "api/Order/refund";
        /// <summary>
        /// 取餐提醒接口 get请求
        /// </summary>
        public static string sendmealmsg = "api/sendmealmsg/";

        // com环境  beta环境

        /// <summary>
        /// 收银同步菜品接口
        /// </summary>
        public static string synchrodataDish_com = "api/synchrodataDish";
        public static string synchrodataDish_beta = "api/synchrodataDish";
        /// <summary>
        /// 重新清台接口
        /// </summary>
        public static string getPayStatus_com = "api/getPayStatus";
        public static string getPayStatus_beta = "api/getPayStatus";
        /// <summary>
        /// 门店分单接口
        /// </summary>
        public static string separateOrder_com = "api/separateOrder";
        public static string separateOrder_beta = "api/order/separateOrder";
        /// <summary>
        /// 小程序活动接口
        /// </summary>
        public static string completeOrder_com = "api/activies/list";
        public static string completeOrder_beta = "http://ordermealbeta.welcrm.com/api/activies/list?bid=100075";
        /// <summary>
        /// 收银通知小程序锁单
        /// </summary>
        public static string lockOrder_com = "api/order/lockOrder";
        public static string lockOrder_beta = "api/order/lockOrder";
        /// <summary>
        /// 小程序营销活动接口 get请求
        /// </summary>
        public static string list = "api/activies/list";
        /// <summary>
        /// 小程序营销活动接口基地址  get请求
        /// </summary>
        public static string list_baseUrl = "http://domain.com/";
        /// <summary>
        /// 收银退菜菜通知
        /// </summary>
        public static string changeOrderDishMsg = "api/changeOrderDishMsg/";
        /// <summary>
        /// 汇付-撤销储值接口
        /// </summary>
        public static string huifuChargeCancel = "api/huifuChargeCancel";


        #endregion


        /// <summary>
        /// 基地址
        /// </summary>
        public static string payInfo_baseUrl = "http://ordermealbeta.welcrm.com/";
        /// <summary>
        /// 查询订单实际支付数据结果
        /// </summary>
        public static string payInfo_url = "tool/payInfo/";
    }

    public class WxProgram 
    {
        public static string Url = "http://ip:port/";
        /// <summary>
        /// 获取门店基础数据
        /// </summary>
        public static string syncDishes= "pzcatering-web/weix/syncDishes.do";
        /// <summary>
        /// 订单等待状态接口
        /// </summary>
        public static string orderWaitStatus = "pzcatering-gateway/weix/orderWaitStatus.do";
        /// <summary>
        /// 门店营业状态
        /// </summary>
        public static string shopStatus = "pzcatering-api/wx/shopStatus.do";
        /// <summary>
        /// 沽清菜品接口
        /// </summary>
        public static string dishSellOff = "pzcatering-api/wx/dishSellOff.do";
        /// <summary>
        /// 获取发票码
        /// </summary>
        public static string invoice = "pzcatering-api/wx/invoice.do";
        /// <summary>
        /// 查询桌态接口
        /// </summary>
        public static string tableStatus = "pzcatering-api/wx/tableStatus.do";
        /// <summary>
        /// 微信后付下单接口
        /// </summary>
        public static string dishesSend = "pzcatering-api/wx/dishesSend.do";
        /// <summary>
        /// 支付上传订单接口（仅预结，不锁单）
        /// </summary>
        public static string payLock = "pzcatering-api/wx/payLock";
        /// <summary>
        /// 后付锁单接口
        /// </summary>
        public static string lockUrl = "pzcatering-api/wx/lock";
        /// <summary>
        /// 后付支付清台接口
        /// </summary>
        public static string pay = "pzcatering-api/wx/pay";
        /// <summary>
        /// 解锁桌台接口
        /// </summary>
        public static string orderUnlock = "pzcatering-api/wx/orderUnlock.do";
        /// <summary>
        /// 先付门店计算金额接口
        /// </summary>
        public static string preCalculation = "pzcatering-api/wx/preCalculation.do";
        /// <summary>
        /// 先付结账清台接口
        /// </summary>
        public static string prePay = "pzcatering-api/wx/prePay.do";
        /// <summary>
        /// 订单等待状态接口
        /// </summary>
        public static string orderWaitStatus_url = "pzcatering-api/wx/orderWaitStatus.do";

    }
}
