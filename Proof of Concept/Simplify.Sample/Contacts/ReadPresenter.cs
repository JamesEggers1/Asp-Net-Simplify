namespace Simplify.Sample.Contacts
{
    public class ReadPresenter : PresenterBase
    {
			protected override void Get()
			{
				Model = DataSource.Contacts;
			}
    }
}