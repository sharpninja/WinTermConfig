using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using GPS.WinTermConfig.UI.Common;
using GPS.WinTermConfig.UI.Editor;
using GPS.WinTermConfig.UI.Editor.Options;
using GPS.WinTermConfig.UI.Shared;
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

        protected override async void OnAfterRender(bool firstRender) { 
            base.OnAfterRender(firstRender);
            await Editor.Layout();
        }

        protected override void OnInitialized()
        {
            var settingsJson = File.ReadAllText(ViewModel.Filename);

            _editorModel = new EditorModel(
                new EditorOptions()
                {
                    Value = settingsJson,
                    Language = "json",
                    Theme = "vs-dark",
                    Minimap = new MinimapOptions()
                    {
                        Enabled = false
                    }
                },
                new EditorLayoutInfo()
                {
                    Width = "Auto",
                    Height = "Auto",
                });

            base.OnInitialized();
        }
    }
}
