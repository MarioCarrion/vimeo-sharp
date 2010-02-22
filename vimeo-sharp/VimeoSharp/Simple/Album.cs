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

using System.Xml;
using System.Xml.Linq;

namespace VimeoSharp.Simple {

	public class Album {

		public Album ()
		{
		}
		
		public Album (XElement album)
		{
			Id = XmlConvert.ToInt32 (album.Element ("id").Value);
			CreatedOn = album.Element ("created_on").Value;
			LastModified = album.Element ("last_modified").Value;
			Title = album.Element ("title").Value;
			Description = album.Element ("description").Value;
			Url = album.Element ("url").Value;
			ThumbnailSmall = album.Element ("thumbnail_small").Value;
			ThumbnailMedium = album.Element ("thumbnail_medium").Value;
			ThumbnailLarge = album.Element ("thumbnail_large").Value;
			TotalVideos = XmlConvert.ToInt32 (album.Element ("thumbnail_large").Value);
		}

		public int Id {
			get;
			set;
		}

		public string CreatedOn {
			get;
			set;
		}

		public string LastModified {
			get;
			set;
		}

		public string Title {
			get;
			set;
		}

		public string Description {
			get;
			set;
		}

		public string Url {
			get;
			set;
		}

		public string ThumbnailSmall {
			get;
			set;
		}

		public string ThumbnailMedium {
			get;
			set;
		}

		public string ThumbnailLarge {
			get;
			set;
		}

		public int TotalVideos {
			get;
			set;
		}
	
	}
}