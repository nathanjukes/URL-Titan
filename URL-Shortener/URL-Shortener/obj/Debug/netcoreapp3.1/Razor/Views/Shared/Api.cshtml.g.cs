#pragma checksum "E:\coding\GitHub\Repos\URL-Shortener\URL-Shortener\URL-Shortener\Views\Shared\Api.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f7ea96a5f15ba2834a49216daed75a5bbae977e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Api), @"mvc.1.0.view", @"/Views/Shared/Api.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f7ea96a5f15ba2834a49216daed75a5bbae977e", @"/Views/Shared/Api.cshtml")]
    public class Views_Shared_Api : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "api", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\coding\GitHub\Repos\URL-Shortener\URL-Shortener\URL-Shortener\Views\Shared\Api.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "URL Titan: API";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container mt-3 text-center"">
    <h1 class=""text-white pt-4"">URL-Titan  API  Documentation v1.0</h1>
    <label class=""text-white-50 pb-3"">Click the Endpoint to see more info!</label>
    <div>
        <table class=""table text-white mt-4 table-hover text-left"" cellspacing=""5"">
            <thead class=""text-primary"" style=""font-weight:bold"">
                <tr>
                    <th scope=""col"">METHOD</th>
                    <th scope=""col"">ENDPOINT</th>
                    <th scope=""col"">USAGE</th>
                    <th scope=""col"">ADDED</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td class=""text-white"" style=""font-weight:bold"" scope=""row"">POST</td>
                    <td class=""text-primary"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f7ea96a5f15ba2834a49216daed75a5bbae977e4219", async() => {
                WriteLiteral("/Api/ShortenURL");
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
            WriteLiteral(@"</td>
                    <td class=""text-white"">Takes a full URL and returns a shortened version</td>
                    <td class=""text-white"">25/08/2020</td>
                </tr>
                <tr>
                    <td class=""text-white"" style=""font-weight:bold"" scope=""row"">GET</td>
                    <td class=""text-primary"">/Api/GetFullUrl</td>
                    <td class=""text-white"">Returns the full URL for a given shortened URL</td>
                    <td class=""text-white"">26/08/2020</td>
                </tr>
                <tr>
                    <td class=""text-white"" style=""font-weight:bold"" scope=""row"">POST</td>
                    <td class=""text-primary"">/Api/ShortenCollection</td>
                    <td class=""text-white"">Takes an array of URLs and returns an array of shortened URLs</td>
                    <td class=""text-white"">26/08/2020</td>
                </tr>
                <tr>
                    <td class=""text-white"" style=""font-weight:bold"" scope=""");
            WriteLiteral(@"row"">GET</td>
                    <td class=""text-primary"">/Api/GetUrlUses</td>
                    <td class=""text-white"">Gets the total amount of uses for a given shortened URL</td>
                    <td class=""text-white"">27/08/2020</td>
                </tr>
                <tr>
                    <td class=""text-white"" style=""font-weight:bold"" scope=""row"">GET</td>
                    <td class=""text-primary"">/Api/GetUrlStats</td>
                    <td class=""text-white"">Gets the full stats for a given shortened URL</td>
                    <td class=""text-white"">27/08/2020</td>
                </tr>
            </tbody>
        </table>
        <label class=""text-white-50 mt-5 pb-2"">Please note: This entire project is hosted on a Raspberry Pi and may be subject to downtime for maintenance. In addition to this, it is not the most powerful server so please be cautious with the amount of calls you make to ensure that I can keep running URL-Titan. 😄</label>
    </div>
</div>");
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
