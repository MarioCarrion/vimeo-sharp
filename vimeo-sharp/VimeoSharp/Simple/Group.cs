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

using System;
using System.Xml.Linq;
using System.Xml;

namespace VimeoSharp.Simple {

	public class Group {

		public Group ()
		{
		}
		
		public Group (XElement grp)
		{
			Id = XmlConvert.ToInt32 (grp.Element ("id").Value);
			Name = grp.Element ("name").Value;
			Description = grp.Element ("description").Value;
			Url = grp.Element ("url").Value;
			Logo = grp.Element ("logo").Value;
			Thumbnail = grp.Element ("thumbnail").Value;
			CreatedOn= grp.Element ("created_on").Value;
			CreatorId= XmlConvert.ToInt32 (grp.Element ("creator_id").Value);
			CreatorDisplayName = grp.Element ("creator_display_name").Value;
			CreatorUrl = grp.Element ("creator_url").Value;
			IsMod = Helper.LiteralValueToBoolean (grp.Element ("is_mod").Value);
			IsCreator = Helper.LiteralValueToBoolean (grp.Element ("is_creator").Value);
			TotalMembers = XmlConvert.ToInt32 (grp.Element ("total_members").Value);
			TotalVideos = XmlConvert.ToInt32 (grp.Element ("total_videos").Value);
			TotalFiles = XmlConvert.ToInt32 (grp.Element ("total_files").Value);
			TotalForumTopics = XmlConvert.ToInt32 (grp.Element ("total_forum_topics").Value);
			TotalUpcomingEvents = XmlConvert.ToInt32 (grp.Element ("total_upcoming_events").Value);
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
		
		public string Url {
			get;
			set;
		}
		
		public string Logo {
			get;
			set;
		}
		
		public string Thumbnail {
			get;
			set;
		}
		
		// FIXME: Use DateTime
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
		
		public bool IsMod {
			get;
			set;
		}
		
		public bool IsCreator {
			get;
			set;
		}
		
		public int TotalMembers {
			get;
			set;
		}
		
		public int TotalVideos {
			get;
			set;
		}
		
		public int TotalFiles {
			get;
			set;
		}
		
		public int TotalForumTopics {
			get;
			set;
		}
		
		public int TotalEvents {
			get;
			set;
		}
		
		public int TotalUpcomingEvents {
			get;
			set;
		}
	}
}
