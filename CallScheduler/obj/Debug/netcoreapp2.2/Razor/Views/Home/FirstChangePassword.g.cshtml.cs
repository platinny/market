#pragma checksum "C:\Users\Ayotunde\Documents\CallScheduler\CallScheduler\Views\Home\FirstChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2d2d03ac12fdb0ae1b27dacd9d2750cae16535e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FirstChangePassword), @"mvc.1.0.view", @"/Views/Home/FirstChangePassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/FirstChangePassword.cshtml", typeof(AspNetCore.Views_Home_FirstChangePassword))]
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
#line 1 "C:\Users\Ayotunde\Documents\CallScheduler\CallScheduler\Views\_ViewImports.cshtml"
using CallScheduler;

#line default
#line hidden
#line 2 "C:\Users\Ayotunde\Documents\CallScheduler\CallScheduler\Views\_ViewImports.cshtml"
using CallScheduler.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2d2d03ac12fdb0ae1b27dacd9d2750cae16535e", @"/Views/Home/FirstChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"022342d3dceb960d97de97251f131ea87ea006fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FirstChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("change-password"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Ayotunde\Documents\CallScheduler\CallScheduler\Views\Home\FirstChangePassword.cshtml"
  
    ViewData["Title"] = "First Change Password";

#line default
#line hidden
            BeginContext(59, 250, true);
            WriteLiteral("\r\n<div id=\"colorlib-contact\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-8 animate-box\" align=\"center\" style=\"margin-left:10%;margin-top:10%;\">\r\n                <h2>Change Password</h2>\r\n\r\n                ");
            EndContext();
            BeginContext(309, 1653, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2d2d03ac12fdb0ae1b27dacd9d2750cae16535e4641", async() => {
                BeginContext(350, 223, true);
                WriteLiteral("\r\n                    <div class=\"row form-group\">\r\n                        <div class=\"col-md-12\">\r\n                            <input type=\"hidden\" name=\"Username\" id=\"Username\" class=\"form-control\" placeholder=\"Username\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 573, "\"", 602, 1);
#line 15 "C:\Users\Ayotunde\Documents\CallScheduler\CallScheduler\Views\Home\FirstChangePassword.cshtml"
WriteAttributeValue("", 581, ViewData["Username"], 581, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(603, 1352, true);
                WriteLiteral(@" style=""text-align:center;"">
                        </div>
                    </div>
                    <div class=""row form-group"">
                        <div class=""col-md-12"">
                            <input type=""password"" name=""OldPassword"" id=""OldPassword"" class=""form-control"" placeholder=""Old Password"" style=""text-align:center;"">
                        </div>
                    </div>
                    <div class=""row form-group"">
                        <div class=""col-md-12"">
                            <input type=""password"" name=""NewPassword"" id=""NewPassword"" class=""form-control"" placeholder=""New Password"" style=""text-align:center;"">
                        </div>
                    </div>
                    <div class=""row form-group"">
                        <div class=""col-md-12"">
                            <input type=""password"" name=""ConfirmPassword"" id=""ConfirmPassword"" class=""form-control"" placeholder=""Confirm Password"" style=""text-align:center;"">
             ");
                WriteLiteral(@"           </div>
                    </div>
                    <div class=""form-group"">
                        <div class=""col-md-12"">
                            <button type=""submit"" class=""btn btn-primary"" style=""width:50%;"">Submit</button>
                        </div>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1962, 60, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2039, 1558, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {

        });

        $('#change-password').submit(function (event) {
            console.log(""submit!"");
            event.preventDefault();

            var data = new FormData();
            data.append(""Username"", $(""#Username"").val());
            data.append(""OldPassword"", $(""#OldPassword"").val());
            data.append(""NewPassword"", $(""#NewPassword"").val());
            data.append(""ConfirmPassword"", $(""#ConfirmPassword"").val());

            $.ajax({
                type: 'POST',
                url: '/api/changepassword',
                contentType: false,
                processData: false,
                data: data,
                success: function (message) {
                    console.log(message);
                    var loginSuccess = message.success;
                    var loginStatus = message.status;
                    if (loginSuccess == true) {
                        setTimeout(function () {
       ");
                WriteLiteral(@"                     $('#OldPassword').val('');
                            $('#NewPassword').val('');
                            $('#ConfirmPassword').val('');
                            window.location.href = loginStatus;
                        }, 2000);
                    } else {
                        alert(loginStatus);
                    }
                },
                error: function () {
                    alert(""An error occurred"");
                }
            });
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(3600, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
