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

using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace VimeoSharp.Simple {

	public class AlbumRequest {

		public AlbumRequest  ()
		{
		}

		public AlbumRequest (int id)
		{
			Id = id;
		}

		public int Id {
			get;
			set;
		}

		#region Videos in that album

		public XmlDocument VideosAsXml  {
			get {
				return Helper.RequestUrl (string.Format (RequestUrls.Album, 
				                                          Id, "videos"));
			}
		}

		public List<Video> Videos {
			get { return Generator.GetList<Video> (VideosAsXml); }
		}

		#endregion

		#region Album info for the specified album

		public XmlDocument InfoAsXml  {
			get {
				return Helper.RequestUrl (string.Format (RequestUrls.Album, 
				                                          Id, "info"));
			}
		}
		
		public Album Info {
			get { return Generator.GetElement<Album> (InfoAsXml); }
		}

		#endregion
		
	}
}
