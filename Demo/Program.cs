using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Threading;
using System.Data.SqlClient;
using System.Drawing;
using ThoughtWorks.QRCode.Codec;
using System.Runtime.CompilerServices;
using System.IO;
using System.Drawing.Imaging;
using NPOI.XWPF.UserModel;
using System.Xml;
using System.Reflection;
using System.ComponentModel;
using Models;
using Org.BouncyCastle.Utilities.Encoders;
using SqlSugar;
using Dos.ORM;
using System.Net.Http;
using System.Net;
using System.Collections;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace Demo
{
    class Program
    {

        static void Main(string[] args)
        {
            #region

            //string json11111 = "{\"systemId\":\"5011016\",\"sign\":\"9bc3101ecbb733f6224aeb0c430f17fa\",\"content\":{\"order\":{\"cardNo\":\"\",\"isUsePoints\":\"\",\"orderTotalPoints\":\"\",\"memberCode\":\"6610510065\",\"tables\":[],\"serialno\":\"895228e3-1f24-415b-862a-e6bdd48610ff\",\"orderId\":\"2018011115470629634168\",\"bookingOrderCode\":\"\",\"companyCode\":\"f78b89fc-b574-4b86-b079-e98e82a27f18\",\"brandId\":\"f6a2aa93-b364-447c-9ac8-ba792e626c91\",\"shopId\":\"e01845c5-2f26-42b4-8019-9a9ef0acfc64\",\"channelId\":\"1041002\",\"username\":\"微信餐厅顾客\",\"orderPhone\":\"18621703243\",\"city\":\"上海市\",\"address\":\"山西南路350号\",\"addressDetail\":\"\",\"userLng\":\"121.363520016388\",\"userLat\":\"31.165385569443\",\"menuVersion\":\"\",\"productVersion\":\"\",\"categoryVersion\":\"\",\"commissionAmount\":\"0\",\"businessFavourableAmount\":\"0\",\"platformFavourableAmount\":\"0\",\"favourableAmount\":\"0\",\"businessAmount\":\"7.0\",\"orderNumber\":\"1\",\"coordType\":\"5\",\"tableFor\":\"\",\"dineType\":\"2\",\"deliveryrouteFees\":\"0\",\"deliveryrouteName\":\"\",\"deliveryroutePhone\":\"\",\"deliveryrouteStatus\":\"\",\"orderTime\":\"2018-01-11}]}]}}}";

            //var str11111 = JsonConvert.DeserializeObject<Dictionary<string, object>>(json11111);




            //var data11111 = JsonConvert.DeserializeObject<SortedDictionary<string, object>>(json11111);
            //data11111.OrderBy(s => s.Key);
            //var newjson = JsonConvert.SerializeObject(data11111);
            //newjson = newjson + "af385c35708a43e9ad58e68876af9666";


            //string str = "123";
            //str = Md5.GenerateMD5(str);

            //object datas= GetUrlData.Post("http://qa.wiselong.cc/wl-integration-web/sign/valid",newjson);





            //List<Pss> list1 = new List<Pss>();
            //List<Pss> list2 = new List<Pss>();
            //Pss ps = new Pss();

            //for (int i = 0; i < 3; i++)
            //{
            //    ps.v1 = $"{i}";
            //    ps.v2 = i;
            //    list1.Add(ps);
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    Pss pss = new Pss();
            //    pss.v1 = $"{i}";
            //    pss.v2 = i;
            //    list2.Add(pss);

            //}
            //Console.WriteLine("list1");
            //foreach (var item in list1)
            //{

            //    Console.WriteLine(item.v1+"&"+item.v2);
            //}
            //Console.WriteLine("");
            //Console.WriteLine("list2");
            //foreach (var item in list2)
            //{

            //    Console.WriteLine(item.v1 + "&" + item.v2);
            //}





            //NET_IntcptPrt.PrtXml prtXml = new PrtXml();
            //NET_IntcptPrt.PrintHandler printHandler = new PrintHandler();
            //var res= printHandler.PrintXML(2, "<PRINTLINE>电子发票：</PRINTLINE><PRINTCENTERED>请使用微信扫描以下二维码,二维码有效期为30</PRINTCENTERED><PRINTCENTERED>天,如您需要当日发票,请务必在消费当日申请  </PRINTCENTERED><PRINTCENTERED>Pls scan QR code with WeChat if you need     </PRINTCENTERED><PRINTCENTERED>e-invoice.QRCode valid for 30days.           </PRINTCENTERED><PRINTCENTERED>E-invoice application date will be stated     </PRINTCENTERED><PRINTCENTERED>on E-invoice                                  </PRINTCENTERED><LINEFEED>1</LINEFEED><PRINTBITMAP><PATH>parkingqr.bmp</PATH><SIZE>1</SIZE><JUSTIFY>1</JUSTIFY></PRINTBITMAP><CUT>PARTIAL</CUT>");
            //string[] arr_str = { @"##0120QN=20200828190600000;ST=27;CN=2011;PW=123456;MN=18AAH;Flag=4;CP=&&DataTime=20200828190600;a24088-Rtd=0.0,a24088-Flag=F&&B981", @"【2020-08-28 19:10:34:044】##0120QN=20200828191000000;ST=27;CN=2011;PW=123456;MN=18AAH;Flag=4;CP=&&DataTime=20200828191000;a24088-Rtd=0.0,a24088-Flag=F&&B981", @"【Receive from 39.144.1.122 : 17206】：" };

            //cn=2011,2051,2061,2031  ,DataTime=时间  a24088-Rtd=  a24088-Flag=


            //StringBuilder builder = new StringBuilder();
            //var index_number_lenght = "CN=2011;".Length;
            //var index_datetime_lenght = "DataTime=20200828191000;".Length;
            //var index_a24088Rtd_lenght = "a24088-Rtd=0.0,".Length;
            //var index_a24088Flag_lenght = "a24088-Flag=F&&B981".Length;
            //for (int i = 0; i < arr_str.Length; i++)
            //{
            //    var index_2011 = arr_str[i].IndexOf("CN=2011;");
            //    var index_2051 = arr_str[i].IndexOf("CN=2015;");
            //    var index_2061 = arr_str[i].IndexOf("CN=2061;");
            //    var index_2031 = arr_str[i].IndexOf("CN=2031;");
            //    var index_datetime = arr_str[i].IndexOf("DataTime");
            //    var index_a24088Rtd = arr_str[i].IndexOf("a24088-Rtd");
            //    var index_a24088Flag = arr_str[i].IndexOf("a24088-Flag");
            //    var arr_str_lenght = arr_str[i].Length;
            //    if (index_2011>0)
            //    {
            //        var newstr1= arr_str[i].Substring(index_2011, index_number_lenght);
            //        builder.Append(newstr1);
            //    }
            //    if ( index_2051 > 0)
            //    {
            //        var newstr2 = arr_str[i].Substring(index_2051, index_number_lenght);
            //        builder.Append(newstr2);
            //    }
            //    if (index_2061 > 0 )
            //    {
            //        var newstr3 = arr_str[i].Substring(index_2061, index_number_lenght);
            //        builder.Append(newstr3);
            //    }
            //    if (index_2031 > 0)
            //    {
            //        var newstr4 = arr_str[i].Substring(index_2031, index_number_lenght);
            //        builder.Append(newstr4);
            //    }
            //    if (index_datetime>0)
            //    {
            //        var newstr5 = arr_str[i].Substring(index_datetime, index_datetime_lenght);
            //        builder.Append(newstr5);
            //    }
            //    if (index_a24088Rtd > 0)
            //    {
            //        var newstr6 = arr_str[i].Substring(index_a24088Rtd, index_a24088Rtd_lenght);
            //        builder.Append(newstr6);
            //    }
            //    if (index_a24088Flag > 0)
            //    {
            //        var newstr7 = arr_str[i].Substring(index_a24088Flag, index_a24088Flag_lenght);
            //        builder.Append(newstr7);
            //    }
            //    DataTable dataTable = new DataTable("测试");
            //    DataRow dataRow = dataTable.NewRow();
            //    dataRow[0]= builder.ToString();
            //    //此处把字符串赋值 

            //}



            //string filePath = @"C:\Users\Administrator\Documents\WeChat Files\wxid_xfdrxmnamarl22\FileStorage\File\2020-09\601.xls";

            //DataTable dataTable = ExcelHelper.ExcelToDataTable(filePath, 0, 0, out var msg);

            //DataTable data = dataTable.Clone();

            //foreach (DataRow item in dataTable.Rows)
            //{

            //    string ss = item[0].ToString();
            //    if (ss.Contains("##") || ss.Contains("CN=2011") || ss.Contains("CN=2051") || ss.Contains("CN=2061") || ss.Contains("CN=2031") || ss.Contains("DataTime=") || ss.Contains("a24088-Rtd=") || ss.Contains("a24088-Flag"))
            //    {


            //        data.ImportRow(item);
            //        string path = @"C:\Users\Administrator\Documents\WeChat Files\wxid_xfdrxmnamarl22\FileStorage\File\2020-09\601.xls";
            //        ExportExcel.ExportToXSSFExcelFromDataTable(data, path, "测试");
            //    }






            //}

            //var a = "";



            //var data1 = "";
            //HttpClientHelper httpClient = new HttpClientHelper();
            //var res= httpClient.Post("http://invoice.gooagoo.com/", "invoice/decryptDesItem.do?t=20200316123428030&mw=2eVlPdvV5V6pJhhCdSNukKmLHUYJ2TUqh8D/Bzi3MFJowSzicUDmvVxUIE1v0fUnZFTL+K8vE1JzBc1eLyxzUMbiH/HkGekmwdJrqjkFqJg=", data1);



            //Data data1 = new Data()
            //{
            //     I1="1"
            //};
            //var res1 = data1?.I1;



            //var res = Math.Round((20.0 / 18), 2);

            //Data data = new Data()
            //{
            //    I1 = "20200316123428030",//业务流水号
            //    I2 = DateTime.Now.ToString("yyMMdd"),//小票日期
            //    I3 = "0",//税盘分机号
            //    I4 = "1",//发票项目
            //    I5 = "109.00".ToString(),
            //    I6 = "109.00".ToString(),
            //    I7 = "",
            //    I8 = ""

            //};

            //string mw1 = $"I1={data.I1}&I2={data.I2}&I3={data.I3}&I4={data.I4}&I5={data.I5}&I6={data.I6}";//密文(3DES加密)
            //string mw1 = $"I1={data.I1}&I2={data.I2}&I3={data.I3}&I4={data.I4}&I5={data.I5}";//密文(3DES加密)
            //string t = "500102201007206608";//税号

            ////3Des 加密的秘钥由 MD5(税号)前 12 位，后 12 位拼接成 24 位加密 KEY。
            //var md5str = Md5Helper.Create(t); //MD5(税号)
            //string desKey = md5str.Substring(0, 12) + md5str.Substring(md5str.Length - 12, 12);//后 12 位拼接成 24 位加密 KEY
            //string mw = DESHelper.Encrypt3Des(mw1, desKey.ToUpper());//3DES加密 
            //mw = UrlEncode(mw);

            //var newurl = "http://f.gooagoo.com/002/8" + "?t=" + t + "_LW" + "&mw=" + mw+ "Z41onnkrsumCb/Lujlr2sJYOWQlH1JJ2qUmVwHwMfxnGuKPS/zT3JiWoVQsErwI8STuHTT87H2I=";
            //var c = newurl.Length;
            //Bitmap imgCode1 = Create_ImgCode(newurl, 200);
            //SaveImg("C:\\Users\\Administrator\\Desktop\\截图\\", imgCode1, "1", 400, 400);//本地保存图片

            //var a = 1;














            //Thread thread = new Thread(new ThreadStart(Thread1));
            //thread.Start();
            //string[] arr = { "1", "2", "3" };
            //var res= string.Join(",", arr);

            //var s = "123";
            //Program.SetStr(ref s);
            //GC.Collect();
            //Console.WriteLine(s);









            ////http://f.test.goago.cn/002/8?t=91142010202002279F_LW&mw=IpG7emERYNBZJDiiP9ssx1PJtTSxCdA5YB/Fb5iuCiP8cD4DaH4kLd0VXpDldAuDsOjxt73aj5DsNOXZtUmjQ/7KCY2zjqGfCC9t21YUDQpJfDl+kWXd5HJy342INMhl4QgC1j0FDns=
            //var sno = "91142010202002279F";
            //string mw = "IpG7emERYNBZJDiiP9ssx1PJtTSxCdA5YB/Fb5iuCiP8cD4DaH4kLd0VXpDldAuDsOjxt73aj5DsNOXZtUmjQ/ 7KCY2zjqGfCC9t21YUDQpJfDl+kWXd5HJy342INMhl4QgC1j0FDns=";
            //var str = Md5Helper.Create(sno);
            //string desKey = str.Substring(0, 12) + str.Substring(str.Length - 12, 12);//后 12 位拼接成 24 位加密 KEY
            //var data = Decrypt3Des(mw, desKey.ToUpper());



            //            string str = @"<informations> <returnCode>SUCCESS</returnCode> <returnMessage>支付成功</returnMessage> <orders> <order> <storeNum>MJSH009</storeNum><saleDateTime>20170906162000</saleDateTime><tableNum>A08</tableNum><amount>1</amount><orderStatus>PAY_SUC</orderStatus><paymentChannel>97</paymentChannel><receiveAmount>0</receiveAmount><discountAmount>0</discountAmount><channelDiscount>0</channelDiscount>##商家优惠金额 <platformDiscount>0</platformDiscount><subject>满记消费</subject> <orderNo>TCWX1709062044227259582750</orderNo><ticket> <ticketNo>卡券号</ticketNo> <ticketName>卡券名称</ticketName> <ticketType>券类型(1领用券，2抵用券)</ticketType> <ticketTypeNo>券类型编号</ticketTypeNo> <ticketAmount>券金额</ticketAmount> <discountNo>折扣编号（当discount为11位时 他就是商品编 号，当discount小于等于4位时他就是折扣编号）</discountNo> </ticket>
            //<card><transAmt>消费金额</transAmt> <transScore>消费积分</transScore> <restAmt>余额</restAmt> <restScore>剩余积分</restScore></card></order></orders></informations>";
            //            XmlDocument doc = new XmlDocument();
            //            doc.LoadXml(str);
            //            string json = Newtonsoft.Json.JsonConvert.SerializeXmlNode(doc);

            //string json = "{\"f\":\"123\",\"c\":\"1\",\"b\":\"f\",\"gg\":\"r\",\"ee\":\"1\"}";

            //var data= SetSign(json);


            //manjiEnum manji = new manjiEnum();
            //var c = GetEnumDesc(manjiEnum.orderStatus.CLOSED);
            //Console.WriteLine(manjiEnum.orderStatus.CLOSED); 








            //Test1();


            //Thread thread1 = new Thread(Test11);
            //Thread thread2 = new Thread(Test12);
            //Thread thread3 = new Thread(Test13);
            //thread1.Start();
            //thread2.Start();
            //thread3.Start();


            //Thread t1 = new Thread(Test11);
            //Console.WriteLine(("t1线程状态 :" + t1.ThreadState.ToString()));
            //t1.Start();
            //Console.WriteLine(("t1线程状态 :" + t1.ThreadState.ToString()));
            //t1.Join(); //等待线程t1执行完成,程序会在这里阻塞
            //Console.WriteLine(("t1线程状态 :" + t1.ThreadState.ToString()));
            //Console.WriteLine("Thread t1 finished");
            //Console.WriteLine(("t1线程状态 :" + t1.ThreadState.ToString()));

            //string type = "";
            //var itemid = "302001,0,0,0,0,0,0,1048586,0,";
            //var index = itemid.ToString().IndexOf("302001");
            //if (itemid.ToString().IndexOf("302001") >= 0 || itemid.ToString().IndexOf("302002") >= 0 || itemid.ToString().IndexOf("302003") >= 0 || itemid.ToString().IndexOf("302004") >= 0)
            //{
            //    type = "预付卡销售和充值";
            //}
            //else
            //{
            //    type = "餐饮费";
            //}
            //var str = "操作成功2123";
            //var a = str.IndexOf("操作成功");
            //if (str.IndexOf("操作成功") >= 0) 
            //{
            //    str = "1";
            //}

            //decimal a = 0.00m;
            //decimal b = 81.283m;
            //var c = (a / b).ToString("0.##%");

            //var str = "appOrderNo=123";
            //var data = Sign(JsonConvert.SerializeObject(str));


            //LogHelper.Log("123");

            //DateTime dateTime = DateTime.Parse("2020-09-21 11:07:34");
            //System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0));
            //long t = (dateTime.Ticks - startTime.Ticks) / 10000;   //除10000调整为13位      
            //var newa = new
            //{
            //    platformDiscount = 0,
            //    appOrderNo = "182177860581601205431675",
            //    payTime = t,
            //    subject = "HDLY002",
            //    orderStatus = "PAY_SUC",
            //    discountAmount = 0,
            //    channelDiscount = 0,
            //    paymentWay = "QRCODE",
            //    buyerId = "o5WHe4qfPGsplEAPbh2myqNuRtLo",
            //    outOrderNo = "4200000678202009188094601099",
            //    paymentChannel = "WECHAT",
            //    localOrderNo = "TCWX2009181730594053900616",
            //    totalAmount = 1,
            //    receiveAmount = 1
            //};

            //var res1 = JsonConvert.SerializeObject(newa);
            //var newstr = Sign(res1);

            //var res22 = HttpPostForm.FormHttpPost("http://localhost:51114/api/pay/ManjiNotify_HN", newstr);

            //decimal de = 1.2m;
            //var data1 = (int)de;

            //Dictionary<string, object> dic11111 = new Dictionary<string, object>();
            //dic11111["b2"] = "2";
            //dic11111["c"] = "1";
            //dic11111["52"] = "2";
            //dic11111["a"] = "1";
            //dic11111["b"] = "2";
            //dic11111["a2"] = "1";
            //var newDic2 = JsonConvert.DeserializeObject<SortedDictionary<string, object>>(JsonConvert.SerializeObject(dic11111));
            //newDic2.OrderBy(s => s.Key);


            //var ccccc = 1;



            //var number = StrRandom(32, true).ToLower();
            //var guid = Guid.NewGuid().ToString("N");




            //Dictionary<string, object> dic = new Dictionary<string, object>();
            //dic.Add("x2", "1");
            //dic.Add("52", "2");
            //dic.Add("a2", "3");
            //dic.Add("g2", "4");
            //dic.Add("kwea2", "1");
            //dic.Add("3oor", "43");
            //dic.Add("oop", "as");
            //dic.Add("g", "fll");
            //dic.Add("v", "oodsf");
            //dic.Add("x1", "3213");
            //dic = dic.OrderBy(s => s.Key).ToDictionary(s => s.Key, p => p.Value);

            //var dicSort = from objDic in dic orderby objDic.Key ascending select objDic;
            //var s3 = dicSort.ToDictionary(s => s.Key, s => s.Value);




            //var str = new { a = "1", b = "2", c = 3 };
            //var data = newTojson(str);


            //Array c = new string[] { };
            //Console.WriteLine(c);
            //Console.WriteLine(JsonConvert.SerializeObject(c));



            #endregion

            #region

            //var res = HttpClientHelper.Get("http://localhost:53678/", "api/wxprogram/Test");,
            //Console.WriteLine(ss(res).Message);
            //var data = new
            //{
            //    success = "",
            //    msg = "",
            //    data = 1
            //};
            //var data_type = typeof(data);

            //var res = HttpClientHelper.Post("", "",JsonConvert.SerializeObject(data));

            //for (int i = 0; i < 100; i++)
            //{
            //    //Guid guid = new Guid();

            //    var numbers = Guid.NewGuid().ToString();
            //    var new_number = numbers.Substring(0, 20);
            //    if (new_number.IndexOf("0") >= 0)
            //    {
            //        Thread.Sleep(1000 * 1);
            //        Console.WriteLine($"000");
            //    }
            //}

            //decimal number = 0.01m;
            //if (number > 0) { Console.WriteLine("0"); }


            //var aa22 = JsonConvert.SerializeObject(new { a = 1, b = 2, c = "111" });

            //decimal aa1 = 1;
            //double aa2 = 2;
            //float aa3 = 3;

            //var newstr = "urskeieoowe".Replace("e", "");

            //for (int i = 0; i < 100; i++)
            //{

            //    Thread.Sleep(1000);
            //    Random random = new Random();
            //    var randomNumber = random.Next(100000, 999999);
            //    TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            //    var longTime = Convert.ToInt64(ts.TotalMilliseconds).ToString();
            //    var number = StrRandom(90, true);
            //    if (number.IndexOf("00") >= 0)
            //    {
            //        continue;
            //    }
            //    if (i == 99)
            //    {
            //        Console.WriteLine("99");
            //        break;
            //    }
            //    Console.WriteLine($"{randomNumber}{longTime}{number}");
            //}


            //var Number1 = Guid.Empty.ToString("N");
            //var Number2 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            //if (Number1.IndexOf("0") >= 0)
            //{
            //    Console.WriteLine($"{Number2.ToString()}");
            //}

            //Model.OrderInfo orderInfo = new Model.OrderInfo();

            //orderInfo.GetOrderInfo();





            //var json = "{\"dish_kinds\":[{\"id\":\"354\",\"name\":\"热菜类\",\"seq\":\"1\",\"dishkindsno\":\"123\",\"pdkid\":\"123\",\"pkid\":\"123\",\"must\":0,\"must_seq\":1,\"suggest\":0,\"border\":0,\"icon\":\"\",\"children\":[\"354\"],\"dish_count\":6}],\"tables\":{\"tid\":\"5366\",\"sno\":\"106\",\"mealfee\":\"0\",\"tablename\":\"A6\"},\"shops\":{\"sid\":\"72\",\"bid\":\"2\",\"shopname\":\"cyy堂食\",\"shopadd\":\"北京西三旗\",\"shoplocation\":\"\",\"lng\":\"\",\"lat\":\"\",\"ordermode\":3,\"is_bind_user\":1},\"activity_rules\":{\"3003243\":{\"dsid\":\"123\",\"bmemberPrice\":true,\"balanceBmemberprice\":true,\"balanceBdiscount\":true,\"discount\":0.8,\"cpqflag\":true,\"djqflag\":true,\"type\":\"-1\"}},\"marketing\":[{\"dsid\":\"46\",\"name\":\"满100-50\",\"programtype\":1,\"money\":100,\"submoney\":50,\"type\":1,\"max\":50,\"validtime\":\"2017-08-03--2017-09-30\",\"timeflag\":3,\"applytimes\":\"00:00--23:59\",\"applytime\":null,\"not_include_dish_kinds\":[\"123\",\"321\"],\"buy\":[{\"dishsno\":\"10001\",\"normsid\":\"123\",\"num\":2}],\"gift\":[{\"dishsno\":\"10001\",\"normsid\":\"123\",\"num\":1}],\"cpqflag\":true,\"djqflag\":true}],\"head_activity\":{\"image\":\"8.jpg\",\"activities\":[{\"title\":\"满100元减10元，5月28号13：00-14：满\",\"content\":\"5月28号13：00-14：00期间，满100减10元啦\",\"type\":\"1\"}]},\"memo\":[{\"omid\":\"5\",\"omkid\":\"3\",\"ordermemo\":\"少辣\"}],\"kinds_memo\":{\"all\":[{\"omid\":\"5\",\"omkid\":\"3\",\"ordermemo\":\"少辣\"},{\"omid\":\"5\",\"omkid\":\"3\",\"ordermemo\":\"少辣\"}],\"123\":[{\"omid\":\"5\",\"omkid\":\"3\",\"ordermemo\":\"少辣\"},{\"omid\":\"5\",\"omkid\":\"3\",\"ordermemo\":\"少辣\"}],\"456\":[{\"omid\":\"5\",\"omkid\":\"3\",\"ordermemo\":\"少辣\"}]},\"dishs\":{\"000002\":{\"id\":\"10315\",\"dishToppingId\":\"10315\",\"name\":\"新品\",\"dishsno\":\"00002\",\"describ\":\"推荐理由\",\"info\":\"\",\"type\":\"1\",\"wxDishs\":true,\"dishkind\":[\"308\"],\"pkid\":\"123\",\"icon\":\"1.jpg\",\"image\":\"8.jpg\",\"dishimg\":\"5.jpg\",\"min_unit\":\"0.5\",\"min_count\":5,\"min_reduce\":1,\"soldout\":0,\"priceName\":\"斤\",\"isWeigh\":0,\"isSellDishes\":0,\"norms\":[{\"name\":\"盒\",\"duid\":\"122\",\"price\":\"10.00\",\"orgprice\":\"10.00\",\"bargainprice\":0,\"memberprice\":\"10.00\",\"membergid\":[\"142\",\"521\"],\"min_unit\":0,\"limitCount\":0}],\"cooks\":[{\"id\":123,\"name\":\"红烧\",\"aprice\":3,\"soldout\":0,\"selectflag\":1,\"selectcount\":2,\"order\":1,\"practicetypeid\":12,\"practicetypename\":\"做法类别\"}],\"setmeals\":{\"price\":\"10.00\",\"orgprice\":\"10.00\",\"bargainprice\":0,\"memberprice\":\"10.00\",\"membergid\":[\"142\",\"521\"],\"limitCount\":0,\"maindish\":[{\"title\":\"主菜组\",\"name\":\"菜品名1-1\",\"id\":1,\"duid\":1,\"dishsno\":\"1001\",\"cooks\":[{\"id\":123,\"name\":\"红烧\",\"selectflag\":1,\"selectcount\":2,\"order\":1,\"practicetypeid\":12,\"practicetypename\":\"做法类别\"}]}],\"mandatory\":[{\"title\":\"三选二\",\"selnum\":\"2\",\"items\":[{\"name\":\"菜品名2-1\",\"id\":\"2\",\"duid\":1,\"dishsno\":\"1002\",\"maxnum\":\"10\",\"aprice\":\"3\",\"cooks\":[{\"id\":123,\"name\":\"红烧\",\"selectflag\":1,\"selectcount\":2,\"order\":1,\"practicetypeid\":12,\"practicetypename\":\"做法类别\"}]}]}],\"optional\":[{\"title\":\"可选辅菜组1\",\"name\":\"菜品名2-1\",\"id\":\"2\",\"duid\":1,\"dishsno\":\"1002\",\"maxnum\":\"10\",\"aprice\":\"3\",\"cooks\":[{\"id\":123,\"name\":\"红烧\",\"selectflag\":1,\"selectcount\":2,\"order\":1,\"practicetypeid\":12,\"practicetypename\":\"做法类别\"}]}]}}},\"toppings\":[{\"tpid\":1,\"tpno\":\"002\",\"remarkid\":1,\"tpname\":\"配料\",\"firstspell\":\"PL\",\"addprice\":2.2,\"order\":1,\"rcidList\":[\"1\",\"2\"],\"defaultRcidList\":[\"1\"],\"remarktypename\":\"配料类\",\"selectflag\":1,\"selectcount\":1,\"remarrkexplain\":\"配料说明XXX\"}]}";
            //List<string> list = new List<string>();
            //var data = jsonToDic(json, out list);

            #endregion

            //var c31231 = "15bec116f1e4303d33748f0dc68ac83d".ToUpper();

            //var data_json = "batch_num=&appkey=YORo6BpDiKz4wEvf&cmd=confirmPay&data={\"table_id\":null,\"device_id\":null,\"order_id\":\"B201014142821920342666\",\"orderkind\":1,\"total_pay\":138.00,\"pay_details\":[{\"name\":\"储值实收\",\"amount\":120.00},{\"name\":\"微信小程序实收\",\"amount\":18.00},{\"name\":\"优惠金额抵扣\",\"amount\":15.00}],\"dzb_order\":\"\"}&signature=15BEC116F1E4303D33748F0DC68AC83D&time=2020-10-19 18:05:07";
            //var res = HttpMethods.HttpPost("https://testapi.fnb-tech.com", data_json);



            Table table = new Table();


            string url = "https://testapi.fnb-tech.com";
            string appkey = "YORo6BpDiKz4wEvf";
            string appsecret = "CihotIs0YWpXK7nHa6wjk85g2QGcDAyv";

            table.tables = new string[] { "A1" };

            string data = JsonConvert.SerializeObject(JsonConvert.SerializeObject(table));
            string cmd = "getTableStatus"; //"confirmPay";
            //string signature = Md5Helper.Create(data + appsecret);
            string signature1 = Md5Helper.Create(JsonConvert.SerializeObject(table) + appsecret);

            var newStr = new
            {
                batch_num = Guid.NewGuid().ToString(),
                cmd = cmd,
                data = table,
                signature = signature1,
                time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };
            var json = JsonConvert.SerializeObject(newStr);
            var dic = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

            var strs = "";
            foreach (var item in dic)
            {
                if (item.Key == "data")
                {
                    strs += "data" + "=" + dic["data"].ToString().Replace("\n", "").Replace(" ", "").Replace("\t", "").Replace("\r", "");
                }
                else
                {
                    strs += item.Key + "=" + item.Value.ToString();
                }
                strs += "&";
            }

            strs = strs.Trim('&');

            //strs = strs.Replace("\n", "").Replace(" ", "").Replace("\t", "").Replace("\r", "");

            string dawd = "batch_num=fc7fa62f-d995-40fb-9bdb-383c12e8c24b&cmd=getTableStatus&data={\"tables\":[\"A1\"]}&signature=96ea09fd08115d61ee30d83c0407466d&time=2020-10-20 11:59:03";


            string str = "batch_num=8c9a228b-0d6d-49e9-9e47-922d5a304502&cmd=confirmPay&data={\"table_id\":\"A1\",\"device_id\":\"A1\",\"order_id\":\"B201014142821920342666\",\"orderkind\":1,\"total_pay\":138,\"pay_details\":[{\"name\":\"储值实收\",\"amount\":120},{\"name\":\"微信小程序实收\",\"amount\":18},{\"name\":\"优惠金额抵扣\",\"amount\":15}],\"dzb_order\":\"\"}&signature=a3f271fbef8cd8e2ef8a0257dc7956f8&time=2020-10-20 12:56:17";


            var res = HttpMethods.HttpPost(url, str);


            var msg = HttpPostForm.HttpPostForms(url, str);

            #region


            PriceInfo priceInfo = new PriceInfo();
            var c = priceInfo.price;
            var dd = priceInfo.price?.ToString();
            var dd22 = priceInfo.price.ToString();
            var dd2 = priceInfo.price == null ? 0 : 1;


            PriceInfo priceInfo1 = new PriceInfo() { price = 0.1m };
            var c2 = priceInfo1.price;
            var dd222 = priceInfo1.price?.ToString();
            var dd22222 = priceInfo1.price.ToString();
            var dd2222 = priceInfo1.price == null ? 0 : 1;
            var dd22221 = priceInfo1.price.ToString() == "" ? 0 : priceInfo1.price.Value;


            var s = new { c = "" };
            var a = s?.c;


            //dos.orm 框架
            //只查询Id
            var res1 = DosDb.Context.From<order_info>().Select(s => s.Id).ToList();
            //查询OrderCode和Id
            var res2 = DosDb.Context.From<order_info>().Select(s => new { s.OrderCode, s.Id }).ToList();
            //查询所有
            var res3 = DosDb.Context.From<order_info>().ToList();
            //查询时间区间
            string startTime = "2020-10-12 00:00:00";
            string endTime = "2020-10-13 23:59:59";
            var res4 = DosDb.Context.From<order_info>().ToList().Where(s => string.Compare(s.CreateDateTime.Value.ToString("yyyy-MM-dd HH:mm:ss"), startTime) >= 0 && string.Compare(s.CreateDateTime.Value.ToString("yyyy-MM-dd HH:mm:ss"), endTime) <= 0).ToList();
            //查询数据映射到其他表
            var res5 = DosDb.Context.From<order_info>().ToList<Order>();
            //查询指定条件
            var res6 = DosDb.Context.From<order_info>().Where(s => s.Id == "aeada0a7-f34a-4ad5-afb4-ae7f0acb405e").ToList();
            //按照时间倒序排序 只拿前五条
            var res7 = DosDb.Context.From<order_info>().OrderByDescending(s => s.CreateDateTime).Top(5).ToList();
            var res8 = DosDb.Context.FromSql("SELECT * FROM order_info").ToList<order_info>();
            var res9 = DosDb.Context.FromSql("SELECT * FROM order_info").ToList<Order>();
            //多表查询映射
            var res10 = DosDb.Context.FromSql(
@"select a.OrderCode,b.OrderId,c.State from order_info a 
left join order_detail b on a.Id = b.OrderId
left join order_state c on a.Id = c.OrderId").ToList<OrderState>();
            string OrderId = "aeada0a7-f34a-4ad5-afb4-ae7f0acb405e";
            var res11 = DosDb.Context.FromSql("SELECT * FROM order_info where Id=@id").AddInParameter("@id", DbType.String, OrderId).ToList<order_info>();
            var res12 = DosDb.Context.FromSql(
@"select a.OrderCode,b.OrderId,c.State from order_info a 
left join order_detail b on a.Id = b.OrderId
left join order_state c on a.Id = c.OrderId where c.State='5' ").ToList<OrderState>();


            #endregion

            Console.Read();
        }
        public static string SetPayParm(object dto)
        {
            Dictionary<string, string> _ReqtDic = new Dictionary<string, string>();
            var list = dto.GetType().GetFields();
            foreach (var item in list)
            {
                // MethodInfo m = item.GetGetMethod();
                var value = item.GetValue(dto);
                if (value == null)
                {
                    //_ReqtDic.Add(item.Name, null);
                }
                else
                {
                    _ReqtDic.Add(item.Name, value.ToString());
                }
                //_ReqtDic.Add(item.Name, item.GetValue(dto).ToString());


            }

            var listpam = AsciiDictionary(_ReqtDic);
            var str = "";

            foreach (var item in listpam)
            {
                str += item.Key + "=" + item.Value;
                str += "&";

            }
            str = str.Trim('&');


            return str;
        }
        public static Dictionary<string, string> AsciiDictionary(Dictionary<string, string> sArray)
        {
            Dictionary<string, string> asciiDic = new Dictionary<string, string>();
            string[] arrKeys = sArray.Keys.ToArray();
            Array.Sort(arrKeys, string.CompareOrdinal);
            foreach (var key in arrKeys)
            {
                string value = sArray[key];
                asciiDic.Add(key, value);
            }
            return asciiDic;
        }
        public static Dictionary<string, object> jsonToDic(string json, out List<string> list)
        {
            try
            {
                var dic = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
                list = dic.Keys.ToList();
                return dic;
            }
            catch (Exception)
            {
                list = null;
                return null;
            }

        }
        //订单必须重复推送 否则会出现漏单
        public static MessageModel ToSendOrder(string res)
        {
            if (res.IndexOf("0") >= 0) //重新推送
            {
                for (int i = 1; i <= 3; i++)
                {
                    Thread.Sleep(2 * 1000);
                    res = HttpClientHelper.Get("http://localhost:53678/", "api/wxprogram/Test");
                    if (i == 3 && res.IndexOf("0") >= 0) //推送三次失败 订单异常
                    {
                        Console.WriteLine("第3次推单失败,订单异常");
                        return new MessageModel() { Code = 0, data = null, Message = "订单异常" };
                    }
                    if (res.IndexOf("0") >= 0)
                    {
                        Console.WriteLine($"第{i}次推单,{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}");
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
        /// 截取字符串中指定字符串
        /// </summary>
        /// <returns></returns>
        public static string SubstringStr(string str, string substr)
        {
            str.Replace(substr, "");

            if (string.IsNullOrEmpty(str))
            {
                return "字符串解析异常,不能为空字符串";
            }
            if (str.IndexOf($"{substr}") >= 0)
            {
                for (int i = 0; i <= str.Length; i++)
                {
                    var index = str.IndexOf($"{substr}");
                    str = str.Substring(index, substr.Length);
                }
            }
            else
            {
                return "字符串并未存在指定截取字符";
            }
            return str;
        }
        public static string newTojson(object news)
        {
            string str = "";
            var newstr = news.ToString().Replace("=", ":");
            var dic_json = JsonConvert.DeserializeObject<Dictionary<string, object>>(newstr);
            dic_json.OrderBy(s => s.Key);
            foreach (var item in dic_json)
            {
                str += item.Key + "=" + item.Value;
                str += "&";
            }
            str = str.Trim('&');

            return str;
        }
        /// <summary>
        /// 生成随机字母与数字
        /// </summary>
        /// <param name="Length">生成长度</param>
        /// <param name="Sleep">是否要在生成前将当前线程阻止以避免重复</param>
        /// <returns></returns>
        public static string StrRandom(int Length, bool Sleep)
        {
            if (Sleep) System.Threading.Thread.Sleep(3);
            char[] Pattern = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            string result = "";
            int n = Pattern.Length;
            //System.Random random = new Random(~unchecked((int)DateTime.Now.Ticks));
            System.Random random = new Random();
            for (int i = 0; i < Length; i++)
            {
                int rnd = random.Next(0, n);
                result += Pattern[rnd];
            }
            return result;
        }
        public static string Sign(string json)
        {
            StringBuilder builder = new StringBuilder();
            //MiniPay data = Newtonsoft.Json.JsonConvert.DeserializeObject<MiniPay>(json);
            var res = Newtonsoft.Json.JsonConvert.DeserializeObject<SortedDictionary<string, object>>(json);
            res.OrderBy(s => s.Key);
            List<string> list_key = new List<string>(res.Keys);
            if (list_key.Count > 0 && list_key != null)
            {
                for (int i = 0; i < list_key.Count; i++)
                {
                    builder.Append($"{list_key[i]}={res[list_key[i]]}&");
                }
            }

            var newstr = builder.ToString();
            newstr = newstr.Substring(0, newstr.Length - 1);
            return newstr;
        }
        public static void Test1()
        {
            var datetime = DateTime.Now;
            Console.WriteLine(datetime);
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            for (int i = 0; i < 100000; i++)
            {
                Console.Write(i.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine(DateTime.Now - datetime);
        }
        public static void Test11()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i.ToString());
            }
            Console.WriteLine();
        }
        public static void Test12()
        {
            for (int i = 30000; i < 60000; i++)
            {
                Console.Write(i.ToString());
            }
        }
        public static void Test13()
        {
            for (int i = 60000; i < 100000; i++)
            {
                Console.Write(i.ToString());
            }
        }
        /// <summary>
        /// 获取枚举详细信息
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static string GetEnumDesc(Enum enumValue)
        {
            string str = enumValue.ToString();
            FieldInfo field = enumValue.GetType().GetField(str);

            try
            {
                object[] objs = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (objs == null || objs.Length == 0)
                {
                    return str;
                }
                DescriptionAttribute da = (DescriptionAttribute)objs[0];
                return da.Description;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static string SetSign(string json)
        {
            string key = "";
            StringBuilder builder = new StringBuilder();
            //MiniPay data = Newtonsoft.Json.JsonConvert.DeserializeObject<MiniPay>(json);
            var res = Newtonsoft.Json.JsonConvert.DeserializeObject<SortedDictionary<string, object>>(json);
            res.OrderBy(s => s.Key);
            List<string> list_key = new List<string>(res.Keys);
            if (list_key.Count > 0 && list_key != null)
            {
                for (int i = 0; i < list_key.Count; i++)
                {
                    builder.Append($"{list_key[i]}={res[list_key[i]]}&");
                }
            }
            builder.Append($"key={key}");
            var sign = Md5Helper.Create(builder.ToString());
            sign = sign.ToLower();
            return sign;
        }
        public static void Write(string strs)
        {
            FileStream fs = new FileStream("D:\\", FileMode.CreateNew, FileAccess.Write);
            //获得字节数组
            byte[] data = System.Text.Encoding.Default.GetBytes(strs);
            //开始写入
            fs.Write(data, 0, data.Length);
            //清空缓冲区、关闭流
            fs.Flush();
            fs.Close();
        }
        public static string Decrypt3Des(string aStrString, string aStrKey, CipherMode mode = CipherMode.ECB, string iv = "12345678")
        {
            try
            {
                TripleDESCryptoServiceProvider cryptoServiceProvider1 = new TripleDESCryptoServiceProvider();
                cryptoServiceProvider1.Key = Encoding.UTF8.GetBytes(aStrKey);
                cryptoServiceProvider1.Mode = mode;
                cryptoServiceProvider1.Padding = PaddingMode.PKCS7;
                TripleDESCryptoServiceProvider cryptoServiceProvider2 = cryptoServiceProvider1;
                if (mode == CipherMode.CBC)
                    cryptoServiceProvider2.IV = Encoding.UTF8.GetBytes(iv);
                ICryptoTransform decryptor = cryptoServiceProvider2.CreateDecryptor();
                byte[] inputBuffer = Convert.FromBase64String(aStrString);
                return Encoding.UTF8.GetString(decryptor.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length));
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }
        public static void SaveImg(string strPath, Bitmap img, string name, int width, int height)
        {
            if (Directory.Exists(strPath))
            {
                string str = name + ".bmp";
                ResizeImage(img, width, height, 0).Save(strPath + str, ImageFormat.Bmp);
            }
            else
                Directory.CreateDirectory(strPath);
        }
        public static Bitmap ResizeImage(Bitmap bmp, int newW, int newH, int Mode)
        {
            Bitmap bitmap1;
            try
            {
                Bitmap bitmap2 = new Bitmap(newW, newH);
                Graphics graphics = Graphics.FromImage((Image)bitmap2);
                graphics.DrawImage((Image)bmp, new Rectangle(0, 0, newW, newH), new Rectangle(0, 0, bmp.Width, bmp.Height), GraphicsUnit.Pixel);
                graphics.Dispose();
                bitmap1 = bitmap2;
            }
            catch
            {
                bitmap1 = (Bitmap)null;
            }
            return bitmap1;
        }
        public static Bitmap Create_ImgCode(string codeNumber, int size)
        {
            return new QRCodeEncoder()
            {
                QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE,
                QRCodeScale = size,
                QRCodeVersion = 0,
                QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M
            }.Encode(codeNumber);
        }
        #region URL编码
        /// <summary>
        /// URL编码
        /// </summary>
        /// <param name="str">要进行编码的字符串</param>
        /// <returns></returns>
        public static string UrlEncode(string str)
        {
            StringBuilder sb = new StringBuilder();
            byte[] byStr = System.Text.Encoding.UTF8.GetBytes(str); //默认是System.Text.Encoding.Default.GetBytes(str)
            for (int i = 0; i < byStr.Length; i++)
            {
                sb.Append(@"%" + Convert.ToString(byStr[i], 16));
            }

            return (sb.ToString());
        }
        #endregion

        /// <summary>
        /// 创建无参的方法
        /// </summary>
        static void Thread1()
        {
            Console.WriteLine("这是无参的方法");
        }
        /// <summary>
        /// 创建无参的方法
        /// </summary>
        static void Thread2()
        {
            Console.WriteLine("这是无参的方法");
        }

        public static void SetStr(ref string s)
        {
            // s = "1";
        }
        public class Pss
        {
            public string v1 { get; set; }
            public int v2 { get; set; }
        }
        public class Data
        {
            /// <summary>
            /// 业务流水号 商户系统保证唯一性
            /// </summary>
            public string I1 { get; set; }
            /// <summary>
            /// 小票日期 YYYYmmdd
            /// </summary>
            public string I2 { get; set; }
            /// <summary>
            /// 分机号 税盘分机号
            /// </summary>
            public string I3 { get; set; }
            /// <summary>
            /// 发票项目 开票项目
            /// </summary>
            public string I4 { get; set; }
            /// <summary>
            /// 金额 小票总金额(最多两位小数)
            /// </summary>
            public string I5 { get; set; }
            /// <summary>
            /// 单价 最多两位小数
            /// </summary>
            public string I6 { get; set; }
            /// <summary>
            /// 数量
            /// </summary>
            public string I7 { get; set; }
            /// <summary>
            /// 单位
            /// </summary>
            public string I8 { get; set; }
        }
    }

    public class Table
    {
        public object tables { get; set; }
    }
    public class PriceInfo
    {
        public decimal? price { get; set; }
    }
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
    public class Order
    {
        /// <summary>
        /// 
        /// </summary>
        public System.String Id { get; set; }
        /// <summary>
        /// 订单ID
        /// </summary>
        public string OrderId { get; set; }
    }
    public class OrderState
    {
        public string OrderCode { get; set; }
        public string OrderId { get; set; }
        public string State { get; set; }
    }
    public class HttpMethods
    {

        #region POST
        public static string PostJson(string url, string json, int timeOut = 100)
        {
            //定义request并设置request的路径
            WebRequest request = WebRequest.Create(url);
            request.Method = "post";
            request.Timeout = timeOut * 1000;
            //初始化request参数
            //设置参数的编码格式，解决中文乱码
            byte[] byteArray = Encoding.UTF8.GetBytes(json);
            //设置request的MIME类型及内容长度
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;
            //打开request字符流
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            //定义response为前面的request响应
            WebResponse response = request.GetResponse();
            //定义response字符流
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();//读取所有
            return responseFromServer;
        }
        /// <summary>
        /// HTTP POST方式请求数据
        /// </summary>
        /// <param name="url">URL.</param>
        /// <param name="param">POST的数据</param>
        /// <returns></returns>
        public static string HttpPostJson(string url, string param = null)
        {
            HttpWebRequest request;

            //如果是发送HTTPS请求  
            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version10;
            }
            else
            {
                request = WebRequest.Create(url) as HttpWebRequest;
            }

            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "*/*";
            request.Timeout = 15000;
            request.AllowAutoRedirect = false;



            StreamWriter requestStream = null;
            WebResponse response = null;
            string responseStr = null;

            try
            {
                requestStream = new StreamWriter(request.GetRequestStream());
                requestStream.Write(param);
                requestStream.Close();

                response = request.GetResponse();
                if (response != null)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    responseStr = reader.ReadToEnd();
                    reader.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                request = null;
                requestStream = null;
                response = null;
            }

            return responseStr;
        }
        /// <summary>
        /// HTTP POST方式请求数据
        /// </summary>
        /// <param name="url">URL.</param>
        /// <param name="param">POST的数据</param>
        /// <returns></returns>
        public static string HttpPost(string url, string param = null)
        {
            HttpWebRequest request;

            //如果是发送HTTPS请求  
            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version10;
            }
            else
            {
                request = WebRequest.Create(url) as HttpWebRequest;
            }

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.Accept = "*/*";
            request.Timeout = 15000;
            request.AllowAutoRedirect = false;



            StreamWriter requestStream = null;
            WebResponse response = null;
            string responseStr = null;

            try
            {
                requestStream = new StreamWriter(request.GetRequestStream());
                requestStream.Write(param);
                requestStream.Close();

                response = request.GetResponse();
                if (response != null)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    responseStr = reader.ReadToEnd();
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                request = null;
                requestStream = null;
                response = null;
            }

            return responseStr;
        }

        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true; //总是接受  
        }
        public static string BuildRequest(string strUrl, Dictionary<string, string> dicPara, string fileName)
        {
            string contentType = "image/jpeg";
            //待请求参数数组
            FileStream Pic = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            byte[] PicByte = new byte[Pic.Length];
            Pic.Read(PicByte, 0, PicByte.Length);
            int lengthFile = PicByte.Length;

            //构造请求地址

            //设置HttpWebRequest基本信息
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(strUrl);
            //设置请求方式：get、post
            request.Method = "POST";
            //设置boundaryValue
            string boundaryValue = DateTime.Now.Ticks.ToString("x");
            string boundary = "--" + boundaryValue;
            request.ContentType = "\r\nmultipart/form-data; boundary=" + boundaryValue;
            //设置KeepAlive
            request.KeepAlive = true;
            //设置请求数据，拼接成字符串
            StringBuilder sbHtml = new StringBuilder();
            foreach (KeyValuePair<string, string> key in dicPara)
            {
                sbHtml.Append(boundary + "\r\nContent-Disposition: form-data; name=\"" + key.Key + "\"\r\n\r\n" + key.Value + "\r\n");
            }
            sbHtml.Append(boundary + "\r\nContent-Disposition: form-data; name=\"pic\"; filename=\"");
            sbHtml.Append(fileName);
            sbHtml.Append("\"\r\nContent-Type: " + contentType + "\r\n\r\n");
            string postHeader = sbHtml.ToString();
            //将请求数据字符串类型根据编码格式转换成字节流
            Encoding code = Encoding.GetEncoding("UTF-8");
            byte[] postHeaderBytes = code.GetBytes(postHeader);
            byte[] boundayBytes = Encoding.ASCII.GetBytes("\r\n" + boundary + "--\r\n");
            //设置长度
            long length = postHeaderBytes.Length + lengthFile + boundayBytes.Length;
            request.ContentLength = length;

            //请求远程HTTP
            Stream requestStream = request.GetRequestStream();
            Stream myStream = null;
            try
            {
                //发送数据请求服务器
                requestStream.Write(postHeaderBytes, 0, postHeaderBytes.Length);
                requestStream.Write(PicByte, 0, lengthFile);
                requestStream.Write(boundayBytes, 0, boundayBytes.Length);
                HttpWebResponse HttpWResp = (HttpWebResponse)request.GetResponse();
                myStream = HttpWResp.GetResponseStream();
            }
            catch (WebException e)
            {
                //LogResult(e.Message);
                return "";
            }
            finally
            {
                if (requestStream != null)
                {
                    requestStream.Close();
                }
            }

            //读取处理结果
            StreamReader reader = new StreamReader(myStream, code);
            StringBuilder responseData = new StringBuilder();

            String line;
            while ((line = reader.ReadLine()) != null)
            {
                responseData.Append(line);
            }
            myStream.Close();
            Pic.Close();

            return responseData.ToString();
        }
        #endregion

        #region Put
        /// <summary>
        /// HTTP Put方式请求数据.
        /// </summary>
        /// <param name="url">URL.</param>
        /// <returns></returns>
        public static string HttpPut(string url, string param = null)
        {
            HttpWebRequest request;

            //如果是发送HTTPS请求  
            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version10;
            }
            else
            {
                request = WebRequest.Create(url) as HttpWebRequest;
            }
            request.Method = "PUT";
            request.ContentType = "application/x-www-form-urlencoded";
            request.Accept = "*/*";
            request.Timeout = 15000;
            request.AllowAutoRedirect = false;

            StreamWriter requestStream = null;
            WebResponse response = null;
            string responseStr = null;

            try
            {
                requestStream = new StreamWriter(request.GetRequestStream());
                requestStream.Write(param);
                requestStream.Close();

                response = request.GetResponse();
                if (response != null)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    responseStr = reader.ReadToEnd();
                    reader.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                request = null;
                requestStream = null;
                response = null;
            }

            return responseStr;
        }
        #endregion

        #region Delete
        /// <summary>
        /// HTTP Delete方式请求数据.
        /// </summary>
        /// <param name="url">URL.</param>
        /// <returns></returns>
        public static string HttpDelete(string url, string param = null)
        {
            HttpWebRequest request;

            //如果是发送HTTPS请求  
            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version10;
            }
            else
            {
                request = WebRequest.Create(url) as HttpWebRequest;
            }
            request.Method = "Delete";
            request.ContentType = "application/x-www-form-urlencoded";
            request.Accept = "*/*";
            request.Timeout = 15000;
            request.AllowAutoRedirect = false;

            StreamWriter requestStream = null;
            WebResponse response = null;
            string responseStr = null;

            try
            {
                requestStream = new StreamWriter(request.GetRequestStream());
                requestStream.Write(param);
                requestStream.Close();

                response = request.GetResponse();
                if (response != null)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    responseStr = reader.ReadToEnd();
                    reader.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return responseStr;
        }
        #endregion

        #region Get
        /// <summary>
        /// HTTP GET方式请求数据.
        /// </summary>
        /// <param name="url">URL.</param>
        /// <returns></returns>
        public static string HttpGet(string url, Hashtable headht = null)
        {
            HttpWebRequest request;

            //如果是发送HTTPS请求  
            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version10;
            }
            else
            {
                request = WebRequest.Create(url) as HttpWebRequest;
            }
            request.Method = "GET";
            //request.ContentType = "application/x-www-form-urlencoded";
            request.Accept = "*/*";
            request.Timeout = 15000;
            request.AllowAutoRedirect = false;
            WebResponse response = null;
            string responseStr = null;
            if (headht != null)
            {
                foreach (DictionaryEntry item in headht)
                {
                    request.Headers.Add(item.Key.ToString(), item.Value.ToString());
                }
            }

            try
            {
                response = request.GetResponse();

                if (response != null)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    responseStr = reader.ReadToEnd();
                    reader.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return responseStr;
        }
        public static string HttpGet(string url, Encoding encodeing, Hashtable headht = null)
        {
            HttpWebRequest request;

            //如果是发送HTTPS请求  
            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version10;
            }
            else
            {
                request = WebRequest.Create(url) as HttpWebRequest;
            }
            request.Method = "GET";
            //request.ContentType = "application/x-www-form-urlencoded";
            request.Accept = "*/*";
            request.Timeout = 15000;
            request.AllowAutoRedirect = false;
            WebResponse response = null;
            string responseStr = null;
            if (headht != null)
            {
                foreach (DictionaryEntry item in headht)
                {
                    request.Headers.Add(item.Key.ToString(), item.Value.ToString());
                }
            }

            try
            {
                response = request.GetResponse();

                if (response != null)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream(), encodeing);
                    responseStr = reader.ReadToEnd();
                    reader.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return responseStr;
        }
        #endregion

        #region Post With Pic
        private string HttpPost(string url, IDictionary<object, object> param, string filePath)
        {
            string boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x");
            byte[] boundarybytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");

            HttpWebRequest wr = (HttpWebRequest)WebRequest.Create(url);
            wr.ContentType = "multipart/form-data; boundary=" + boundary;
            wr.Method = "POST";
            wr.KeepAlive = true;
            wr.Credentials = System.Net.CredentialCache.DefaultCredentials;

            Stream rs = wr.GetRequestStream();
            string responseStr = null;

            string formdataTemplate = "Content-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}";
            foreach (string key in param.Keys)
            {
                rs.Write(boundarybytes, 0, boundarybytes.Length);
                string formitem = string.Format(formdataTemplate, key, param[key]);
                byte[] formitembytes = System.Text.Encoding.UTF8.GetBytes(formitem);
                rs.Write(formitembytes, 0, formitembytes.Length);
            }
            rs.Write(boundarybytes, 0, boundarybytes.Length);

            string headerTemplate = "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n";
            string header = string.Format(headerTemplate, "pic", filePath, "text/plain");
            byte[] headerbytes = System.Text.Encoding.UTF8.GetBytes(header);
            rs.Write(headerbytes, 0, headerbytes.Length);

            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[4096];
            int bytesRead = 0;
            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
            {
                rs.Write(buffer, 0, bytesRead);
            }
            fileStream.Close();

            byte[] trailer = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");
            rs.Write(trailer, 0, trailer.Length);
            rs.Close();

            WebResponse wresp = null;
            try
            {
                wresp = wr.GetResponse();
                Stream stream2 = wresp.GetResponseStream();
                StreamReader reader2 = new StreamReader(stream2);
                responseStr = reader2.ReadToEnd();
                //logger.Debug(string.Format("File uploaded, server response is: {0}", responseStr));
            }
            catch (Exception ex)
            {
                //logger.Error("Error uploading file", ex);
                if (wresp != null)
                {
                    wresp.Close();
                    wresp = null;
                }
                throw;
            }
            return responseStr;
        }
        #endregion

        #region Post With Pic
        /// <summary>
        /// HTTP POST方式请求数据(带图片)
        /// </summary>
        /// <param name="url">URL</param>        
        /// <param name="param">POST的数据</param>
        /// <param name="fileByte">图片</param>
        /// <returns></returns>
        public static string HttpPost(string url, IDictionary<object, object> param, byte[] fileByte)
        {
            string boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x");
            byte[] boundarybytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");

            HttpWebRequest wr = (HttpWebRequest)WebRequest.Create(url);
            wr.ContentType = "multipart/form-data; boundary=" + boundary;
            wr.Method = "POST";
            wr.KeepAlive = true;
            wr.Credentials = System.Net.CredentialCache.DefaultCredentials;

            Stream rs = wr.GetRequestStream();
            string responseStr = null;

            string formdataTemplate = "Content-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}";
            foreach (string key in param.Keys)
            {
                rs.Write(boundarybytes, 0, boundarybytes.Length);
                string formitem = string.Format(formdataTemplate, key, param[key]);
                byte[] formitembytes = System.Text.Encoding.UTF8.GetBytes(formitem);
                rs.Write(formitembytes, 0, formitembytes.Length);
            }
            rs.Write(boundarybytes, 0, boundarybytes.Length);

            string headerTemplate = "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n";
            string header = string.Format(headerTemplate, "pic", fileByte, "text/plain");//image/jpeg
            byte[] headerbytes = System.Text.Encoding.UTF8.GetBytes(header);
            rs.Write(headerbytes, 0, headerbytes.Length);

            rs.Write(fileByte, 0, fileByte.Length);

            byte[] trailer = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");
            rs.Write(trailer, 0, trailer.Length);
            rs.Close();

            WebResponse wresp = null;
            try
            {
                wresp = wr.GetResponse();
                Stream stream2 = wresp.GetResponseStream();
                StreamReader reader2 = new StreamReader(stream2);
                responseStr = reader2.ReadToEnd();
                // logger.Error(string.Format("File uploaded, server response is: {0}", responseStr));
            }
            catch (Exception ex)
            {
                //logger.Error("Error uploading file", ex);
                if (wresp != null)
                {
                    wresp.Close();
                    wresp = null;
                }
                throw;
            }
            return responseStr;
        }
        #endregion

        #region HttpsClient
        /// <summary>
        /// 创建HttpClient
        /// </summary>
        /// <returns></returns>
        public static HttpClient CreateHttpClient(string url)
        {
            HttpClient httpclient;
            //如果是发送HTTPS请求  
            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
                httpclient = new HttpClient();
            }
            else
            {
                httpclient = new HttpClient();
            }
            return httpclient;
        }
        #endregion
    }

    public class Param
    {

        public string cmd { get; set; }
        public string data { get; set; }
        public string signature { get; set; }
        public string appkey { get; set; }
        public string time { get; set; }
        public string batch_num { get; set; }

    }
}
