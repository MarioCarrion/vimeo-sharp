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

using System.Collections.Generic;
using System.Reflection;

using VimeoSharp.Simple;

namespace VimeoSharp {
	
	class Program {

		static void Main (string[] args)
		{
			string userid = "brad"; // As used in the examples

			UserRequest userRequest = new UserRequest () { UsernameId = userid };
			List<LikedVideo> videos = userRequest.Likes;
			
			System.Console.WriteLine ("ContactsLike:");
			foreach (LikedVideo video in videos) {
				System.Console.WriteLine ("\tcontactsLike");
				foreach (PropertyInfo property in video.GetType ().GetProperties ()) {
					System.Console.WriteLine ("\t\t{0}={1}", property.Name, property.GetValue (video, null));
				}
			}
			
//			System.Console.WriteLine ("VideoRequest:");
//			VideoRequest videoRequest = new VideoRequest () {VideoId = 3924090};
//			Video video1 = videoRequest.Video;
//			foreach (PropertyInfo property in video1.GetType ().GetProperties ()) {
//					System.Console.WriteLine ("\t\t{0}={1}", property.Name, property.GetValue (video1, null));
//				}

			System.Console.WriteLine ("");
		}
	}
}

