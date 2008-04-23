//
// WrapLabel.cs
//
// Author:
//   Aaron Bockover <abockover@novell.com>
//
// Copyright (C) 2008 Novell, Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using Gtk;

namespace Hyena.Widgets
{
    public class WrapLabel : Widget
    {
        private string text;
        private bool use_markup = false;
        private Pango.Layout layout;
        
        public WrapLabel ()
        {
        }
        
        private void CreateLayout ()
        {
            if (layout != null) {
                layout.Dispose ();
            }
            
            layout = new Pango.Layout (PangoContext);
            layout.Wrap = Pango.WrapMode.Word;
        }
        
        private void UpdateLayout ()
        {
            if (layout == null) {
                CreateLayout ();
            }
            
            if (use_markup) {
                layout.SetMarkup (text);
            } else {
                layout.SetText (text);
            }
            
            QueueResize ();
        }
        
        protected override void OnStyleSet (Style previous_style)
        {
            CreateLayout ();
            UpdateLayout ();
            base.OnStyleSet (previous_style);
        }
        
        protected override void OnRealized ()
        {
            WidgetFlags |= WidgetFlags.NoWindow;
            GdkWindow = Parent.GdkWindow;
            base.OnRealized ();
        }
        
        protected override void OnUnrealized ()
        {
            WidgetFlags &= ~WidgetFlags.NoWindow;
            base.OnUnrealized ();
        }
        
        protected override void OnSizeAllocated (Gdk.Rectangle allocation)
        {
            int lw, lh;
            
            layout.Width = (int)(allocation.Width * Pango.Scale.PangoScale);
            layout.GetPixelSize (out lw, out lh);
            
            HeightRequest = lh;
            
            base.OnSizeAllocated (allocation);
        }

        protected override bool OnExposeEvent (Gdk.EventExpose evnt)
        {
            if (evnt.Window != GdkWindow) {
                return base.OnExposeEvent (evnt);
            }
            
            Gtk.Style.PaintLayout (Style, GdkWindow, State, false, evnt.Area, 
                this, null, Allocation.X, Allocation.Y, layout);
            
            return true;
        }
        
        public string Markup {
            get { return text; }
            set {
                use_markup = true;
                text = value;
                UpdateLayout ();
            }
        }
        
        public string Text {
            get { return text; }
            set {
                use_markup = false;
                text = value;
                UpdateLayout ();
            }
        }       
    }
}
