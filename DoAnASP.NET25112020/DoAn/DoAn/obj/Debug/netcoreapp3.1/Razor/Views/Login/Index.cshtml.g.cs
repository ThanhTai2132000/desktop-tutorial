#pragma checksum "D:\HocTap\Đồ Án ASP.Net\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "362ecf3edae01d97604170288614601bbea27f66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
#line 1 "D:\HocTap\Đồ Án ASP.Net\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\_ViewImports.cshtml"
using DoAn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HocTap\Đồ Án ASP.Net\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\_ViewImports.cshtml"
using DoAn.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\HocTap\Đồ Án ASP.Net\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\HocTap\Đồ Án ASP.Net\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\HocTap\Đồ Án ASP.Net\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\_ViewImports.cshtml"
using DoAn.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"362ecf3edae01d97604170288614601bbea27f66", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"902cfcc0b7af8a203eaf620f3a858948f8e47815", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<!-- Modal -->
<div class=""modal fade"" id=""form-modal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"" data-backdrop=""false"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title""></h5>
                
            </div>
            <div class=""modal-body"">
               
            </div>
            <div class=""modal-footer"">
                <center><button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Đóng</button></center>  
                
            </div>
        </div>
    </div>
</div>

<input class=""form-control"" type=""text"" id=""UserName"" name=""UserName"" placeholder=""User Name"" />
<input class=""form-control"" type=""password"" id=""Password"" name=""Password"" placeholder=""Password"" />
<button class=""btn btn-primary"" onclick=""Login()"" name=""abc"">Login</button>

<p id=""demo""></p>


");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function Login() {
            var username = $(""#UserName"").val();
            var pass = $(""#Password"").val();

            $.ajax({
                method: ""GET"",
                url: ""../api/LoginAPI/GetAccount"",
                data: {
                    'username': username,
                    'password': pass
                },

               
                success: function (status) {
                    //Neu ghi JSON.stringify(status) luc nay thi status co gtr la:
                    //""{\""TenTK\"":\""Admin\"",\""MatKhau\"":\""123\"",\""LoaiTK\"":0}"" nen phai thuc hien JSON.parse()

                    var statusAfter = JSON.parse(status); //Luc nay statusAfter co kdl la JSON va gtr la:
                    //{ ""TenTK"": ""Admin"", ""MatKhau"": ""123"", ""LoaiTK"": 0 }

                    //Kiem tra tai khoan co ton tai hay khong
                    if (statusAfter != null) {
                        if (statusAfter.LoaiTK == 0) window.location.href = '");
#nullable restore
#line 59 "D:\HocTap\Đồ Án ASP.Net\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Login\Index.cshtml"
                                                                        Write(Url.Action("","Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n                        else if (statusAfter.LoaiTK == 1) window.location.href = \'");
#nullable restore
#line 60 "D:\HocTap\Đồ Án ASP.Net\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Login\Index.cshtml"
                                                                             Write(Url.Action("Index","Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
                    } else {

                        $('#form-modal .modal-body').html(""Sai tài khoản hoặc mật khẩu rồi bro ơi :(((("");
                        $('#form-modal .modal-title').html(""Thông báo"");
                        $('#form-modal').modal('show');
                        $(""#UserName"").val("""");
                        $(""#Password"").val("""");

                    }

");
                WriteLiteral("                }\r\n\r\n            })\r\n\r\n\r\n        };\r\n    </script>\r\n");
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
