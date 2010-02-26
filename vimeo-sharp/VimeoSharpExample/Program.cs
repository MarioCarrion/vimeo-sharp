//
// VimeoSharpExample. API example.
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
using System.Collections.Generic;
using System.Reflection;

using VimeoSharp.Simple;

namespace VimeoSharp {

	class Program {

		static void Main (string[] args)
		{
			string userid = "brad"; // As used in the examples
			UserRequest userRequest = new UserRequest () { UsernameId = userid };

			PrintResult<Album> (userRequest.Albums, "Album");

			PrintResult<Channel> (userRequest.Channels, "Channel");
	
			Console.WriteLine ("Info");
			PrintResult<User> (userRequest.Info);

			PrintResult<Video> (userRequest.Videos, "Video");

			PrintResult<Video> (userRequest.Likes, "LikesVideo");

			PrintResult<Video> (userRequest.AppearsIn, "AppearsIn");

			PrintResult<Video> (userRequest.AllVideos, "AllVideos");

			PrintResult<Video> (userRequest.Subscriptions, "Subscriptions");

			PrintResult<Video> (userRequest.ContactsVideos, "ContactsVideos");

			PrintResult<Video> (userRequest.ContactsLike, "ContactsLike");

			PrintResult<Group> (userRequest.Groups, "Groups");

			VideoRequest videoRequest = new VideoRequest () { VideoId = 9704017 };
			Console.WriteLine ("Video");
			PrintResult<Video> (videoRequest.Video);
			
			GroupRequest groupRequest = new GroupRequest () { GroupId = "awesome" };
			PrintResult<Group> (groupRequest.Groups, "Groups");
			
			PrintResult<User> (groupRequest.Users, "Users");
			
			PrintResult<Video> (groupRequest.Videos, "Videos");
		}

		static void PrintResult<T> (List<T> values, string type)
		{
			Console.WriteLine ("{0}:", type);
			int count = 0;
			foreach (T val in values) {
				Console.WriteLine ("\t{0}. {1}", count++, type);
				PrintResult (val);
			}
		}

		static void PrintResult<T> (T val)
		{
			foreach (PropertyInfo property in val.GetType ().GetProperties ())
				Console.WriteLine ("\t\t{0} = {1}", 
				                   property.Name, 
				                   property.GetValue (val, null));
		}
	}
}
