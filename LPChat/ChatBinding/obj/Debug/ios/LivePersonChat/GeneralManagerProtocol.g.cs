//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;

namespace LivePersonChat {
	[Protocol (Name = "GeneralManagerProtocol", WrapperType = typeof (GeneralManagerProtocolWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ClearManager", Selector = "clearManager")]
	public interface IGeneralManagerProtocol : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("clearManager")]
		[Preserve (Conditional = true)]
		void ClearManager ();
		
	}
	
	internal sealed class GeneralManagerProtocolWrapper : BaseWrapper, IGeneralManagerProtocol {
		[Preserve (Conditional = true)]
		public GeneralManagerProtocolWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("clearManager")]
		[CompilerGenerated]
		public void ClearManager ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("clearManager"));
		}
		
	}
}
