#pragma checksum "C:\Users\B00650670\source\repos\COM412 Coursework 1\CinemaBooking\Pages\Queries\Query3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10b66bdf978b90bd17fc89ea7966a7a6ca5cc672"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CinemaBooking.Pages.Queries.Pages_Queries_Query3), @"mvc.1.0.razor-page", @"/Pages/Queries/Query3.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Queries/Query3.cshtml", typeof(CinemaBooking.Pages.Queries.Pages_Queries_Query3), null)]
namespace CinemaBooking.Pages.Queries
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\B00650670\source\repos\COM412 Coursework 1\CinemaBooking\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\B00650670\source\repos\COM412 Coursework 1\CinemaBooking\Pages\_ViewImports.cshtml"
using CinemaBooking;

#line default
#line hidden
#line 3 "C:\Users\B00650670\source\repos\COM412 Coursework 1\CinemaBooking\Pages\_ViewImports.cshtml"
using CinemaBooking.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10b66bdf978b90bd17fc89ea7966a7a6ca5cc672", @"/Pages/Queries/Query3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bd1a65704bee9530a74f6ba5ef3c5c1cbd47285", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Queries_Query3 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\B00650670\source\repos\COM412 Coursework 1\CinemaBooking\Pages\Queries\Query3.cshtml"
  
    ViewData["Title"] = "Query3";

#line default
#line hidden
            BeginContext(97, 126, true);
            WriteLiteral("\r\n<h2>Maximum Minimum Query</h2>\r\n<br>\r\n\r\n<b> This query is displaying the minimum and maximum prices paid for bookings.</b>\r\n");
            EndContext();
            BeginContext(224, 23, false);
#line 11 "C:\Users\B00650670\source\repos\COM412 Coursework 1\CinemaBooking\Pages\Queries\Query3.cshtml"
Write(ViewData["MaxMinQuery"]);

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CinemaBooking.Pages.Queries.Query3Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CinemaBooking.Pages.Queries.Query3Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CinemaBooking.Pages.Queries.Query3Model>)PageContext?.ViewData;
        public CinemaBooking.Pages.Queries.Query3Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
