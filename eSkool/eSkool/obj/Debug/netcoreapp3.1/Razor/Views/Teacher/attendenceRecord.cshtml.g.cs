#pragma checksum "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\attendenceRecord.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "437427b2be0845e4c3b0a9b196b458ed1a2209b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_attendenceRecord), @"mvc.1.0.view", @"/Views/Teacher/attendenceRecord.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"437427b2be0845e4c3b0a9b196b458ed1a2209b2", @"/Views/Teacher/attendenceRecord.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb71ca231d026605b621ec616166762e711b9ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_attendenceRecord : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<eSkool.Logistics.studentMonthlyAttendence>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Teacher/attendenceRecord"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\attendenceRecord.cshtml"
  
    ViewData["Title"] = "attendenceRecord";
    Layout = "~/Views/Shared/_TeacherLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    table, th, td {
        text-align: center;
        margin: auto;
        border: 1px solid #f6eff5;
        border-collapse: collapse;
    }

    th, td {
        padding: 10px 30px;
        background-color: #338da13d;
        color: #267385;
    }



    th {
        background-color: #338da1;
        color: #f6eff5;
    }
</style>


<div class=""form-group"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "437427b2be0845e4c3b0a9b196b458ed1a2209b24687", async() => {
                WriteLiteral(@"

        <div class=""form-row"">
            <div class=""form-group col-md-3"">
                <label><b>Attendence of Month</b> </label>
                <select name=""attendenceMonth"" class=""custom-select custom-select-lg"" required>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "437427b2be0845e4c3b0a9b196b458ed1a2209b25210", async() => {
                    WriteLiteral("--Month ");
#nullable restore
#line 36 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\attendenceRecord.cshtml"
                                                 Write(ViewBag.attendenceMonth);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 37 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\attendenceRecord.cshtml"
                      

                      foreach(var month in ViewBag.months)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "437427b2be0845e4c3b0a9b196b458ed1a2209b27428", async() => {
#nullable restore
#line 41 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\attendenceRecord.cshtml"
                               Write(month);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 42 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\attendenceRecord.cshtml"
                            }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    
                </select>
            </div>

            <div class=""form-group col-md-3"">
                <input type=""submit"" class=""btn btn-dark"" value=""Search Now"" style=""margin-left:50px;margin-top:33px;width:60%"">
            </div>
        </div>
    ");
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
            WriteLiteral("\r\n</div>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Student Name\r\n            </th>\r\n            <th>\r\n                Father Name\r\n            </th>\r\n");
#nullable restore
#line 63 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\attendenceRecord.cshtml"
               
                for(int i=1; i<= ViewBag.DaysInMonth;i++)
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>");
#nullable restore
#line 66 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\attendenceRecord.cshtml"
                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 67 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\attendenceRecord.cshtml"
                  }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 72 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\attendenceRecord.cshtml"
          
            foreach(var studentAttendence in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 77 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\attendenceRecord.cshtml"
                   Write(studentAttendence.studentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 80 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\attendenceRecord.cshtml"
                   Write(studentAttendence.fatherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 82 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\attendenceRecord.cshtml"
                       var i = 1;
                        foreach(var day in studentAttendence.days)
                        {
                            if (i <= ViewBag.DaysInMonth)
                            {
                                if (day == 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td style=\"color:green\">P</td>\r\n");
#nullable restore
#line 90 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\attendenceRecord.cshtml"
                                }
                                else if (day == 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td style=\"color:blue\">L</td>\r\n");
#nullable restore
#line 94 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\attendenceRecord.cshtml"
                                }
                                else if (day == -1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   <td style=\"color:red\" >A</td>\r\n");
#nullable restore
#line 98 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\attendenceRecord.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td> </td>\r\n");
#nullable restore
#line 102 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\attendenceRecord.cshtml"
                                }
                            }
                            i = i + 1;
                        }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 108 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\attendenceRecord.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    </tbody>\r\n\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<eSkool.Logistics.studentMonthlyAttendence>> Html { get; private set; }
    }
}
#pragma warning restore 1591
