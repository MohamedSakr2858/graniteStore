#pragma checksum "C:\Users\student\Documents\repos\graniteStore\graniteStore\Views\Shared\_TableButtonsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bc38586d53e7d4d3569953d663bd3408754522c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TableButtonsPartial), @"mvc.1.0.view", @"/Views/Shared/_TableButtonsPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_TableButtonsPartial.cshtml", typeof(AspNetCore.Views_Shared__TableButtonsPartial))]
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
#line 1 "C:\Users\student\Documents\repos\graniteStore\graniteStore\Views\_ViewImports.cshtml"
using graniteStore;

#line default
#line hidden
#line 2 "C:\Users\student\Documents\repos\graniteStore\graniteStore\Views\_ViewImports.cshtml"
using graniteStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bc38586d53e7d4d3569953d663bd3408754522c", @"/Views/Shared/_TableButtonsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5273a4e9e9a3cb8d4a835ea9e77f9a13d9807693", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TableButtonsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(136, 81, true);
            WriteLiteral("\r\n\r\n    <div class=\"btn-group\" role=\"group\" >\r\n        <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 217, "\"", 250, 1);
#line 9 "C:\Users\student\Documents\repos\graniteStore\graniteStore\Views\Shared\_TableButtonsPartial.cshtml"
WriteAttributeValue("", 224, Url.Action("Edit/"+Model), 224, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(251, 121, true);
            WriteLiteral(">\r\n            <i class=\"fa fa-pencil-square-o\" aria-hidden=\"true\"></i>\r\n        </a>\r\n        <a class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 372, "\"", 408, 1);
#line 12 "C:\Users\student\Documents\repos\graniteStore\graniteStore\Views\Shared\_TableButtonsPartial.cshtml"
WriteAttributeValue("", 379, Url.Action("Details/"+Model), 379, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(409, 116, true);
            WriteLiteral(">\r\n            <i class=\"fa fa-info-circle\" aria-hidden=\"true\"></i>\r\n        </a>\r\n        <a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 525, "\"", 560, 1);
#line 15 "C:\Users\student\Documents\repos\graniteStore\graniteStore\Views\Shared\_TableButtonsPartial.cshtml"
WriteAttributeValue("", 532, Url.Action("Delete/"+Model), 532, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(561, 83, true);
            WriteLiteral(">\r\n            <i class=\"fa fa-trash\" aria-hidden=\"true\"></i>\r\n        </a>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
