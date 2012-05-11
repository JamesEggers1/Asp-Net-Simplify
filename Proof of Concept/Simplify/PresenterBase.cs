using System.Web;

namespace Simplify
{
    public abstract class PresenterBase : IPresenter
    {
        public dynamic Model { get; set; }

        protected HttpRequest Request { get; set; }

        protected HttpResponse Response { get; set; }

        public virtual void HandleRequest(HttpRequest request, HttpResponse response)
        {
            Request = request;
            Response = response;

            switch (request.HttpMethod)
            {
                case "POST":
                    Post();
                    break;

                case "GET":
                    Get();
                    break;

                case "PUT":
                    Put();
                    break;

                case "DELETE":
                    Delete();
                    break;

                default:
                    throw new HttpException(404, string.Format("The requested resource does not allow for Http {0} actions.", request.HttpMethod));
            }
        }

        protected virtual void Post()
        {
            throw new HttpException(404, "The requested resource does not allow for Http POST actions.");
        }

        protected virtual void Get()
        {
            throw new HttpException(404, "The requested resource does not allow for Http GET actions.");
        }

        protected virtual void Put()
        {
            throw new HttpException(404, "The requested resource does not allow for Http Put actions.");
        }

        protected virtual void Delete()
        {
            throw new HttpException(404, "The requested resource does not allow for Http DELETE actions.");
        }
    }
}