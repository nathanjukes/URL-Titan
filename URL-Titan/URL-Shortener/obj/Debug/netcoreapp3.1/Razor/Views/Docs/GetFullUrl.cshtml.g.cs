#pragma checksum "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\Docs\GetFullUrl.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "572cb229eb5176bcd31d8e27ed1bcc9408f199de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Docs_GetFullUrl), @"mvc.1.0.view", @"/Views/Docs/GetFullUrl.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"572cb229eb5176bcd31d8e27ed1bcc9408f199de", @"/Views/Docs/GetFullUrl.cshtml")]
    public class Views_Docs_GetFullUrl : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<URL_Shortener.Models.DocsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "docs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\Docs\GetFullUrl.cshtml"
  
    ViewData["Title"] = "URL Titan: API - Get Full URL";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""container mt-3 text-center"">
        <h1 class=""text-white pt-4"">Get Full URL Endpoint</h1>
        <label class=""text-white-50"">Lets you retrieve the full URL of a shortened URL in json form</label>
        <p class=""pb-3"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "572cb229eb5176bcd31d8e27ed1bcc9408f199de3718", async() => {
                WriteLiteral("Back to Docs");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</p>
    </div>
    <div class=""col-lg-8"">
        <div class=""container mt-3 text-center float-left col-md-10 offset-2 table-responsive"">
            <table class=""table text-white mt-4 text-left"">
                <tbody>
                    <tr>
                        <th class=""text-primary"">Description</th>
                        <td>Returns the base URL</td>
                    </tr>
                    <tr>
                        <th class=""text-primary"">Endpoint</th>
                        <td>/Api/GetFullUrl</td>
                    </tr>
                    <tr>
                        <th class=""text-primary"">HTTP Method</th>
                        <td>GET</td>
                    </tr>
                    <tr>
                        <th class=""text-primary"">Authorization</th>
                        <td>No authorization required</td>
                    </tr>
                    <tr>
                        <th class=""text-primary"">Request Limit</th>
                  ");
            WriteLiteral(@"      <td>∞</td>
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
                        GET ");
#nullable restore
#line 48 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\Docs\GetFullUrl.cshtml"
                        Write(Model.HostName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"Api/GetFullUrl
                        <br /><br />
                        Required Body Parameters: <br />""ShortUrl"" : YourShortenedURL
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
            '<b>ShortUrl</b>' - The shortened URL you were given
            <br /><label class=""pt-2 text-muted"">e.g. '");
#nullable restore
#line 63 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\Docs\GetFullUrl.cshtml"
                                                   Write(Model.HostName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"36fd0'</label>
        </label>
    </div>

    <h2 class=""mt-5 pt-3"">Example Response</h2>
    <div class=""mt-3"" style=""background-color:#1b1f22; border-radius:0.4em;"">
        <label class=""my-3 mx-4 px-3"">
            <code class=""text-white"" style=""font-size:medium;"">
                {
                ""baseUrl"": ""https://www.reddit.com/r/url-titan"",
                ""shortenedUrl"": """);
#nullable restore
#line 73 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\Docs\GetFullUrl.cshtml"
                             Write(Model.HostName);

#line default
#line hidden
#nullable disable
            WriteLiteral("36fd0\"\r\n                }\r\n            </code>\r\n        </label>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
