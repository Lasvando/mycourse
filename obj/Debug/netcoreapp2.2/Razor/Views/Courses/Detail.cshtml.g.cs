#pragma checksum "C:\Users\Federico\Desktop\MyCourse\Views\Courses\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cac943412197426ff947d8a457ec9040ed263746"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Detail), @"mvc.1.0.view", @"/Views/Courses/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/Detail.cshtml", typeof(AspNetCore.Views_Courses_Detail))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\Users\Federico\Desktop\MyCourse\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#line 3 "C:\Users\Federico\Desktop\MyCourse\Views\_ViewImports.cshtml"
using MyCourse.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cac943412197426ff947d8a457ec9040ed263746", @"/Views/Courses/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54cd52ed39abecd474331a3ee15813f21cb4a7b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseDetailViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 104, true);
            WriteLiteral("\r\n<section class=\"course-info\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-9\">\r\n            <h1>");
            EndContext();
            BeginContext(135, 11, false);
#line 6 "C:\Users\Federico\Desktop\MyCourse\Views\Courses\Detail.cshtml"
           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(146, 279, true);
            WriteLiteral(@"</h1>
        </div>
        <div class=""col-md-3 d-flex align-item-center"">
            <a href=""#"" class=""btn btn-warning btn-lg btn-block register-button mt-5"">Iscriviti</a>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-9"">
            <p>");
            EndContext();
            BeginContext(426, 17, false);
#line 14 "C:\Users\Federico\Desktop\MyCourse\Views\Courses\Detail.cshtml"
          Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(443, 117, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-md-3 course-picture\">\r\n            <aside>\r\n                <author>di ");
            EndContext();
            BeginContext(561, 12, false);
#line 18 "C:\Users\Federico\Desktop\MyCourse\Views\Courses\Detail.cshtml"
                      Write(Model.Author);

#line default
#line hidden
            EndContext();
            BeginContext(573, 49, true);
            WriteLiteral("</author>\r\n                <div class=\"rating\">\r\n");
            EndContext();
#line 20 "C:\Users\Federico\Desktop\MyCourse\Views\Courses\Detail.cshtml"
                     for (int i = 1; i <= 5; i++)
                    {
                        if (Model.Rating >= i)
                        {

#line default
#line hidden
            BeginContext(771, 57, true);
            WriteLiteral("                            <i class=\"fas fa-star\"></i>\r\n");
            EndContext();
#line 25 "C:\Users\Federico\Desktop\MyCourse\Views\Courses\Detail.cshtml"
                        }
                        else if (Model.Rating > i - 1)
                        {

#line default
#line hidden
            BeginContext(938, 66, true);
            WriteLiteral("                            <i class=\"fas fa-star-half-alt\"></i>\r\n");
            EndContext();
#line 29 "C:\Users\Federico\Desktop\MyCourse\Views\Courses\Detail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1088, 57, true);
            WriteLiteral("                            <i class=\"far fa-star\"></i>\r\n");
            EndContext();
#line 33 "C:\Users\Federico\Desktop\MyCourse\Views\Courses\Detail.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(1195, 59, true);
            WriteLiteral("                </div>\r\n                <div class=\"price\">");
            EndContext();
            BeginContext(1255, 18, false);
#line 36 "C:\Users\Federico\Desktop\MyCourse\Views\Courses\Detail.cshtml"
                              Write(Model.CurrentPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1273, 8, true);
            WriteLiteral(" <br><s>");
            EndContext();
            BeginContext(1282, 15, false);
#line 36 "C:\Users\Federico\Desktop\MyCourse\Views\Courses\Detail.cshtml"
                                                         Write(Model.FullPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1297, 82, true);
            WriteLiteral("</s></div>\r\n                <div class=\"course-picture\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1379, "\"", 1401, 1);
#line 38 "C:\Users\Federico\Desktop\MyCourse\Views\Courses\Detail.cshtml"
WriteAttributeValue("", 1385, Model.ImagePath, 1385, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1402, 173, true);
            WriteLiteral(" alt=\"course-picture\" width=\"128\">\r\n                </div>\r\n            </aside>\r\n        </div>\r\n    </div>\r\n</section>\r\n<section class=\"course-lessons\">\r\n    <h2>Lezioni (");
            EndContext();
            BeginContext(1576, 19, false);
#line 45 "C:\Users\Federico\Desktop\MyCourse\Views\Courses\Detail.cshtml"
            Write(Model.Lessons.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1595, 8, true);
            WriteLiteral(")</h2>\r\n");
            EndContext();
#line 46 "C:\Users\Federico\Desktop\MyCourse\Views\Courses\Detail.cshtml"
     foreach (var lesson in Model.Lessons)
    {

#line default
#line hidden
            BeginContext(1654, 129, true);
            WriteLiteral("        <hr>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-9 d-flex align-items-left\">\r\n                <a href=\"#\">");
            EndContext();
            BeginContext(1784, 12, false);
#line 51 "C:\Users\Federico\Desktop\MyCourse\Views\Courses\Detail.cshtml"
                       Write(lesson.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1796, 154, true);
            WriteLiteral("</a>\r\n            </div>\r\n            <div class=\"col-md-3 d-flex align-items-right lesson-duration\">\r\n                <i class=\"far fa-clock \"></i><time>");
            EndContext();
            BeginContext(1951, 37, false);
#line 54 "C:\Users\Federico\Desktop\MyCourse\Views\Courses\Detail.cshtml"
                                              Write(lesson.Duration.ToString("m'm 's's'"));

#line default
#line hidden
            EndContext();
            BeginContext(1988, 45, true);
            WriteLiteral("</time>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 57 "C:\Users\Federico\Desktop\MyCourse\Views\Courses\Detail.cshtml"
    }

#line default
#line hidden
            BeginContext(2040, 260, true);
            WriteLiteral(@"    <hr>
    <div class=""row course-duration"">
        <div class=""col-md-9 d-flex align-items-left"">
            Totale
        </div>
        <div class=""col-md-3 d-flex align-items-right lesson-duration"">
            <i class=""far fa-clock""></i><time>");
            EndContext();
            BeginContext(2301, 55, false);
#line 64 "C:\Users\Federico\Desktop\MyCourse\Views\Courses\Detail.cshtml"
                                         Write(Model.TotalCourseDuration.ToString(@"hh\h\ mm\m\ ss\s"));

#line default
#line hidden
            EndContext();
            BeginContext(2356, 47, true);
            WriteLiteral("</time>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591