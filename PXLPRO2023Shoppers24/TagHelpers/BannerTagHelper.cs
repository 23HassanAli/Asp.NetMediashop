using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Net.Http;

namespace PXLPRO2023Shoppers24.TagHelpers
{
    [HtmlTargetElement(Attributes = "banner")]
    public class BannerTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string content = $@"<div class='card'>";

        }
    }
}
