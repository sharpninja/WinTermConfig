#pragma checksum "C:\GitHub\WinTermConfig\src\GPS.WinTermConfig.UI\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71be7cd54353af46c83317a3eb54220bd5727b7f"
// <auto-generated/>
#pragma warning disable 1591
namespace GPS.WinTermConfig.UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\GitHub\WinTermConfig\src\GPS.WinTermConfig.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GitHub\WinTermConfig\src\GPS.WinTermConfig.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\GitHub\WinTermConfig\src\GPS.WinTermConfig.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\GitHub\WinTermConfig\src\GPS.WinTermConfig.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\GitHub\WinTermConfig\src\GPS.WinTermConfig.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\GitHub\WinTermConfig\src\GPS.WinTermConfig.UI\_Imports.razor"
using Microsoft.Extensions.DependencyInjection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\GitHub\WinTermConfig\src\GPS.WinTermConfig.UI\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\GitHub\WinTermConfig\src\GPS.WinTermConfig.UI\_Imports.razor"
using Microsoft.Extensions.Logging.Abstractions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\GitHub\WinTermConfig\src\GPS.WinTermConfig.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\GitHub\WinTermConfig\src\GPS.WinTermConfig.UI\_Imports.razor"
using GPS.WinTermConfig.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\GitHub\WinTermConfig\src\GPS.WinTermConfig.UI\_Imports.razor"
using GPS.WinTermConfig.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\GitHub\WinTermConfig\src\GPS.WinTermConfig.UI\_Imports.razor"
using Blazaco;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\GitHub\WinTermConfig\src\GPS.WinTermConfig.UI\_Imports.razor"
using Blazaco.Editor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\GitHub\WinTermConfig\src\GPS.WinTermConfig.UI\_Imports.razor"
using Blazaco.Editor.Options;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron-fluid");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h2>Windows Terminal Configuration</h2>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\GitHub\WinTermConfig\src\GPS.WinTermConfig.UI\Pages\Index.razor"
                     ViewModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenElement(8, "fieldset");
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.AddMarkupContent(10, "<label for=\"fileName\" 5>Filename</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "class", "form-control form-control-sm small");
                __builder2.AddAttribute(13, "id", "fileName");
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\GitHub\WinTermConfig\src\GPS.WinTermConfig.UI\Pages\Index.razor"
                                                                                             ViewModel.Filename

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ViewModel.Filename = __value, ViewModel.Filename))));
                __builder2.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ViewModel.Filename));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n\r\n            ");
                __builder2.OpenComponent<Blazaco.Editor.MonacoEditor>(18);
                __builder2.AddAttribute(19, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazaco.Editor.EditorModel>(
#nullable restore
#line 10 "C:\GitHub\WinTermConfig\src\GPS.WinTermConfig.UI\Pages\Index.razor"
                                                _editorModel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 10 "C:\GitHub\WinTermConfig\src\GPS.WinTermConfig.UI\Pages\Index.razor"
                                                                     500

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 10 "C:\GitHub\WinTermConfig\src\GPS.WinTermConfig.UI\Pages\Index.razor"
                                                                                  500

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddComponentReferenceCapture(22, (__value) => {
#nullable restore
#line 10 "C:\GitHub\WinTermConfig\src\GPS.WinTermConfig.UI\Pages\Index.razor"
                                Editor = (Blazaco.Editor.MonacoEditor)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
