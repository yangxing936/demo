using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OrderInfo
    {
        public string identify { get; set; }
        public string out_order_id { get; set; }
        public string people { get; set; }
        public string tableno { get; set; }
        public string ordermemo { get; set; }
        public List<normalitems> normalitems { get; set; }
        public List<setmeal> setmeal { get; set; }
        public member member { get; set; }
    }
    public class ordermemo
    {
        public Array id { get; set; }
        public string text { get; set; }
    }
    public class normalitems
    {
        public int did { get; set; }
        public string dishsno { get; set; }
        public string name { get; set; }
        public int duid { get; set; }
        public string dishunit { get; set; }
        public int count { get; set; }
        public int number { get; set; }
        public float price { get; set; }
        public string orgprice { get; set; }
        public float memberprice { get; set; }
        public string dishimg { get; set; }
        public cooks cooks { get; set; }
        public int type { get; set; }
        public string membergid { get; set; }
        public int bgift { get; set; }
        public int isWeigh { get; set; }
        public int bmemberprice { get; set; }
        public int bargainprice { get; set; }
        public int aprice { get; set; }
        public int pkid { get; set; }
        public string remark { get; set; }
        public string bbuySno { get; set; }
        public string bgiftSno { get; set; }
        public bool cpqflag { get; set; }
        public string activity { get; set; }
        public string memo { get; set; }
        public int centPrice { get; set; }
    }
    public class cooks
    {
        public string aprice { get; set; }
        public string id { get; set; }
        public string cook { get; set; }
    }
    public class member
    {
        public string openid { get; set; }
        public string name { get; set; }
        public string mobile { get; set; }
        public string cno { get; set; }
        public int sex { get; set; }
        public string birthday { get; set; }
        public string grade { get; set; }
        public string grade_name { get; set; }
        public int credit { get; set; }
        public int balance { get; set; }
        public string unionid { get; set; }
    }
    public class setmeal 
    {
        public int did { get; set; }
        public string dishsno { get; set; }
        public string name { get; set; }
        public int pkid { get; set; }
        public string dishimg { get; set; }
        public int type { get; set; }
        public Array membergid { get; set; }
        public int number { get; set; }
        public float price { get; set; }
        public float memberprice { get; set; }
        public float orgprice { get; set; }
        public float aprice { get; set; }
        public float realprice { get; set; }
        public int bgift { get; set; }
        public int isWeigh { get; set; }
        public string bbuySno { get; set; }
        public string bgiftSno { get; set; }
        public int bmemberprice { get; set; }
        public int bargainprice { get; set; }
        public List<maindish> maindish { get; set; }
        public List<mandatory> mandatory { get; set; }
        public List<optional> optional { get; set; }
        public string activity { get; set; }
    }
    public class maindish 
    {
        public int name { get; set; }
        public int number { get; set; }
        public int id { get; set; }
        public int duid { get; set; }
        public int dishsno { get; set; }
        public int practiceid { get; set; }
    }
    public class mandatory 
    {
    
    }
    public class optional 
    {
    
    }

    public class storeOrderInfo
    {
        public string identify { get; set; }
        public string out_order_id { get; set; }
        public string mobile { get; set; }
        public int people { get; set; }
        public string tableno { get; set; }
        public string meal_number { get; set; }
        public string ordermemo { get; set; }
        public string openid { get; set; }
        public string name { get; set; }
        public float total { get; set; }
        public float cost { get; set; }
        public float vipcost { get; set; }
        public int shop_id { get; set; }
        public upgrade upgrade { get; set; }
        public float mealfee { get; set; }
        public List<normalitems> normalitems { get; set; }
        public List<setmeal> setmeal { get; set; }
        public int brand_id { get; set; }
        public int business_id { get; set; }
        public string shop_name { get; set; }
        //public string pkid { get; set; }
        public float discount_money { get; set; }
        public float memberPrice { get; set; }
        public float weiXinPay { get; set; }
        public float balance { get; set; }
        public int credit { get; set; }
        public discount_info discount_info { get; set; }
        public vip_discount vip_discount { get; set; }
        /// <summary>
        /// 大众营销活动数据 汇付有 N
        /// </summary>
        public List<promotions> promotions { get; set; }
        public List<discounts> discounts { get; set; }
        public List<serviceCharge> serviceCharge { get; set; }
    }
    public class upgrade
    {
        public int cardnum { get; set; }
        public int orginlevel { get; set; }
        public string level { get; set; }
        public int gradeamount { get; set; }
    }

    public class discount_info 
    {
    
    }
    public class vip_discount 
    {
    
    }

    public class promotions 
    {
        public int id { get; set; }
        public string title { get; set; }
        public string money { get; set; }
        public string dishsno { get; set; }
    }

    public class discounts 
    {
        public int? dsid { get; set; }
        public string title { get; set; }
        public float money { get; set; }
        public int type { get; set; }
        public int? rules { get; set; }
        public int? memberPriceType { get; set; }
    }
    public class serviceCharge 
    {
        public string title { get; set; }
        public int money { get; set; }
    }
    public class data 
    {
        public string oid { get; set; }
        public string source { get; set; }
        public int amount { get; set; }
        public string invoice { get; set; }
        public string invoice_price { get; set; }
        public discounts discount_info { get; set; }
        public string memberPrice { get; set; }
        public Array cpq_info { get; set; }
        
    }
    public class pay_info 
    {
        public string source { get; set; }
        public string amount { get; set; }
        public int storepay { get; set; }
        public string serilNo { get; set; }

    }
    public class wlife 
    {
        public string cno { get; set; }
        public string grade { get; set; }
        public string name { get; set; }
        public string grade_name { get; set; }
        public string balance { get; set; }
        public string credit { get; set; }
        public string receive_credit { get; set; }
        public string receive_coupons { get; set; }
    }
    public class dishs 
    {
        public string did { get; set; }
        public string dishsno { get; set; }
        public string name { get; set; }
        public string normalname { get; set; }
        public string duid { get; set; }
        public int number { get; set; }
        public int count { get; set; }
        public string dishunit { get; set; }
        public string centPrice { get; set; }
        public string price { get; set; }
        public string orgprice { get; set; }
        public int isWeigh { get; set; }
        public float memberprice { get; set; }
        public string dishimg { get; set; }
        public Array cooks { get; set; }
        public string bgift { get; set; }
        public string bbuySno { get; set; }
        public string bgiftSno { get; set; }
        public float bmemberprice { get; set; }
        public string bargainprice { get; set; }
        public float aprice { get; set; }
        public string pkid { get; set; }
        public int type { get; set; }
        public Array membergid { get; set; }
        public bool cpqflag { get; set; }
        public string cpqRules { get; set; }
        public int cpqhasbeen { get; set; }
        public Array cpqDeno { get; set; }
        public string remark { get; set; }
    }

    public class datas 
    {
        public string shopKey { get; set; }
        public string out_order_id { get; set; }
        public string sign { get; set; }
    }

    public class dishes 
    {
        public string dishsno { get; set; }
        public string dishname { get; set; }
        public int price { get; set; }
    }
}
