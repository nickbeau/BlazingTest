#pragma checksum "C:\s\BlazingTest\BlazingTest\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "651f89073542c98a6a0ab793a222b5f035de9638"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingTest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using BlazingTest;
    using BlazingTest.Shared;
    using System.IO;
    using System.IO.Compression;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            builder.OpenElement(1, "p");
            builder.AddContent(2, "Current count: ");
            builder.AddContent(3, currentCount);
            builder.CloseElement();
            builder.AddMarkupContent(4, "\r\n\r\n");
            builder.OpenElement(5, "button");
            builder.AddAttribute(6, "class", "btn btn-primary");
            builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, IncrementCount));
            builder.AddContent(8, "Click me");
            builder.CloseElement();
            builder.AddMarkupContent(9, "\r\n");
            builder.OpenElement(10, "button");
            builder.AddAttribute(11, "class", "btn btn-secondary");
            builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, GenerateZipFile));
            builder.AddContent(13, "Generate Zip File");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 11 "C:\s\BlazingTest\BlazingTest\Pages\Counter.razor"
            
    int currentCount = 0;

    void IncrementCount()
    {
        currentCount++;
    }

    void GenerateZipFile()
    {
        using (var memoryStream = new MemoryStream())
        {
            using (var archive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
            {
                var demofile = archive.CreateEntry("foo.txt");
                using (var entryStream = demofile.Open())
                {
                    using (var streamWriter = new StreamWriter(entryStream))
                    {
                        streamWriter.Write("Bar!");
                    }
                }
            }
            FileUtil.SaveAs("nick.zip", memoryStream.ToArray(), JSRuntime);

        }


    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
