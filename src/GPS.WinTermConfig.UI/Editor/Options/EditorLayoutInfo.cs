using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GPS.WinTermConfig.UI.Editor.Options
{
    public class EditorLayoutInfo
    {
        /**
            * The internal layout details of the editor.
            */
        /**
         * Full editor width.
         */
        public string Width { get; set; } = default;
        /**
         * Full editor height.
         */
        public string Height { get; set; } = default;
        /**
         * Left position for the glyph margin.
         */
        public double GlyphMarginLeft { get; set; } = default;
        /**
         * The width of the glyph margin.
         */
        public double GlyphMarginWidth { get; set; } = default;
        /**
         * Left position for the line doubles.
         */
        public double LinedoublesLeft { get; set; } = default;
        /**
         * The width of the line doubles.
         */
        public double LinedoublesWidth { get; set; } = default;
        /**
         * Left position for the line decorations.
         */
        public double DecorationsLeft { get; set; } = default;
        /**
         * The width of the line decorations.
         */
        public double DecorationsWidth { get; set; } = default;
        /**
         * Left position for the content (actual text)
         */
        public double ContentLeft { get; set; } = default;
        /**
         * The width of the content (actual text)
         */
        public double ContentWidth { get; set; } = default;
        /**
         * The position for the minimap
         */
        public double MinimapLeft { get; set; } = default;
        /**
         * The width of the minimap
         */
        public double MinimapWidth { get; set; } = default;
        /**
         * The double of columns (of typical characters) fitting on a viewport line.
         */
        public double ViewportColumn { get; set; } = default;
        /**
         * The width of the vertical scrollbar.
         */
        public double VerticalScrollbarWidth { get; set; } = default;
        /**
         * The height of the horizontal scrollbar.
         */
        public double HorizontalScrollbarHeight { get; set; } = default;
    }
}
