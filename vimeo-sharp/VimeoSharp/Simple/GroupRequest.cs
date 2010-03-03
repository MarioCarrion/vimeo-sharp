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

	public class GroupRequest {

		public GroupRequest ()
		{
		}
		
		public GroupRequest (string groupId)
		{
			GroupId = groupId;
		}

		public string GroupId {
			get;
			set;
		}

		#region Videos added to that group

		public XmlDocument VideosAsXml  {
			get {
				return Helper.RequestUrl (string.Format (RequestUrls.Group, 
				                                           GroupId, "videos"));
			}
		}
		
		public List<Video> Videos {
			get { return Generator.GetList<Video> (VideosAsXml); }
		}

		#endregion

		#region Users who have joined the group

		public XmlDocument UsersAsXml  {
			get {
				return Helper.RequestUrl (string.Format (RequestUrls.Group, 
				                                           GroupId, "users"));
			}
		}
		
		public List<User> Users {
			get { return Generator.GetList<User> (UsersAsXml); }
		}

		#endregion

		#region Group info for the specified group

		public XmlDocument GroupsAsXml  {
			get {
				return Helper.RequestUrl (string.Format (RequestUrls.Group, 
				                                           GroupId, "info"));
			}
		}
		
		public List<Group> Groups {
			get { return Generator.GetList<Group> (GroupsAsXml); }
		}

		#endregion
	}
}
