#pragma checksum "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\Transaction\ListPayment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d595a696c23833acfddffae8710c48115fbab4ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction_ListPayment), @"mvc.1.0.view", @"/Views/Transaction/ListPayment.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\_ViewImports.cshtml"
using WebProjekti;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\_ViewImports.cshtml"
using WebProjekti.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\_ViewImports.cshtml"
using WebProjekti.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\_ViewImports.cshtml"
using DataAccessLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\_ViewImports.cshtml"
using WebProjekti.Models.Administration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\_ViewImports.cshtml"
using EntityLayer.Persons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\_ViewImports.cshtml"
using EntityLayer.Accounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\_ViewImports.cshtml"
using EntityLayer.Transactions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\_ViewImports.cshtml"
using EntityLayer.Credits;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d595a696c23833acfddffae8710c48115fbab4ce", @"/Views/Transaction/ListPayment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a78a38a60cf7bcc507145fc380ab22337670ba9", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction_ListPayment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PayCredit>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\Transaction\ListPayment.cshtml"
  
    ViewBag.Title = "Payment Credit List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n");
#nullable restore
#line 7 "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\Transaction\ListPayment.cshtml"
     if (Model == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-sm-12 text-center\">\r\n                No Payments\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 14 "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\Transaction\ListPayment.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-sm-12"">
                <div class=""card shadow mb-4"">
                    <div class=""card-header py-3"">
                        <h6 class=""m-0 font-weight-bold text-center"">Payment List</h6>
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive text-nowrap"">
                            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                                <thead>
                                    <tr>
                                        <th>Full Name</th>
                                        <th>Name</th>
                                        <th>Card Number</th>
                                        <th>Account Number</th>
                                        <th>Credit Number</th>
                                        <th>Amount</th>
                                        <th>Date</th>
                    ");
            WriteLiteral("                    <th>Description</th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 39 "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\Transaction\ListPayment.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 42 "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\Transaction\ListPayment.cshtml"
                                           Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 43 "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\Transaction\ListPayment.cshtml"
                                           Write(item.Client.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 44 "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\Transaction\ListPayment.cshtml"
                                           Write(item.CardNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 45 "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\Transaction\ListPayment.cshtml"
                                           Write(item.AccountNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 46 "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\Transaction\ListPayment.cshtml"
                                           Write(item.CreditNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 47 "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\Transaction\ListPayment.cshtml"
                                           Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 48 "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\Transaction\ListPayment.cshtml"
                                           Write(item.ExecutionDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 49 "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\Transaction\ListPayment.cshtml"
                                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 51 "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\Transaction\ListPayment.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 59 "C:\Users\Admin\Desktop\WebProjekti\WebProjekti\Views\Transaction\ListPayment.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PayCredit>> Html { get; private set; }
    }
}
#pragma warning restore 1591