#pragma checksum "C:\Users\gdeca\source\repos\Momias\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b658e20064f7ef261347e30d08ac0d611f7fb5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
#line 2 "C:\Users\gdeca\source\repos\Momias\Pages\_ViewImports.cshtml"
using Momias.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gdeca\source\repos\Momias\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gdeca\source\repos\Momias\Pages\_ViewImports.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gdeca\source\repos\Momias\Pages\_ViewImports.cshtml"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gdeca\source\repos\Momias\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gdeca\source\repos\Momias\Pages\_ViewImports.cshtml"
using Momias.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/pages")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b658e20064f7ef261347e30d08ac0d611f7fb5f", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60ebbbda654f71e3e0dbf15c6b06095849f02c1c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h4 class=""bg-primary text-white text-center p-2"">People</h4>
<table class=""table table-sm table-bordered table-striped"">
    <thead>
        <tr>
            <th>ID</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Profession</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 14 "C:\Users\gdeca\source\repos\Momias\Pages\Index.cshtml"
         foreach (Person p in Model.People)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("class", " class=\"", 422, "\"", 458, 1);
#nullable restore
#line 16 "C:\Users\gdeca\source\repos\Momias\Pages\Index.cshtml"
WriteAttributeValue("", 430, Model.GetClass(p.FirstName), 430, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>");
#nullable restore
#line 17 "C:\Users\gdeca\source\repos\Momias\Pages\Index.cshtml"
               Write(p.PersonId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\gdeca\source\repos\Momias\Pages\Index.cshtml"
               Write(p.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 18 "C:\Users\gdeca\source\repos\Momias\Pages\Index.cshtml"
                             Write(p.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\gdeca\source\repos\Momias\Pages\Index.cshtml"
               Write(p.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\gdeca\source\repos\Momias\Pages\Index.cshtml"
               Write(p.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            </tr>\r\n");
#nullable restore
#line 22 "C:\Users\gdeca\source\repos\Momias\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b658e20064f7ef261347e30d08ac0d611f7fb5f6968", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label for=\"selectedCity\">City</label>\r\n        <select name=\"selectedCity\" class=\"form-control\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b658e20064f7ef261347e30d08ac0d611f7fb5f7389", async() => {
                    WriteLiteral("Select City");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\gdeca\source\repos\Momias\Pages\Index.cshtml"
             foreach (string city in Model.Cities)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b658e20064f7ef261347e30d08ac0d611f7fb5f9307", async() => {
                    WriteLiteral("\r\n                    ");
#nullable restore
#line 33 "C:\Users\gdeca\source\repos\Momias\Pages\Index.cshtml"
               Write(city);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 32 "C:\Users\gdeca\source\repos\Momias\Pages\Index.cshtml"
AddHtmlAttributeValue("", 1022, city == Model.SelectedCity, 1022, 29, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Users\gdeca\source\repos\Momias\Pages\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n    </div>\r\n    <button class=\"btn btn-primary\" type=\"submit\">Select</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\gdeca\source\repos\Momias\Pages\Index.cshtml"
            
    public class IndexModel : PageModel
    {
        private DataContext context;
        public IndexModel(DataContext dbContext)
        {
            context = dbContext;
        }
        public IEnumerable<Person> People { get; set; }
        public IEnumerable<string> Cities { get; set; }
        [FromQuery]
        public string SelectedCity { get; set; }
        public void OnGet()
        {
            People = context.People;
        }
        public string GetClass(string city) =>
        SelectedCity == city ? "bg-info text-white" : "";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
