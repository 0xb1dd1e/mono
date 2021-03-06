//
// Authors:
//      Marek Habersack (mhabersack@novell.com)
//
// (C) 2010 Novell, Inc (http://www.novell.com)
//

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

namespace System.Web.UI
{
#if NET_2_0
	sealed class MainDirectiveAttribute <T>
#else
	sealed class MainDirectiveAttribute
#endif
	{
		string unparsedValue;
#if NET_2_0
		T value;
#else
		object value;
#endif
		bool isExpression;
		bool isDataBound;
		
		public string UnparsedValue {
			get { return unparsedValue; }
		}

		public bool IsExpression {
			get { return isExpression; }
		}
#if NET_2_0
		public T Value {
			get { return value; }
		}
#else
		public object Value {
			get { return value; }
		}
#endif
		public MainDirectiveAttribute (string value)
		{
			this.unparsedValue = value;
#if NET_2_0
			if (value != null)
				this.isExpression = BaseParser.IsExpression (value);
#endif
		}
#if NET_2_0
		public MainDirectiveAttribute (T value, bool unused)
#else
		public MainDirectiveAttribute (object value)
#endif
		{
			this.value = value;
		}
	}
}
