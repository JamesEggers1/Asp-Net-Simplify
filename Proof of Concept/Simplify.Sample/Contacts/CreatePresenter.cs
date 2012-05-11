using System.Web;

namespace Simplify.Sample.Contacts
{
    public class CreatePresenter : PresenterBase
    {
			protected override void Get()
			{
				// do nothing;
			}

			protected override void Post()
			{
				if (Request.Form.Count == 0)
				{
					return;
				}

				DataSource.Contacts.Add(
						new Contact()
						{
							Id = int.Parse(Request.Form["id"].ToString()),
							FirstName = Request.Form["firstName"].ToString(),
							LastName = Request.Form["lastName"].ToString(),
							City = Request.Form["city"].ToString(),
							State = Request.Form["state"].ToString()
						}
						);

				Response.Redirect("Default.aspx");
			}
    }
}