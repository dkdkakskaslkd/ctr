#pragma checksum "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44d3082bc213d09c95bd9de4dc7bf04041d46615"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ConstructWedDb.Pages.FilReq.Filter.Pages_FilReq_Filter_FilterPay), @"mvc.1.0.razor-page", @"/Pages/FilReq/Filter/FilterPay.cshtml")]
namespace ConstructWedDb.Pages.FilReq.Filter
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44d3082bc213d09c95bd9de4dc7bf04041d46615", @"/Pages/FilReq/Filter/FilterPay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb94684257b908fabed029982a8d6ce66f8ea04c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FilReq_Filter_FilterPay : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 9 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
           Write(Html.DisplayNameFor(model => model.Order[0].ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 12 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
           Write(Html.DisplayNameFor(model => model.Order[0].Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
           Write(Html.DisplayNameFor(model => model.Order[0].StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
           Write(Html.DisplayNameFor(model => model.Order[0].EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
           Write(Html.DisplayNameFor(model => model.Order[0].CompletionMark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
           Write(Html.DisplayNameFor(model => model.Order[0].AboutPayment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
           Write(Html.DisplayNameFor(model => model.Order[0].CustomerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
           Write(Html.DisplayNameFor(model => model.Order[0].TypeOfJobID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
           Write(Html.DisplayNameFor(model => model.Order[0].BrigadeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
           Write(Html.DisplayNameFor(model => model.Order[0].StaffID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 41 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
         foreach (var item in Model.Order)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
               Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
               Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
               Write(Html.DisplayFor(modelItem => item.CompletionMark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
               Write(Html.DisplayFor(modelItem => item.AboutPayment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 63 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
                      
                        try
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
                       Write(Model.Customer.First(M => M.ID == item.CustomerID).FullName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
                                                                                        
                        }
                        catch
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>нет</p>\r\n");
#nullable restore
#line 71 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 76 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
                      
                        try
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
                       Write(Model.TypeOfJob.First(M => M.ID == item.TypeOfJobID).Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
                                                                                      
                        }
                        catch
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>нет</p>\r\n");
#nullable restore
#line 84 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 89 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
                      
                        try
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
                       Write(Model.Brigade.First(M => M.ID == item.BrigadeID).Staff1ID);

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
                       Write(Model.Brigade.First(M => M.ID == item.BrigadeID).Staff2ID);

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
                       Write(Model.Brigade.First(M => M.ID == item.BrigadeID).Staff3ID);

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
                                                                                      
                        }
                        catch
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>нет</p>\r\n");
#nullable restore
#line 99 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 103 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
                      
                        try
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
                       Write(Model.Staff.First(M => M.ID == item.StaffID).FullName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
                                                                                  
                        }
                        catch
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>нет</p>\r\n");
#nullable restore
#line 111 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 117 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FilterPay.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConstructWedDb.Pages.FilReq.Filter.FilterPayModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConstructWedDb.Pages.FilReq.Filter.FilterPayModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConstructWedDb.Pages.FilReq.Filter.FilterPayModel>)PageContext?.ViewData;
        public ConstructWedDb.Pages.FilReq.Filter.FilterPayModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
