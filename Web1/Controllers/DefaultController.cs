using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Img() 
        {
            return View();
        }


        /// <summary>
        /// 图片上传
        /// </summary>
        /// <returns></returns>
        public ActionResult SaveImage()
        {
            try
            {
                //判断上传文件的数目
                if (Request.Files.Count > 0)
                {
                    //获取文件
                    HttpPostedFileBase proImage = Request.Files["uploadImage"];//获取上传的图片

                    //判断上传文件大小，小于5M
                    if (proImage.ContentLength > 5 * 1024 * 1024)
                    {
                        return Content("Error1");
                    }

                    //截取图片类型：image/png
                    string[] filetypes = proImage.ContentType.Split('/');

                    //判断文件的类型
                    if (filetypes[1] == "jpg" || filetypes[1] == "gif" || filetypes[1] == "png" || filetypes[1] == "bmg" || filetypes[1] == "jpeg")
                    {
                        //给上传文件重命名
                        string filename = DateTime.Now.ToString("yyyyMMddHHmmssfff") + Guid.NewGuid().ToString();
                        if (Directory.Exists(Server.MapPath("~/Uploadfile/TaskReportImages")) == false)//如果不存在就创建file文件夹
                        {
                            Directory.CreateDirectory(Server.MapPath("~/Uploadfile/TaskReportImages"));
                        }
                        //文件保存的路径
                        string filesavepath = Server.MapPath("~/Uploadfile/TaskReportImages/" + filename + "." + filetypes[1]);

                        //保存图片
                        proImage.SaveAs(filesavepath);

                        //返回文件名，可以在前台展示出来
                        return Content(filename + "." + filetypes[1]);
                    }
                    else
                    {
                        //图片格式不对
                        return Content("Error2");
                    }


                }
                else
                {    //上传图片数目小于或者等于0
                    return Content("Error1");
                }
            }
            catch
            {
                return Content("Error2");
            }


        }
    }
}