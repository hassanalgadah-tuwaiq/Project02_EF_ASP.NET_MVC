#pragma checksum "C:\Users\Hassan\Desktop\Project02_EF_ASP.NET_MVC\animeik\animeik\Views\Anime\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5aecf54b31c73277f92128ee7cf0f02b4c0b58b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anime_Details), @"mvc.1.0.view", @"/Views/Anime/Details.cshtml")]
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
#line 1 "C:\Users\Hassan\Desktop\Project02_EF_ASP.NET_MVC\animeik\animeik\Views\_ViewImports.cshtml"
using animeik;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hassan\Desktop\Project02_EF_ASP.NET_MVC\animeik\animeik\Views\_ViewImports.cshtml"
using animeik.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5aecf54b31c73277f92128ee7cf0f02b4c0b58b9", @"/Views/Anime/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cf84c05be49bfe609698b79df22ecb03679115f", @"/Views/_ViewImports.cshtml")]
    public class Views_Anime_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Hassan\Desktop\Project02_EF_ASP.NET_MVC\animeik\animeik\Views\Anime\Details.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";
    Anime a = (Anime)ViewData["anime"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<H1>");
#nullable restore
#line 7 "C:\Users\Hassan\Desktop\Project02_EF_ASP.NET_MVC\animeik\animeik\Views\Anime\Details.cshtml"
Write(a.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</H1>\r\n<div style=\"font-family: Arial, sans-serif ; font-size: x-large\">\r\n    <div style=\"float: left; margin-right: 1em\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 253, "\"", 271, 1);
#nullable restore
#line 10 "C:\Users\Hassan\Desktop\Project02_EF_ASP.NET_MVC\animeik\animeik\Views\Anime\Details.cshtml"
WriteAttributeValue("", 259, a.image_url, 259, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n    </div>\r\n    <p>Title: ");
#nullable restore
#line 12 "C:\Users\Hassan\Desktop\Project02_EF_ASP.NET_MVC\animeik\animeik\Views\Anime\Details.cshtml"
         Write(a.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Type: ");
#nullable restore
#line 13 "C:\Users\Hassan\Desktop\Project02_EF_ASP.NET_MVC\animeik\animeik\Views\Anime\Details.cshtml"
        Write(a.type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Episodes: ");
#nullable restore
#line 14 "C:\Users\Hassan\Desktop\Project02_EF_ASP.NET_MVC\animeik\animeik\Views\Anime\Details.cshtml"
            Write(a.episodes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Start date: ");
#nullable restore
#line 15 "C:\Users\Hassan\Desktop\Project02_EF_ASP.NET_MVC\animeik\animeik\Views\Anime\Details.cshtml"
              Write(a.start_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>End date: ");
#nullable restore
#line 16 "C:\Users\Hassan\Desktop\Project02_EF_ASP.NET_MVC\animeik\animeik\Views\Anime\Details.cshtml"
            Write(a.end_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Score: ");
#nullable restore
#line 17 "C:\Users\Hassan\Desktop\Project02_EF_ASP.NET_MVC\animeik\animeik\Views\Anime\Details.cshtml"
         Write(a.score);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 482, "\"", 495, 1);
#nullable restore
#line 18 "C:\Users\Hassan\Desktop\Project02_EF_ASP.NET_MVC\animeik\animeik\Views\Anime\Details.cshtml"
WriteAttributeValue("", 489, a.url, 489, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">MAL</a>\r\n</div>");
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
