#pragma checksum "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\ChiTietHoaDon\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ec8f5e65eb16fa4b98216023de24d193ac28a8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ChiTietHoaDon_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/ChiTietHoaDon/Details.cshtml")]
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
#line 1 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\_ViewImports.cshtml"
using DoAn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\_ViewImports.cshtml"
using DoAn.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ec8f5e65eb16fa4b98216023de24d193ac28a8d", @"/Areas/Admin/Views/ChiTietHoaDon/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2aaba470b291693f49e42ad8eab78ba239a959a4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ChiTietHoaDon_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoAn.Areas.Admin.Models.ChiTietHoaDonModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\ChiTietHoaDon\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>ChiTietHoaDonModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\ChiTietHoaDon\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaHoaDon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\ChiTietHoaDon\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaHoaDon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\ChiTietHoaDon\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TenDienThoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\ChiTietHoaDon\Details.cshtml"
       Write(Html.DisplayFor(model => model.TenDienThoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\ChiTietHoaDon\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\ChiTietHoaDon\Details.cshtml"
       Write(Html.DisplayFor(model => model.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\ChiTietHoaDon\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DonGia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\ChiTietHoaDon\Details.cshtml"
       Write(Html.DisplayFor(model => model.DonGia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\ChiTietHoaDon\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GiaKhuyenMai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\ChiTietHoaDon\Details.cshtml"
       Write(Html.DisplayFor(model => model.GiaKhuyenMai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ec8f5e65eb16fa4b98216023de24d193ac28a8d7793", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "D:\Nam3-HK1\ASP.NET\DoAnASP.NET\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\ChiTietHoaDon\Details.cshtml"
                           WriteLiteral(Model.ID);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ec8f5e65eb16fa4b98216023de24d193ac28a8d9964", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoAn.Areas.Admin.Models.ChiTietHoaDonModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
