#pragma checksum "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\Student\class_announcement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fd81aebfacd3ce81d7b74d7fdbe3e077b5aa9d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_class_announcement), @"mvc.1.0.view", @"/Views/Student/class_announcement.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd81aebfacd3ce81d7b74d7fdbe3e077b5aa9d7", @"/Views/Student/class_announcement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb71ca231d026605b621ec616166762e711b9ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_class_announcement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<eSkool.Models.ClassAnnouncement>>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\Student\class_announcement.cshtml"
  
    ViewBag.Title = "class_announcement";
    Layout = "~/Views/Shared/_StudentLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .modal {
        display: none; /* Hidden by default */
        position: fixed; /* Stay in place */
        z-index: 1; /* Sit on top */
        padding-top: 50px; /* Location of the box */
        left: 0;
        top: 0;
        width: 100%; /* Full width */
        height: 100%; /* Full height */
        border: 1px solid rgb(145 74 140);
        overflow: auto; /* Enable scroll if needed */
        background-color: rgb(0,0,0); /* Fallback color */
        background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
    }

    .modal-content {
        background-color: #fefefe;
        margin: auto;
        box-shadow: 0 4px 8px 0 rgb(199 24 161 / 57%), 0 6px 20px 0 #448797;
        border: 1px solid #888;
        width: 50%;
    }

    .modal-body form {
        display: flex;
        flex-direction: column;
        padding: 2%;
    }

    .modal-header {
        background-color: #7b5c9261;
        color: white;
    }

        .modal-header h3 {
          ");
            WriteLiteral(@"  font-size: 25px;
            font-style: italic;
            font-family: serif;
        }

    .modal-body input, .modal-body textarea {
        border: none;
        background: #efefef;
        padding: 2%;
        margin: 1%;
    }

    .modal-body form input[type=submit]:hover {
        box-shadow: -6px 6px 0px 0 #22a1b782;
        background: rgb(145 74 140 / 45%);
    }

    .modal-body form input[type=submit] {
        color: #ffffff;
        box-shadow: -6px 6px 0px 0 rgb(145 74 140 / 45%);
        background: #22a1b782;
    }

    .modal-body form div {
        margin-bottom: 2%
    }



    .image-card {
        width: 20%;
        padding: 2px;
        height: 100%;
        text-align: center;
    }

        .image-card img {
            width: 100%;
            height: 100%;
        }

    .post {
       
        width: 100%;
        margin: 10px;
        border: 1px solid #52b6c5;
        background-color: #3d7d8930;
    }

    .post-card {
   ");
            WriteLiteral(@"     margin: 8px;
        height: 8%;
        padding: 0;
        display: flex;
        flex-direction: column;
    }

        .post-card p {
            margin: 0;
        }

    .post-details {
        padding: 10px;
    }

    .add-class button {
        background-color: #e90b0b14;
        padding: 10px;
        width: 100%;
        margin: 10px;
        border: 1px dashed red;
        color: red;
        text-align: center;
        font-size: larger;
        font-style: italic;
    }

        .add-class button:hover {
            box-shadow: 0px 10px 10px 0 rgb(223 197 197), 0 15px 30px 0 rgb(221 219 221 / 60%);
        }
    .date {
        color: gray;
        text-align: end;
    }
</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fd81aebfacd3ce81d7b74d7fdbe3e077b5aa9d76232", async() => {
                WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 132 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\Student\class_announcement.cshtml"
     foreach (var announcement in Model)
    {


#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"post\">\r\n            <div class=\"post-details\">\r\n                <h3>");
#nullable restore
#line 137 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\Student\class_announcement.cshtml"
               Write(announcement.Header);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                <p>");
#nullable restore
#line 138 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\Student\class_announcement.cshtml"
              Write(announcement.Content);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"date\">");
#nullable restore
#line 140 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\Student\class_announcement.cshtml"
                         Write(announcement.PostDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        </div>\r\n");
#nullable restore
#line 142 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\Student\class_announcement.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<eSkool.Models.ClassAnnouncement>> Html { get; private set; }
    }
}
#pragma warning restore 1591
