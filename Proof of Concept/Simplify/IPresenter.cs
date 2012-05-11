using System.Web;

namespace Simplify
{
    public interface IPresenter
    {
        dynamic Model { get; set; }

        void HandleRequest(HttpRequest request, HttpResponse response);
    }
}