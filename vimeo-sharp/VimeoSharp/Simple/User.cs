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

	[XmlElement (ElementName="user")]
	public class User {
		
		public User ()
		{
		}

		[XmlElement (ElementName="id", 
		             ConversionType=ConversionType.Integer)]
		public int Id {
			get;
			set;
		}

		[XmlElement (ElementName="display_name")]
		public string DisplayName {
			get;
			set;
		}

		// TODO: use datatime
		[XmlElement (ElementName="created_on")]
		public string CreatedOn {
			get;
			set;
		}

		[XmlElement (ElementName="is_staff", 
		             ConversionType=ConversionType.Boolean)]
		public bool IsStaff {
			get;
			set;
		}

		[XmlElement (ElementName="is_plus",
		             ConversionType=ConversionType.Boolean)]
		public bool IsPlus {
			get;
			set;
		}

		[XmlElement (ElementName="location")]
		public string Location {
			get;
			set;
		}

		[XmlElement (ElementName="url")]
		public string Url {
			get;
			set;
		}

		[XmlElement (ElementName="bio")]
		public string Bio {
			get;
			set;
		}

		[XmlElement (ElementName="profile_url")]
		public string ProfileUrl {
			get;
			set;
		}

		[XmlElement (ElementName="videos_url")]
		public string VideosUrl {
			get;
			set;
		}

		[XmlElement (ElementName="total_videos_uploaded", 
		             ConversionType=ConversionType.Integer)]
		public int TotalVideosUploaded {
			get;
			set;
		}

		[XmlElement (ElementName="total_videos_appears_in", 
		             ConversionType=ConversionType.Integer)]
		public int TotalVideoAppearsIn {
			get;
			set;
		}

		[XmlElement (ElementName="total_videos_liked", 
		             ConversionType=ConversionType.Integer)]
		public int TotalVideosLiked {
			get;
			set;
		}

		[XmlElement (ElementName="total_contacts",
		             ConversionType=ConversionType.Integer)]
		public int TotalContacts {
			get;
			set;
		}

		[XmlElement (ElementName="total_albums", 
		             ConversionType=ConversionType.Integer)]
		public int TotalAlbums {
			get;
			set;
		}

		[XmlElement (ElementName="total_channels", 
		             ConversionType=ConversionType.Integer)]
		public int TotalChannels {
			get;
			set;
		}

		[XmlElement (ElementName="portrait_small")]
		public string PortraitSmall {
			get;
			set;
		}

		[XmlElement (ElementName="portrait_medium")]
		public string PortraitMedium {
			get;
			set;
		}

		[XmlElement (ElementName="portrait_large")]
		public string PortraitLarge {
			get;
			set;
		}
	}
}