#pragma checksum "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be75ff42006952a464916da9a0775a5025f3fbae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registros_Index), @"mvc.1.0.view", @"/Views/Registros/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be75ff42006952a464916da9a0775a5025f3fbae", @"/Views/Registros/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e75e1ade7019490a284be19410a6c3fc2971c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Registros_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebPractica.Models.Registro>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark m-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-family: Bradley Hand, cursive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right: 3%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
  
    ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""wrapper "">

    <div class=""content-wrapper bg-white d-flex justify-content-center align-items-center"">
        <div class=""card shadow"" style=""width:90%"">
            <div class=""card-header text-dark""><center><h2>Usuarios Registrados</h2></center></div>
            <p>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be75ff42006952a464916da9a0775a5025f3fbae6312", async() => {
                WriteLiteral("Nuevo Registro");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            WriteLiteral("\r\n            </p>\r\n            <table class=\"table table-dark\" id=\"tblData\" style=\"font-family: Bradley Hand, cursive\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 17 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Imagen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 20 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Documento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 23 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 26 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>");
            WriteLiteral("                            <th>\r\n                                ");
#nullable restore
#line 31 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>");
            WriteLiteral("                            <th>\r\n                                ");
#nullable restore
#line 35 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Deporte));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 38 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Trabaja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 41 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Sueldo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 44 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 50 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                         foreach (var item in Model)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                             if (item.Estado != "I")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr class=\"text-dark\">\r\n                                <td>\r\n");
#nullable restore
#line 56 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                                                                                    if (item.Imagen != null)
                                    {
                                        var base64 = Convert.ToBase64String(item.Imagen);
                                        var imgScr = String.Format("data:image/jpg;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral("<img");
            BeginWriteAttribute("src", " src=\'", 2960, "\'", 2973, 1);
#nullable restore
#line 59 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
WriteAttributeValue("", 2966, imgScr, 2966, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width:50px; max-height:50px;\" class=\"img-circle elevation-2\" />\r\n");
#nullable restore
#line 60 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 63 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Documento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 66 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 69 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>");
            WriteLiteral(" ");
            WriteLiteral("\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 74 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>");
            WriteLiteral("                                    <td>\r\n                                        ");
#nullable restore
#line 78 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Deporte));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 81 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Trabaja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 84 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Sueldo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 87 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"d-flex\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be75ff42006952a464916da9a0775a5025f3fbae16587", async() => {
                WriteLiteral("<i class=\"fas fa-pencil-alt\">  </i>  Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                                                                                              WriteLiteral(item.IdRegistro);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be75ff42006952a464916da9a0775a5025f3fbae19039", async() => {
                WriteLiteral("<i class=\"fas fa-folder\">  </i>  Detalle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                                                                                              WriteLiteral(item.IdRegistro);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <a class=\"btn btn-danger btn-sm\" data-toggle=\"modal\" data-target=\"#delete-conformation\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5327, "\"", 5362, 3);
            WriteAttributeValue("", 5337, "recibir(", 5337, 8, true);
#nullable restore
#line 92 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
WriteAttributeValue("", 5345, item.IdRegistro, 5345, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5361, ")", 5361, 1, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-right: 3%;\"><i class=\"fas fa-trash\">  </i>  Eliminar</a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 95 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
                <div class=""modal fade"" id=""delete-conformation"" tabindex=""-1"" role=""dialog"" aria-labelledby=""confirmdelete"" aria-hidden=""true"" data-backdrop=""static"" data-keyboard=""false"">
                    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <h5 class=""modal-title"" id=""confirmdelete"">Eliminar</h5>
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                    <span aria-hidden=""true"">&times;</span>
                                </button>
                            </div>
                            <div class=""modal-body"">
                                <p>¿Está seguro de eliminar este registro?</p>
                            </div>
                            <div class=""modal-footer"">
");
            WriteLiteral("                                <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Cancelar</button> ");
#nullable restore
#line 112 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                                                                                                                        using (Html.BeginForm("Delete", "Registros"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input type=\"hidden\" id=\"codigo\" name=\"id\" />\r\n                                    <input type=\"submit\" value=\"Eliminar\" data-toggle=\"modal\" data-target=\"#delete-conformation\" class=\"btn btn-danger\" />\r\n");
#nullable restore
#line 116 "C:\WebPracticaultima\WebPractica\WebPractica\Views\Registros\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</div>
    <script language=""javascript"">
        function recibir(id) {
            var valor = id
            document.getElementById(""codigo"").value = valor;
        }
    </script>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n        <script src=\"/js/Tablas.js\"></script> ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebPractica.Models.Registro>> Html { get; private set; }
    }
}
#pragma warning restore 1591
