#pragma checksum "D:\Personal_Documents\Project\MajorProject\test-\ChildCare\ChildCare\Source Code\03 Presentation\ChildCare.MonitoringSystem.Web\Views\User\StudentTracking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "feeedd32577acc0daff0652b221abfb50aae8217"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_StudentTracking), @"mvc.1.0.view", @"/Views/User/StudentTracking.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/StudentTracking.cshtml", typeof(AspNetCore.Views_User_StudentTracking))]
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
#line 1 "D:\Personal_Documents\Project\MajorProject\test-\ChildCare\ChildCare\Source Code\03 Presentation\ChildCare.MonitoringSystem.Web\Views\_ViewImports.cshtml"
using ChildCare.MonitoringSystem.Web;

#line default
#line hidden
#line 2 "D:\Personal_Documents\Project\MajorProject\test-\ChildCare\ChildCare\Source Code\03 Presentation\ChildCare.MonitoringSystem.Web\Views\_ViewImports.cshtml"
using ChildCare.MonitoringSystem.Web.Models;

#line default
#line hidden
#line 3 "D:\Personal_Documents\Project\MajorProject\test-\ChildCare\ChildCare\Source Code\03 Presentation\ChildCare.MonitoringSystem.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feeedd32577acc0daff0652b221abfb50aae8217", @"/Views/User/StudentTracking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b9c265e513faefe9e45f2a293f15e5f04373ab2", @"/Views/_ViewImports.cshtml")]
    public class Views_User_StudentTracking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_UserLeftNavigation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onload", new global::Microsoft.AspNetCore.Html.HtmlString("initMap();"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/img/user.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Homepage.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Personal_Documents\Project\MajorProject\test-\ChildCare\ChildCare\Source Code\03 Presentation\ChildCare.MonitoringSystem.Web\Views\User\StudentTracking.cshtml"
  
    ViewData["Title"] = "StudentTracking";

#line default
#line hidden
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("LeftNavigation", async() => {
                BeginContext(79, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(85, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "feeedd32577acc0daff0652b221abfb50aae82176590", async() => {
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
                EndContext();
                BeginContext(123, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(128, 24, true);
            WriteLiteral("\r\n<!-- MAIN CONTENT-->\r\n");
            EndContext();
            BeginContext(152, 3597, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feeedd32577acc0daff0652b221abfb50aae82178073", async() => {
                BeginContext(178, 332, true);
                WriteLiteral(@"
    <div class=""main-content"">

        <div class=""row"">
            <div class=""col-md-12"">
                <!-- MAP DATA-->
                <div class=""map-data m-b-40"">
                    <h3 class=""title-3 m-b-30"">
                        <i class=""zmdi zmdi-map""></i>Student Tracking Map
                    </h3>
");
                EndContext();
                BeginContext(1103, 44, true);
                WriteLiteral("                    <div class=\"map-wrap\">\r\n");
                EndContext();
                BeginContext(1212, 2530, true);
                WriteLiteral(@"                        <div id=""map""></div>
                        <script>

                            // Initialize and add the map
                            // $(document).ready(function () {
                            function initMap() {

                                // The location of Uluru

                                $.ajax({
                                    url: '/Student/GetStudentLocation',
                                    type: 'get',
                                    dataType: 'json',
                                    success: function (result) {

                                        if (result) {


                                            var latitude = result.latitude;

                                            var langitude = result.longitute;

                                            var uluru = { lat: latitude, lng: langitude };
                                            // The map, centered at Uluru
                                 ");
                WriteLiteral(@"           var map = new google.maps.Map(
                                                document.getElementById('map'), { zoom: 10, center: uluru });
                                            // The marker, positioned at Uluru
                                            var marker = new google.maps.Marker({ position: uluru, map: map });
                                        }
                                        else {
                                            alert(""failed to get data"");
                                        }

                                    },


                                });
                            }

                            //    });


                        </script>
                        <!--Load the API from the specified URL
                        * The async attribute allows the browser to render the page while the API loads
                        * The key parameter will contain your own API key (which is not needed for this t");
                WriteLiteral(@"utorial)
                        * The callback parameter executes the initMap() function
                        -->
                        <script async defer
                                src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyDxi53n1l21ELjpf2Oq0frWB50S6GyCG5o&callback=initMap"">
                        </script>
                    </div>
                </div>
                <!-- END MAP DATA-->
            </div>
        </div>

    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3749, 158, true);
            WriteLiteral("\r\n<!-- END MAIN CONTENT-->\r\n\r\n<div id=\"overlay\" style=\"z-index:4\">\r\n    <!--start Account popup-->\r\n    <div id=\"test-form-div \">\r\n        <div id=\"test-form\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3907, "\"", 3915, 0);
            EndWriteAttribute();
            BeginContext(3916, 222, true);
            WriteLiteral(">\r\n            <div class=\"form-container\">\r\n                <a class=\"pull-right\" href=\" \"><i class=\"fa fa-close\"></i></a>\r\n                <h2 align=\"center\" class=\"text-primary\">Profile View</h2><hr />\r\n                ");
            EndContext();
            BeginContext(4138, 1032, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feeedd32577acc0daff0652b221abfb50aae821713199", async() => {
                BeginContext(4181, 136, true);
                WriteLiteral("\r\n                    <div class=\"form-group\" align=\"center\">\r\n                        <div class=\"image\">\r\n                            ");
                EndContext();
                BeginContext(4317, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "feeedd32577acc0daff0652b221abfb50aae821713729", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4352, 811, true);
                WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label class=""text-primary"">User Name</label>
                        <label class=""form-control"" name=""fname"" id=""fname"">Purshotham</label>
                    </div>
                    <div class=""form-group"">
                        <label class=""text-primary"">User Email</label>
                        <label class=""form-control"" name=""email"" id=""fname"">Pursh123@gmail.com</label>
                    </div>
                    <div class=""form-group"">
                        <label class=""text-primary"">Mobile No</label>
                        <label class=""form-control"" name=""number"" id=""pwd"">9653247815</label>
                    </div>

                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5170, 135, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!--close Account popup-->\r\n    <!--start setting popup-->\r\n    <div id=\"setting\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5305, "\"", 5313, 0);
            EndWriteAttribute();
            BeginContext(5314, 210, true);
            WriteLiteral(">\r\n        <div class=\"form-container\">\r\n            <a class=\"pull-right\" href=\" \"><i class=\"fa fa-close\"></i></a>\r\n            <h2 align=\"center\" class=\"text-primary\">Password Setting</h2><hr />\r\n            ");
            EndContext();
            BeginContext(5524, 918, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feeedd32577acc0daff0652b221abfb50aae821717751", async() => {
                BeginContext(5567, 868, true);
                WriteLiteral(@"
                <div class=""form-group"">
                    <label>Old Password</label>
                    <input class=""form-control"" type=""text"" name=""fname"" id=""fname"" required>
                </div>
                <div class=""form-group"">
                    <label>New Password</label>
                    <input class=""form-control"" type=""email"" name=""email"" id=""fname"" required>
                </div>
                <div class=""form-group"">
                    <label for=""pwd"">Confirm Password</label>
                    <input class=""form-control"" type=""tel"" name=""number"" id=""pwd"" required>
                </div>
                <button type=""submit"" class=""btn btn-block btn-primary"" id=""reg"">SUBMIT </button><br>
                <a href=""#moresetting"" class=""pull-right"" onclick=""showmoresetting()"">Set More Details</a>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6442, 124, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <!--close setting popup-->\r\n    <!--start more setting popup-->\r\n    <div id=\"moresetting\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 6566, "\"", 6574, 0);
            EndWriteAttribute();
            BeginContext(6575, 213, true);
            WriteLiteral(">\r\n        <div class=\"form-container\">\r\n            <a class=\"pull-right\" href=\" \"><i class=\"fa fa-close\"></i></a>\r\n            <h2 align=\"center\" class=\"text-primary\">User Detail Setting</h2><hr />\r\n            ");
            EndContext();
            BeginContext(6788, 990, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feeedd32577acc0daff0652b221abfb50aae821720975", async() => {
                BeginContext(6831, 940, true);
                WriteLiteral(@"
                <div class=""form-group"">
                    <label>User Name</label>
                    <input class=""form-control"" type=""text"" name=""fname"" id=""fname"" required>
                </div>
                <div class=""form-group"">
                    <label>User Email</label>
                    <input class=""form-control"" type=""email"" name=""email"" id=""fname"" required>
                </div>
                <div class=""form-group"">
                    <label>Address</label>
                    <input class=""form-control"" type=""email"" name=""email"" id=""fname"" required>
                </div>
                <div class=""form-group"">
                    <label>Mobile No</label>
                    <input class=""form-control"" type=""email"" name=""email"" id=""fname"" required>
                </div>
                <button type=""submit"" class=""btn btn-block btn-primary"" id=""reg"">EDIT</button>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7778, 77, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <!--close more setting popup-->\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7872, 1379, true);
                WriteLiteral(@"
    <script>
        function search(string) {
            window.find(string);
        }

        function showtest() {
            $('#test-form').animate({ top: '15%' }, 500);
            $('#test-form-div').animate({ top: '20%' }, 500);
            $('.account-dropdown').hide();
            document.getElementById(""overlay"").style.display = ""block"";
        }
        function hidetest() {
            $('#test-form').animate({ top: '-500%' }, 500);
            document.getElementById(""overlay"").style.display = ""None"";
        }

        function showsetting() {
            $('#setting').animate({ top: '15%' }, 500);
            $('.account-dropdown').hide();
            document.getElementById(""overlay"").style.display = ""block"";
        }
        function hidesetting() {
            $('#setting').animate({ top: '-500%' }, 500);
            document.getElementById(""overlay"").style.display = ""none"";
        }

        function showmoresetting() {
            $('#moresetting').ani");
                WriteLiteral(@"mate({ top: '15%' }, 500);
            $('.account-dropdown').hide();
            document.getElementById(""overlay"").style.display = ""block"";
        }
        function hidemoresetting() {
            $('#moresetting').animate({ top: '-500%' }, 500);
            document.getElementById(""overlay"").style.display = ""None"";
        }
    </script>
");
                EndContext();
            }
            );
            BeginContext(9254, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(9274, 2870, true);
                WriteLiteral(@"
    <style>
        #overlay {
            position: fixed; /* Sit on top of the page content */
            display: none; /* Hidden by default */
            width: 100%; /* Full width (cover the whole page) */
            height: 100%; /* Full height (cover the whole page) */
            top: 0;
            left: 0;
            right: 0;
            bottom: 0;
            background-color: rgba(0,0,0,0.5); /* Black background with opacity */
            z-index: 2; /* Specify a stack order in case you're using a different order for other elements */
            cursor: pointer; /* Add a pointer on hover */
            overflow: auto;
        }

        #test-form {
            position: fixed;
            top: -500%;
            width: 35%;
            margin-left: 30%;
            background-color: white;
            box-shadow: 2px 3px 8px slategrey;
            border-radius: 5px;
            padding: 35px;
        }
        /* Set the size of the div element that contains th");
                WriteLiteral(@"e map */
        #map {
            height: 400px; /* The height is 400 pixels */
            width: 100%; /* The width is the width of the web page */
        }

        #setting {
            position: fixed;
            top: -500%;
            width: 35%;
            margin-left: 30%;
            background-color: white;
            box-shadow: 2px 3px 8px slategrey;
            border-radius: 5px;
            padding: 35px;
        }

        #moresetting {
            position: fixed;
            top: -500%;
            width: 35%;
            margin-left: 30%;
            background-color: white;
            box-shadow: 2px 3px 8px slategrey;
            border-radius: 5px;
            padding: 35px;
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

       ");
                WriteLiteral(@" form.example input[type=text] {
            padding: 8px;
            font-size: 17px;
            border: 1px solid grey;
            float: left;
            width: 70%;
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
            cursor: pointer;
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
                EndContext();
            }
            );
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
