using Microsoft.JSInterop;
using System.Threading.Tasks;
using GPS.WinTermConfig.UI.Editor.Options;
using System;

namespace GPS.WinTermConfig.UI.Editor
{
    public static class BlazacoJSInterop
    {
        public static ValueTask<bool> InitializeEditor(IJSRuntime runtime, EditorModel editorModel)
            => runtime.InvokeAsync<bool>("Blazaco.Editor.InitializeEditor", new[] { editorModel });

        public static ValueTask<bool> UpdateOptions(IJSRuntime runtime, string id, EditorOptions editorOptions)
            => runtime.InvokeAsync<bool>("Blazaco.Editor.UpdateOptions", new object[] { id, editorOptions });

        public static ValueTask<string> GetValue(IJSRuntime runtime, string id)
            => runtime.InvokeAsync<string>("Blazaco.Editor.GetValue", new[] { id });

        public static ValueTask<bool> SetValue(IJSRuntime runtime, string id, string value)
            => runtime.InvokeAsync<bool>("Blazaco.Editor.SetValue", new[] { id, value });

        public static ValueTask<bool> SetTheme(IJSRuntime runtime, string id, string theme)
            => runtime.InvokeAsync<bool>("Blazaco.Editor.SetTheme", new[] { id, theme });
        public static ValueTask<bool> Layout(IJSRuntime runtime, string id, EditorLayoutInfo layoutInfo = null)
            => runtime.InvokeAsync<bool>("Blazaco.Editor.Layout", new object[] { id, layoutInfo });
    }
}
