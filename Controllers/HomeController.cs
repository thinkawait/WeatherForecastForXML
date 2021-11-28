using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.XPath;

namespace WeatherForecastForXML.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? id)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("https://opendata.cwb.gov.tw/fileapi/v1/opendataapi/F-A0012-001?Authorization=CWB-BC2E6A08-130F-4DCA-B26C-8E5ADF09F133&downloadType=WEB&format=XML");
            //XmlElement root = xmlDocument.DocumentElement;

            //XML文件若有xmlns記得追加XmlNamespaceManager
            XmlNamespaceManager manager = new XmlNamespaceManager(xmlDocument.NameTable);
            manager.AddNamespace("cwb","urn:cwb:gov:tw:cwbcommon:0.1");
            ViewBag.manager = manager;

            var titleList = xmlDocument.GetElementsByTagName("locationName");
            var titleList2 = xmlDocument.SelectNodes("//cwb:location", manager);
            ViewBag.titleList = titleList;
            if(id!=null)
            {
                XmlNodeList itemlist = xmlDocument.GetElementsByTagName($"location");
                ViewBag.itemlist = itemlist[(int)id];
            }
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}