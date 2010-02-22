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
	
	public class User {
		
		public User ()
		{
		}
		
		public User (XElement user)
		{
			Id = XmlConvert.ToInt32 (user.Element ("id").Value);
			DisplayName = user.Element ("display_name").Value;
			CreatedOn = user.Element ("created_on").Value;
			IsStaff  = XmlConvert.ToBoolean (user.Element ("is_staff").Value);
			IsPlus = XmlConvert.ToBoolean (user.Element ("is_plus").Value);
			Location = user.Element ("location").Value;
			Url = user.Element ("url").Value;
			Bio = user.Element ("bio").Value;
			ProfileUrl = user.Element ("profile_url").Value;
			VideosUrl = user.Element ("videos_url").Value;
			TotalVideosUploaded = XmlConvert.ToInt32 (user.Element ("total_videos_uploaded").Value);
			TotalVideoAppearsIn = XmlConvert.ToInt32 (user.Element ("total_videos_appears_in").Value);
			TotalVideosLiked = XmlConvert.ToInt32 (user.Element ("total_videos_liked").Value);
			TotalContacts = XmlConvert.ToInt32 (user.Element ("total_contacts").Value);
			TotalAlbums = XmlConvert.ToInt32 (user.Element ("total_albums").Value);
			TotalChannels = XmlConvert.ToInt32 (user.Element ("total_channels").Value);
			PortraitSmall = user.Element ("portrait_small").Value;
			PortraitMedium = user.Element ("portrait_medium").Value;
			PortraitLarge = user.Element ("portrait_large").Value;
		}

		public int Id {
			get;
			set;
		}

		public string DisplayName {
			get;
			set;
		}

		// TODO: use datatime
		public string CreatedOn {
			get;
			set;
		}

		public bool IsStaff {
			get;
			set;
		}

		public bool IsPlus {
			get;
			set;
		}

		public string Location {
			get;
			set;
		}

		public string Url
		{
			get;
			set;
		}

		public string Bio {
			get;
			set;
		}

		public string ProfileUrl {
			get;
			set;
		}

		public string VideosUrl {
			get;
			set;
		}

		public int TotalVideosUploaded {
			get;
			set;
		}

		public int TotalVideoAppearsIn {
			get;
			set;
		}

		public int TotalVideosLiked {
			get;
			set;
		}

		public int TotalContacts {
			get;
			set;
		}

		public int TotalAlbums {
			get;
			set;
		}

		public int TotalChannels {
			get;
			set;
		}

		public string PortraitSmall {
			get;
			set;
		}

		public string PortraitMedium {
			get;
			set;
		}

		public string PortraitLarge {
			get;
			set;
		}
	}
}