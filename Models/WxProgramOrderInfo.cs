using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.WxProgramOrderInfo
{
    public class WxProgramOrderInfo
    {
        public string identify { get; set; }
        public string tableno { get; set; }
        public string brand_id { get; set; }
        public string business_id { get; set; }
        public string shop_name { get; set; }
        public ordermemo ordermemo { get; set; }
        public member member { get; set; }
        public float total { get; set; }
        public float cost { get; set; }
        public string people { get; set; }
        public float mealfee { get; set; }
        public float discountable { get; set; }
        public float membercouponsprice { get; set; }
        public string djqflag { get; set; }
        public string djqRules { get; set; }
        public string cpqflag { get; set; }
        public string cpqRules { get; set; }
        public discount_info discount_info { get; set; }
        public Array discounts { get; set; }
        public Array setmeal { get; set; }
        public List<normalitems> normalitems { get; set; }
        public string weiXinPay { get; set; }
        public string balance { get; set; }
        public string credit { get; set; }
        public string update_time { get; set; }
        public saulPayPull saulPayPull { get; set; }
        public string id { get; set; }
        public string msgId { get; set; }
        public string out_order_id { get; set; }
    }
    public class ordermemo
    {
        public Array id { get; set; }
        public string text { get; set; }
    }
    public class member
    {
        public string openid { get; set; }
        public string name { get; set; }
        public string mobile { get; set; }
        public string cno { get; set; }
        public string grade { get; set; }
        public float credit { get; set; }
        public float ratio { get; set; }
        public float balance { get; set; }
        public string viptype { get; set; }
    }
    public class discount_info
    {
        public float dsid { get; set; }
        public string title { get; set; }
        public float money { get; set; }
        public float type { get; set; }
        public string rules { get; set; }
        public float memberPriceType { get; set; }
    }
    public class normalitems
    {
        public float did { get; set; }
        public string dishsno { get; set; }
        public string name { get; set; }
        public string pkid { get; set; }
        public string normalname { get; set; }
        public float duid { get; set; }
        public float type { get; set; }
        public Array membergid { get; set; }
        public float number { get; set; }
        public float price { get; set; }
        public float orgprice { get; set; }
        public float memberprice { get; set; }
        public string dishimg { get; set; }
        public cooks cooks { get; set; }
        public toppingorders toppingorders { get; set; }
    }
    public class cooks
    {
        public float id { get; set; }
        public string name { get; set; }
        public float aprice { get; set; }
    }
    public class toppingorders
    {
        public float tpid { get; set; }
        public float count { get; set; }
        public float isfree { get; set; }
    }
    public class saulPayPull
    {

    }
    public class pay_infos
    {
        public string type { get; set; }
        public string action { get; set; }
        public string address { get; set; }
        public string table { get; set; }
        public long create_time { get; set; }
        public string create_time_str { get; set; }
        public data data { get; set; }
        public List<pay_list> pay_info { get; set; }
        public wlife wlife { get; set; }
    }
    public class data
    {
        public string oid { get; set; }
        public string source { get; set; }
        public string amount { get; set; }
        public string invoice { get; set; }
        public string invoice_price { get; set; }
        public discount_info discount_info { get; set; }
        public float memberPrice { get; set; }
        public Array cpq_info { get; set; }
        public string trade_alarm { get; set; }
        public string pay_info { get; set; }
        public string MyProperty { get; set; }
    }
    public class pay_list 
    {
        public string source { get; set; }
        public float amount { get; set; }
        public float storepay { get; set; }
        public string serilNo { get; set; }
    }
    public class wlife 
    {
        public string cno { get; set; }
        public string name { get; set; }
        public string grade { get; set; }
        public string grade_name { get; set; }
        public string balance { get; set; }
        public string credit { get; set; }
    }
}
