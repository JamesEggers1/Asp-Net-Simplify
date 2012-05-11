using System.Web;

namespace Simplify.Sample.Contacts
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