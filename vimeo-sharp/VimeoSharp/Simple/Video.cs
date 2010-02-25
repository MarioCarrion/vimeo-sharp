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

using System.Xml.Linq;

namespace VimeoSharp.Simple {

	[XmlElement (ElementName="video")]
	public class Video {

		public Video ()
		{
		}

		[XmlElement (ElementName="id", ConversionType=ConversionType.Integer)]
		public int Id {
			get;
			set;
		}

		[XmlElement (ElementName="title")]
		public string Title {
			get;
			set;
		}

		[XmlElement (ElementName="description")]
		public string Description {
			get;
			set;
		}

		[XmlElement (ElementName="url")]
		public string Url {
			get;
			set;
		}

		// TODO: Use DateTime
		[XmlElement (ElementName="upload_date")]
		public string UploadDate {
			get;
			set;
		}

		[XmlElement (ElementName="thumbnail_small")]
		public string ThumbnailSmall {
			get;
			set;
		}

		[XmlElement (ElementName="thumbnail_medium")]
		public string ThumbnailMedium {
			get;
			set;
		}

		[XmlElement (ElementName="thumbnail_large")]
		public string ThumbnailLarge {
			get;
			set;
		}

		[XmlElement (ElementName="user_name")]
		public string UserName {
			get;
			set;
		}

		[XmlElement (ElementName="user_url")]
		public string UserUrl {
			get;
			set;
		}

		[XmlElement (ElementName="user_portrait_small")]
		public string UserPortraitSmall {
			get;
			set;
		}

		[XmlElement (ElementName="user_portrait_medium")]
		public string UserPortraitMedium {
			get;
			set;
		}

		[XmlElement (ElementName="user_portrait_large")]
		public string UserPortraitLarge {
			get;
			set;
		}

		[XmlElement (ElementName="user_portrait_huge")]
		public string UserPortraitHuge {
			get;
			set;
		}

		[XmlElement (ElementName="stats_number_of_likes", 
		             ConversionType=ConversionType.Integer)]
		public int StatsNumberOfLikes {
			get;
			set;
		}

		[XmlElement (ElementName="stats_number_of_plays", 
		             ConversionType=ConversionType.Integer)]
		public int StatsNumberOfPlays {
			get;
			set;
		}

		[XmlElement (ElementName="stats_number_of_comments", 
		             ConversionType=ConversionType.Integer)]
		public int StatsNumberOfComments {
			get;
			set;
		}

		[XmlElement (ElementName="duration", 
		             ConversionType=ConversionType.Integer)]
		public int Duration {
			get;
			set;
		}

		[XmlElement (ElementName="width", 
		             ConversionType=ConversionType.Integer)]
		public int Width {
			get;
			set;
		}

		[XmlElement (ElementName="height", 
		             ConversionType=ConversionType.Integer)]
		public int Height {
			get;
			set;
		}

		[XmlElement (ElementName="tags")]
		public string Tags {
			get;
			set;
		}

		// FIXME: Use DateTime
		[XmlElement (ElementName="liked_on")]
		public string LikedOn {
			get;
			set;
		}
	}
}

