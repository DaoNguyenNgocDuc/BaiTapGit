#pragma checksum "C:\Users\ASUS\Desktop\DOANWEB\WepAppDA\webapp\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc9669d28f97390a1fa1a0936fb3eea2d4e59b1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ASUS\Desktop\DOANWEB\WepAppDA\webapp\Views\_ViewImports.cshtml"
using webapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\DOANWEB\WepAppDA\webapp\Views\_ViewImports.cshtml"
using webapp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc9669d28f97390a1fa1a0936fb3eea2d4e59b1b", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65a1c503453d7dd6178e7cc0a511687825341a73", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\DOANWEB\WepAppDA\webapp\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Page Header Section Start Here -->
<section class=""page-header"">
    <div class=""container"">
        <div class=""page-title"">
            <h2>Tin Tức Mới Nhất</h2>
            <ul class=""breadcrumb lab-ul"">
                <li><a href=""index.html"">Trang</a></li>
                <li>Blog</li>
            </ul>
        </div>
    </div>
</section>
<!-- Page Header Section Ending Here -->
<!-- Blog Section Start Here -->
<section class=""blog-section padding-tb"">
    <div class=""container"">
        <div class=""section-wrapper"">
            <div class=""row justify-content-center"">
");
#nullable restore
#line 24 "C:\Users\ASUS\Desktop\DOANWEB\WepAppDA\webapp\Views\Blog\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-4 col-sm-6 col-12"">
                    <div class=""post-item"">
                        <div class=""post-item-inner"">
                            <div class=""post-thumb"">
                                <a href=""#""><img");
            BeginWriteAttribute("src", " src=\"", 1019, "\"", 1034, 1);
#nullable restore
#line 30 "C:\Users\ASUS\Desktop\DOANWEB\WepAppDA\webapp\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1025, item.Anh, 1025, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"lab-blog\"></a>\r\n                            </div>\r\n                            <div class=\"post-content\">\r\n                                <h5><a");
            BeginWriteAttribute("href", " href=\"", 1187, "\"", 1220, 2);
            WriteAttributeValue("", 1194, "/Blog/Details/", 1194, 14, true);
#nullable restore
#line 33 "C:\Users\ASUS\Desktop\DOANWEB\WepAppDA\webapp\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1208, item.Mablog, 1208, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 33 "C:\Users\ASUS\Desktop\DOANWEB\WepAppDA\webapp\Views\Blog\Index.cshtml"
                                                                    Write(item.Tieude.Substring(0, 20));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</a></h5>\r\n                                <div class=\"author-date\">\r\n                                    <a href=\"#\" class=\"date\"><i class=\"icofont-calendar\"></i>");
#nullable restore
#line 35 "C:\Users\ASUS\Desktop\DOANWEB\WepAppDA\webapp\Views\Blog\Index.cshtml"
                                                                                        Write(item.Ngaydang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    <a href=\"#\" class=\"admin\"><i class=\"icofont-ui-user\"></i>");
#nullable restore
#line 36 "C:\Users\ASUS\Desktop\DOANWEB\WepAppDA\webapp\Views\Blog\Index.cshtml"
                                                                                        Write(item.Tk);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                                </div>\r\n");
#nullable restore
#line 38 "C:\Users\ASUS\Desktop\DOANWEB\WepAppDA\webapp\Views\Blog\Index.cshtml"
                                 if (item.Noidung.Length < 50)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>");
#nullable restore
#line 40 "C:\Users\ASUS\Desktop\DOANWEB\WepAppDA\webapp\Views\Blog\Index.cshtml"
                                  Write(item.Noidung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 41 "C:\Users\ASUS\Desktop\DOANWEB\WepAppDA\webapp\Views\Blog\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>");
#nullable restore
#line 44 "C:\Users\ASUS\Desktop\DOANWEB\WepAppDA\webapp\Views\Blog\Index.cshtml"
                          Write(item.Noidung.Substring(0, 50));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</p>\r\n");
#nullable restore
#line 45 "C:\Users\ASUS\Desktop\DOANWEB\WepAppDA\webapp\Views\Blog\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"post-footer\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2053, "\"", 2086, 2);
            WriteAttributeValue("", 2060, "/Blog/Details/", 2060, 14, true);
#nullable restore
#line 47 "C:\Users\ASUS\Desktop\DOANWEB\WepAppDA\webapp\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2074, item.Mablog, 2074, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""text-btn"">Read More<i class=""icofont-double-right""></i></a>
                                    <a href=""#"" class=""comments""><i class=""icofont-comment""></i><span>2</span></a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 54 "C:\Users\ASUS\Desktop\DOANWEB\WepAppDA\webapp\Views\Blog\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n              \r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Blog Section Ending Here -->\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
