#pragma checksum "D:\HocTap\Đồ Án ASP.Net\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\Shared\_HeaderPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eadb184331212f724d6b9860fc1071480869d687"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__HeaderPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_HeaderPartial.cshtml")]
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
#line 1 "D:\HocTap\Đồ Án ASP.Net\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\_ViewImports.cshtml"
using DoAn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HocTap\Đồ Án ASP.Net\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\_ViewImports.cshtml"
using DoAn.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eadb184331212f724d6b9860fc1071480869d687", @"/Areas/Admin/Views/Shared/_HeaderPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2aaba470b291693f49e42ad8eab78ba239a959a4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__HeaderPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/template/assetsadmin/images/logo.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("srcset", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div id=\"app\">\r\n    <div id=\"sidebar\" class=\'active\'>\r\n        <div class=\"sidebar-wrapper active\">\r\n            <div class=\"sidebar-header\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eadb184331212f724d6b9860fc1071480869d6874521", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""sidebar-menu"">
                <ul class=""menu"">
                    <li class='sidebar-title'>Main Menu</li>
                    <li class=""sidebar-item active"">
                        <i data-feather=""home"" width=""20""></i>
                        ");
#nullable restore
#line 13 "D:\HocTap\Đồ Án ASP.Net\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\Shared\_HeaderPartial.cshtml"
                   Write(Html.ActionLink("DongDienThoai", "Index", "DongDienThoai", null, new { @class = "sidebar-link" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"sidebar-item \">\r\n                        <i data-feather=\"home\" width=\"20\"></i>\r\n                        ");
#nullable restore
#line 17 "D:\HocTap\Đồ Án ASP.Net\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\Shared\_HeaderPartial.cshtml"
                   Write(Html.ActionLink("DienThoai", "Index", "DienThoai", null, new { @class = "sidebar-link" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </li>
                </ul>
            </div>
            <button class=""sidebar-toggler btn x""><i data-feather=""x""></i></button>
        </div>
    </div>
    <div id=""main"">
        <nav class=""navbar navbar-header navbar-expand navbar-light"">
            <a class=""sidebar-toggler"" href=""#""><span class=""navbar-toggler-icon""></span></a>
            <button class=""btn navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent""
                    aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                <ul class=""navbar-nav d-flex align-items-center navbar-light ml-auto"">
                    <li class=""dropdown nav-icon"">
                        <a href=""#"" data-toggle=""dropdown"" class=""nav-link  dropdown-toggle nav-link-lg nav-link-");
            WriteLiteral(@"user"">
                            <div class=""d-lg-inline-block"">
                                <i data-feather=""bell""></i>
                            </div>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right dropdown-menu-large"">
                            <h6 class='py-2 px-4'>Notifications</h6>
                            <ul class=""list-group rounded-none"">
                                <li class=""list-group-item border-0 align-items-start"">
                                    <div class=""avatar bg-success mr-3"">
                                        <span class=""avatar-content""><i data-feather=""shopping-cart""></i></span>
                                    </div>
                                    <div>
                                        <h6 class='text-bold'>New Order</h6>
                                        <p class='text-xs'>
                                            An order made by Ahmad Saugi for product Samsung Gal");
            WriteLiteral(@"axy S69
                                        </p>
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </li>
                    <li class=""dropdown nav-icon mr-2"">
                        <a href=""#"" data-toggle=""dropdown"" class=""nav-link  dropdown-toggle nav-link-lg nav-link-user"">
                            <div class=""d-lg-inline-block"">
                                <i data-feather=""mail""></i>
                            </div>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right"">
                            <a class=""dropdown-item"" href=""#""><i data-feather=""user""></i> Account</a>
                            <a class=""dropdown-item active"" href=""#""><i data-feather=""mail""></i> Messages</a>
                            <a class=""dropdown-item"" href=""#""><i data-feather=""settings""></i> Settings</a>
                            <di");
            WriteLiteral(@"v class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#""><i data-feather=""log-out""></i> Logout</a>
                        </div>
                    </li>
                    <li class=""dropdown"">
                        <a href=""#"" data-toggle=""dropdown"" class=""nav-link dropdown-toggle nav-link-lg nav-link-user"">
                            <div class=""avatar mr-1"">
                                <img src=""assets/images/avatar/avatar-s-1.png""");
            BeginWriteAttribute("alt", " alt=\"", 4449, "\"", 4455, 0);
            EndWriteAttribute();
            BeginWriteAttribute("srcset", " srcset=\"", 4456, "\"", 4465, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right"">
                            <a class=""dropdown-item"" href=""#""><i data-feather=""user""></i> Account</a>
                            <a class=""dropdown-item active"" href=""#""><i data-feather=""mail""></i> Messages</a>
                            <a class=""dropdown-item"" href=""#""><i data-feather=""settings""></i> Settings</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#""><i data-feather=""log-out""></i> Logout</a>
                        </div>
                    </li>
                    <li>Hi, ");
#nullable restore
#line 84 "D:\HocTap\Đồ Án ASP.Net\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\Shared\_HeaderPartial.cshtml"
                       Write(ViewBag.account);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n");
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
