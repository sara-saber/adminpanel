#pragma checksum "C:\Users\sarah\Source\Repos\adminpanel\Admin\Views\Home\_Partial2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cccf7a1451c85b3bf8e02de21525061ade62375d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Partial2), @"mvc.1.0.view", @"/Views/Home/_Partial2.cshtml")]
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
#line 1 "C:\Users\sarah\Source\Repos\adminpanel\Admin\Views\_ViewImports.cshtml"
using Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sarah\Source\Repos\adminpanel\Admin\Views\_ViewImports.cshtml"
using Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cccf7a1451c85b3bf8e02de21525061ade62375d", @"/Views/Home/_Partial2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425c13ece3d0cfbb1fc0f84962af70815be6a0e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__Partial2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div class=\"col-12 col-sm-6 col-md-3\">\r\n        <div class=\"info-box\">\r\n            <span");
            BeginWriteAttribute("class", " class=\"", 107, "\"", 178, 3);
            WriteAttributeValue("", 115, "info-box-icon", 115, 13, true);
#nullable restore
#line 4 "C:\Users\sarah\Source\Repos\adminpanel\Admin\Views\Home\_Partial2.cshtml"
WriteAttributeValue("  ", 128, ViewData["class_"+Model.ToString()], 130, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 166, "elevation-1", 167, 12, true);
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 182, "\"", 226, 1);
#nullable restore
#line 4 "C:\Users\sarah\Source\Repos\adminpanel\Admin\Views\Home\_Partial2.cshtml"
WriteAttributeValue(" ", 190, ViewData["icon_"+Model.ToString()], 191, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></span>\r\n\r\n            <div class=\"info-box-content\">\r\n                <span class=\"info-box-text\"> ");
#nullable restore
#line 7 "C:\Users\sarah\Source\Repos\adminpanel\Admin\Views\Home\_Partial2.cshtml"
                                        Write(ViewData["text_" + Model.ToString()]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <span class=\"info-box-number\">\r\n                    ");
#nullable restore
#line 9 "C:\Users\sarah\Source\Repos\adminpanel\Admin\Views\Home\_Partial2.cshtml"
               Write(ViewData["number_" + Model.ToString()]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<small>%</small>\r\n                </span>\r\n            </div>\r\n            <!-- /.info-box-content -->\r\n        </div>\r\n        <!-- /.info-box -->\r\n    </div>");
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