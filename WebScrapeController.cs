using PraiseTeam.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PraiseTeam.Controllers.Api
{
    [RoutePrefix ("api/WebScrapes")]
    public class WebScrapeController : ApiController
    {
        IWebScrapeService _webScrapeService;

        public WebScrapeController(IWebScrapeService webScrapeService)
        {
            _webScrapeService = webScrapeService;
        }

        [Route(), HttpGet]
        public HttpResponseMessage WebScrape()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _webScrapeService.WebScrape());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
