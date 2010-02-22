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

	public class Video {

		public Video ()
		{
		}
		
		public Video (XElement video)
		{
			Id = XmlConvert.ToInt32 (video.Element ("id").Value);
			Title = video.Element ("title").Value;
			Description = video.Element ("description").Value;
			Url = video.Element ("url").Value;
			UploadDate = video.Element ("upload_date").Value;
			ThumbnailSmall = video.Element ("thumbnail_small").Value;
			ThumbnailMedium = video.Element ("thumbnail_medium").Value;
			ThumbnailLarge = video.Element ("thumbnail_large").Value;
			UserName = video.Element ("user_name").Value;
			UserUrl = video.Element ("user_url").Value;
			UserPortraitSmall = video.Element ("user_portrait_small").Value;
			UserPortraitMedium = video.Element ("user_portrait_medium").Value;
			UserPortraitLarge = video.Element ("user_portrait_large").Value;
			UserPortraitHuge = video.Element ("user_portrait_huge").Value;
			StatsNumberOfLikes = XmlConvert.ToInt32 (video.Element ("stats_number_of_likes").Value);
			StatsNumberOfPlays = XmlConvert.ToInt32 (video.Element ("stats_number_of_plays").Value);
			StatsNumberOfComments = XmlConvert.ToInt32 (video.Element ("stats_number_of_comments").Value);
			Duration = XmlConvert.ToInt32 (video.Element ("duration").Value);
			Width = XmlConvert.ToInt32 (video.Element ("width").Value);
			Height = XmlConvert.ToInt32 (video.Element ("height").Value);
			Tags = video.Element ("tags").Value;
		}

		public int Id {
			get;
			set;
		}

		public string Title {
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

		// TODO: Use DateTime
		public string UploadDate {
			get;
			set;
		}

		public string ThumbnailSmall {
			get;
			set;
		}

		public string ThumbnailMedium {
			get;
			set;
		}

		public string ThumbnailLarge {
			get;
			set;
		}

		public string UserName {
			get;
			set;
		}

		public string UserUrl {
			get;
			set;
		}

		public string UserPortraitSmall {
			get;
			set;
		}

		public string UserPortraitMedium {
			get;
			set;
		}

		public string UserPortraitLarge {
			get;
			set;
		}

		public string UserPortraitHuge {
			get;
			set;
		}

		public int StatsNumberOfLikes {
			get;
			set;
		}

		public int StatsNumberOfPlays {
			get;
			set;
		}

		public int StatsNumberOfComments {
			get;
			set;
		}

		public int Duration {
			get;
			set;
		}

		public int Width {
			get;
			set;
		}

		public int Height {
			get;
			set;
		}

		public string Tags {
			get;
			set;
		}

	}
}

