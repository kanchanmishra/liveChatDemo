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
	[Protocol (Name = "ConversationViewControllerAgentDelegate", WrapperType = typeof (ConversationViewControllerAgentDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AgentDidChangeUserInputText", Selector = "agentDidChangeUserInputText:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetUIAdapterDelegate", Selector = "setUIAdapterDelegate:", ParameterType = new Type [] { typeof (LivePersonChat.UIAdapterDelegate) }, ParameterByRef = new bool [] { false })]
	public interface IConversationViewControllerAgentDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class ConversationViewControllerAgentDelegate_Extensions {
		[CompilerGenerated]
		public static void AgentDidChangeUserInputText (this IConversationViewControllerAgentDelegate This, string text)
		{
			if (text == null)
				throw new ArgumentNullException ("text");
			var nstext = NSString.CreateNative (text);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("agentDidChangeUserInputText:"), nstext);
			NSString.ReleaseNative (nstext);
			
		}
		
		[CompilerGenerated]
		public static void SetUIAdapterDelegate (this IConversationViewControllerAgentDelegate This, UIAdapterDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setUIAdapterDelegate:"), @delegate.Handle);
		}
		
	}
	
	internal sealed class ConversationViewControllerAgentDelegateWrapper : BaseWrapper, IConversationViewControllerAgentDelegate {
		[Preserve (Conditional = true)]
		public ConversationViewControllerAgentDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
