#pragma checksum "D:\Đồ Án 1\WebsitePhoneDoAn1\WebsitePhoneDoAn1\Views\Home\LienHe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98cce034b0d3fc7cd3eaafcf5d3fe3a44e33481d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LienHe), @"mvc.1.0.view", @"/Views/Home/LienHe.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98cce034b0d3fc7cd3eaafcf5d3fe3a44e33481d", @"/Views/Home/LienHe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aad7e0bbc85570f106ec7da61f297f0ed18ba195", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LienHe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Đồ Án 1\WebsitePhoneDoAn1\WebsitePhoneDoAn1\Views\Home\LienHe.cshtml"
  
    ViewData["Title"] = "LienHe";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"contact-1\">\r\n    <div class=\"container-fluid\">\r\n        <div class=\"contact-1-main\">\r\n            <div class=\"contact-right wow bounceInUp\" data-wow-delay=\"0.3s\">\r\n                <h3>Liên Hệ </h3>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98cce034b0d3fc7cd3eaafcf5d3fe3a44e33481d3694", async() => {
                WriteLiteral("\r\n                    <p>Name</p>\r\n                    <input type=\"text\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 397, "\"", 411, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 412, "\"", 423, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <p>Email</p>\r\n                    <input type=\"text\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 501, "\"", 515, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 516, "\"", 527, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <p>Telephone</p>\r\n                    <input type=\"text\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 609, "\"", 623, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 624, "\"", 635, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <p>Message</p>\r\n                    <textarea");
                BeginWriteAttribute("placeholder", " placeholder=\"", 706, "\"", 720, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 721, "\"", 732, 0);
                EndWriteAttribute();
                WriteLiteral("> </textarea>\r\n                    <input type=\"submit\" value=\"Send\">\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>

            <div class=""clearfix""> </div>
        </div>
        <div class=""map wow bounceInRight"" data-wow-delay=""0.3s"">
            <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d538.1464125615497!2d106.66721038089503!3d10.776253340800718!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x429098e67e8786a7!2zS2hvYSBDw7RuZyBOZ2jhu4cgVGjDtG5nIFRpbiAtIMOQ4bqhaSBI4buNYyBOZ2_huqFpIE5n4buvIFRpbiBI4buNYyBUaMOgbmggUGjhu5EgSOG7kyBDaMOtIE1pbmg!5e0!3m2!1svi!2s!4v1594741116557!5m2!1svi!2s"" width=""600"" height=""450"" frameborder=""0"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 1424, "\"", 1442, 0);
            EndWriteAttribute();
            WriteLiteral(" aria-hidden=\"false\" tabindex=\"0\"></iframe>\r\n        </div>\r\n    </div>\r\n</div>");
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