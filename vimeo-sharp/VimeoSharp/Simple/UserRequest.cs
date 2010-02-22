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
	
	//http://vimeo.com/api/docs/simple-api

	public class UserRequest {

		public static readonly string UserRequestUrl = "http://vimeo.com/api/v2/{0}/{1}.xml";

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
			get {
				XmlDocument infoXml = InfoAsXml;
				return (from u in Helper.ConvertToXDocument (infoXml).Descendants ("user")
				         select new User (u)).First ();
			}
		}

		#endregion

		#region Videos created by user
		
		public XmlDocument VideosAsXml {
			get { return RequestUrl ("videos"); }
		}

		public List<Video> Videos {
			get { 
				return (from v in Helper.ConvertToXDocument (VideosAsXml).Descendants ("video")
					     select new Video (v)).ToList ();
			}
		}
		
		#endregion

		#region Videos the user likes

		public XmlDocument LikesAsXml {
			get { return RequestUrl ("likes"); }
		}

		public List<LikedVideo> Likes {
			get { 
				return (from lv in Helper.ConvertToXDocument (LikesAsXml).Descendants ("video")
					     select new LikedVideo (lv)).ToList ();
			}
		}

		#endregion

		#region Videos that the user appears in

		public XmlDocument AppearsInAsXml {
			get { return RequestUrl ("appears_in"); }
		}

		public List<Video> AppearsIn {
			get {
				return (from v in Helper.ConvertToXDocument (AppearsInAsXml).Descendants ("video")
					     select new Video (v)).ToList ();
			}
		}

		#endregion

		#region Videos that the user appears in and created

		public XmlDocument AllVideosAsXml {
			get { return RequestUrl ("all_videos"); }
		}

		public List<Video> AllVideos {
			get { 
				return (from v in Helper.ConvertToXDocument (AllVideosAsXml).Descendants ("video")
					     select new Video (v)).ToList (); 
			}
		}

		#endregion

		#region Videos the user is subscribed to

		public XmlDocument SubscriptionsAsXml {
			get { return RequestUrl ("subscriptions"); }
		}

		public List<Video> Subscriptions {
			get { 
				return (from v in Helper.ConvertToXDocument (SubscriptionsAsXml).Descendants ("video")
					     select new Video (v)).ToList (); 
			}
		}

		#endregion

		#region Albums the user has created
		public XmlDocument AlbumsAsXml {
			get { return RequestUrl ("albums"); }
		}

		public List<Album> Albums {
			get {
				return (from a in Helper.ConvertToXDocument (InfoAsXml).Descendants ("album")
					     select new Album (a)).ToList ();
			}
		}

		#endregion

		#region Channels the user has created and subscribed to

		public XmlDocument ChannelsAsXml {
			get { return RequestUrl ("channels"); }
		}

		public List<Channel> Channels {
			get { 
				return (from c in Helper.ConvertToXDocument (ChannelsAsXml).Descendants ("channel")
					     select new Channel (c)).ToList ();
			}
		}

		#endregion
		
		#region Groups the user has created and joined

		public XmlDocument GroupsAsXml {
			get { return RequestUrl ("groups"); }
		}
		
		public List<Group> Groups {
			get {
				return (from g in Helper.ConvertToXDocument (GroupsAsXml).Descendants ("group")
				         select new Group (g)).ToList ();
			}
		}
		
		#endregion

		#region Videos that the user's contacts created
		
		public XmlDocument ContactsVideosAsXml {
			get { return RequestUrl ("contacts_videos"); }
		}
		
		public List<Video> ContactsVideos {
			get {
				return (from cv in Helper.ConvertToXDocument (ContactsVideosAsXml).Descendants ("video")
				         select new Video (cv)).ToList ();
			}
		}
		
		#endregion

		#region Videos that the user's contacts like
		
		public XmlDocument ContactsLikeAsXml  {
			get { return RequestUrl ("contacts_like"); }
		}
		
		public List<Video> ContactsLike {
			get {
				return (from cl in Helper.ConvertToXDocument (ContactsLikeAsXml).Descendants ("video")
				         select new Video (cl)).ToList ();
			}
		}
		
		#endregion

		#region Private members

		private XmlDocument RequestUrl (string request)
		{
			if (string.IsNullOrEmpty (UsernameId))
				throw new System.ArgumentException ("Missing Username.");

			return Helper.RequestUrl (string.Format (UserRequestUrl, 
			                                           UsernameId, request, "xml"));
		}

		#endregion
	}
}

