#pragma checksum "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Request\PerDep.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "032305627ebec733e604b616ee374d373799d94f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ConstructWedDb.Pages.FilReq.Request.Pages_FilReq_Request_PerDep), @"mvc.1.0.razor-page", @"/Pages/FilReq/Request/PerDep.cshtml")]
namespace ConstructWedDb.Pages.FilReq.Request
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
#line 1 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\_ViewImports.cshtml"
using ConstructWedDb;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"032305627ebec733e604b616ee374d373799d94f", @"/Pages/FilReq/Request/PerDep.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb94684257b908fabed029982a8d6ce66f8ea04c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FilReq_Request_PerDep : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Сотрудник\r\n            </th>\r\n            <th>\r\n                Должность\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Request\PerDep.cshtml"
         foreach (var item in Model.Staff)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 21 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Request\PerDep.cshtml"
               Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 24 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Request\PerDep.cshtml"
                      
                        try
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Request\PerDep.cshtml"
                       Write(Model.Position.First(M => M.ID == item.PositionID).Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Request\PerDep.cshtml"
                                                                                    
                        }
                        catch
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>нет</p>\r\n");
#nullable restore
#line 32 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Request\PerDep.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Request\PerDep.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConstructWedDb.Pages.FilReq.filter.PerDepModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConstructWedDb.Pages.FilReq.filter.PerDepModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConstructWedDb.Pages.FilReq.filter.PerDepModel>)PageContext?.ViewData;
        public ConstructWedDb.Pages.FilReq.filter.PerDepModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
