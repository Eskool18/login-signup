#pragma checksum "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\upload_helping_material.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1d3f88aa391ce73fc91076502fd35ac5a3a399a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_upload_helping_material), @"mvc.1.0.view", @"/Views/Teacher/upload_helping_material.cshtml")]
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
#line 1 "D:\fyp\ESkool\eSkool\eSkool\Views\_ViewImports.cshtml"
using eSkool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\fyp\ESkool\eSkool\eSkool\Views\_ViewImports.cshtml"
using eSkool.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1d3f88aa391ce73fc91076502fd35ac5a3a399a", @"/Views/Teacher/upload_helping_material.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb71ca231d026605b621ec616166762e711b9ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_upload_helping_material : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<eSkool.Models.HelpingMeterial>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Teacher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "upload_helping_material", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("show-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\upload_helping_material.cshtml"
  
    ViewBag.Title = "upload_helping_material";
    Layout = "~/Views/Shared/_TeacherLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .book-card img {
        width: 40%;
        height: 10%;
    }

    .show-btn {
        /* font-weight: 600; */
        color: #ffffff;
        width: 90%;
        box-shadow: -6px 6px 0px 0 rgb(145 74 140 / 45%);
        font-size: 18px;
        border: none;
        padding: 3%;
        /* border: 1px solid #7b5c92d9; */
        background: #22a1b782;
    }

    .book-details {
        display: flex;
        flex-direction: column;
    }

    .show-btn:hover {
        /*   box-shadow: 0px 20px 80px 0 rgb(38 157 178 / 62%);*/
        box-shadow: -6px 6px 0px 0 #22a1b782;
        background: rgb(145 74 140 / 45%);
        color: white;
        text-decoration: none;
    }

    .show-btn i {
        color: #954587;
    }


    .book-card {
        width: 25%;
        color: white;
        margin: 10px;
        padding: 1%;
        background-color: #7b5c9261;
        text-align: center;
    }

    .book-details li i {
        font-size: 50px;
    }
");
            WriteLiteral(@"
    .book-display {
        display: flex;
        flex-direction: row;
        flex-wrap: wrap;
        justify-content: center;
    }

    .book-card ul {
        padding: 0;
        list-style: none;
        padding-top: 5px;
    }

        .book-card ul li {
            margin: 2%;
        }

    .heading {
        background-color: #954587;
        opacity: 0.7;
        text-align: center;
        color: white;
        padding: 8px;
        justify-content: center;
    }
    form {
        background-color: #417d8f2e;
        margin: auto;
        border: 2px dashed #447b8d;
    }

        form h3 {
            text-align: center;
        }
</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1d3f88aa391ce73fc91076502fd35ac5a3a399a7204", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1d3f88aa391ce73fc91076502fd35ac5a3a399a7466", async() => {
                    WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-10\">\r\n                <h3>Upload New Material</h3>\r\n                <label for=\"cName\">Class Name:</label>\r\n                <input type=\"number\" name=\"cName\"");
                    BeginWriteAttribute("value", " value=\"", 2233, "\"", 2255, 1);
#nullable restore
#line 97 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\upload_helping_material.cshtml"
WriteAttributeValue("", 2241, ViewBag.cname, 2241, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" readonly />\r\n                <label for=\"sName\">Subject Name:</label>\r\n                <input type=\"text\" name=\"sName\"");
                    BeginWriteAttribute("value", " value=\"", 2375, "\"", 2397, 1);
#nullable restore
#line 99 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\upload_helping_material.cshtml"
WriteAttributeValue("", 2383, ViewBag.sname, 2383, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" readonly />
                <label for=""mType"">Material Type</label>
                <input type=""text"" name=""mType"" placeholder=""Slides"" required />
                <input type=""file"" name=""files"" multiple required />
            </div>
        </div>
        <div class=""form-group"">
            <div class=""col-md-10"">
                <input type=""submit"" value=""Upload"" />
            </div>
        </div>
    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <div class=\"book-display\">\r\n");
#nullable restore
#line 113 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\upload_helping_material.cshtml"
         foreach (var material in Model)
        {


#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"book-card\">\r\n                <h3 class=\"heading\"> ");
#nullable restore
#line 117 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\upload_helping_material.cshtml"
                                Write(material.MaterialClass);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"<sup>th</sup> </h3>
                <ul>
                    <div class=""book-details"">
                        <li>
                            <i class=""fas fa-book""></i>

                        </li>
                        <li>
                            ");
#nullable restore
#line 125 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\upload_helping_material.cshtml"
                       Write(material.MaterialName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </li>\r\n                    </div>\r\n                    <li>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1d3f88aa391ce73fc91076502fd35ac5a3a399a12317", async() => {
                    WriteLiteral(" <i class=\"fas fa-angle-double-down\"> </i> Download ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3448, "~/Teacher/download?filePath=/lib/", 3448, 33, true);
#nullable restore
#line 129 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\upload_helping_material.cshtml"
AddHtmlAttributeValue("", 3481, material.MaterialName, 3481, 22, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n");
#nullable restore
#line 133 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\upload_helping_material.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<eSkool.Models.HelpingMeterial>> Html { get; private set; }
    }
}
#pragma warning restore 1591
