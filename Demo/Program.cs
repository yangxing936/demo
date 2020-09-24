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

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region

            //string json = "{\"systemId\":\"5011016\",\"sign\":\"9bc3101ecbb733f6224aeb0c430f17fa\",\"content\":{\"order\":{\"cardNo\":\"\",\"isUsePoints\":\"\",\"orderTotalPoints\":\"\",\"memberCode\":\"6610510065\",\"tables\":[],\"serialno\":\"895228e3-1f24-415b-862a-e6bdd48610ff\",\"orderId\":\"2018011115470629634168\",\"bookingOrderCode\":\"\",\"companyCode\":\"f78b89fc-b574-4b86-b079-e98e82a27f18\",\"brandId\":\"f6a2aa93-b364-447c-9ac8-ba792e626c91\",\"shopId\":\"e01845c5-2f26-42b4-8019-9a9ef0acfc64\",\"channelId\":\"1041002\",\"username\":\"微信餐厅顾客\",\"orderPhone\":\"18621703243\",\"city\":\"上海市\",\"address\":\"山西南路350号\",\"addressDetail\":\"\",\"userLng\":\"121.363520016388\",\"userLat\":\"31.165385569443\",\"menuVersion\":\"\",\"productVersion\":\"\",\"categoryVersion\":\"\",\"commissionAmount\":\"0\",\"businessFavourableAmount\":\"0\",\"platformFavourableAmount\":\"0\",\"favourableAmount\":\"0\",\"businessAmount\":\"7.0\",\"orderNumber\":\"1\",\"coordType\":\"5\",\"tableFor\":\"\",\"dineType\":\"2\",\"deliveryrouteFees\":\"0\",\"deliveryrouteName\":\"\",\"deliveryroutePhone\":\"\",\"deliveryrouteStatus\":\"\",\"orderTime\":\"2018-01-11}]}]}}}";

            //var str = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);




            //var data = JsonConvert.DeserializeObject<SortedDictionary<string,object>>(json);
            //data.OrderBy(s => s.Key);
            //var newjson = JsonConvert.SerializeObject(data);
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



            var res= Math.Round((20.0 / 18), 2);

            Data data = new Data()
            {
                I1 = "20200316123428030",//业务流水号
                I2 = DateTime.Now.ToString("yyMMdd"),//小票日期
                I3 = "0",//税盘分机号
                I4 = "1",//发票项目
                I5 = "109.00".ToString(),
                I6 = "109.00".ToString(),
                I7 = "",
                I8 = ""
               
            };

            //string mw1 = $"I1={data.I1}&I2={data.I2}&I3={data.I3}&I4={data.I4}&I5={data.I5}&I6={data.I6}";//密文(3DES加密)
            string mw1 = $"I1={data.I1}&I2={data.I2}&I3={data.I3}&I4={data.I4}&I5={data.I5}";//密文(3DES加密)
            string t = "500102201007206608";//税号

            //3Des 加密的秘钥由 MD5(税号)前 12 位，后 12 位拼接成 24 位加密 KEY。
            var md5str = Md5Helper.Create(t); //MD5(税号)
            string desKey = md5str.Substring(0, 12) + md5str.Substring(md5str.Length - 12, 12);//后 12 位拼接成 24 位加密 KEY
            string mw = DESHelper.Encrypt3Des(mw1, desKey.ToUpper());//3DES加密 
            //mw = UrlEncode(mw);

            var newurl = "http://f.gooagoo.com/002/8" + "?t=" + t + "_LW" + "&mw=" + mw; ;
            Bitmap imgCode1 = Create_ImgCode(newurl, 5);
            SaveImg("C:\\Users\\Administrator\\Desktop\\截图\\", imgCode1, "电子发票二维码1", 320, 320);//本地保存图片















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




            //DateTime dateTime = DateTime.Parse("2020-09-21 11:07:34");
            //System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0));
            //long t = (dateTime.Ticks - startTime.Ticks) / 10000;   //除10000调整为13位      
            //var newa = new
            //{
            //    platformDiscount = 0,
            //    appOrderNo = "182177860581600744248652",
            //    payTime = t,
            //    subject = "HDLY002",
            //    orderStatus = "PAY_SUC",
            //    discountAmount = 0,
            //    channelDiscount = 0,
            //    paymentWay = "QRCODE",
            //    buyerId = "oiArOs_2AWBBP4aKObRNGZm132fw",
            //    outOrderNo = "4200000678202009188094601099",
            //    paymentChannel = "WECHAT",
            //    localOrderNo = "TCWX2009181730594053900616",
            //    totalAmount = 1,
            //    receiveAmount = 1
            //};

            //var res1 = JsonConvert.SerializeObject(newa);
            //var newstr = Sign(res1);

            //var res = HttpPostForm.FormHttpPost("http://localhost:51114/api/pay/ManjiNotify_HN", newstr);

            //decimal de = 1.2m;
            //var data1 = (int)de;

            //Dictionary<string, object> dic = new Dictionary<string, object>();
            //dic["b2"] = "2";
            //dic["c"] = "1";
            //dic["52"] = "2";
            //dic["a"] = "1";
            //dic["b"] = "2";
            //dic["a2"] = "1";
            //var newDic2 = JsonConvert.DeserializeObject<SortedDictionary<string, object>>(JsonConvert.SerializeObject(dic));
            //newDic.OrderBy(s => s.Key);





            #endregion
            var number = StrRandom(32, true).ToLower();
            var guid = Guid.NewGuid().ToString("N");
            Console.Read();
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
}
