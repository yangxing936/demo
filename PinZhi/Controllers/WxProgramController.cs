using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Web.Http;
using Models;
using Models.WxProgramOrderInfo;
using Newtonsoft.Json;

namespace PinZhi.Controllers
{
    public class WxProgramController : ApiController
    {
        #region 小程序调门店接口

        /// <summary>
        /// 获取门店基础数据
        /// </summary>
        /// <param name="shop_id">门店ID</param>
        /// <returns></returns>
        [Route("api/wxprogram/syncDishes")]
        [HttpPost]
        public MessageModel syncDishes(int shop_id)
        {
            var res = HttpClientHelper.Post(WxProgram.Url, WxProgram.syncDishes, JsonConvert.SerializeObject(new
            {
                shop_id = shop_id
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        /// <summary>
        /// 产能数据获取
        /// </summary>
        /// <param name="shop_id">收银门店id</param>
        /// <param name="outorderid">平台订单id 。不传递参数则返回门店当前产能</param>
        /// <returns></returns>
        [Route("api/wxprogram/orderWaitStatus")]
        [HttpPost]
        public MessageModel orderWaitStatus(int shop_id, string outorderid = "")
        {
            var res = HttpClientHelper.Post(WxProgram.Url, WxProgram.orderWaitStatus, JsonConvert.SerializeObject(new
            {
                shop_id = shop_id,
                outorderid = outorderid
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        /// <summary>
        /// 门店营业状态
        /// </summary>
        /// <returns></returns>
        [Route("api/wxprogram/shopStatus")]
        [HttpPost]
        public MessageModel shopStatus()
        {
            var res = HttpClientHelper.Get(WxProgram.Url, WxProgram.shopStatus);
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        /// <summary>
        /// 沽清菜品接口
        /// </summary>
        /// <returns></returns>
        [Route("api/wxprogram/dishSellOff")]
        [HttpPost]
        public MessageModel dishSellOff()
        {
            var res = HttpClientHelper.Get(WxProgram.Url, WxProgram.dishSellOff);
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        /// <summary>
        /// 获取发票码
        /// </summary>
        /// <param name="outorderid"></param>
        /// <returns></returns>
        [Route("api/wxprogram/invoice")]
        [HttpPost]
        public MessageModel invoice(string outorderid)
        {
            var res = HttpClientHelper.Post(WxProgram.Url, WxProgram.invoice, JsonConvert.SerializeObject(new
            {
                outorderid = outorderid
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        /// <summary>
        /// 查询桌态接口
        /// </summary>
        /// <param name="tableno">桌台号</param>
        /// <returns></returns>
        [Route("api/wxprogram/tableStatus")]
        [HttpPost]
        public MessageModel tableStatus(string tableno)
        {
            var res = HttpClientHelper.Post(WxProgram.Url, WxProgram.tableStatus, JsonConvert.SerializeObject(new
            {
                tableno = tableno
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        /// <summary>
        /// 微信后付下单接口
        /// </summary>
        /// <param name="identify">平台订单id</param>
        /// <param name="id">消息id</param>
        /// <param name="openid"></param>
        /// <param name="order_info">订单内容</param>
        /// <returns></returns>
        [Route("api/wxprogram/dishesSend")]
        [HttpPost]
        public MessageModel dishesSend(string identify, string id, string openid, object order_info)
        {
            var res = HttpClientHelper.Post(WxProgram.Url, WxProgram.dishesSend, JsonConvert.SerializeObject(new
            {
                identify = identify,
                id = id,
                openid = openid,
                order_info = order_info
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        /// <summary>
        /// 支付上传订单（仅计算金额）
        /// </summary>
        /// <param name="openid"></param>
        /// <param name="tableno"></param>
        /// <param name="out_order_id"></param>
        /// <param name="table_sno"></param>
        /// <param name="identify"></param>
        /// <returns></returns>
        [Route("api/wxprogram/payLock")]
        [HttpPost]
        public MessageModel payLock(string openid, string tableno, string out_order_id, string table_sno, string identify)
        {
            var res = HttpClientHelper.Post(WxProgram.Url, WxProgram.payLock, JsonConvert.SerializeObject(new
            {
                openid = openid,
                tableno = tableno,
                out_order_id = out_order_id,
                table_sno = table_sno,
                identify = identify
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        /// <summary>
        /// 后付预结并锁单
        /// </summary>
        /// <param name="openid"></param>
        /// <param name="tableno"></param>
        /// <param name="out_order_id"></param>
        /// <param name="table_sno"></param>
        /// <param name="identify"></param>
        /// <returns></returns>
        [Route("api/wxprogram/lockUrl")]
        [HttpPost]
        public MessageModel lockUrl(string openid, string tableno, string out_order_id, string table_sno, string identify)
        {
            var res = HttpClientHelper.Post(WxProgram.Url, WxProgram.lockUrl, JsonConvert.SerializeObject(new
            {
                openid = openid,
                tableno = tableno,
                out_order_id = out_order_id,
                table_sno = table_sno,
                identify = identify
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        /// <summary>
        /// 后付支付清台
        /// </summary>
        /// <returns></returns>
        [Route("api/wxprogram/pay")]
        [HttpPost]
        public MessageModel pay()
        {
            var res = HttpClientHelper.Post(WxProgram.Url, WxProgram.pay, JsonConvert.SerializeObject(new
            {

            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        /// <summary>
        /// 解锁桌台
        /// </summary>
        /// <param name="out_order_id"></param>
        /// <returns></returns>
        [Route("api/wxprogram/orderUnlock")]
        [HttpPost]
        public MessageModel orderUnlock(string out_order_id)
        {
            var res = HttpClientHelper.Post(WxProgram.Url, WxProgram.orderUnlock, JsonConvert.SerializeObject(new
            {
                out_order_id = out_order_id
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        /// <summary>
        /// 先付门店计算金额
        /// </summary>
        /// <param name="out_order_id"></param>
        /// <returns></returns>
        [Route("api/wxprogram/preCalculation")]
        [HttpPost]
        public MessageModel preCalculation(string out_order_id)
        {
            var res = HttpClientHelper.Post(WxProgram.Url, WxProgram.preCalculation, JsonConvert.SerializeObject(new
            {
                out_order_id = out_order_id
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        /// <summary>
        /// 先付结账清台接口
        /// </summary>
        /// <param name="identify"></param>
        /// <returns></returns>
        [Route("api/wxprogram/prePay")]
        [HttpPost]
        public MessageModel prePay(string identify)
        {
            Models.WxProgramOrderInfo.wlife wlife = new Models.WxProgramOrderInfo.wlife();
            List<Models.WxProgramOrderInfo.pay_list> pay_Info = new List<pay_list>();
            Models.WxProgramOrderInfo.data data = new Models.WxProgramOrderInfo.data();
            Models.WxProgramOrderInfo.discount_info discount_Info = new Models.WxProgramOrderInfo.discount_info();
            Models.WxProgramOrderInfo.member member = new Models.WxProgramOrderInfo.member();
            Models.WxProgramOrderInfo.ordermemo ordermemo = new Models.WxProgramOrderInfo.ordermemo();
            List<Models.WxProgramOrderInfo.normalitems> normalitem = new List<Models.WxProgramOrderInfo.normalitems>();
            Models.WxProgramOrderInfo.saulPayPull saulPayPull = new Models.WxProgramOrderInfo.saulPayPull();
            WxProgramOrderInfo order_Info = new WxProgramOrderInfo()
            {
                balance = "",
                brand_id = "",
                business_id = "",
                cost = 0,
                cpqflag = "",
                cpqRules = "",
                credit = "",
                discountable = 0,
                discounts = new string[] { },
                discount_info = discount_Info,
                djqflag = "",
                djqRules = "",
                id = "",
                identify = "",
                mealfee = 0,
                member = member,
                membercouponsprice = 0,
                msgId = "",
                normalitems = normalitem,
                ordermemo = ordermemo,
                out_order_id = "",
                people = "",
                saulPayPull = saulPayPull,
                setmeal = new string[] { },
                shop_name = "",
                tableno = "",
                total = 0,
                update_time = "",
                weiXinPay = ""
            };

            pay_infos pay_info = new pay_infos()
            {
                action = "",
                address = "",
                create_time = 0,
                create_time_str = "",
                data = data,
                pay_info = pay_Info,
                table = "",
                type = "",
                wlife = wlife
            };

            var res = HttpClientHelper.Post(WxProgram.Url, WxProgram.prePay, JsonConvert.SerializeObject(new
            {
                identify = identify
            }));

            if (res.IndexOf("0") >= 0) //重新推送
            {
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(1 * 1000);
                    res = HttpClientHelper.Post(WxProgram.Url, WxProgram.prePay, JsonConvert.SerializeObject(new
                    {
                        identify = identify,
                        order_info = order_Info,
                        pay_info = pay_info
                    }));
                    if (i == 2 && res.IndexOf("0") >= 0) //推送三次失败 订单异常
                    {
                        return new MessageModel() { Code = 0, data = null, Message = "订单异常" };
                    }
                    if (res.IndexOf("0") >= 0)
                    {
                        continue;
                    }
                    else
                    {
                        return new MessageModel() { Code = 0, data = null, Message = res };
                    }
                }
            }

            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        /// <summary>
        /// 订单等待状态接口
        /// </summary>
        /// <param name="outorderid"></param>
        /// <returns></returns>
        [Route("api/wxprogram/orderWaitStatus")]
        [HttpPost]
        public MessageModel orderWaitStatus(string outorderid)
        {
            var res = HttpClientHelper.Post(WxProgram.Url, WxProgram.orderWaitStatus, JsonConvert.SerializeObject(new
            {
                outorderid = outorderid
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        [Route("api/wxprogram/Test")]
        [HttpGet]
        public string Test()
        {
            return "31230312";
        }
        #endregion
    }
}
