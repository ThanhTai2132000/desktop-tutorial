#pragma checksum "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Cart\ListCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10d29452f3c3841d4c4322e3e8f7ae65efc89885"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_ListCart), @"mvc.1.0.view", @"/Views/Cart/ListCart.cshtml")]
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
#line 2 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\_ViewImports.cshtml"
using DoAn.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\_ViewImports.cshtml"
using DoAn.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\_ViewImports.cshtml"
using DoAn.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10d29452f3c3841d4c4322e3e8f7ae65efc89885", @"/Views/Cart/ListCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c07e4fd978363e222be5ebb8d49ce034c81635b", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_ListCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "deleteCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Cart\ListCart.cshtml"
  
    ViewData["Title"] = "ListCart";
    Layout = "~/Views/Shared/_Layout.cshtml";
  

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n<div class=\"container\">\r\n    <div class=\"list-cart\">\r\n        <table class=\"table\" border=\"1\">\r\n");
#nullable restore
#line 10 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Cart\ListCart.cshtml"
              
                int STT = 0;
                if (ViewBag.carts != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <thead>
                        <tr class=""info"">
                            <th>ID</th>
                            <th>Tên Điện Thoại</th>
                            <th>Hình Điện Thoại</th>
                            <th>Đợn Giá</th>
                            <th>Số Lượng</th>
                            <th>Tổng Giá</th>
                            <th>Cập Nhật</th>
                            <th>Xoá</th>
                        </tr>
                    </thead>
");
#nullable restore
#line 26 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Cart\ListCart.cshtml"
                    foreach (var item in ViewBag.carts)
                    {
                        string txt_class = "quantity_" + item.DienThoai.ID;
                        STT++;
                        float total = item.DienThoai.DonGia * item.Quantity;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <thead>\r\n                            <tr class=\"info\">\r\n\r\n                                <td>");
#nullable restore
#line 34 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Cart\ListCart.cshtml"
                               Write(STT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 35 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Cart\ListCart.cshtml"
                               Write(item.DienThoai.TenDT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "10d29452f3c3841d4c4322e3e8f7ae65efc898857723", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1322, "~/ImgDienThoai/", 1322, 15, true);
#nullable restore
#line 36 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Cart\ListCart.cshtml"
AddHtmlAttributeValue("", 1337, item.DienThoai.Hinh, 1337, 20, false);

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
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 37 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Cart\ListCart.cshtml"
                               Write(item.DienThoai.DonGia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><input type=\"number\"");
            BeginWriteAttribute("class", " class=\"", 1514, "\"", 1532, 1);
#nullable restore
#line 38 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Cart\ListCart.cshtml"
WriteAttributeValue("", 1522, txt_class, 1522, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1533, "\"", 1555, 1);
#nullable restore
#line 38 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Cart\ListCart.cshtml"
WriteAttributeValue("", 1541, item.Quantity, 1541, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                                <td>");
#nullable restore
#line 39 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Cart\ListCart.cshtml"
                               Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1653, "\"", 1660, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 40 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Cart\ListCart.cshtml"
                                                   Write(item.DienThoai.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"updateCart\">Update</a></td>\r\n                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10d29452f3c3841d4c4322e3e8f7ae65efc8988511434", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Cart\ListCart.cshtml"
                                                                                       WriteLiteral(item.DienThoai.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n\r\n                            </tr>\r\n                        </thead>\r\n");
#nullable restore
#line 45 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Cart\ListCart.cshtml"
                    }
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h1>Vỏ Hàng Trống</h1>\r\n");
#nullable restore
#line 50 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Cart\ListCart.cshtml"
                    ;
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </table>\r\n        <center><button onclick=\"ThanhToan()\" class=\"btn btn-success\">Thanh Toán</button></center>  \r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

        <script>
            $(document).ready(function () {
                $("".updateCart"").click(function (event) {
                    event.preventDefault();
                    var quantity = $("".quantity_"" + $(this).attr(""data-id"")).val();
                    console.log(quantity);
                    $.ajax({
                        type: ""POST"",
                        url:""");
#nullable restore
#line 68 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Cart\ListCart.cshtml"
                        Write(Url.Action("updateCart","Cart"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                        data: {
                            id: $(this).attr(""data-id""),
                            quantity:quantity
                        },
                        success: function (result) {
                            window.location.href = '");
#nullable restore
#line 74 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Cart\ListCart.cshtml"
                                               Write(Url.Action("ListCart","Cart"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
                        }
                    });
                });
            });
        </script>

        <script>
            function ThanhToan() {
                $.ajax({
                    url: ""../Cart/ThanhToan"",
                    
                    success: function (res) {
                        if (res == false) {
                            alert(""Không thể thực hiện thanh toán"")
                        } else {
                            alert(""Thanh toán thành công"")
                        }
                        window.location.reload()
                    }
                });
            }
        </script>
    ");
            }
            );
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
