using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using StoreApp.Web.Models;

namespace StoreApp.Web.TagHelpers
{ // _ViewImports burada aktif hale getirip projeye tanitacagiz.

    [HtmlTargetElement("div", Attributes ="page-model")]
    public class PageLinkTagHelper:TagHelper
    {
        [ViewContext]
        public ViewContext?  viewContext { get; set; }
        public PageInfo? pageModel { get; set; }
        public string? pageAction { get; set; }
        
        private IUrlHelperFactory _urlHelperFactory;

        public PageLinkTagHelper(IUrlHelperFactory urlHelperFactory)
        {
            _urlHelperFactory = urlHelperFactory;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (viewContext != null && pageModel !=null) 
            { 
                IUrlHelper urlHelper= _urlHelperFactory.GetUrlHelper(viewContext);// urlHelper.Action(PageAction, new {page=1});
                TagBuilder div = new TagBuilder("div");
                for (int i = 1; i <= pageModel.TotalPages; i++)
                {
                    TagBuilder link = new TagBuilder("a");
                    link.Attributes["href"] = urlHelper.Action(pageAction, new { page = i });
                    link.InnerHtml.Append(i.ToString());
                    div.InnerHtml.AppendHtml(link);
                }
                output.Content.AppendHtml(div.InnerHtml);
            }
            //base.Process(context, output);
        }
    }
}
