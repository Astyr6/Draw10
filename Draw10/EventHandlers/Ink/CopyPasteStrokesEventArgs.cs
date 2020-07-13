using System.Collections.Generic;

using Windows.UI.Input.Inking;

namespace Draw10.EventHandlers.Ink
{
    public class CopyPasteStrokesEventArgs
    {
        public IEnumerable<InkStroke> Strokes { get; set; }

        public CopyPasteStrokesEventArgs(IEnumerable<InkStroke> strokes)
        {
            Strokes = strokes;
        }
    }
}
