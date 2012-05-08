using System.Web;

namespace Simplify.Core
{
    public interface IPresenter
    {
        dynamic Model { get; set; }

        void HandleRequest(HttpRequest request, HttpResponse response);
    }
}