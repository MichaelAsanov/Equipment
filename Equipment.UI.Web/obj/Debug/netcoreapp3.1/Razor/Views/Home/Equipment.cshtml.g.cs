#pragma checksum "C:\Users\Михаил\source\repos\Equipment\Equipment.UI.Web\Views\Home\Equipment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "581536fad4a4984172b2f7e83a3c83639f730ba8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Equipment), @"mvc.1.0.view", @"/Views/Home/Equipment.cshtml")]
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
#line 1 "C:\Users\Михаил\source\repos\Equipment\Equipment.UI.Web\Views\_ViewImports.cshtml"
using Equipment.UI.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Михаил\source\repos\Equipment\Equipment.UI.Web\Views\_ViewImports.cshtml"
using Equipment.UI.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"581536fad4a4984172b2f7e83a3c83639f730ba8", @"/Views/Home/Equipment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0573746d3d5d1d973471604a87f61e8b8101f16c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Equipment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form-custom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Михаил\source\repos\Equipment\Equipment.UI.Web\Views\Home\Equipment.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "581536fad4a4984172b2f7e83a3c83639f730ba85313", async() => {
                WriteLiteral(@"

    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">

    <title>INSPINIA | Dashboard v.4</title>

    <link href=""css/wrapbootstrap/bootstrap.min.css"" rel=""stylesheet"">
    <link href=""css/wrapbootstrap/font-awesome/css/font-awesome.css"" rel=""stylesheet"">

    <!-- Morris -->
    <link href=""css/wrapbootstrap/plugins/morris/morris-0.4.3.min.css"" rel=""stylesheet"">

    <link href=""css/wrapbootstrap/animate.css"" rel=""stylesheet"">
    <link href=""css/wrapbootstrap/style.css"" rel=""stylesheet"">
    
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "581536fad4a4984172b2f7e83a3c83639f730ba86166", async() => {
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
                WriteLiteral(@"
    
    <script src=""js/LINQ_JS_MIN.js"" ></script>
    
    <script src=""js/angularjs/angular.min.js"" ></script>
    
    <script src=""js/equipmentApp/equipmentApp.js"" ></script>
    <script src=""js/equipmentApp/filters/filterByRoleAndType.js"" ></script>
    <script src=""js/equipmentApp/equipmentService.js"" ></script>
    <script src=""js/equipmentApp/equipmentController.js"" ></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "581536fad4a4984172b2f7e83a3c83639f730ba88461", async() => {
                WriteLiteral(@"
<div id=""wrapper"" ng-app=""equipmentApp"" ng-controller=""equipmentController"">
    <nav class=""navbar-default navbar-static-side"" role=""navigation"">
        <div class=""sidebar-collapse"">
            <ul class=""nav metismenu"" id=""side-menu"">
                <li class=""active"">
                    <a href=""#""><i class=""fa fa-th-large""></i> <span class=""nav-label"">Роль</span> <span class=""fa arrow""></span></a>
                    <ul class=""nav nav-second-level collapse"">
                        <li ng-repeat=""role in Roles"" ng-click=""AddOrRemoveItem(role, SelectedRoles)"" ng-class=""{'selected-aside-item': SelectedRoles.contains(role)}"">
                            <a href=""#"">{{role}}</a>
                        </li>
                    </ul>
                </li>
                <li class=""active"">
                    <a href=""#""><i class=""fa fa-diamond""></i> <span class=""nav-label"">Тип</span></a>
                    <ul class=""nav nav-second-level collapse"">
                        <li ng-repe");
                WriteLiteral(@"at=""type in Types"" ng-click=""AddOrRemoveItem(type, SelectedTypes)"" ng-class=""{'selected-aside-item': SelectedTypes.contains(type)}"">
                            <a href=""#"">{{type}}</a>
                        </li>
                    </ul>
                </li>
            </ul>

        </div>
    </nav>

    <div id=""page-wrapper"" class=""gray-bg"">
        <div class=""row border-bottom"">
            <nav class=""navbar navbar-static-top white-bg"" role=""navigation"" style=""margin-bottom: 0"">
                <div class=""navbar-header"">
                    <a class=""navbar-minimalize minimalize-styl-2 btn btn-primary "" href=""#""><i class=""fa fa-bars""></i> </a>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "581536fad4a4984172b2f7e83a3c83639f730ba810551", async() => {
                    WriteLiteral(@"
                        <div class=""form-group"">
                            <input type=""text"" placeholder=""Search for something..."" class=""form-control"" name=""top-search"" id=""top-search"" ng-model=""text"">
                        </div>
                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
                <ul class=""nav navbar-top-links navbar-right"">
                    <li>
                        <span class=""m-r-sm text-muted welcome-message"">Найдено: {{(Equipment | filter:{title:text} | filterByRoleAndType:SelectedRoles:SelectedTypes).length}}</span>
                    </li>
                     <li>
                        <span class=""m-r-sm text-muted welcome-message"">Всего устройств: {{Equipment.length}}</span>
                    </li>
                </ul>
            </nav>
        </div>


        <div class=""wrapper wrapper-content"">
           
            <div class=""row"">
                <div class=""col-lg-4"" ng-repeat=""equip in Equipment | filter:{title:text} | filterByRoleAndType:SelectedRoles:SelectedTypes"">
                    <div class=""ibox float-e-margins"">
                        <span class=""badge badge-danger"" ng-if=""equip.i_owner"">Я владелец</span>
                        <span class=""badge badge-primary"" ng-if=""equip.i_u");
                WriteLiteral(@"ser"">Я пользователь</span>
                        <div class=""ibox-title"">
                            <h5>{{equip.title}}</h5>
                        </div>
                        <div class=""ibox-content"">
                            <div class=""row"">
                                <div class=""col-xs-3"">
                                    <small class=""stats-label"">Серийный номер</small>
                                    <h4>{{equip.serial}}</h4>
                                </div>

                                <div class=""col-xs-3"">
                                    <small class=""stats-label"">Код ЕНС</small>
                                    <h4>{{equip.code_ehd}}</h4>
                                </div>
                                <div class=""col-xs-3"">
                                    <small class=""stats-label"">Код CA</small>
                                    <h4>{{equip.code_ca}}</h4>
                                </div>
                                <");
                WriteLiteral(@"div class=""col-xs-3"">
                                    <small class=""stats-label"">Инвентарный номер</small>
                                    <h4>{{equip.inventory_num}}</h4>
                                </div>
                            </div>
                        </div>
                        <div class=""ibox-content"">
                            <div class=""row"">
                                <div class=""col-xs-4"">
                                    <small class=""stats-label"">Последняя активность</small>
                                    <h4>{{equip.last_activity}}</h4>
                                </div>

                                <div class=""col-xs-4"" ng-if=""equip.owner"">
                                    <small class=""stats-label"">Владелец</small>
                                    <h4 class=""person"">{{equip.owner}}</h4>
                                </div>
                                <div class=""col-xs-4"" ng-if=""equip.employee_has_device"">
         ");
                WriteLiteral(@"                           <small class=""stats-label"">Устройство у сотрудника</small>
                                    <h4 class=""person"">{{equip.employee_has_device}}</h4>
                                </div>
                            </div>
                        </div>
                        
                    </div>
                </div>
            </div>
        </div>    
    </div>
</div>

<!-- Mainly scripts -->
<script src=""js/wrapbootstrap/jquery-2.1.1.js""></script>
<script src=""js/wrapbootstrap/bootstrap.min.js""></script>
<script src=""js/wrapbootstrap/plugins/metisMenu/jquery.metisMenu.js""></script>
<script src=""js/wrapbootstrap/plugins/slimscroll/jquery.slimscroll.min.js""></script>

<!-- Flot -->
<script src=""js/wrapbootstrap/plugins/flot/jquery.flot.js""></script>
<script src=""js/wrapbootstrap/plugins/flot/jquery.flot.tooltip.min.js""></script>
<script src=""js/wrapbootstrap/plugins/flot/jquery.flot.spline.js""></script>
<script src=""js/wrapbootstrap/plugins/flot/j");
                WriteLiteral(@"query.flot.resize.js""></script>
<script src=""js/wrapbootstrap/plugins/flot/jquery.flot.pie.js""></script>
<script src=""js/wrapbootstrap/plugins/flot/jquery.flot.symbol.js""></script>
<script src=""js/wrapbootstrap/plugins/flot/curvedLines.js""></script>

<!-- Peity -->
<script src=""js/wrapbootstrap/plugins/peity/jquery.peity.min.js""></script>
<script src=""js/wrapbootstrap/demo/peity-demo.js""></script>

<!-- Custom and plugin javascript -->
<script src=""js/wrapbootstrap/inspinia.js""></script>
<script src=""js/wrapbootstrap/plugins/pace/pace.min.js""></script>

<!-- jQuery UI -->
<script src=""js/wrapbootstrap/plugins/jquery-ui/jquery-ui.min.js""></script>

<!-- Jvectormap -->
<script src=""js/wrapbootstrap/plugins/jvectormap/jquery-jvectormap-2.0.2.min.js""></script>
<script src=""js/wrapbootstrap/plugins/jvectormap/jquery-jvectormap-world-mill-en.js""></script>

<!-- Sparkline -->
<script src=""js/wrapbootstrap/plugins/sparkline/jquery.sparkline.min.js""></script>

<!-- Sparkline demo data  -->
<scr");
                WriteLiteral("ipt src=\"js/wrapbootstrap/demo/sparkline-demo.js\"></script>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
