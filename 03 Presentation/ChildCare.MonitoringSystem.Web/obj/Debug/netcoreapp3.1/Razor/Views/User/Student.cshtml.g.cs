#pragma checksum "D:\ChildCare\ChildCare\Source Code\03 Presentation\ChildCare.MonitoringSystem.Web\Views\User\Student.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcdc09b2c4caae119e58211102228a54a25843e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Student), @"mvc.1.0.view", @"/Views/User/Student.cshtml")]
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
#line 1 "D:\ChildCare\ChildCare\Source Code\03 Presentation\ChildCare.MonitoringSystem.Web\Views\_ViewImports.cshtml"
using ChildCare.MonitoringSystem.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ChildCare\ChildCare\Source Code\03 Presentation\ChildCare.MonitoringSystem.Web\Views\_ViewImports.cshtml"
using ChildCare.MonitoringSystem.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ChildCare\ChildCare\Source Code\03 Presentation\ChildCare.MonitoringSystem.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcdc09b2c4caae119e58211102228a54a25843e6", @"/Views/User/Student.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b9c265e513faefe9e45f2a293f15e5f04373ab2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Student : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_UserLeftNavigation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formnotes"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("LeftNavigation", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dcdc09b2c4caae119e58211102228a54a25843e65107", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<!-- MAIN CONTENT-->\r\n<div class=\"main-content\">\r\n");
            WriteLiteral(@"    <div class=""container-fluid"">
        <br />
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""panel panel-success"">

                    <h3 style=""text-align:center;""><strong style=""color: black;font-size: 40px;text-shadow: 2px 7px 2px darkgrey"">Your Child Details</strong> </h3>
                    <hr />
                    <div class=""panel-body"">
                        <div class=""table-sorting table-responsive"">

                            <div class=""panel-body"">
                        
                                <div class=""table-sorting table-responsive"" align=""center"">
                                    <!--  SHOW ENTRIES--><br />
                                    <div class=""portrait"" align=""center"" >
                                        <img  id=""simg"" style=""width: 20%; height:20%;border-radius: 50%; border:2px solid black"">
                                    </div>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcdc09b2c4caae119e58211102228a54a25843e67468", async() => {
                WriteLiteral(@"

                                        <table align=""center"" style=""width: 500px; margin-top: 20px; font-size: 15px;"" class=""table table-striped table-bordered table-hover"" id=""tSortable22"">
                                            <thead>
                                                <tr>

                                                    <td><strong>Name </strong></td>

                                                    <td><h6 id=""name""></h6></td>
                                                </tr>
                                                <tr>
                                                    <td><strong>Address </strong></td>
                                                    <td><h6 id=""address""></h6></td>
                                                </tr>
                                                <tr>
                                                    <td><strong>Gender </strong></td>
                                                    <td><h6 id=""gender""");
                WriteLiteral(@"></h6></td>
                                                </tr>
                                                <tr>
                                                    <td><strong>DOB </strong></td>
                                                    <td><h6 id=""dob""></h6></td>
                                                </tr>
                                                <tr>
                                                    <td><strong>Father / Guardian name</strong></td>
                                                    <td><h6 id=""father""></h6></td>
                                                </tr>
                                                <tr>
                                                    <td><strong>Mother </strong></td>
                                                    <td><h6 id=""mother""></h6></td>
                                                </tr>


                                            </thead>

                                        </table");
                WriteLiteral(">\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n                        </div>\r\n\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {

            $.ajax({

                url: '/Student/GetUsersStudentInfo',
                type: 'get',
                dataType: 'json',

                success: function (result) {
                  
                    document.getElementById('simg').src = result.studentImg;
                    document.getElementById('name').innerHTML = result.studentName;
                    document.getElementById('address').innerHTML = result.studentAddress;
                    document.getElementById('gender').innerHTML = result.studentGender;
                    document.getElementById('dob').innerHTML = result.studentDob;
                    document.getElementById('father').innerHTML = result.fatherName;
                    document.getElementById('mother').innerHTML = result.motherName;
                },
            });
        });


    </script>
    <script>
        function search(string) {
            window.find(string);
    ");
                WriteLiteral("    }\r\n    </script>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <style>
        #simg:hover {

            -ms-transform: scale(1.5); /* IE 9 */
            -webkit-transform: scale(1.5); /* Safari 3-8 */
            transform: scale(1.3);
        }
        #test-form-div {
            position: fixed;
            top: -500%;
            max-width: 1500px;
            max-height: 1500px;
            min-width: 1500px;
            min-height: 1500px;
            background-color: black;
        }

        form.example input[type=text] {
            padding: 8px;
            font-size: 17px;
            border: 1px solid grey;
            float: left;
            width: 72%;
            height: 60%;
            background: white;
        }

        form.example button {
            float: left;
            width: 20%;
            height: 70%;
            padding: 10px;
            background: #2196F3;
            color: white;
            font-size: 17px;
            border: 1px solid grey;
            border-left: none;
          ");
                WriteLiteral(@"  cursor: pointer;
        }

            form.example button:hover {
                background: #0b7dda;
            }

        form.example::after {
            content: """";
            clear: both;
            display: table;
        }
    </style>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591