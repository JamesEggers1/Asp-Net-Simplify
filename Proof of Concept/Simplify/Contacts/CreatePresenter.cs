using System.Web;
using Simplify.Core;

namespace Simplify.Contacts
{
    public class CreatePresenter : IPresenter
    {
        public dynamic Model { get; set; }

        public void HandleRequest(HttpRequest request, HttpResponse response)
        {
            if (request.Form.Count == 0)
            {
                return;
            }

            DataSource.Contacts.Add(
                new Contact()
                {
                    Id = int.Parse(request.Form["id"].ToString()),
                    FirstName = request.Form["firstName"].ToString(),
                    LastName = request.Form["lastName"].ToString(),
                    City = request.Form["city"].ToString(),
                    State = request.Form["state"].ToString()
                }
                );

            response.Redirect("Default.aspx");
        }
    }
}