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
	[Protocol (Name = "LPDataManagerSDKDelegate", WrapperType = typeof (LPDataManagerSDKDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LPMessagingSDKDataEncryptionFailed", Selector = "LPMessagingSDKDataEncryptionFailed:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	public interface ILPDataManagerSDKDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("LPMessagingSDKDataEncryptionFailed:")]
		[Preserve (Conditional = true)]
		void LPMessagingSDKDataEncryptionFailed (NSError error);
		
	}
	
	internal sealed class LPDataManagerSDKDelegateWrapper : BaseWrapper, ILPDataManagerSDKDelegate {
		[Preserve (Conditional = true)]
		public LPDataManagerSDKDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("LPMessagingSDKDataEncryptionFailed:")]
		[CompilerGenerated]
		public void LPMessagingSDKDataEncryptionFailed (NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("LPMessagingSDKDataEncryptionFailed:"), error.Handle);
		}
		
	}
}
