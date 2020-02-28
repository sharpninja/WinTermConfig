using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GPS.WinTermConfig.UI.Editor;
using GPS.WinTermConfig.UI.Editor.Options;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;

namespace GPS.WinTermConfig.UI.Shared
{
    public partial class MonacoEditor
    {
        [Parameter]
        public MonacoEditor Ref
        {
            get => this._ref;
            set => _ref = value;
        }

        [Inject]
        public ILogger<MonacoEditor> Logger { get; set; }

        [Inject]
        IJSRuntime runtime { get; set; }

        [Parameter]
        public EditorModel Model { get; set; }

        [Parameter]
        public string @class { get; set; }

        [Parameter]
        public string Height
        {
            get => Model.LayoutInfo.Height;
            set
            {
                Model.LayoutInfo.Height = double.TryParse(value, out var height) ? $"{height}px" : value;
            }
        }

        [Parameter]
        public string Width
        {
            get => Model.LayoutInfo.Width;
            set
            {
                Model.LayoutInfo.Width = double.TryParse(value, out var width) ? $"{width}px" : value;
            }
        }

        private bool _alreadyRendered = false;
        private MonacoEditor _ref;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (!_alreadyRendered)
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(Width) && !string.IsNullOrWhiteSpace(Height))
                    {
                        Model.LayoutInfo = new EditorLayoutInfo
                        {
                            Width = Width,
                            Height = Height
                        };
                    }


                    _alreadyRendered = await BlazacoJSInterop.InitializeEditor(runtime, Model);
                }
                catch (Exception ex)
                {
                    Logger.LogError("Error initializing MonacoEditor JavaScript.", ex);
                }
            }
        }

        public async Task<string> GetValue()
        {
            return await BlazacoJSInterop.GetValue(runtime, Model.Id);
        }

        public async Task<bool> SetValue(string newValue)
        {
            return await BlazacoJSInterop.SetValue(runtime, Model.Id, newValue);
        }

        public async Task<bool> SetTheme(string newTheme)
        {
            return await BlazacoJSInterop.SetTheme(runtime, Model.Id, newTheme);
        }

        public async Task<bool> Layout()
        {
            try
            {
                return await BlazacoJSInterop.Layout(runtime, Model.Id);
            }
            catch (Exception ex)
            {
                Logger.LogError("Error in JavaScript calling Layout.", ex);
                return false;
            }
        }

    }

}
