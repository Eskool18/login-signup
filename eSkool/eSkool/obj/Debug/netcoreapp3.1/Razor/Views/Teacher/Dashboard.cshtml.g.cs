#pragma checksum "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\Teacher\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3970dab5a13effa4439fdf6251f54f97780db846"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3970dab5a13effa4439fdf6251f54f97780db846", @"/Views/Teacher/Dashboard.cshtml")]
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
                                <button class=""btn btn-outline-primary"">
                                    <div class=""container"">
                                        <div class=""row"">
                                            <div class=""col-sm-4"">
                                                <img src=""/image/paper.png"" style=""width: 70px;height: 70px;bo");
            WriteLiteral(@"rder-radius:50%"">
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
                                    <div class=""row"">
                                        <div class=""col-sm-4"">
                                            <img src=""/image/paper.png"" style=""width: 70px;height: 70px;border-radius:50%"">
                                        </div>
                                        <div class=""col-sm-8"">
                            ");
            WriteLiteral(@"                <p>Saved Paper</p>
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
                                            <img src=""/image/paper.png"" style=""width: 70px;height: 70px;border-radius:50%"">
                                        </div>
                                        <div class=""col-sm-8"">
                                            <p>Past Paper</p>
                                        </div>
                                    </div>
  ");
            WriteLiteral(@"                              </div>

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
                                            <p>Use Template</p>
                                        </div>
                                    </div>
                                </div>

                            </button>
                        </div>
                    </div>

                    <hr style=""margin-top: 50px; text-decoration-thickness: 5px;"">");
            WriteLiteral(@"

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
                                        </div>
                                    </div>
                                </div>

                            </button>
                        </div>
                        <div class=""col-sm-6"">
                            <button class=""btn btn-outline-primary"">
                                ");
            WriteLiteral(@"<div class=""container"">
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
                    </div>


                </div>



            </div>
            <div class=""col-sm-3 forcol"">
                <h1>Notification</h1>



            </div>
        </div>
    </div>

    <div class=""container"">

    </div>
</div>
");
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
