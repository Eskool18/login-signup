<<<<<<< HEAD
#pragma checksum "D:\fyp\ESkool\eSkool\eSkool\Views\Student\helping_material.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c27125ddba88451141a0c8e157ba74c308b4f96"
=======
#pragma checksum "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\Student\helping_material.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4369ef9e0a59bff6e7847276b78f97b7721bdfd3"
>>>>>>> 335cf0a6995cf44020600aa10cc2cb8008688831
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_helping_material), @"mvc.1.0.view", @"/Views/Student/helping_material.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4369ef9e0a59bff6e7847276b78f97b7721bdfd3", @"/Views/Student/helping_material.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb71ca231d026605b621ec616166762e711b9ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_helping_material : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<eSkool.Models.HelpingMeterial>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("show-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
<<<<<<< HEAD
#line 1 "D:\fyp\ESkool\eSkool\eSkool\Views\Student\helping_material.cshtml"
=======
#line 2 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\Student\helping_material.cshtml"
>>>>>>> 335cf0a6995cf44020600aa10cc2cb8008688831
  
    ViewBag.Title = "helping_material";
    Layout = "~/Views/Shared/_StudentLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>

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
    ");
            WriteLiteral(@"}

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
    h1 {
        color: #75b1c6;
        text-shadow: 2px 2px #a66a9f;
        text-align: center;
        background-color: #f6eff5;
        padding: 1%;
        font-weight: 600;
    }
</style>
<h1>Download Helping Material</h1>
<div class=""book-display"">
");
#nullable restore
<<<<<<< HEAD
#line 80 "D:\fyp\ESkool\eSkool\eSkool\Views\Student\helping_material.cshtml"
  String book = "CN.pdf";

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "D:\fyp\ESkool\eSkool\eSkool\Views\Student\helping_material.cshtml"
 for (int j = 0; j < 4; j++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 class=\"heading\"> Class ");
#nullable restore
#line 83 "D:\fyp\ESkool\eSkool\eSkool\Views\Student\helping_material.cshtml"
                          Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <sup>th</sup> </h3>\r\n    <div class=\"book-display\">\r\n");
#nullable restore
#line 85 "D:\fyp\ESkool\eSkool\eSkool\Views\Student\helping_material.cshtml"
         for (int i = 0; i < 6; i++)
        {
=======
#line 94 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\Student\helping_material.cshtml"
     foreach (var material in Model)
    {
>>>>>>> 335cf0a6995cf44020600aa10cc2cb8008688831


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"book-card\">\r\n            <h3 class=\"heading\"> ");
#nullable restore
<<<<<<< HEAD
#line 97 "D:\fyp\ESkool\eSkool\eSkool\Views\Student\helping_material.cshtml"
                       Write(j);
=======
#line 98 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\Student\helping_material.cshtml"
                            Write(material.MaterialClass);
>>>>>>> 335cf0a6995cf44020600aa10cc2cb8008688831

#line default
#line hidden
#nullable disable
            WriteLiteral("<sup>th</sup> </h3>\r\n            <ul>\r\n                <div class=\"book-details\">\r\n                    <li>\r\n                        <i class=\"fas fa-book\"></i>\r\n\r\n                    </li>\r\n                    <li>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 97 "D:\fyp\ESkool\eSkool\eSkool\Views\Student\helping_material.cshtml"
                            Write(i);
=======
#line 106 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\Student\helping_material.cshtml"
                   Write(material.MaterialName);
>>>>>>> 335cf0a6995cf44020600aa10cc2cb8008688831

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("\r\n                        </li>\r\n                    </div>\r\n                 \r\n                    <li>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c27125ddba88451141a0c8e157ba74c308b4f967099", async() => {
=======
            WriteLiteral("\r\n                    </li>\r\n                </div>\r\n                <li>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4369ef9e0a59bff6e7847276b78f97b7721bdfd36713", async() => {
>>>>>>> 335cf0a6995cf44020600aa10cc2cb8008688831
                WriteLiteral(" <i class=\"fas fa-angle-double-down\"> </i> Download ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2479, "~/Student/download?filePath=/lib/", 2479, 33, true);
#nullable restore
<<<<<<< HEAD
#line 102 "D:\fyp\ESkool\eSkool\eSkool\Views\Student\helping_material.cshtml"
AddHtmlAttributeValue("", 2402, book, 2402, 5, false);
=======
#line 110 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\Student\helping_material.cshtml"
AddHtmlAttributeValue("", 2512, material.MaterialName, 2512, 22, false);
>>>>>>> 335cf0a6995cf44020600aa10cc2cb8008688831

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
            WriteLiteral("\r\n                </li>\r\n            </ul>\r\n        </div>\r\n");
#nullable restore
<<<<<<< HEAD
#line 106 "D:\fyp\ESkool\eSkool\eSkool\Views\Student\helping_material.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 110 "D:\fyp\ESkool\eSkool\eSkool\Views\Student\helping_material.cshtml"

}
=======
#line 114 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\Student\helping_material.cshtml"

    }
>>>>>>> 335cf0a6995cf44020600aa10cc2cb8008688831

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
