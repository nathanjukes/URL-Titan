#pragma checksum "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\DisplayURL.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7bf5cfd6a23ee6d1a283ef4eb839f2e3b268078"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_URL_DisplayURL), @"mvc.1.0.view", @"/Views/URL/DisplayURL.cshtml")]
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
#line 1 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\DisplayURL.cshtml"
using URL_Shortener.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7bf5cfd6a23ee6d1a283ef4eb839f2e3b268078", @"/Views/URL/DisplayURL.cshtml")]
    public class Views_URL_DisplayURL : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EnterURLModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\DisplayURL.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Display URL";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container align-content-center mt-5 text-center\">\r\n\r\n");
#nullable restore
#line 11 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\DisplayURL.cshtml"
     if (Model.UrlData != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!--Show all info relating to their url in this scope-->\r\n        <div class=\" bg-secondary pb-3 mb-4 col-md-12\" style=\"border-radius:0.5em\">\r\n            <h3 class=\"pt-3 text-black\">Shortened URL:  ");
#nullable restore
#line 15 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\DisplayURL.cshtml"
                                                    Write(Model.HostName+Model.UrlData.ShortenedIdentifier);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h3>
        </div>
        <div class="" bg-secondary pb-3 mb-5 col-md-8 offset-2"" style=""border-radius:0.5em"">
            <h4 class=""pt-3 text-black"">How to use the Shortened URL:</h4>
            <h5 class=""mt-3  text-pr"">Simply enter the shortened URL into any browser and you will be redirected to the full URL that you submitted.</h5>
        </div>
");
#nullable restore
#line 21 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\DisplayURL.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container align-content-center mt-3 mb-4\">\r\n        <div class=\"col-md-12 text-center\">\r\n            <h3 class=\"text-light pb-3\" id=\"fullURLTable\">Your Previous URLs</h3>\r\n");
#nullable restore
#line 25 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\DisplayURL.cshtml"
             if (Model.UserUrls.Count() > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table class=""table table-primary table-striped table-bordered table-hover table-sm"">
                    <thead>
                        <tr>
                            <th scope=""col"">Shortened URL</th>
                            <th scope=""col"">Full URL</th>
                            <th scope=""col"" style=""width:25%; text-align:right""></th>
                        </tr>
                    </thead>
");
#nullable restore
#line 35 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\DisplayURL.cshtml"
                     foreach (URL url in Model.UserUrls.Reverse())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 38 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\DisplayURL.cshtml"
                            Write(Model.HostName+url.ShortenedIdentifier);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 39 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\DisplayURL.cshtml"
                           Write(url.BaseURL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 41 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\DisplayURL.cshtml"
                             using (Html.BeginForm("DeleteURL", "url"))
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\DisplayURL.cshtml"
                           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\DisplayURL.cshtml"
                                                        ;

                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\DisplayURL.cshtml"
                           Write(Html.Hidden("shortenedID", url.ShortenedIdentifier));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <!--Passing a shortenedID parameter to the controller-->\r\n");
#nullable restore
#line 46 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\DisplayURL.cshtml"
                           Write(Html.Hidden("PageType", "FullList"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <!--Passing a pageType parameter to the controller-->\r\n");
            WriteLiteral("                                <td><span><button name=\"shortenedID\" id=\"btnSubmit\" type=\"submit\" class=\"btn btn-outline-primary\">Delete</button></span></td>\r\n");
#nullable restore
#line 49 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\DisplayURL.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 51 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\DisplayURL.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n");
#nullable restore
#line 53 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\DisplayURL.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h4 class=\"pt-3 text-primary\">⠀No URLs Shortened 😢</h4>\r\n");
#nullable restore
#line 57 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\DisplayURL.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EnterURLModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
