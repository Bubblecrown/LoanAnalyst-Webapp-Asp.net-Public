#pragma checksum "D:\Works\CMM357 Web Dev\Project Midterm\LoanWebApp\Loan Webapp\Views\Loan\Report.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea914764c8681145748ad25ff3fdef7d1eebc6de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Loan_Report), @"mvc.1.0.view", @"/Views/Loan/Report.cshtml")]
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
#line 1 "D:\Works\CMM357 Web Dev\Project Midterm\LoanWebApp\Loan Webapp\Views\_ViewImports.cshtml"
using Loan_Webapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Works\CMM357 Web Dev\Project Midterm\LoanWebApp\Loan Webapp\Views\_ViewImports.cshtml"
using Loan_Webapp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea914764c8681145748ad25ff3fdef7d1eebc6de", @"/Views/Loan/Report.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f6a25b6dab2cabe0b315ea4e2b407b5b3d56595", @"/Views/_ViewImports.cshtml")]
    public class Views_Loan_Report : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Loan_Webapp.Models.Loan>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/report.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Complete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\Works\CMM357 Web Dev\Project Midterm\LoanWebApp\Loan Webapp\Views\Loan\Report.cshtml"
  
    ViewData["Title"] = "Report";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!--jumbotronใช้ในการทำให้หน้าจอเป็นreponsive-->\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ea914764c8681145748ad25ff3fdef7d1eebc6de4701", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea914764c8681145748ad25ff3fdef7d1eebc6de5817", async() => {
                WriteLiteral(@"
    <section class=""nav-block""></section>
    <div class=""jumbotron-fluid text-center content"">
        <div class=""row"" style=""margin-bottom:70px;"">
            <div class=""col-sm-1 ""></div>
            <div class=""col-sm-10 container-style"">

                <div class=""row head-block"">
                    <div class=""col-sm-1  ""> </div>
                    <div class=""col-sm-1 side-block ""> </div>
                    <div class=""col-sm-8 result-head"">
                        <p> ผลรายงานการซื้อ</p>
                    </div>
                    <div class=""col-sm-1 side-block ""> </div>
                    <div class=""col-sm-1  ""> </div>
                </div>

                <!--ข้อมูลส่วนตัว-->

                <div class=""row "">
                    <div class=""col-sm-1  ""> </div>
                    <div class=""col-sm-1 side-block ""> </div>
                    <div class=""col-sm-8 detail-head"">
                        <p> ข้อมูลส่วนตัว</p>
                    </div>
                    <div class=""col-");
                WriteLiteral(@"sm-1 side-block ""> </div>
                    <div class=""col-sm-1  ""> </div>
                </div>


                <div class=""row "">
                    <div class=""col-sm-1  ""> </div>
                    <div class=""col-sm-1 side-block ""> </div>
                    <div class=""col-sm-2 detail-subhead "">
                        <p> ชื่อ:</p>
                    </div>
                    <div class=""col-sm-6 detail-text"">
                        <p>");
#nullable restore
#line 48 "D:\Works\CMM357 Web Dev\Project Midterm\LoanWebApp\Loan Webapp\Views\Loan\Report.cshtml"
                      Write(Html.DisplayFor(nm => nm.NameUser));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </p>
                    </div>
                    <div class=""col-sm-1 side-block ""> </div>
                    <div class=""col-sm-1  ""> </div>

                </div>

                <div class=""row "">
                    <div class=""col-sm-1  ""> </div>
                    <div class=""col-sm-1 side-block ""> </div>
                    <div class=""col-sm-2 detail-subhead "">
                        <p> เบอร์โทร:</p>
                    </div>
                    <div class=""col-sm-6 detail-text"">
                        <p>");
#nullable restore
#line 62 "D:\Works\CMM357 Web Dev\Project Midterm\LoanWebApp\Loan Webapp\Views\Loan\Report.cshtml"
                      Write(Html.DisplayFor(ph => ph.NumberUser));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </p>
                    </div>
                    <div class=""col-sm-1 side-block ""> </div>
                    <div class=""col-sm-1  ""> </div>

                </div>


                <div class=""row "">
                    <div class=""col-sm-1  ""> </div>
                    <div class=""col-sm-1 side-block ""> </div>
                    <div class=""col-sm-2 detail-subhead "">
                        <p> ที่อยู่:</p>
                    </div>
                    <div class=""col-sm-6 detail-text"">
                        <p>");
#nullable restore
#line 77 "D:\Works\CMM357 Web Dev\Project Midterm\LoanWebApp\Loan Webapp\Views\Loan\Report.cshtml"
                      Write(Html.DisplayFor(ad => ad.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                    </div>
                    <div class=""col-sm-1 side-block ""> </div>
                    <div class=""col-sm-1  ""> </div>

                </div>


                <div class=""row "">
                    <div class=""col-sm-1  ""> </div>
                    <div class=""col-sm-1 side-block ""> </div>
                    <div class=""col-sm-8 line""></div>
                    <div class=""col-sm-1 side-block ""> </div>
                    <div class=""col-sm-1  ""> </div>
                </div>

                <!--ข้อมูลซื้อบ้าน-->
                <div class=""row "">
                    <div class=""col-sm-1  ""> </div>
                    <div class=""col-sm-1 side-block ""> </div>
                    <div class=""col-sm-8 detail-head"">
                        <p> ข้อมูลซื้อบ้าน</p>
                    </div>
                    <div class=""col-sm-1 side-block ""> </div>
                    <div class=""col-sm-1  ""> </div>
                </div>

                <div class=""row "">
                    <d");
                WriteLiteral(@"iv class=""col-sm-1  ""> </div>
                    <div class=""col-sm-1 side-block "">  </div>
                    <div class=""col-sm-2 detail-subhead "">
                        <p>ประเภทบ้านของคุณ :</p>
                    </div>
                    <div class=""col-sm-2 detail-text"">
                        <p>");
#nullable restore
#line 111 "D:\Works\CMM357 Web Dev\Project Midterm\LoanWebApp\Loan Webapp\Views\Loan\Report.cshtml"
                      Write(Html.DisplayFor(th => th.TypeHomeCustomer));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                    </div>\n                    <div class=\"col-sm-2 detail-subhead \">\n                        <p>ราคาบ้านของคุณ : </p>\n                    </div>\n                    <div class=\"col-sm-2 detail-text \">\n                        <p>");
#nullable restore
#line 117 "D:\Works\CMM357 Web Dev\Project Midterm\LoanWebApp\Loan Webapp\Views\Loan\Report.cshtml"
                      Write(Html.DisplayFor(lnc => lnc.LoanCustomer));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" บาท</p>
                    </div>
                    <div class=""col-sm-1 side-block ""> </div>
                    <div class=""col-sm-1  ""> </div>

                </div>


                <div class=""row "">
                    <div class=""col-sm-1  ""> </div>
                    <div class=""col-sm-1 side-block "">  </div>
                    <div class=""col-sm-2 detail-subhead "">
                        <p>ผ่อนจ่ายจำนวน :</p>
                    </div>
                    <div class=""col-sm-2 detail-text"">
                        <p>");
#nullable restore
#line 132 "D:\Works\CMM357 Web Dev\Project Midterm\LoanWebApp\Loan Webapp\Views\Loan\Report.cshtml"
                      Write(Html.DisplayFor(mon => mon.Numofmonths));

#line default
#line hidden
#nullable disable
                WriteLiteral(" งวด</p>\n                    </div>\n                    <div class=\"col-sm-2 detail-subhead \">\n                        <p>เป็นเวลา :</p>\n                    </div>\n                    <div class=\"col-sm-2 detail-text \">\n                        <p>");
#nullable restore
#line 138 "D:\Works\CMM357 Web Dev\Project Midterm\LoanWebApp\Loan Webapp\Views\Loan\Report.cshtml"
                      Write(Html.DisplayFor(yrs => yrs.Numofyear));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" ปี</p>
                    </div>
                    <div class=""col-sm-1 side-block ""> </div>
                    <div class=""col-sm-1  ""> </div>

                </div>

                <div class=""row "">
                    <div class=""col-sm-1  ""> </div>
                    <div class=""col-sm-1 side-block "">  </div>
                    <div class=""col-sm-2 detail-subhead "">
                        <p>ธนาคารที่กู้ :</p>
                    </div>
                    <div class=""col-sm-2 detail-text"">
                        <p>");
#nullable restore
#line 152 "D:\Works\CMM357 Web Dev\Project Midterm\LoanWebApp\Loan Webapp\Views\Loan\Report.cshtml"
                      Write(Html.DisplayFor(bk => bk.BankCustomer));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                    </div>
                    <div class=""col-sm-2 detail-subhead ""> </div>
                    <div class=""col-sm-2 detail-text ""></div>
                    <div class=""col-sm-1 side-block ""> </div>
                    <div class=""col-sm-1  ""> </div>

                </div>

                <div class=""row "">
                    <div class=""col-sm-1  ""> </div>
                    <div class=""col-sm-1 side-block ""> </div>
                    <div class=""col-sm-8 line""></div>
                    <div class=""col-sm-1 side-block ""> </div>
                    <div class=""col-sm-1  ""> </div>
                </div>

                <div class=""row "">
                    <div class=""col-sm-1  ""> </div>
                    <div class=""col-sm-6 side-block ""> </div>
                    <div class=""col-sm-3 button-block"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea914764c8681145748ad25ff3fdef7d1eebc6de14854", async() => {
                    WriteLiteral("ยืนยัน ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                    </div>
                    <div class=""col-sm-1 side-block ""> </div>
                    <div class=""col-sm-1  ""> </div>
                </div>






            </div>
            <div class=""col-sm-1 ""></div>



        </div>
    </div>






");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Loan_Webapp.Models.Loan> Html { get; private set; }
    }
}
#pragma warning restore 1591
