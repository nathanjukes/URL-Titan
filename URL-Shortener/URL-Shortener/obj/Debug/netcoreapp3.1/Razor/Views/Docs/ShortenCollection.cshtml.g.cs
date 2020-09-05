#pragma checksum "E:\coding\GitHub\Repos\URL-Shortener\URL-Shortener\URL-Shortener\Views\Docs\ShortenCollection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e20c0a1fdacca593ec3f4cf1bdaab1599d691fcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Docs_ShortenCollection), @"mvc.1.0.view", @"/Views/Docs/ShortenCollection.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e20c0a1fdacca593ec3f4cf1bdaab1599d691fcb", @"/Views/Docs/ShortenCollection.cshtml")]
    public class Views_Docs_ShortenCollection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<URL_Shortener.Models.DocsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\coding\GitHub\Repos\URL-Shortener\URL-Shortener\URL-Shortener\Views\Docs\ShortenCollection.cshtml"
  
    ViewData["Title"] = "URL Titan: API - ShortenCollection";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""container mt-3 text-center"">
        <h1 class=""text-white pt-4"">Shorten Collection Endpoint</h1>
        <label class=""text-white-50 pb-3"">Lets you POST a collection of URL's and get the shortened URL's returned</label>
    </div>
    <div class=""col-lg-8"">
        <div class=""container mt-3 text-center float-left col-md-10 offset-2 table-responsive"">
            <table class=""table text-white mt-4 text-left"">
                <tbody>
                    <tr>
                        <th class=""text-primary"">Description</th>
                        <td>Shortens a collection of URL's</td>
                    </tr>
                    <tr>
                        <th class=""text-primary"">Endpoint</th>
                        <td>/Api/ShortenCollection</td>
                    </tr>
                    <tr>
                        <th class=""text-primary"">HTTP Method</th>
                        <td>POST</td>
                    </tr>
                    ");
            WriteLiteral(@"<tr>
                        <th class=""text-primary"">Authorization</th>
                        <td>No authorization required</td>
                    </tr>
                    <tr>
                        <th class=""text-primary"">Request Limit</th>
                        <td>∞</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class="" mt-4 pt-3 px-3 text-center"">
            <h2 class=""text-white"">Example Request</h2>
            <div class=""text-left"" style=""background-color:#1b1f22; border-radius:0.4em;"">
                <label class=""my-3 mx-4 px-3"">
                    <code class=""text-white"" style=""font-size:medium;"">
                        POST ");
#nullable restore
#line 47 "E:\coding\GitHub\Repos\URL-Shortener\URL-Shortener\URL-Shortener\Views\Docs\ShortenCollection.cshtml"
                         Write(Model.HostName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"Api/ShortenCollection
                        <br /><br />
                        Required Body Parameters: <br />""UrlList"" : YourURL
                    </code>
                </label>
            </div>
        </div>
    </div>
</div>

<div class=""container text-center text-white my-5 py-4"" style=""clear:both"">
    <h2>Required Body Parameters</h2>
    <div class=""mt-3"" style=""background-color:#1b1f22; border-radius:0.4em;"">
        <label class=""pt-3"">
            '<b>BaseURL</b>' - The URL you wish to have shortened and returned to you
            <br /><label class=""pt-2 text-muted"">e.g. 'https://twitter.com/'</label>
        </label>
    </div>

    <h2 class=""mt-5 pt-3"">Example Response</h2>
    <div class=""mt-3"" style=""background-color:#1b1f22; border-radius:0.4em;"">
        <label class=""my-3 mx-4 px-3"">
            <code class=""text-white"" style=""font-size:medium;"">
                {
                ""shortenedUrl"": """);
#nullable restore
#line 71 "E:\coding\GitHub\Repos\URL-Shortener\URL-Shortener\URL-Shortener\Views\Docs\ShortenCollection.cshtml"
                             Write(Model.HostName);

#line default
#line hidden
#nullable disable
            WriteLiteral("32189\"\r\n                }\r\n            </code>\r\n        </label>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<URL_Shortener.Models.DocsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
