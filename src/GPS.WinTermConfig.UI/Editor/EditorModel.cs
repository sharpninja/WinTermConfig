using System;
using GPS.WinTermConfig.UI.Editor.Options;

namespace GPS.WinTermConfig.UI.Editor
{
    public class EditorModel
    {
        public EditorModel(EditorOptions editorOptions, EditorLayoutInfo editorLayoutInfo) 
        {
            Options = editorOptions;
            LayoutInfo = editorLayoutInfo;
        }

        public string Id { get; set; } = $"Blazaco_{new Random().Next(0, 1000000).ToString()}";
        public EditorOptions Options { get; set; } = new EditorOptions();
        public EditorLayoutInfo LayoutInfo { get; set; } = new EditorLayoutInfo();
    }
}
