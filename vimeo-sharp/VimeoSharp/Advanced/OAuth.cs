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
using System.Security.Cryptography;
using System.Text;
using System.Web;
using VimeoSharp;

namespace VimeoSharp.Advanced {

	public class OAuth {

		public OAuth ()
		{
//			Console.WriteLine (Encode ("Hola! Mundo#$"));
			ConsumerKey = "SETSOMETHINGHERE!";
		}
		
		#region OAuth Parameters @ http://vimeo.com/api/docs/oauth
		
		// oauth_consumer_key
		string ConsumerKey {
			get;
			set;
		}

		// oauth_nonce
		string NOnce {
			get {
				Random random = new Random ();
				return new string (Enumerable.Repeat (0, 10)
				                    .Select (i => (char) rand.Next (65, 90))
				                    .ToArray ());
			}
		}
		
		// oauth_signature_method
		string SignatureMethod {
			get { return "HMAC-SHA1"; }
		}

		// oauth_timestamp
		string TimeStamp {
			get {
				return ((int) (DateTime.UtcNow
				               - new DateTime (1970, 1, 1, 0, 0, 0)).TotalSeconds)
					.ToString ();
			}
		}

		// oauth_version
		string Version {
			get { return "1.0"; }
		}

		#endregion

		// Encoding @ http://vimeo.com/api/docs/oauth
		string Encode (string str)
		{
			string reserved = "!*'();:@&=+$,/?%#[]";
			StringBuilder encodedString = new StringBuilder ();

			foreach (char character in str) {
				if (reserved.IndexOf (character) != -1)
					encodedString.Append (string.Format ("%{0:X2}",
					                                     (int) character));
				else
					encodedString.Append (character);
			}

			return encodedString.ToString ();
		}

		string GenerateSignature (string url,
		                          string consumerSecret,
		                          string consumerKey,
		                          string nonce,
		                          string timestap,
		                          string signatureMethod,
		                          string verifier,
		                          string token)
		{
			StringBuilder parameters = new StringBuilder ();

			parameters.Append ("oauth_consumer_key=");
			parameters.Append (consumerKey);

			parameters.Append ("&oauth_nonce=");
			parameters.Append (nonce);

			parameters.Append ("&oauth_signature_method=");
			parameters.Append (signatureMethod);

			if (token != null) {
				parameters.Append ("&oauth_token=");
				parameters.Append (token);
			}

			parameters.Append ("&oauth_timestamp=");
			parameters.Append (timestap);

			if (verifier != null) {
				parameters.Append ("&oauth_verifier=");
				parameters.Append (verifier);
			}

			parameters.Append ("&oauth_version=1.0");

			string baseString = "GET" + "&" + Encode (url) + "&" + Encode (parameters.ToString ());
			
			// 2. Creating the key
			consumerSecret = Encode (consumerSecret);
			string key = consumerSecret + "&"; // no TokenSecret... yet

			// signature
			HMACSHA1 hmacsha1 = new HMACSHA1();
			hmacsha1.Key = Encoding.ASCII.GetBytes (key);

			byte[] dataBuffer = Encoding.ASCII.GetBytes (baseString);
			byte[] hashBytes = hmacsha1.ComputeHash (dataBuffer);
			string signature = Convert.ToBase64String(hashBytes);
			
			return HttpUtility.UrlEncode (signature);
		}
	}
}
