using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazingTest
{
    public static class FileUtil
    {
        public static Task SaveAs(string filename, byte[] data, IJSRuntime runtime)
            => runtime.InvokeAsync<object>(
                "saveAsFile",
                filename,
                Convert.ToBase64String(data));
    }
}
