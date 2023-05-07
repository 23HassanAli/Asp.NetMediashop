using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.ComponentModel;
using System.Net.Http;

namespace PXLPRO2023Shoppers24.TagHelpers
{
    [HtmlTargetElement("div")]
    public class TestTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.PreContent.SetHtmlContent("<b>");
            output.PostContent.SetHtmlContent("</b>");
        }
        private TagBuilder GetFormattedDiv(string content)
        {
            TagBuilder title = new TagBuilder("h1");
            title.InnerHtml.Append(content);
            TagBuilder container = new TagBuilder("div");
            container.Attributes["class"] = "bg-info m-1 p-1";
            container.InnerHtml.AppendHtml(title);
            return container;
        }
    }
}
