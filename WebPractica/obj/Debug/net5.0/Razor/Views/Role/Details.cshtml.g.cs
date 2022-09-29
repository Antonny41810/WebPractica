#pragma checksum "C:\WebPracticaultima\WebPractica\WebPractica\Views\Role\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3704d9239cb4fa161c370ce802204d194c02108"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_Details), @"mvc.1.0.view", @"/Views/Role/Details.cshtml")]
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
#line 1 "C:\WebPracticaultima\WebPractica\WebPractica\Views\_ViewImports.cshtml"
using WebPractica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\WebPracticaultima\WebPractica\WebPractica\Views\_ViewImports.cshtml"
using WebPractica.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3704d9239cb4fa161c370ce802204d194c02108", @"/Views/Role/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e75e1ade7019490a284be19410a6c3fc2971c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveUserRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'¿Está seguro de eliminar el rol del usuario?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Role\Details.cshtml"
   ViewData["Title"] = "Detalle"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""wrapper text-dark"">
    <div class=""content-wrapper bg-white d-flex justify-content-center align-items-center"">
        <div class=""card card-primary shadow"" style=""width:35rem"">
            <h3 class=""text-center"" style=""font-weight: bold"">Usuario: <b>");
#nullable restore
#line 6 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Role\Details.cshtml"
                                                                     Write(ViewBag.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></h3>
            <hr />
            <div class=""container"">
                <div class=""row"">
                    <div class=""mx-auto"">
                        <div class=""col-lg-12"">
                            <div class=""row"">
                                <div class=""col-12"">
");
#nullable restore
#line 14 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Role\Details.cshtml"
                                     if (Model.Count == 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p>Este usuario no tiene roles</p> ");
#nullable restore
#line 16 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Role\Details.cshtml"
                                                                           }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <h1 class=""text-center"">Roles</h1>
                                        <table class=""table table-striped table-bordered"">
                                            <thead class=""bg-success text-white"">
                                                <tr>
                                                    <th>Rol</th>
                                                    <th>Acción</th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
#nullable restore
#line 28 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Role\Details.cshtml"
                                                 foreach (var r in Model)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr class=\"text-dark\">\r\n                                                        <td>");
#nullable restore
#line 31 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Role\Details.cshtml"
                                                       Write(r);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3704d9239cb4fa161c370ce802204d194c021087317", async() => {
                WriteLiteral("Eliminar Rol");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-role", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Role\Details.cshtml"
                                                                                                  WriteLiteral(r);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["role"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-role", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["role"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Role\Details.cshtml"
                                                                                                                          WriteLiteral(ViewBag.UserName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                        </td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 36 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Role\Details.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </tbody>\r\n                                        </table>\r\n");
#nullable restore
#line 39 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Role\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
