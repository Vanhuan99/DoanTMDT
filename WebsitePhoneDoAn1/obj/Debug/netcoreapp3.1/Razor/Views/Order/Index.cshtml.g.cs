#pragma checksum "D:\Đồ Án 1\WebsitePhoneDoAn1\WebsitePhoneDoAn1\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1484c4483f7e9dc126576717bc8c37f3763412d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1484c4483f7e9dc126576717bc8c37f3763412d", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aad7e0bbc85570f106ec7da61f297f0ed18ba195", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Cart/XacNhan"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Đồ Án 1\WebsitePhoneDoAn1\WebsitePhoneDoAn1\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table>
    <tr>
        <th>
            <h1>GIỎ HÀNG CỦA BẠN</h1>
        </th>
        <th colspan=""6"">
            &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;
            &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;
        </th>
    </tr>
</table>

<div class=""container"">
    <div class=""row"">
        <div class=""col-sm-12"">
            <table class=""table"">
                <tr>
                    <th>Hình ảnh</th>
                    <th>Tên Sản phẩm</th>
                    <th>số lượng</th>
                    <th>Giá tiền</th>
                </tr>
");
#nullable restore
#line 29 "D:\Đồ Án 1\WebsitePhoneDoAn1\WebsitePhoneDoAn1\Views\Order\Index.cshtml"
                 foreach (var item in ViewBag.cart)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 888, "\"", 919, 1);
#nullable restore
#line 33 "D:\Đồ Án 1\WebsitePhoneDoAn1\WebsitePhoneDoAn1\Views\Order\Index.cshtml"
WriteAttributeValue("", 896, item.Product.ProductId, 896, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1484c4483f7e9dc126576717bc8c37f3763412d6367", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 963, "~/images/", 963, 9, true);
#nullable restore
#line 34 "D:\Đồ Án 1\WebsitePhoneDoAn1\WebsitePhoneDoAn1\Views\Order\Index.cshtml"
AddHtmlAttributeValue("", 972, item.Product.ProductImage, 972, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                        <th>\r\n                            ");
#nullable restore
#line 37 "D:\Đồ Án 1\WebsitePhoneDoAn1\WebsitePhoneDoAn1\Views\Order\Index.cshtml"
                       Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <td>");
#nullable restore
#line 39 "D:\Đồ Án 1\WebsitePhoneDoAn1\WebsitePhoneDoAn1\Views\Order\Index.cshtml"
                       Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "D:\Đồ Án 1\WebsitePhoneDoAn1\WebsitePhoneDoAn1\Views\Order\Index.cshtml"
                       Write(item.Product.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 42 "D:\Đồ Án 1\WebsitePhoneDoAn1\WebsitePhoneDoAn1\Views\Order\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td align=\"right\" colspan=\"6\"><strong>Tạm tính:</strong></td>\r\n                    <td style=\"color:#d72626\">\r\n                        ");
#nullable restore
#line 46 "D:\Đồ Án 1\WebsitePhoneDoAn1\WebsitePhoneDoAn1\Views\Order\Index.cshtml"
                   Write(ViewBag.total);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
                </tr>
                <tr>
                    <td align=""right"" colspan=""6"">Khuyến mãi:</td>
                    <td>
                        0.00
                    </td>
                </tr>
                <tr>
                    <td align=""right"" colspan=""6""><strong>Tổng tiền:</strong></td>
                    <td style=""color:#d72626"">
                        ");
#nullable restore
#line 58 "D:\Đồ Án 1\WebsitePhoneDoAn1\WebsitePhoneDoAn1\Views\Order\Index.cshtml"
                   Write(ViewBag.total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n            </table>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1484c4483f7e9dc126576717bc8c37f3763412d10336", async() => {
                WriteLiteral(@"
                <h4>THÔNG TIN KHÁCH HÀNG</h4>
                <div class=""form-group"">
                    <label for=""inputName"">Họ và tên: </label>
                    <input type=""text"" class=""form-control"" name=""Name"" id=""Name"" placeholder=""FullName"">
                </div>
                <div class=""form-group"">
                    <label for=""inputSDT"">Số điện thoại: </label>
                    <input type=""number"" class=""form-control"" name=""sdt"" id=""sdt"" placeholder=""Phone Number"">
                </div>
                <div class=""form-group"">
                    <label for=""inputEmail"">Email</label>
                    <input type=""email"" class=""form-control"" name=""Email"" id=""Email"" placeholder=""Email"">
                </div><br />
                <div>
                    <input type=""submit"" class=""form-control btn-outline-success"" value=""THANH TOÁN"" />
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
