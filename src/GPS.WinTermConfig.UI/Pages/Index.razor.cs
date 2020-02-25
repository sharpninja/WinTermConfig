using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Blazaco.Editor;
using Blazaco.Editor.Options;
using GPS.WinTermConfig.UI.Common;
using Microsoft.AspNetCore.Components;

namespace GPS.WinTermConfig.UI.Pages
{
    public partial class Index
    {
        private EditorModel _editorModel { get; set; }
        private MonacoEditor _editor;

        [Inject]
        public MainViewModel ViewModel { get; set; }
        public MonacoEditor Editor
        {
            get => _editor;
            set
            {
                if (value == _editor)
                    return;

                _editor = value;
            }
        }

        protected override void OnInitialized()
        {
            var settingsJson = File.ReadAllText(ViewModel.Filename);

            _editorModel = new EditorModel(new EditorOptions()
            {
                Value = settingsJson,
                Language = "json",
                Theme = "vs-dark",
                Minimap = new MinimapOptions()
                {
                    Enabled = false
                }
            }, new EditorLayoutInfo()
            {
                Width = 500,
                Height = 500,
            });

            base.OnInitialized();
        }
    }
}
