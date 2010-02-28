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
using System.Xml.Linq;

namespace VimeoSharp.Simple {

	public class UserRequest {

		public UserRequest () 
			: this (string.Empty)
		{
		}

		public UserRequest (string usernameId)
		{
		}

		public string UsernameId {
			get;
			set;
		}

		#region User info for the specified user

		public XmlDocument InfoAsXml {
			get { return RequestUrl ("info"); }
		}

		public User Info {
			get { return Generator.GetElement<User> (InfoAsXml); }
		}

		#endregion

		#region Videos created by user
		
		public XmlDocument VideosAsXml {
			get { return RequestUrl ("videos"); }
		}

		public List<Video> Videos {
			get { return Generator.GetList<Video> (VideosAsXml); }
		}
		
		#endregion

		#region Videos the user likes

		public XmlDocument LikesAsXml {
			get { return RequestUrl ("likes"); }
		}

		public List<Video> Likes {
			get { return Generator.GetList<Video> (LikesAsXml); }
		}

		#endregion

		#region Videos that the user appears in

		public XmlDocument AppearsInAsXml {
			get { return RequestUrl ("appears_in"); }
		}

		public List<Video> AppearsIn {
			get { return Generator.GetList<Video> (AppearsInAsXml); }
		}

		#endregion

		#region Videos that the user appears in and created

		public XmlDocument AllVideosAsXml {
			get { return RequestUrl ("all_videos"); }
		}

		public List<Video> AllVideos {
			get { return Generator.GetList<Video> (AllVideosAsXml); }
		}

		#endregion

		#region Videos the user is subscribed to

		public XmlDocument SubscriptionsAsXml {
			get { return RequestUrl ("subscriptions"); }
		}

		public List<Video> Subscriptions {
			get { return Generator.GetList<Video> (SubscriptionsAsXml); }
		}

		#endregion

		#region Albums the user has created
		public XmlDocument AlbumsAsXml {
			get { return RequestUrl ("albums"); }
		}

		public List<Album> Albums {
			get { return Generator.GetList<Album> (AlbumsAsXml); }
		}

		#endregion

		#region Channels the user has created and subscribed to

		public XmlDocument ChannelsAsXml {
			get { return RequestUrl ("channels"); }
		}

		public List<Channel> Channels {
			get {
				return Generator.GetList<Channel> (ChannelsAsXml);
			}
		}

		#endregion
		
		#region Groups the user has created and joined

		public XmlDocument GroupsAsXml {
			get { return RequestUrl ("groups"); }
		}
		
		public List<Group> Groups {
			get { return Generator.GetList<Group> (GroupsAsXml); }
		}
		
		#endregion

		#region Videos that the user's contacts created
		
		public XmlDocument ContactsVideosAsXml {
			get { return RequestUrl ("contacts_videos"); }
		}
		
		public List<Video> ContactsVideos {
			get { return Generator.GetList<Video> (ContactsVideosAsXml); }
		}
		
		#endregion

		#region Videos that the user's contacts like
		
		public XmlDocument ContactsLikeAsXml  {
			get { return RequestUrl ("contacts_like"); }
		}
		
		public List<Video> ContactsLike {
			get { return Generator.GetList<Video> (ContactsLikeAsXml); }
		}
		
		#endregion

		#region Private members

		private XmlDocument RequestUrl (string request)
		{
			if (string.IsNullOrEmpty (UsernameId))
				throw new System.ArgumentException ("Missing Username.");

			return Helper.RequestUrl (string.Format (RequestUrls.UserUrl, 
			                                           UsernameId, request, "xml"));
		}

		#endregion
	}
}

