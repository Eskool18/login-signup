#pragma checksum "C:\Users\Farooq\ESkool\eSkool\eSkool\Views\Student\subjects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "980a0c1b21f65e2cd3948fdce8a231ffedea802e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_subjects), @"mvc.1.0.view", @"/Views/Student/subjects.cshtml")]
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
#line 1 "C:\Users\Farooq\ESkool\eSkool\eSkool\Views\_ViewImports.cshtml"
using eSkool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Farooq\ESkool\eSkool\eSkool\Views\_ViewImports.cshtml"
using eSkool.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"980a0c1b21f65e2cd3948fdce8a231ffedea802e", @"/Views/Student/subjects.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb71ca231d026605b621ec616166762e711b9ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_subjects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Farooq\ESkool\eSkool\eSkool\Views\Student\subjects.cshtml"
  
    ViewBag.Title = "subjects";
    Layout = "~/Views/Shared/_StudentLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .class-card {
        display: flex;
        height: 100%;
        flex-direction: row;
    }
    .class-banner {
        width: 18%;
        color: #22a1b782;
        font-weight: bolder;
        text-align: center;
        border-left: 3px #75b1c6;
        border-left-style: outset;
        background: white;
    }
    .class-banner p{
        margin-top:10%;
    }
    .class-div {
        color: whitesmoke;
        box-shadow: 0px 10px 10px 0 rgb(39 155 176 / 42%), 0 15px 30px 0 rgb(145 73 139 / 60%);
        width: 29%;
        background-color: #7b5c9261;
        margin: 2%;
    }

    .class-detail {
        
        width: 100%;
        margin: 10px;
     
       
        display: flex;
        flex-wrap: wrap;
        flex-direction: column;
    }
    .sub-div {
        display: flex;
        flex-direction: row;
        flex-wrap: wrap;
        justify-content: center;
    }
    .sub-card img {
        width: 100%;
        height: 50%;
    }");
            WriteLiteral(@"
    .class-detail i {
        color: #954587;
        font-size:20px;
        padding:5px;
       
    }
    .class-detail a{
        color: white;
        margin-left:10%;
    }
    .class-detail h2{
        text-align:center;
    }
    .sub-card {
        margin: 10px;
        background-color: #ecc0da;
        width: 30%;
        height: 25%;
        margin-top: 20px;
        padding: 0;
        text-align: center;
        display: flex;
        flex-wrap: wrap;
        flex-direction: column;
    }
</style>

<div class=""sub-div"">
   
");
#nullable restore
#line 82 "C:\Users\Farooq\ESkool\eSkool\eSkool\Views\Student\subjects.cshtml"
     for (int i = 0; i < 3; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"class-div\">\r\n        <div class=\"class-card\">\r\n            <div class=\"class-banner\">\r\n                <p>\r\n                    9<br />T<br />H\r\n                </p>\r\n            </div>\r\n            <div class=\"class-detail\">\r\n");
            WriteLiteral("                <h2>");
#nullable restore
#line 93 "C:\Users\Farooq\ESkool\eSkool\eSkool\Views\Student\subjects.cshtml"
               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h2>
                <a href=""/Student/gradebook""><i class=""fas fa-trophy""></i>&nbsp; Gradebook</a>
                <a href=""/Student/helping_material""><i class=""fas fa-book-open""></i>&nbsp; Helping Material</a>
                <a href=""/Student/class_announcement""><i class=""fas fa-bell""></i>&nbsp; Announcements</a>
                <a href=""/Student/practice""><i class=""fas fa-pencil-alt""></i>&nbsp; Practice</a>
            </div>
        </div>
    </div>
");
#nullable restore
#line 101 "C:\Users\Farooq\ESkool\eSkool\eSkool\Views\Student\subjects.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n</div>\r\n");
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
