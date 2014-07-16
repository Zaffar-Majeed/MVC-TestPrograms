using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class MessageController : Controller
    {
        //
        // GET: /Message/

        public String Index(String q)
        {
            return HttpUtility.HtmlEncode("welcome to " + q);
        }

        public String NewMsg(int id)
        {
            return "the value passed is : " + id;
        }
    }
}
