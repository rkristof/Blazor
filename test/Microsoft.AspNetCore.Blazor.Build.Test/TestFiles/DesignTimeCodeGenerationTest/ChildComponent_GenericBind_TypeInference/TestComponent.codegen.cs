// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    public class TestComponent : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        ((System.Action)(() => {
global::System.Object __typeHelper = "*, TestAssembly";
        }
        ))();
        }
        #pragma warning restore 219
        #pragma warning disable 0414
        private static System.Object __o = null;
        #pragma warning restore 0414
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            __Blazor.Test.TestComponent.TypeInference.CreateMyComponent_0(builder, -1, -1, Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                       Value

#line default
#line hidden
            ), -1, 
            __value => Value = __value);
        }
        #pragma warning restore 1998
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
            
    string Value;

#line default
#line hidden
    }
}
namespace __Blazor.Test.TestComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMyComponent_0<TItem>(global::Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder, int seq, int __seq0, TItem __arg0, int __seq1, global::System.Action<TItem> __arg1)
        {
        builder.OpenComponent<global::Test.MyComponent<TItem>>(seq);
        builder.AddAttribute(__seq0, "Item", __arg0);
        builder.AddAttribute(__seq1, "ItemChanged", __arg1);
        builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
