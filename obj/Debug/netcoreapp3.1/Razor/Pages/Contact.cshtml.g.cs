#pragma checksum "/home/monchkrit/Code-House/ISAS/Pages/Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66df20851a4dd7d6edf7ee561f81c254055032de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ISAS.Pages.Pages_Contact), @"mvc.1.0.razor-page", @"/Pages/Contact.cshtml")]
namespace ISAS.Pages
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
#line 1 "/home/monchkrit/Code-House/ISAS/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/monchkrit/Code-House/ISAS/Pages/_ViewImports.cshtml"
using ISAS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/monchkrit/Code-House/ISAS/Pages/_ViewImports.cshtml"
using ISAS.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66df20851a4dd7d6edf7ee561f81c254055032de", @"/Pages/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaa7e382126dd0182dc0c717b300c4f1d5a5df43", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-fluid"">
  <div class=""row align-items-center"">
    <img src=""../images/ISAS.png"" />
  </div>
  <div class=""row form-box"">
    <div class=""col"">
      <p class=""h3"">All Inqueries to Internet Sites and Stores</p>
      <p class=""lead"">Contact: Donny Buckman MIS</p>
      <strong>Address:</strong><br />
      Donny Buckman<br />
      201 Rava Pkwy<br />
      Greenfield, CA 93927<br /><br />
      <strong>Telephone:</strong> 831-229-8474<br />
      <p><strong><a href=""mailto:dbuckman@plantformsoftware.com"">E-Mail: dbuckman@plantformsoftware.com</a></strong></p>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.ContactModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.ContactModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.ContactModel>)PageContext?.ViewData;
        public MyApp.Namespace.ContactModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
