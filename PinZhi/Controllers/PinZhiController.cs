using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Web.Http;
using Models;
using Newtonsoft.Json;

namespace PinZhi.Controllers
{
    public class PinZhiController : ApiController
    {

        #region 点餐平台调用门店pos接口

        [Route("api/pinzhi/BserInfo")]
        [HttpPost]
        public MessageModel BserInfo(int shop_id, string tableno)
        {
            var res = HttpClientHelper.Post(StoreUrlModel.Url, StoreUrlModel.baseInfo, JsonConvert.SerializeObject(new
            {
                shop_id = shop_id,
                tableno = tableno
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        [Route("api/pinzhi/shopBaseInfo")]
        [HttpPost]
        public MessageModel shopBaseInfo(int shop_id, string tableno)
        {
            var res = HttpClientHelper.Post(StoreUrlModel.Url, StoreUrlModel.shopBaseInfo, JsonConvert.SerializeObject(new
            {
                shop_id = shop_id,
                tableno = tableno
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        [Route("api/pinzhi/shopStatus")]
        [HttpPost]
        public MessageModel shopStatus(int shop_id)
        {
            var res = HttpClientHelper.Post(StoreUrlModel.Url, StoreUrlModel.shopStatus, JsonConvert.SerializeObject(new
            {
                shop_id = shop_id
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        [Route("api/pinzhi/clearDish")]
        [HttpPost]
        public MessageModel clearDish()
        {
            var res = HttpClientHelper.Post(StoreUrlModel.Url, StoreUrlModel.clearDish, "");
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        [Route("api/pinzhi/orderPrecheck")]
        [HttpPost]
        public MessageModel orderPrecheck(string out_order_id)
        {
            List<normalitems> normalitems = new List<normalitems>();
            List<setmeal> setmeals = new List<setmeal>();
            member member = new member();


            order_info order_Info = new order_info()
            {
                identify = "",
                member = member,
                normalitems = normalitems,
                ordermemo = "",
                out_order_id = "",
                people = "",
                setmeal = setmeals,
                tableno = ""
            };
            var res = HttpClientHelper.Post(StoreUrlModel.Url, StoreUrlModel.orderPrecheck, "");
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        [Route("api/pinzhi/firstPay")]
        [HttpPost]
        public MessageModel firstPay(string out_order_id)
        {

            List<discounts> discounts = new List<discounts>();
            discount_info discount_Info = new discount_info();
            List<normalitems> normalitems = new List<normalitems>();
            upgrade upgrade = new upgrade();
            vip_discount vip_Discount = new vip_discount();
            List<setmeal> setmeals = new List<setmeal>();
            List<serviceCharge> serviceCharges = new List<serviceCharge>();
            List<promotions> promotions = new List<promotions>();

            storeOrderInfo storeOrderInfo = new storeOrderInfo()
            {
                balance = 0,
                brand_id = 1,
                business_id = 1,
                cost = 0,
                credit = 0,
                discounts = discounts,
                discount_info = discount_Info,
                discount_money = 0,
                identify = "",
                mealfee = 0,
                meal_number = "",
                memberPrice = 0,
                mobile = "",
                name = "",
                normalitems = normalitems,
                openid = "",
                ordermemo = "",
                out_order_id = "",
                people = 0,
                promotions = promotions,
                serviceCharge = serviceCharges,
                setmeal = setmeals,
                shop_id = 0,
                shop_name = "",
                tableno = "",
                total = 0,
                upgrade = upgrade,
                vipcost = 0,
                vip_discount = vip_Discount,
                weiXinPay = 0
            };
            var res = HttpClientHelper.Post(StoreUrlModel.Url, StoreUrlModel.firstPay, JsonConvert.SerializeObject(storeOrderInfo));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }
        [Route("api/pinzhi/getOrderinfor")]
        [HttpPost]
        public MessageModel getOrderinfor(string tablesno, string out_order_id)
        {
            var res = HttpClientHelper.Post(StoreUrlModel.Url, StoreUrlModel.getOrderinfor, JsonConvert.SerializeObject(new
            {
                tablesno = tablesno,
                out_order_id = out_order_id
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }
        [Route("api/pinzhi/tableStatus")]
        [HttpPost]
        public MessageModel tableStatus(string tableno, string out_order_id, string oid)
        {
            var res = HttpClientHelper.Post(StoreUrlModel.Url, StoreUrlModel.tableStatus, JsonConvert.SerializeObject(new
            {
                tableno = tableno,
                out_order_id = out_order_id,
                oid = oid
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }
        [Route("api/pinzhi/order")]
        [HttpPost]
        public MessageModel order(string out_order_id, string openid, string order_batch_id = null)
        {
            string json = "";

            List<normalitems> normalitems = new List<normalitems>();
            List<setmeal> setmeals = new List<setmeal>();
            member member = new member();

            order_info order_Info = new order_info()
            {
                identify = "",
                member = member,
                normalitems = normalitems,
                ordermemo = "",
                out_order_id = "",
                people = "",
                setmeal = setmeals,
                tableno = ""
            };

            if (!string.IsNullOrEmpty(order_batch_id))
            {
                json = JsonConvert.SerializeObject(new
                {
                    out_order_id = out_order_id,
                    openid = openid,
                    order_Info = order_Info,
                    order_batch_id = order_batch_id
                });
            }
            else
            {
                json = JsonConvert.SerializeObject(new
                {
                    out_order_id = out_order_id,
                    openid = openid,
                    order_Info = order_Info
                });
            }

            var res = HttpClientHelper.Post(StoreUrlModel.Url, StoreUrlModel.order, json);
            return new MessageModel() { Code = 0, data = null, Message = res };
        }
        [Route("api/pinzhi/uploadOrders")]
        [HttpPost]
        public MessageModel uploadOrders(string tableno, string out_order_id)
        {
            member member = new member();
            var res = HttpClientHelper.Post(StoreUrlModel.Url, StoreUrlModel.uploadOrders, JsonConvert.SerializeObject(new
            {
                tableno = tableno,
                out_order_id = out_order_id,
                member = JsonConvert.SerializeObject(member)
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }
        [Route("api/pinzhi/payOrder")]
        [HttpPost]
        public MessageModel payOrder(string tableno)
        {
            discounts discounts = new discounts();
            data data = new data()
            {
                amount = 0,
                cpq_info = new string[] { },
                discount_info = discounts,
                invoice = "",
                invoice_price = "",
                memberPrice = "",
                oid = "",
                source = ""
            };
            pay_info pay_info = new pay_info()
            {
                amount = "",
                source = "",
                serilNo = "",
                storepay = 0
            };
            wlife wlife = new wlife()
            {
                balance = "",
                cno = "",
                credit = "",
                grade = "",
                grade_name = "",
                name = "",
                receive_coupons = "",
                receive_credit = ""
            };
            var res = HttpClientHelper.Post(StoreUrlModel.Url, StoreUrlModel.payOrder, JsonConvert.SerializeObject(new
            {
                tableno = tableno,
                data = data,
                pay_info = pay_info,
                wlife = wlife
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }
        [Route("api/pinzhi/unlockOrder")]
        [HttpPost]
        public MessageModel unlockOrder(string out_order_id)
        {
            var res = HttpClientHelper.Post(StoreUrlModel.Url, StoreUrlModel.unlockOrder, JsonConvert.SerializeObject(new
            {
                out_order_id = out_order_id
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }



        #endregion

        #region 门店pos调用点餐平台接口


        [Route("api/pinzhi/BserInfo")]
        [HttpPost]
        public MessageModel completeOrder(string out_order_id, string meal_number)
        {
            var res = HttpClientHelper.Post(StoreUrlModel.Url_Program, StoreUrlModel.completeOrder, JsonConvert.SerializeObject(new
            {
                out_order_id = out_order_id,
                meal_number = meal_number
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        [Route("api/pinzhi/uploadOrder")]
        [HttpPost]
        public MessageModel uploadOrder(string out_order_id, string msgBody = "订单发生变化")
        {
            List<discounts> discounts = new List<discounts>();
            discount_info discount_Info = new discount_info();
            List<normalitems> normalitems = new List<normalitems>();
            upgrade upgrade = new upgrade();
            vip_discount vip_Discount = new vip_discount();
            List<setmeal> setmeals = new List<setmeal>();
            List<serviceCharge> serviceCharges = new List<serviceCharge>();
            List<promotions> promotions = new List<promotions>();

            storeOrderInfo storeOrderInfo = new storeOrderInfo()
            {
                balance = 0,
                brand_id = 1,
                business_id = 1,
                cost = 0,
                credit = 0,
                discounts = discounts,
                discount_info = discount_Info,
                discount_money = 0,
                identify = "",
                mealfee = 0,
                meal_number = "",
                memberPrice = 0,
                mobile = "",
                name = "",
                normalitems = normalitems,
                openid = "",
                ordermemo = "",
                out_order_id = "",
                people = 0,
                promotions = promotions,
                serviceCharge = serviceCharges,
                setmeal = setmeals,
                shop_id = 0,
                shop_name = "",
                tableno = "",
                total = 0,
                upgrade = upgrade,
                vipcost = 0,
                vip_discount = vip_Discount,
                weiXinPay = 0
            };

            var res = HttpClientHelper.Post(StoreUrlModel.Url_Program, StoreUrlModel.uploadOrder, JsonConvert.SerializeObject(new
            {
                out_order_id = out_order_id,
                msgBody = msgBody,
                order_info = storeOrderInfo
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        [Route("api/pinzhi/unlockOrder_Program")]
        [HttpPost]
        public MessageModel unlockOrder_Program(string out_order_id)
        {
            var res = HttpClientHelper.Post(StoreUrlModel.Url_Program, StoreUrlModel.unlockOrder_Program, JsonConvert.SerializeObject(new
            {
                out_order_id = out_order_id
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        [Route("api/pinzhi/changeTable")]
        [HttpPost]
        public MessageModel changeTable(string out_order_id, string table_sno)
        {
            var res = HttpClientHelper.Post(StoreUrlModel.Url_Program, StoreUrlModel.changeTable, JsonConvert.SerializeObject(new
            {
                out_order_id = out_order_id,
                table_sno = table_sno
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        [Route("api/pinzhi/combineTable")]
        [HttpPost]
        public MessageModel combineTable(string out_order_id, string table_sno)
        {
            var res = HttpClientHelper.Post(StoreUrlModel.Url_Program, StoreUrlModel.combineTable, JsonConvert.SerializeObject(new
            {
                out_order_id = out_order_id,
                table_sno = table_sno
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        [Route("api/pinzhi/sold_out")]
        [HttpPost]
        public MessageModel sold_out(int shop_id)
        {
            dishs dishs = new dishs()
            {
                aprice = 0,
                bargainprice = "",
                bbuySno = "",
                bgift = "",
                bgiftSno = "",
                bmemberprice = 0,
                centPrice = "",
                cooks = new string[] { },
                count = 0,
                cpqDeno = new string[] { },
                cpqflag = false,
                cpqhasbeen = 0,
                cpqRules = "",
                did = "",
                dishimg = "",
                dishsno = "",
                dishunit = "",
                duid = "",
                isWeigh = 0,
                membergid = new string[] { },
                memberprice = 0,
                name = "",
                normalname = "",
                number = 0,
                orgprice = "",
                pkid = "",
                price = "",
                remark = "",
                type = 0

            };
            var res = HttpClientHelper.Post(StoreUrlModel.Url_Program, StoreUrlModel.sold_out, JsonConvert.SerializeObject(new
            {
                shop_id = shop_id,
                dishs = JsonConvert.SerializeObject(dishs)
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        [Route("api/pinzhi/calcel")]
        [HttpPost]
        public MessageModel calcel(int shop_id)
        {
            dishs dishs = new dishs()
            {
                aprice = 0,
                bargainprice = "",
                bbuySno = "",
                bgift = "",
                bgiftSno = "",
                bmemberprice = 0,
                centPrice = "",
                cooks = new string[] { },
                count = 0,
                cpqDeno = new string[] { },
                cpqflag = false,
                cpqhasbeen = 0,
                cpqRules = "",
                did = "",
                dishimg = "",
                dishsno = "",
                dishunit = "",
                duid = "",
                isWeigh = 0,
                membergid = new string[] { },
                memberprice = 0,
                name = "",
                normalname = "",
                number = 0,
                orgprice = "",
                pkid = "",
                price = "",
                remark = "",
                type = 0

            };
            var res = HttpClientHelper.Post(StoreUrlModel.Url_Program, StoreUrlModel.calcel, JsonConvert.SerializeObject(new
            {
                shop_id = shop_id,
                dishs = JsonConvert.SerializeObject(dishs)
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        [Route("api/pinzhi/orderQuit")]
        [HttpPost]
        public MessageModel orderQuit(string out_order_id)
        {
            var res = HttpClientHelper.Post(StoreUrlModel.Url_Program, StoreUrlModel.orderQuit, JsonConvert.SerializeObject(new
            {
                out_order_id = out_order_id
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        [Route("api/pinzhi/refund")]
        [HttpPost]
        public MessageModel refund(string data)
        {
            //POST form
            string appkey = "";
            string out_order_id = "";
            appkey = Common.Create(appkey);
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic[$"{out_order_id}"] = out_order_id;
            appkey = $"{appkey}" + "#" + $"{JsonConvert.SerializeObject(dic)}";

            byte[] bytes = Encoding.Default.GetBytes(appkey);
            var sign = Convert.ToBase64String(bytes);

            datas datas = new datas()
            {
                out_order_id = "",
                shopKey = "",
                sign = sign
            };

            var res = HttpClientHelper.Post_from(StoreUrlModel.Url_Program, StoreUrlModel.refund, Common.data(datas));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        [Route("api/pinzhi/sendmealmsg")]
        [HttpPost]
        public MessageModel sendmealmsg(string orderId)
        {
            var res = HttpClientHelper.Get(StoreUrlModel.Url_Program, StoreUrlModel.sendmealmsg + $"{orderId}");
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        [Route("api/pinzhi/synchrodataDish")]
        [HttpPost]
        public MessageModel synchrodataDish(string type, int sid, string sign, string force)
        {
            var res = HttpClientHelper.Post(StoreUrlModel.Url_Program, StoreUrlModel.synchrodataDish_com, "");
            return new MessageModel() { Code = 0, data = null, Message = res };
        }
        [Route("api/pinzhi/getPayStatus")]
        [HttpPost]
        public MessageModel getPayStatus(int orderId)
        {
            string sign = "";
            var res = HttpClientHelper.Post(StoreUrlModel.Url_Program, StoreUrlModel.getPayStatus_com, JsonConvert.SerializeObject(new
            {
                orderId = orderId,
                sign = sign
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        [Route("api/pinzhi/separateOrder")]
        [HttpPost]
        public MessageModel separateOrder(int out_order_id)
        {
            string sign = "";
            var res = HttpClientHelper.Post(StoreUrlModel.Url_Program, StoreUrlModel.separateOrder_com, JsonConvert.SerializeObject(new
            {
                out_order_id = out_order_id
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }


        [Route("api/pinzhi/list")]
        [HttpPost]
        public MessageModel list(string bid)
        {
            var res = HttpClientHelper.Get(StoreUrlModel.Url_Program, StoreUrlModel.completeOrder_com + $"?bid={bid}");
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        [Route("api/pinzhi/lockOrder")]
        [HttpPost]
        public MessageModel lockOrder(string out_order_id)
        {
            var res = HttpClientHelper.Post(StoreUrlModel.Url_Program, StoreUrlModel.lockOrder_com, JsonConvert.SerializeObject(new
            {
                out_order_id = out_order_id
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        [Route("api/pinzhi/changeOrderDishMsg")]
        [HttpPost]
        public MessageModel changeOrderDishMsg(string out_order_id, string time, string msg = "商家已退菜")
        {
            List<dishes> dishes = new List<dishes>();
            var res = HttpClientHelper.Post(StoreUrlModel.Url_Program, StoreUrlModel.changeOrderDishMsg + $"{out_order_id}", JsonConvert.SerializeObject(new
            {
                time = time,
                msg = msg,
                dishes = dishes
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        [Route("api/pinzhi/huifuChargeCancel")]
        [HttpPost]
        public MessageModel huifuChargeCancel(int charge_id, int cashier_id, int handlerId)
        {
            var res = HttpClientHelper.Post(StoreUrlModel.Url_Program, StoreUrlModel.huifuChargeCancel, JsonConvert.SerializeObject(new
            {
                charge_id = charge_id,
                cashier_id = cashier_id,
                handlerId = handlerId
            }));
            return new MessageModel() { Code = 0, data = null, Message = res };
        }

        [Route("api/pinzhi/payInfo")]
        [HttpPost]
        public MessageModel payInfo(string out_order_id)
        {
            var res = HttpClientHelper.Get(StoreUrlModel.payInfo_baseUrl, StoreUrlModel.payInfo_url + $"{out_order_id}");
            return new MessageModel() { Code = 0, data = null, Message = res };
        }
        #endregion

        #region 小程序调门店接口

        #endregion


    }
}
