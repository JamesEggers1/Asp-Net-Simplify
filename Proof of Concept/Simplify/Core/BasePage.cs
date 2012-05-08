using System;
using System.Web.UI;
using StructureMap;

namespace Simplify.Core
{
    [FileLevelControlBuilder(typeof(SimplifyPageControlBuilder))]
    public class BasePage : Page
    {
        public virtual dynamic Model { get { return null; } }
    }

    [FileLevelControlBuilder(typeof(SimplifyPageControlBuilder))]
    public class BasePage<T> : BasePage where T : IPresenter
    {
        public T Presenter { get; set; }

        public override dynamic Model { get { return Presenter.Model; } }

        public BasePage()
        {
            Presenter = ObjectFactory.GetInstance<T>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Presenter.HandleRequest(this.Request, this.Response);
        }
    }
}