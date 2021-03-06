#pragma checksum "C:\Users\gdeca\source\repos\Momias\Pages\Account\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf3cc1a441adf37574348cae4d1bb0f224dcc721"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Account_Details), @"mvc.1.0.razor-page", @"/Pages/Account/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf3cc1a441adf37574348cae4d1bb0f224dcc721", @"/Pages/Account/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60ebbbda654f71e3e0dbf15c6b06095849f02c1c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Account_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!--The HttpContext.User property can be accessed through the User convenience property defined by the PageModel and
ControllerBase classes. This Razor Page confirms that there is an authenticated user associated with the request and gets the
IdentityUser object that describes the user-->
<table class=""table table-sm table-bordered"">
    <tbody>
");
#nullable restore
#line 8 "C:\Users\gdeca\source\repos\Momias\Pages\Account\Details.cshtml"
         if (Model.IdentityUser == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr><th class=\"text-center\">No User</th></tr>\r\n");
#nullable restore
#line 11 "C:\Users\gdeca\source\repos\Momias\Pages\Account\Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr><th>Name</th><td>");
#nullable restore
#line 14 "C:\Users\gdeca\source\repos\Momias\Pages\Account\Details.cshtml"
                            Write(Model.IdentityUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n            <tr><th>Email</th><td>");
#nullable restore
#line 15 "C:\Users\gdeca\source\repos\Momias\Pages\Account\Details.cshtml"
                             Write(Model.IdentityUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 16 "C:\Users\gdeca\source\repos\Momias\Pages\Account\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\gdeca\source\repos\Momias\Pages\Account\Details.cshtml"
            
    public class DetailsModel : PageModel
    {
        private UserManager<IdentityUser> userManager;
        public DetailsModel(UserManager<IdentityUser> manager)
        {
            userManager = manager;
        }
        public IdentityUser IdentityUser { get; set; }
        public async Task OnGetAsync()
        {
            if (User.Identity.IsAuthenticated)
            {
                IdentityUser = await userManager.FindByNameAsync(User.Identity.Name);
            }
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DetailsModel>)PageContext?.ViewData;
        public DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
