#pragma checksum "C:\Users\Maunatlala Tech Inc\Documents\2022 SCHOOL WOORK\CSIQ 3734\Activities\Activtity 10\StudentFiles(30)\StudentFiles\MobileZone\MobileZone\Views\Mobile\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb430c62ccc0ae25b383e198d4642a11a244e4fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mobile_Details), @"mvc.1.0.view", @"/Views/Mobile/Details.cshtml")]
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
#line 1 "C:\Users\Maunatlala Tech Inc\Documents\2022 SCHOOL WOORK\CSIQ 3734\Activities\Activtity 10\StudentFiles(30)\StudentFiles\MobileZone\MobileZone\Views\_ViewImports.cshtml"
using MobileZone.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Maunatlala Tech Inc\Documents\2022 SCHOOL WOORK\CSIQ 3734\Activities\Activtity 10\StudentFiles(30)\StudentFiles\MobileZone\MobileZone\Views\_ViewImports.cshtml"
using MobileZone.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb430c62ccc0ae25b383e198d4642a11a244e4fb", @"/Views/Mobile/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbbc6b2a91ac9f225e9c77d45962dc1c08adca63", @"/Views/_ViewImports.cshtml")]
    public class Views_Mobile_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mobile>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Mobile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::MobileZone.Infrastructure.HeadingTagHelper __MobileZone_Infrastructure_HeadingTagHelper;
        private global::MobileZone.Infrastructure.LinkTagHelper __MobileZone_Infrastructure_LinkTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Maunatlala Tech Inc\Documents\2022 SCHOOL WOORK\CSIQ 3734\Activities\Activtity 10\StudentFiles(30)\StudentFiles\MobileZone\MobileZone\Views\Mobile\Details.cshtml"
   ViewData["Title"] = "Mobile Details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("h2", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb430c62ccc0ae25b383e198d4642a11a244e4fb5124", async() => {
#nullable restore
#line 4 "C:\Users\Maunatlala Tech Inc\Documents\2022 SCHOOL WOORK\CSIQ 3734\Activities\Activtity 10\StudentFiles(30)\StudentFiles\MobileZone\MobileZone\Views\Mobile\Details.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __MobileZone_Infrastructure_HeadingTagHelper = CreateTagHelper<global::MobileZone.Infrastructure.HeadingTagHelper>();
            __tagHelperExecutionContext.Add(__MobileZone_Infrastructure_HeadingTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<div>\n    <hr />\n    <div class=\"font-weight-bold\">");
#nullable restore
#line 8 "C:\Users\Maunatlala Tech Inc\Documents\2022 SCHOOL WOORK\CSIQ 3734\Activities\Activtity 10\StudentFiles(30)\StudentFiles\MobileZone\MobileZone\Views\Mobile\Details.cshtml"
                             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div> ");
            WriteLiteral("\n    <hr />\n    <p>\n        <span class=\"font-weight-bold\">\n            ");
#nullable restore
#line 12 "C:\Users\Maunatlala Tech Inc\Documents\2022 SCHOOL WOORK\CSIQ 3734\Activities\Activtity 10\StudentFiles(30)\StudentFiles\MobileZone\MobileZone\Views\Mobile\Details.cshtml"
       Write(Html.DisplayNameFor(model=>model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </span><br />\n       ");
#nullable restore
#line 14 "C:\Users\Maunatlala Tech Inc\Documents\2022 SCHOOL WOORK\CSIQ 3734\Activities\Activtity 10\StudentFiles(30)\StudentFiles\MobileZone\MobileZone\Views\Mobile\Details.cshtml"
  Write(Model.Price.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("\n    </p>\n    <p>\n        <span class=\"font-weight-bold\">\n            ");
#nullable restore
#line 18 "C:\Users\Maunatlala Tech Inc\Documents\2022 SCHOOL WOORK\CSIQ 3734\Activities\Activtity 10\StudentFiles(30)\StudentFiles\MobileZone\MobileZone\Views\Mobile\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </span><br />\n        ");
#nullable restore
#line 20 "C:\Users\Maunatlala Tech Inc\Documents\2022 SCHOOL WOORK\CSIQ 3734\Activities\Activtity 10\StudentFiles(30)\StudentFiles\MobileZone\MobileZone\Views\Mobile\Details.cshtml"
   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </p>\n    <p>\n        <span class=\"font-weight-bold\">\n            ");
#nullable restore
#line 24 "C:\Users\Maunatlala Tech Inc\Documents\2022 SCHOOL WOORK\CSIQ 3734\Activities\Activtity 10\StudentFiles(30)\StudentFiles\MobileZone\MobileZone\Views\Mobile\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ManufactureDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </span><br />\n        ");
#nullable restore
#line 26 "C:\Users\Maunatlala Tech Inc\Documents\2022 SCHOOL WOORK\CSIQ 3734\Activities\Activtity 10\StudentFiles(30)\StudentFiles\MobileZone\MobileZone\Views\Mobile\Details.cshtml"
   Write(Model.ManufactureDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("\n    </p>\n    <p>\n        <span class=\"font-weight-bold\">\n            ");
#nullable restore
#line 30 "C:\Users\Maunatlala Tech Inc\Documents\2022 SCHOOL WOORK\CSIQ 3734\Activities\Activtity 10\StudentFiles(30)\StudentFiles\MobileZone\MobileZone\Views\Mobile\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </span><br />\n        ");
#nullable restore
#line 32 "C:\Users\Maunatlala Tech Inc\Documents\2022 SCHOOL WOORK\CSIQ 3734\Activities\Activtity 10\StudentFiles(30)\StudentFiles\MobileZone\MobileZone\Views\Mobile\Details.cshtml"
   Write(Model.IsInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </p>\n</div>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb430c62ccc0ae25b383e198d4642a11a244e4fb9943", async() => {
                WriteLiteral("Edit");
            }
            );
            __MobileZone_Infrastructure_LinkTagHelper = CreateTagHelper<global::MobileZone.Infrastructure.LinkTagHelper>();
            __tagHelperExecutionContext.Add(__MobileZone_Infrastructure_LinkTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\Maunatlala Tech Inc\Documents\2022 SCHOOL WOORK\CSIQ 3734\Activities\Activtity 10\StudentFiles(30)\StudentFiles\MobileZone\MobileZone\Views\Mobile\Details.cshtml"
                                                             WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb430c62ccc0ae25b383e198d4642a11a244e4fb12711", async() => {
                WriteLiteral("Back to List");
            }
            );
            __MobileZone_Infrastructure_LinkTagHelper = CreateTagHelper<global::MobileZone.Infrastructure.LinkTagHelper>();
            __tagHelperExecutionContext.Add(__MobileZone_Infrastructure_LinkTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mobile> Html { get; private set; }
    }
}
#pragma warning restore 1591
