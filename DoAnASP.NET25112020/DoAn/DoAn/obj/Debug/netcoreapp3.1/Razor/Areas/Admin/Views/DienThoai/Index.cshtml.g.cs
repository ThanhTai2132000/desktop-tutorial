#pragma checksum "C:\Users\Admin\Documents\GitHub\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\DienThoai\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "348daf814837d0cdfa13686748427dc0d2c63d45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DienThoai_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/DienThoai/Index.cshtml")]
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
#line 1 "C:\Users\Admin\Documents\GitHub\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\_ViewImports.cshtml"
using DoAn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\_ViewImports.cshtml"
using DoAn.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"348daf814837d0cdfa13686748427dc0d2c63d45", @"/Areas/Admin/Views/DienThoai/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2aaba470b291693f49e42ad8eab78ba239a959a4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_DienThoai_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoAn.Areas.Admin.Models.DienThoaiModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Admin\Documents\GitHub\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\DienThoai\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"text\" id=\"Search\" placeholder=\"Search here...\" />\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "348daf814837d0cdfa13686748427dc0d2c63d453980", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Admin\Documents\GitHub\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\DienThoai\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TenDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Admin\Documents\GitHub\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\DienThoai\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DongDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Admin\Documents\GitHub\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\DienThoai\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Hinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Admin\Documents\GitHub\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\DienThoai\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DonGia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Admin\Documents\GitHub\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Areas\Admin\Views\DienThoai\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GiaKM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody id=\"list-dt\">\r\n");
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"    <script>
        $(document).ready(function () {
            function Contains(txt_one, txt_two) {
                if (txt_one.indexOf(txt_two) != -1)
                    return true;
            }
            $(""#Search"").keyup(function () {
                var searchText = $(""#Search"").val().toLowerCase();
                $("".result"").each(function () {
                    if (!Contains($(this).text().toLowerCase(), searchText)) {
                        $(this).hide();
                    } else { $(this).show(); }
                });
            });
        });
    </script>


");
                WriteLiteral(@"<script>

        $(document).ready(function () {
            $.ajax({
                method: ""GET"",
                url: ""../api/PhoneListAPI/GetPhoneList"",

                success: function (list) {
                    listJSON = JSON.parse(list);
                    var data = '';
                    $.each(listJSON, function (key, value) {
                        data += '<tr class=""result"">';
                        data += '<td>' + value.TenDT + '</td>';
                        data += '<td>' + value.MaDT + '</td>';
                        data += '<td>' + value.Hinh + '</td>';
                        data += '<td>' + value.DonGia + '</td>';
                        data += '<td>' + value.GiaKM + '</td>';
                        data += '<td>';
                        data += '<a href=""/Admin/DienThoai/Edit/' + value.ID + '"">Edit</a> |';
                        data += '<a href=""/Admin/DienThoai/Details/' + value.ID + '"">Details</a> |';
                        data += '<a href=""/Adm");
                WriteLiteral(@"in/DienThoai/Delete/' + value.ID + '"">Delete</a>';
                        data += '</td>';
                        data += '</tr>';

                    });
                    $('#list-dt').append(data);
                }

            });

        });

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoAn.Areas.Admin.Models.DienThoaiModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
