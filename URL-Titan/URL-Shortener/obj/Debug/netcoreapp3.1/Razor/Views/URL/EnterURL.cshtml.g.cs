#pragma checksum "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\EnterURL.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ceb904385756e00a83bf54956bd11a1b953d69a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_URL_EnterURL), @"mvc.1.0.view", @"/Views/URL/EnterURL.cshtml")]
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
#line 1 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\EnterURL.cshtml"
using URL_Shortener.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ceb904385756e00a83bf54956bd11a1b953d69a", @"/Views/URL/EnterURL.cshtml")]
    public class Views_URL_EnterURL : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EnterURLModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/SetActiveNavLink.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-text  pt-0 text-primary text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "api", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:underline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form_message"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "BaseURL", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Your URL here"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("resize:none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:#c41200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "url", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "uploadurl", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "url-list", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\EnterURL.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "URL Titan";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script");
            BeginWriteAttribute("src", " src=\'", 185, "\'", 232, 1);
#nullable restore
#line 9 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\EnterURL.cshtml"
WriteAttributeValue("", 191, Url.Content("~/Scripts/jquery-1.8.2.js"), 191, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\'text/javascript\'></script>\r\n<script");
            BeginWriteAttribute("src", " src=\'", 275, "\'", 325, 1);
#nullable restore
#line 10 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\EnterURL.cshtml"
WriteAttributeValue("", 281, Url.Content("~/Scripts/jquery.validate.js"), 281, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\'text/javascript\'></script>\r\n<script");
            BeginWriteAttribute("src", " src=\'", 368, "\'", 430, 1);
#nullable restore
#line 11 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\EnterURL.cshtml"
WriteAttributeValue("", 374, Url.Content("~/Scripts/jquery.validate.unobtrusive.js"), 374, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\'text/javascript\'></script>\r\n\r\n");
#nullable restore
#line 13 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\EnterURL.cshtml"
    string urlCountDisplay = Model.UserUrls.Count() == 0 ? "5 URLs" : $"{Model.UserUrls.Count()} URLs";

    if(Model.UserUrls.Count() == 1)
    {
        urlCountDisplay = "URL";
    }
 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ceb904385756e00a83bf54956bd11a1b953d69a10429", async() => {
                WriteLiteral("SetActiveNav(\"Home\")");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h3 class=\"card-text  pb-0 text-light text-center\"><br />An efficient, simple way to enhance your links and make them more clickable!</h3>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ceb904385756e00a83bf54956bd11a1b953d69a11713", async() => {
                WriteLiteral(" URL-Titan API!");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n\r\n<div class=\"container align-content-center mt-5\">\r\n    <div class=\"col-md-12 text-center\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ceb904385756e00a83bf54956bd11a1b953d69a13376", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label for=\"form_message\" class=\"text-light p-3\">Please input your URL beneath:</label>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ceb904385756e00a83bf54956bd11a1b953d69a13804", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 34 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\EnterURL.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UrlData.BaseURL);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.Name = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <button class=\"btn btn-primary m-md-4\">Get Shortened URL!</button>\r\n                <div>\r\n");
#nullable restore
#line 37 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\EnterURL.cshtml"
                     if (!ViewData.ModelState.IsValid)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ceb904385756e00a83bf54956bd11a1b953d69a16630", async() => {
                    WriteLiteral("Please enter a valid Full URL.");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 39 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\EnterURL.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UrlData.BaseURL);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 40 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\EnterURL.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n</div>\r\n\r\n<div class=\"container align-content-center mt-3\">\r\n    <div class=\"col-md-12 text-center\">\r\n        <h3 class=\"text-light pb-2\">Your Previous ");
#nullable restore
#line 50 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\EnterURL.cshtml"
                                             Write(urlCountDisplay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 51 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\EnterURL.cshtml"
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
                            <th scope=""col"" style=""width:25%; text-align:right"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ceb904385756e00a83bf54956bd11a1b953d69a21338", async() => {
                WriteLiteral("See Full List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n");
#nullable restore
#line 61 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\EnterURL.cshtml"
                foreach (URL url in Model.UserUrls.Reverse())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 64 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\EnterURL.cshtml"
                        Write(Model.HostName + url.ShortenedIdentifier);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 65 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\EnterURL.cshtml"
                       Write(url.BaseURL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 67 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\EnterURL.cshtml"
                         using (Html.BeginForm("DeleteURL", "url"))
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\EnterURL.cshtml"
                       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\EnterURL.cshtml"
                                                    ;

                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\EnterURL.cshtml"
                       Write(Html.Hidden("shortenedID", url.ShortenedIdentifier));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <!--Passing a shortenedID parameter to the controller-->\r\n");
#nullable restore
#line 72 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\EnterURL.cshtml"
                       Write(Html.Hidden("pageType", "IndexList"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <!--Passing a pageType parameter to the controller-->\r\n");
            WriteLiteral("                            <td><span><button name=\"shortenedID\" id=\"btnSubmit\" type=\"submit\" class=\"btn btn-outline-primary\">Delete</button></span></td>\r\n");
#nullable restore
#line 75 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\EnterURL.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 77 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\EnterURL.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n");
#nullable restore
#line 79 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\EnterURL.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h4 class=\"pt-3 text-primary\">⠀No URL\'s Shortened 😢</h4>\r\n");
#nullable restore
#line 83 "E:\coding\GitHub\Repos\URL-Shortener\URL-Titan\URL-Shortener\Views\URL\EnterURL.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>


<div class=""container"">
    <div class=""col-md-12 text-center"">
        <h3 class=""mt-5 pt-5 text-light"">Information!</h3>
        <div class="" bg-secondary pb-3 col-md-12"" style=""border-radius:0.5em"">
            <div class=""container-sm text-center mt-3 pt-lg-4"">
                <div class=""text-body"">
                    <h2 style=""font-size:35px"">
                        What is a 'URL shortener'?
                        <small class=""text-muted text-black-50"" style=""font-size: 23px"">- And why are they so important?</small>
                    </h2>
                    <p style=""font-size:20px"">
                        <br />A URL shortener is a way of condensing a long and obtrusive URL into a small, easy to share URL. It replaces long, ugly URL's with a small and neat URL that is memorable and easily recognisable. Having a shortened URL is important as it allows for a much greater ease of access, meaning that more people will share and click it than ever before.'
    ");
            WriteLiteral(@"                </p>
                </div>
            </div>
        </div>
        <div class=""mt-5 bg-secondary col-md-12"" style=""border-radius:0.5em"">
            <div class=""container-sm text-center mt-2 pt-lg-4"">
                <div class=""text-body"">
                    <h2 style=""font-size:35px"">
                        Why use a URL shortener?
                    </h2>
                    <p class=""pb-4"" style=""font-size:20px"">
                        <br />Using a URL shortener allows for greater clarity in your links and also allows for ease of access. This ease of access gained by using a URL shortener hugely increases your efficiency when accessing links and saves time for anyone using the link.
                    </p>
                </div>
            </div>
        </div>
        <div class=""my-5 bg-secondary col-md-12"" style=""border-radius:0.5em"">
            <div class=""container-sm text-center mt-2 pt-lg-4"">
                <div class=""text-body"">
                    <");
            WriteLiteral(@"h2 style=""font-size:35px"">
                        When to use a URL shortener?
                    </h2>
                    <p class=""pb-4"" style=""font-size:20px"">
                        <br />Using a URL shortener for your links should become a staple in your lifestyle, ideally most of the links you save / share should be compact. This not only helps you, it also helps your friend by not having to enter such long and obtrusive links.
                    </p>
                </div>
            </div>
        </div>
    </div>
</div>


");
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
