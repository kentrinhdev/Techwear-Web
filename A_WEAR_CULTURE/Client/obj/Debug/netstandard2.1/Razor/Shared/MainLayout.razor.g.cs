#pragma checksum "/Users/kentrinh/Projects/A_WEAR_CULTURE/A_WEAR_CULTURE/Client/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94316bf0e43dea136f85ce07cdcbbd30d0774b7c"
// <auto-generated/>
#pragma warning disable 1591
namespace A_WEAR_CULTURE.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/kentrinh/Projects/A_WEAR_CULTURE/A_WEAR_CULTURE/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kentrinh/Projects/A_WEAR_CULTURE/A_WEAR_CULTURE/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/kentrinh/Projects/A_WEAR_CULTURE/A_WEAR_CULTURE/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/kentrinh/Projects/A_WEAR_CULTURE/A_WEAR_CULTURE/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/kentrinh/Projects/A_WEAR_CULTURE/A_WEAR_CULTURE/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/kentrinh/Projects/A_WEAR_CULTURE/A_WEAR_CULTURE/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/kentrinh/Projects/A_WEAR_CULTURE/A_WEAR_CULTURE/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/kentrinh/Projects/A_WEAR_CULTURE/A_WEAR_CULTURE/Client/_Imports.razor"
using A_WEAR_CULTURE.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/kentrinh/Projects/A_WEAR_CULTURE/A_WEAR_CULTURE/Client/_Imports.razor"
using A_WEAR_CULTURE.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/kentrinh/Projects/A_WEAR_CULTURE/A_WEAR_CULTURE/Client/_Imports.razor"
using A_WEAR_CULTURE.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenComponent<A_WEAR_CULTURE.Client.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\n    ");
            __builder.AddMarkupContent(9, @"<div class=""top-row px-4"">
        <h3 class=""row-nav-text"">
            CULTURE A WEAR <span class=""row-nav-text-spacer"">|l|&nbsp;</span>
        </h3>
        <p class=""row-nav-text row-nav-sub-text"">
            <span class=""row-nav-sub-text-pop"">POP</span>

            <span class=""text-color-change"">wear it</span>

            <span class=""row-nav-sub-text-pop"">CULTURE</span>

            <span class=""text-color-change"">get it</span>

            <span class=""row-nav-sub-text-pop"">AWARE</span>
        </p>
    </div>

    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "content px-4");
            __builder.AddMarkupContent(12, "\n        ");
            __builder.AddContent(13, 
#nullable restore
#line 26 "/Users/kentrinh/Projects/A_WEAR_CULTURE/A_WEAR_CULTURE/Client/Shared/MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
