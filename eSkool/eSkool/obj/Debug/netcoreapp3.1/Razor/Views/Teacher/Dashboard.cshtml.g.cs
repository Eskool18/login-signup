#pragma checksum "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\Teacher\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfb07ead035c0d185879ad90fd38ed979d898a6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Dashboard), @"mvc.1.0.view", @"/Views/Teacher/Dashboard.cshtml")]
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
#line 1 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\_ViewImports.cshtml"
using eSkool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\_ViewImports.cshtml"
using eSkool.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfb07ead035c0d185879ad90fd38ed979d898a6b", @"/Views/Teacher/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb71ca231d026605b621ec616166762e711b9ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\Teacher\Dashboard.cshtml"
  
    ViewBag.Title = "Dashboard ";
    Layout = "~/Views/Shared/_TeacherLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .forcol {
        margin: 5px;
        padding: 5px;
        background-color: white;
        text-align: center;
    }
    #leave {
        width: 30%;
        padding: 4%;
        font-size: 20px;
        text-align: center;
        color: white;
        background: rgba(0, 0, 0, 0) linear-gradient( -135deg, #4ea5bdd1 0%, #b69cc3 100%) repeat scroll 0 0;
        border-radius: 5px;
        box-shadow: 0 3px 15px 0 rgb(0 0 0 / 10%);
        float: left;
    }
</style>



<div>

    <!--mainDiv For Entire Page-->
    <div class=""container-fluid"" style=""width:100%"">
        <!--main Row For Entire Page-->
        <div class=""row"">

            <div class=""col-sm-5 forcol"">
                <h1> Functionalities</h1>
                <div class=""container-fluid"">
                    <div class=""row"" style=""margin-top: 30px;"">
                        <div class=""col-sm-6"">
                            <a href=""/GeneratePaper/showCourses"">
                               ");
            WriteLiteral(@" <button class=""btn btn-outline-primary"">
                                    <div class=""container"">
                                        <div class=""row"">
                                            <div class=""col-sm-4"">
                                                <img src=""/image/paper.png"" style=""width: 70px;height: 70px;border-radius:50%"">
                                            </div>
                                            <div class=""col-sm-8"">
                                                <p>Generate Paper</p>
                                            </div>
                                        </div>
                                    </div>

                                </button>
                            </a>
                        </div>
                        <div class=""col-sm-6"">
                            <button class=""btn btn-outline-primary"">
                                <div class=""container"">
                                    <div cl");
            WriteLiteral(@"ass=""row"">
                                        <div class=""col-sm-4"">
                                            <img src=""/image/paper.png"" style=""width: 70px;height: 70px;border-radius:50%"">
                                        </div>
                                        <div class=""col-sm-8"">
                                            <p>Saved Paper</p>
                                        </div>
                                    </div>
                                </div>

                            </button>
                        </div>
                    </div>

                    <div class=""row"" style=""margin-top: 30px;"">
                        <div class=""col-sm-6"">
                            <button class=""btn btn-outline-primary"">
                                <div class=""container"">
                                    <div class=""row"">
                                        <div class=""col-sm-4"">
                                            <img src=");
            WriteLiteral(@"""/image/paper.png"" style=""width: 70px;height: 70px;border-radius:50%"">
                                        </div>
                                        <div class=""col-sm-8"">
                                            <p>Past Paper</p>
                                        </div>
                                    </div>
                                </div>

                            </button>
                        </div>
                        <div class=""col-sm-6"">
                            <button class=""btn btn-outline-primary"">
                                <div class=""container"">
                                    <div class=""row"">
                                        <div class=""col-sm-4"">
                                            <img src=""/image/paper.png"" style=""width: 70px;height: 70px;border-radius:50%"">
                                        </div>
                                        <div class=""col-sm-8"">
                                         ");
            WriteLiteral(@"   <p>Use Template</p>
                                        </div>
                                    </div>
                                </div>

                            </button>
                        </div>
                    </div>

                    <hr style=""margin-top: 50px; text-decoration-thickness: 5px;"">

                    <div class=""row"" style=""margin-top: 30px;"">
                        <div class=""col-sm-6"">
                            <button class=""btn btn-outline-primary"">
                                <div class=""container"">
                                    <div class=""row"">
                                        <div class=""col-sm-4"">
                                            <img src=""/image/paper.png"" style=""width: 70px;height: 70px;border-radius:50%"">
                                        </div>
                                        <div class=""col-sm-8"">
                                            <p>Request Question</p>
              ");
            WriteLiteral(@"                          </div>
                                    </div>
                                </div>

                            </button>
                        </div>
                        <div class=""col-sm-6"">
                            <button class=""btn btn-outline-primary"">
                                <div class=""container"">
                                    <div class=""row"">
                                        <div class=""col-sm-4"">
                                            <img src=""/image/paper.png"" style=""width: 70px;height: 70px;border-radius:50%"">
                                        </div>
                                        <div class=""col-sm-8"">
                                            <p>Print Notes chapterwise</p>
                                        </div>
                                    </div>
                                </div>

                            </button>
                        </div>
                    <");
            WriteLiteral("/div>\r\n\r\n\r\n                </div>\r\n\r\n\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n    <div id=\"leave\">\r\n        <a class=\"show-leave dash-links\" href=\"leaveBox\"><p> Leave Requests </p> <i class=\"fas fa-edit\"></i> </a>\r\n    </div>\r\n</div>\r\n");
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
