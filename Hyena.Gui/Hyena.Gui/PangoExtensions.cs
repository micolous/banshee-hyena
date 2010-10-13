//
// PangoExtensions.cs
// 
// Author:
//   Aaron Bockover <abockover@novell.com>
// 
// Copyright 2009 Novell, Inc.
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

using System;
using System.Linq;

using Pango;

namespace Hyena.Gui
{
    public static class PangoExtensions
    {
        public static int MeasureTextHeight (this FontDescription description, Context context)
        {
            return MeasureTextHeight (description, context, context.Language);
        }

        public static int MeasureTextHeight (this FontDescription description, Context context, Language language)
        {
            using (var metrics = context.GetMetrics (description, language)) {
                return ((int)(metrics.Ascent + metrics.Descent) + 512) >> 10; // PANGO_PIXELS (d)
            }
        }

        public static string FormatEscaped (this string format, params object [] args)
        {
            return String.Format (format, args.Select (a => GLib.Markup.EscapeText (a.ToString ())).ToArray ());
        }
    }
}
