// 
// NHibernate.Mapping.Attributes
// This product is under the terms of the GNU Lesser General Public License.
//
//
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 4.0.30319.x
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
//
//
// This source code was auto-generated by Refly, Version=2.21.1.0 (modified).
//
namespace NHibernate.Mapping.Attributes
{
	
	
	/// <summary> </summary>
	public enum LockMode
	{
		
		/// <summary>Default value (don't use it)</summary>
		Unspecified,
		
		/// <summary>none</summary>
		[System.Xml.Serialization.XmlEnumAttribute("none")]
		None,
		
		/// <summary>read</summary>
		[System.Xml.Serialization.XmlEnumAttribute("read")]
		Read,
		
		/// <summary>upgrade</summary>
		[System.Xml.Serialization.XmlEnumAttribute("upgrade")]
		Upgrade,
		
		/// <summary>upgrade-nowait</summary>
		[System.Xml.Serialization.XmlEnumAttribute("upgrade-nowait")]
		UpgradeNoWait,
		
		/// <summary>write</summary>
		[System.Xml.Serialization.XmlEnumAttribute("write")]
		Write,
	}
}
