#pragma checksum "E:\Banu\Zensar\Batch1\Core\CorePrj2\CorePrj2\Views\HR\DisplayPerson.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cb8e8dd5121e09dd0406be80a6a63f905b18b2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HR_DisplayPerson), @"mvc.1.0.view", @"/Views/HR/DisplayPerson.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cb8e8dd5121e09dd0406be80a6a63f905b18b2a", @"/Views/HR/DisplayPerson.cshtml")]
    public class Views_HR_DisplayPerson : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CorePrj2.Models.Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Banu\Zensar\Batch1\Core\CorePrj2\CorePrj2\Views\HR\DisplayPerson.cshtml"
  
    ViewData["Title"] = "DisplayPerson";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>DisplayPerson</h1>\r\n\r\n<li>");
#nullable restore
#line 8 "E:\Banu\Zensar\Batch1\Core\CorePrj2\CorePrj2\Views\HR\DisplayPerson.cshtml"
Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n<li>");
#nullable restore
#line 9 "E:\Banu\Zensar\Batch1\Core\CorePrj2\CorePrj2\Views\HR\DisplayPerson.cshtml"
Write(Model.PersonName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n<li>");
#nullable restore
#line 10 "E:\Banu\Zensar\Batch1\Core\CorePrj2\CorePrj2\Views\HR\DisplayPerson.cshtml"
Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CorePrj2.Models.Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
