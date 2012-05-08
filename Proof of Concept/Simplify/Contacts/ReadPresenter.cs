using System.Web;
using Simplify.Core;

namespace Simplify.Contacts
{
    public class ReadPresenter : IPresenter
    {
        public dynamic Model { get; set; }

        public void HandleRequest(HttpRequest request, HttpResponse response)
        {
            Model = DataSource.Contacts;
        }
    }
}