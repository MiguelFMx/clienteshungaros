using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace clienteshungaros.clases
{
    /// <summary>
    /// Descripción breve de FileUploadHandler
    /// </summary>
    public class FileUploadHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hola a todos");
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