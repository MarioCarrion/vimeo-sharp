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

	public class Channel {

		public Channel ()
		{
		}
		
		public Channel (XElement channel)
		{
			Id = XmlConvert.ToInt32 (channel.Element ("id").Value);
			Name = channel.Element ("name").Value;
			Description = channel.Element ("description").Value;
			Logo = channel.Element ("logo").Value;
			Badge = channel.Element ("badge").Value;
			Url = channel.Element ("url").Value;
			Rss = channel.Element ("rss").Value;
			CreatedOn = channel.Element ("created_on").Value;
			CreatorId = XmlConvert.ToInt32 (channel.Element ("creator_id").Value);
			CreatorDisplayName = channel.Element ("creator_display_name").Value;
			CreatorUrl = channel.Element ("creator_url").Value;
			IsCreator = Helper.LiteralValueToBoolean (channel.Element ("is_creator").Value);
			IsMod = Helper.LiteralValueToBoolean (channel.Element ("is_mod").Value);
			TotalVideos = XmlConvert.ToInt32 (channel.Element ("total_videos").Value);
			TotalSubscribers = XmlConvert.ToInt32 (channel.Element ("total_subscribers").Value);
		}

		public int Id {
			get;
			set;
		}

		public string Name {
			get;
			set;
		}

		public string Description {
			get;
			set;
		}

		public string Logo {
			get;
			set;
		}

		public string Badge {
			get;
			set;
		}

		public string Url {
			get;
			set;
		}

		public string Rss {
			get;
			set;
		}

		public string CreatedOn {
			get;
			set;
		}

		public int CreatorId {
			get;
			set;
		}

		public string CreatorDisplayName {
			get;
			set;
		}

		public string CreatorUrl {
			get;
			set;
		}

		public bool IsCreator {
			get;
			set;
		}

		public bool IsMod {
			get;
			set;
		}

		public int TotalVideos {
			get;
			set;
		}

		public int TotalSubscribers {
			get;
			set;
		}
	}
}