#pragma checksum "C:\Users\Ayotunde\Documents\CallScheduler\CallScheduler\Views\Assigners\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f159f5f9356f1be89e280d42719863f1f98b190a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Assigners_Index), @"mvc.1.0.view", @"/Views/Assigners/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Assigners/Index.cshtml", typeof(AspNetCore.Views_Assigners_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f159f5f9356f1be89e280d42719863f1f98b190a", @"/Views/Assigners/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"022342d3dceb960d97de97251f131ea87ea006fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Assigners_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginatedList<Assigner>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Ayotunde\Documents\CallScheduler\CallScheduler\Views\Assigners\Index.cshtml"
  
    ViewData["Title"] = "Assigners";
    var index = (int)((Model.PageIndex - 1) * 10) + 1;
    var firstPage = 1;
    var lastPage = ViewBag.NumberOfPages;

#line default
#line hidden
            BeginContext(202, 393, true);
            WriteLiteral(@"
<div class=""colorlib-blog"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 text-center colorlib-heading animate-box"">
                <h2>
                    <span style=""float:left;"">Assigners</span>
                    <a href=""/Home/AddAssigner"" class=""btn btn-primary btn-sm"" style=""float:right;""> Add Assigner</a>
                </h2>
");
            EndContext();
#line 18 "C:\Users\Ayotunde\Documents\CallScheduler\CallScheduler\Views\Assigners\Index.cshtml"
                 if (Model.Count == 0)
                {

#line default
#line hidden
            BeginContext(654, 87, true);
            WriteLiteral("                <p>\r\n                    No Assigner available.\r\n                </p>\r\n");
            EndContext();
#line 23 "C:\Users\Ayotunde\Documents\CallScheduler\CallScheduler\Views\Assigners\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(760, 36, true);
            WriteLiteral("            </div>\r\n        </div>\r\n");
            EndContext();
#line 26 "C:\Users\Ayotunde\Documents\CallScheduler\CallScheduler\Views\Assigners\Index.cshtml"
         if (Model.Count != 0)
        {

#line default
#line hidden
            BeginContext(839, 433, true);
            WriteLiteral(@"            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""hpanel"">
                        <div class=""panel-heading"">
                            <div class=""panel-tools"">
                                <a class=""showhide""><i class=""fa fa-chevron-up""></i></a>
                                <a class=""closebox""><i class=""fa fa-times""></i></a>
                            </div>
");
            EndContext();
            BeginContext(1353, 730, true);
            WriteLiteral(@"                        </div>
                        <div class=""panel-body no-border no-shadow"">
                            <div class=""table-responsive"" style = ""font-size:40px"">
                                <table cellpadding=""1"" cellspacing=""1"" class=""table table-bordered table-striped"">
                                    <thead class="" text-primary"">
                                        <tr>
                                            <th>S/N</th>
                                            <th>Code</th>
                                            <th>Name</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
            EndContext();
#line 49 "C:\Users\Ayotunde\Documents\CallScheduler\CallScheduler\Views\Assigners\Index.cshtml"
                                         foreach (var mess in Model)
                                        {

#line default
#line hidden
            BeginContext(2196, 94, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>");
            EndContext();
            BeginContext(2292, 7, false);
#line 52 "C:\Users\Ayotunde\Documents\CallScheduler\CallScheduler\Views\Assigners\Index.cshtml"
                                            Write(index++);

#line default
#line hidden
            EndContext();
            BeginContext(2300, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(2356, 17, false);
#line 53 "C:\Users\Ayotunde\Documents\CallScheduler\CallScheduler\Views\Assigners\Index.cshtml"
                                           Write(mess.AssignerCode);

#line default
#line hidden
            EndContext();
            BeginContext(2373, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(2429, 9, false);
#line 54 "C:\Users\Ayotunde\Documents\CallScheduler\CallScheduler\Views\Assigners\Index.cshtml"
                                           Write(mess.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2438, 54, true);
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
            EndContext();
#line 56 "C:\Users\Ayotunde\Documents\CallScheduler\CallScheduler\Views\Assigners\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2535, 208, true);
            WriteLiteral("                                    </tbody>\r\n                                </table>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"panel-footer\">\r\n");
            EndContext();
            BeginContext(2791, 104, true);
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 67 "C:\Users\Ayotunde\Documents\CallScheduler\CallScheduler\Views\Assigners\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2906, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginatedList<Assigner>> Html { get; private set; }
    }
}
#pragma warning restore 1591
