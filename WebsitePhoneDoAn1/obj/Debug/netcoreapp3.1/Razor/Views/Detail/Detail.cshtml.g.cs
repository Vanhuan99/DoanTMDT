#pragma checksum "D:\Đồ Án 1\WebsitePhoneDoAn1\WebsitePhoneDoAn1\Views\Detail\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd64edd4641e6629f3f91d6edf9aa100242bbc88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Detail_Detail), @"mvc.1.0.view", @"/Views/Detail/Detail.cshtml")]
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
#line 1 "D:\Đồ Án 1\WebsitePhoneDoAn1\WebsitePhoneDoAn1\Views\_ViewImports.cshtml"
using WebsitePhoneDoAn1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Đồ Án 1\WebsitePhoneDoAn1\WebsitePhoneDoAn1\Views\_ViewImports.cshtml"
using WebsitePhoneDoAn1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd64edd4641e6629f3f91d6edf9aa100242bbc88", @"/Views/Detail/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aad7e0bbc85570f106ec7da61f297f0ed18ba195", @"/Views/_ViewImports.cshtml")]
    public class Views_Detail_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebsitePhoneDoAn1.Models.Domain.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Đồ Án 1\WebsitePhoneDoAn1\WebsitePhoneDoAn1\Views\Detail\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Detail</h1>\r\n<div class=\"card\">\r\n");
#nullable restore
#line 9 "D:\Đồ Án 1\WebsitePhoneDoAn1\WebsitePhoneDoAn1\Views\Detail\Detail.cshtml"
     foreach (var item in ViewBag.CategoryList)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card-header\">\r\n            <h4 class=\"card-title\"><a href=\"$\">");
#nullable restore
#line 12 "D:\Đồ Án 1\WebsitePhoneDoAn1\WebsitePhoneDoAn1\Views\Detail\Detail.cshtml"
                                          Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n        </div>\r\n");
#nullable restore
#line 14 "D:\Đồ Án 1\WebsitePhoneDoAn1\WebsitePhoneDoAn1\Views\Detail\Detail.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebsitePhoneDoAn1.Models.Domain.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
