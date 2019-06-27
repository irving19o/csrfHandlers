using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace HelpersExample
{
    /// <summary>
    /// Descripción breve de Handler
    /// </summary>
    public class Handler : IHttpHandler
    {
       
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            try
            {
                AntiForgery.Validate();
                context.Response.Write("This request was validated");
            }
            catch{
                context.Response.Write("");
            }

            

           

            /*if () {
                context.Response.Write("This request was validated");
            }
            else {
                context.Response.Write("This request was not validated");
            }*/
           
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}