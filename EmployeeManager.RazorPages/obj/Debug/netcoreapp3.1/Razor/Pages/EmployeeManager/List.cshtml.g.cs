#pragma checksum "C:\Users\Mario\Desktop\ProjektZaliczeniowy\EmployeeManager.RazorPages\Pages\EmployeeManager\List.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c3af2acb025c8a30fe6416e8c4d1009f0f38f195cb2f582ef183c6973d3ebc73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_EmployeeManager_List), @"mvc.1.0.razor-page", @"/Pages/EmployeeManager/List.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Mario\Desktop\ProjektZaliczeniowy\EmployeeManager.RazorPages\Pages\_ViewImports.cshtml"
using EmployeeManager.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mario\Desktop\ProjektZaliczeniowy\EmployeeManager.RazorPages\Pages\_ViewImports.cshtml"
using EmployeeManager.RazorPages.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mario\Desktop\ProjektZaliczeniowy\EmployeeManager.RazorPages\Pages\_ViewImports.cshtml"
using EmployeeManager.RazorPages.Pages.EmployeeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mario\Desktop\ProjektZaliczeniowy\EmployeeManager.RazorPages\Pages\_ViewImports.cshtml"
using EmployeeManager.RazorPages.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mario\Desktop\ProjektZaliczeniowy\EmployeeManager.RazorPages\Pages\_ViewImports.cshtml"
using EmployeeManager.RazorPages.Pages.Security;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c3af2acb025c8a30fe6416e8c4d1009f0f38f195cb2f582ef183c6973d3ebc73", @"/Pages/EmployeeManager/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c051e74b7263221ccc577253efc2d807119facfeb8e9a0c04092bea3c0fbd53e", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_EmployeeManager_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Insert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("linkbutton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h2>List of Employees</h2>\r\n\r\n<h3 class=\"message\">");
#nullable restore
#line 6 "C:\Users\Mario\Desktop\ProjektZaliczeniowy\EmployeeManager.RazorPages\Pages\EmployeeManager\List.cshtml"
               Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3af2acb025c8a30fe6416e8c4d1009f0f38f195cb2f582ef183c6973d3ebc735617", async() => {
                WriteLiteral("Insert");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<br /><br />\r\n<table border=\"1\">\r\n  <tr>\r\n    <th>Employee ID</th>\r\n    <th>First Name</th>\r\n    <th>Last Name</th>\r\n    <th>Title</th>\r\n    <th>Country</th>\r\n    <th colspan=\"2\">Actions</th>\r\n  </tr>\r\n");
#nullable restore
#line 20 "C:\Users\Mario\Desktop\ProjektZaliczeniowy\EmployeeManager.RazorPages\Pages\EmployeeManager\List.cshtml"
   foreach(var item in Model.Employees)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n  <td>");
#nullable restore
#line 23 "C:\Users\Mario\Desktop\ProjektZaliczeniowy\EmployeeManager.RazorPages\Pages\EmployeeManager\List.cshtml"
 Write(item.EmployeeID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n  <td>");
#nullable restore
#line 24 "C:\Users\Mario\Desktop\ProjektZaliczeniowy\EmployeeManager.RazorPages\Pages\EmployeeManager\List.cshtml"
 Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n  <td>");
#nullable restore
#line 25 "C:\Users\Mario\Desktop\ProjektZaliczeniowy\EmployeeManager.RazorPages\Pages\EmployeeManager\List.cshtml"
 Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n  <td>");
#nullable restore
#line 26 "C:\Users\Mario\Desktop\ProjektZaliczeniowy\EmployeeManager.RazorPages\Pages\EmployeeManager\List.cshtml"
 Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n  <td>");
#nullable restore
#line 27 "C:\Users\Mario\Desktop\ProjektZaliczeniowy\EmployeeManager.RazorPages\Pages\EmployeeManager\List.cshtml"
 Write(item.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n  <td>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3af2acb025c8a30fe6416e8c4d1009f0f38f195cb2f582ef183c6973d3ebc738665", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\Mario\Desktop\ProjektZaliczeniowy\EmployeeManager.RazorPages\Pages\EmployeeManager\List.cshtml"
                           WriteLiteral(item.EmployeeID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  </td>\r\n  <td>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3af2acb025c8a30fe6416e8c4d1009f0f38f195cb2f582ef183c6973d3ebc7310964", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\Mario\Desktop\ProjektZaliczeniowy\EmployeeManager.RazorPages\Pages\EmployeeManager\List.cshtml"
                           WriteLiteral(item.EmployeeID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  </td>\r\n</tr>\r\n");
#nullable restore
#line 35 "C:\Users\Mario\Desktop\ProjektZaliczeniowy\EmployeeManager.RazorPages\Pages\EmployeeManager\List.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ListModel>)PageContext?.ViewData;
        public ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
