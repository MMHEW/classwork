#pragma checksum "C:\Users\fuzzy\Desktop\Git Repos\classwork\MVSC Repo\ClassChallengeDEC08\ClassChallengeDEC08\Views\Friend\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c250b98136fdc82bac58fc8b4a4b1c53f2d04c99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Friend_Index), @"mvc.1.0.view", @"/Views/Friend/Index.cshtml")]
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
#line 1 "C:\Users\fuzzy\Desktop\Git Repos\classwork\MVSC Repo\ClassChallengeDEC08\ClassChallengeDEC08\Views\_ViewImports.cshtml"
using ClassChallengeDEC08;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fuzzy\Desktop\Git Repos\classwork\MVSC Repo\ClassChallengeDEC08\ClassChallengeDEC08\Views\_ViewImports.cshtml"
using ClassChallengeDEC08.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\fuzzy\Desktop\Git Repos\classwork\MVSC Repo\ClassChallengeDEC08\ClassChallengeDEC08\Views\Friend\Index.cshtml"
using ClassChallengeDEC08.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c250b98136fdc82bac58fc8b4a4b1c53f2d04c99", @"/Views/Friend/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3163ccddf8b483088c2d8033157e0fae213b9236", @"/Views/_ViewImports.cshtml")]
    public class Views_Friend_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FriendsList>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\fuzzy\Desktop\Git Repos\classwork\MVSC Repo\ClassChallengeDEC08\ClassChallengeDEC08\Views\Friend\Index.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["Desc"] = "A list of all your friends";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\fuzzy\Desktop\Git Repos\classwork\MVSC Repo\ClassChallengeDEC08\ClassChallengeDEC08\Views\Friend\Index.cshtml"
 foreach(var item in Model.Friends)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n    \r\n    <li> Friends Name ");
#nullable restore
#line 14 "C:\Users\fuzzy\Desktop\Git Repos\classwork\MVSC Repo\ClassChallengeDEC08\ClassChallengeDEC08\Views\Friend\Index.cshtml"
                 Write(item._friendName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n    \r\n    </ul>\r\n    <div class =\"friend-actions\">\r\n\r\n");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c250b98136fdc82bac58fc8b4a4b1c53f2d04c994761", async() => {
                WriteLiteral(" View Friend\'s Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\fuzzy\Desktop\Git Repos\classwork\MVSC Repo\ClassChallengeDEC08\ClassChallengeDEC08\Views\Friend\Index.cshtml"
                                   WriteLiteral(item._friendID);

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
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 24 "C:\Users\fuzzy\Desktop\Git Repos\classwork\MVSC Repo\ClassChallengeDEC08\ClassChallengeDEC08\Views\Friend\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Instructions", async() => {
                WriteLiteral("\r\n        <div class = \"justify-content-end\">\r\n            <p> Here is where you keep all your friends</p>\r\n            <br />\r\n            <p> Did I say Keep?</p>\r\n            <p> What I meant to say was ethically store</p>\r\n        </div>\r\n    ");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FriendsList> Html { get; private set; }
    }
}
#pragma warning restore 1591
