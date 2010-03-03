// 
// VimeoSharp. Vimeo API library.
// 
// Author:
//       Mario Carrion <mario@carrion.mx>
// 
// Copyright (c) 2010 Mario Carrion
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

namespace VimeoSharp {

	public static class RequestUrls {

		#region Simple API: http://vimeo.com/api/docs/simple-api

		public static readonly string Group = "http://vimeo.com/api/v2/group/{0}/{1}.xml";

		public static readonly string User = "http://vimeo.com/api/v2/{0}/{1}.xml";

		public static readonly string Video = "http://vimeo.com/api/v2/video/{0}.{1}.xml";

		public static readonly string Channel = "http://vimeo.com/api/v2/channel/{0}/{1}.xml";

		public static readonly string Album = "http://vimeo.com/api/v2/album/{0}/{1}.xml";

		#endregion
	}
}
