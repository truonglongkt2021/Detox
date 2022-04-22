using Outsourcing.Service;
using System.Web.Http;

namespace Labixa.Controllers
{
    public class CallBackController : ApiController
    {
        private readonly INganLuongService _nganLuong;

        public CallBackController(INganLuongService nganLuong)
        {
            this._nganLuong = nganLuong;
        }

        [HttpGet]
        public IHttpActionResult Version()
        {
            return Ok("1.0.0");
        }

        // POST: /CallBack/GetTransactionDetail
        [HttpPost]
        [Route("api/GetTransactionDetail")]
        public IHttpActionResult GetTransactionDetail(RequestCheckOrder requestOrder)
        {
            var detail = _nganLuong.GetTransactionDetail(requestOrder);
            return Ok(detail);
        }

        // POST: /CallBack/GetUrlCheckout
        [HttpPost]
        [Route("api/GetUrlCheckout")]
        public IHttpActionResult GetUrlCheckout(RequestInfo requestContent)
        {
            requestContent.return_url = Request.RequestUri.AbsoluteUri + "api/ReturnUrl";
            var detail = _nganLuong.GetUrlCheckout(requestContent);
            return Ok(detail);
        }

        [HttpPost]
        [Route("api/ReturnUrl")]
        public IHttpActionResult ReturnUrl(string back)
        {
            return Ok(back);
        }
    }
}