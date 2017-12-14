using Abp.Web.Mvc.Views;

namespace DzeTask.Web.Views
{
    public abstract class DzeTaskWebViewPageBase : DzeTaskWebViewPageBase<dynamic>
    {

    }

    public abstract class DzeTaskWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected DzeTaskWebViewPageBase()
        {
            LocalizationSourceName = DzeTaskConsts.LocalizationSourceName;
        }
    }
}