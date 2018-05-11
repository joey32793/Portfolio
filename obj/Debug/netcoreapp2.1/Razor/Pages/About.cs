#pragma checksum "/Users/joey/asp/pages-apps/Portfolio/Pages/About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97c4664763ea34421501f28659b251cdf2d4799a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Portfolio.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/About.cshtml", typeof(Portfolio.Pages.Pages_About), null)]
namespace Portfolio.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/joey/asp/pages-apps/Portfolio/Pages/_ViewImports.cshtml"
using Portfolio;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97c4664763ea34421501f28659b251cdf2d4799a", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb0b91d38f740f858130f6573772cab915b9c278", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/joey/asp/pages-apps/Portfolio/Pages/About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(67, 2132, true);
            WriteLiteral(@"
<div class=""row text-center"">
    <div class=""col-lg-4"">
        <img class=""img-thumbnail"" src=""images/fallriver.jpg""/>
        <hr/>
        <h5 class=""courier"">> dotnet new about</h5>
        <p>
            I'm a Northern California native, born and raised in Redding, California and currently residing in Sacramento. 
            As a blissfully ignorant youth, I loved science, sports, and blazing hot California summers (kind of). After 
            forming a love affair with all things space as a kid, it only seemed to natural to study math and physics at 
            San Diego State University. I graduated in May of 2016 with a degree in Astrophysics, and began crunching 
            numbers in the defense sector of sunny San Diego.
        </p>

    </div>
    <div class=""col-lg-4"">
        <img class=""img-thumbnail"" src=""images/me.jpg""/>
        <hr/>
        <h5 class=""courier"">> dotnet watch run</h5>
        <p>
            I spent my undergrad writing Fortran and the occasional ");
            WriteLiteral(@"C, where I quickly discovered that while I enjoyed solving
            stellar structure equations (I'm a fan of mass continuity), I far more preferred writing the code
            that solved these problems. I became obsessed with all facets of software development and engineering, aspiring
            to be among the ranks of the best in the world of code. 
        </p>
    </div>
    <div class=""col-lg-4"">
        <img class=""img-fluid"" src=""images/csharp.png""/>
        <hr/>
        <h5 class=""courier"">> dotnet publish</h5>
        <p>
            As a .NET enthusiast, I'm a fan of all things Core nowadays. I prefer building web applications with ASP.NET Core
            and Angular 2+, with a hint of Django when I'm feeling a little adventurous. My data days working 
            in defense created a secondary passion for database programming, where SQL Server, Postgres, and SQLite3 are 
            welcome anytime in my projects. As a guy that struggles to draw stick figures, I'm a self-pro");
            WriteLiteral("claimed Bootstrap\r\n            evangelist as well.\r\n        </p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboutModel>)PageContext?.ViewData;
        public AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
