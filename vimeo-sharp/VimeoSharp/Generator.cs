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
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;

namespace VimeoSharp {

	internal static class Generator {
		
		#region Public Methods
		
		public static List<T> GetList<T> (XmlDocument xmlDocument)
		{
			XmlElementAttribute xmlAttr = GetXmlElementAttribute (typeof (T));
			return (from a in ConvertToXDocument (xmlDocument).Descendants (xmlAttr.ElementName)
			         select GetObject<T> (a)).ToList ();
		}
		
		public static T GetElement<T> (XmlDocument xmlDocument)
		{
			XmlElementAttribute xmlAttr = GetXmlElementAttribute (typeof (T));
			return (from a in ConvertToXDocument (xmlDocument).Descendants (xmlAttr.ElementName)
			         select GetObject<T> (a)).First ();
		}
		
		#endregion
		
		#region Private methods
		
		static XmlElementAttribute GetXmlElementAttribute (Type type)
		{
			Attribute[] attrs = Attribute.GetCustomAttributes (type);
			XmlElementAttribute xmlAttr = null;
			
			foreach (System.Attribute attr in attrs) {
				xmlAttr = attr as XmlElementAttribute;
				if (xmlAttr != null)
					break;
			}

			if (xmlAttr == null || xmlAttr.ElementName == null)
				throw new ArgumentException (string.Format ("Type {0} missing XmlElement attribute name.", 
				                                              type));
			
			return xmlAttr;
		}
		
		static T GetObject<T> (XElement xElement)
		{
			T obj = Activator.CreateInstance<T> ();
			
			PropertyInfo[] properties = typeof(T).GetProperties ();
			foreach (PropertyInfo propertyInfo in properties)
				SetValue (xElement, obj, propertyInfo);
			
			return obj;
		}
		
		static void SetValue (XElement xElement, object obj, PropertyInfo propertyInfo)
		{
			object[] attributes = propertyInfo.GetCustomAttributes (true);

			if (attributes.Length == 0)
				return;

			// If the property is decorated with XmlElementAttribute...
			XmlElementAttribute xmlAttr = null;
			foreach (object attribute in attributes) {
				xmlAttr = attribute as XmlElementAttribute;
				if (xmlAttr != null)
					break;
			}
			if (xmlAttr == null)
				return;

			XElement xAttribute = xElement.Element (xmlAttr.ElementName);
			if (xAttribute == null || string.IsNullOrEmpty (xAttribute.Value))
				return;

			// ... we will set the value returned by the XElement
			if (xmlAttr.ConversionType == ConversionType.Integer)
				propertyInfo.SetValue (obj, XmlConvert.ToInt32 (xAttribute.Value), null);
			else if (xmlAttr.ConversionType == ConversionType.Boolean)
				propertyInfo.SetValue (obj, XmlConvert.ToBoolean (xAttribute.Value), null);
			else if (xmlAttr.ConversionType == ConversionType.LiteralBoolean)
				propertyInfo.SetValue (obj, 
				                       xAttribute.Value == "yes" ? true : false,
				                       null);
			else
				propertyInfo.SetValue (obj, xAttribute.Value, null);
		}

		static XDocument ConvertToXDocument (XmlDocument doc)
		{
			return XDocument.Load (new XmlNodeReader (doc));
		}
		
		#endregion
	}
}
