#pragma checksum "C:\Users\annal\OneDrive\Documents\BAAA\IDigenigen\Interdisciplinary\Interdisciplinary\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26d51c0480d8fdba77733678c5733857ed50ba7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\annal\OneDrive\Documents\BAAA\IDigenigen\Interdisciplinary\Interdisciplinary\Views\_ViewImports.cshtml"
using Interdisciplinary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\annal\OneDrive\Documents\BAAA\IDigenigen\Interdisciplinary\Interdisciplinary\Views\_ViewImports.cshtml"
using Interdisciplinary.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26d51c0480d8fdba77733678c5733857ed50ba7d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2eea889594722046df27b3b9a37f4f8245f3fd39", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12f4c8588e9379963aa53f7a1bdb1857f518eafe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\annal\OneDrive\Documents\BAAA\IDigenigen\Interdisciplinary\Interdisciplinary\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>lorem ipsum  </p>\r\n    <p> test test</p>\r\n    <h2>Tester cocktails</h2>\r\n</div>\r\n<h1>Ingredienser</h1>\r\n<p id=\"list\" style=\"font-size: 15px; font-weight: bold;\">\r\n</p>\r\n<p>\r\n");
#nullable restore
#line 15 "C:\Users\annal\OneDrive\Documents\BAAA\IDigenigen\Interdisciplinary\Interdisciplinary\Views\Home\Index.cshtml"
     foreach (Drink drink in ViewBag.Drinks)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\annal\OneDrive\Documents\BAAA\IDigenigen\Interdisciplinary\Interdisciplinary\Views\Home\Index.cshtml"
   Write(drink.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\annal\OneDrive\Documents\BAAA\IDigenigen\Interdisciplinary\Interdisciplinary\Views\Home\Index.cshtml"
                   ;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<button id=\"button\" onclick=\"randomDrink()\">click here</button>\r\n\r\n<p id=\"drink\" style=\"font-size: 24px; font-weight: bold; color: green;\">\r\n</p>\r\n");
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