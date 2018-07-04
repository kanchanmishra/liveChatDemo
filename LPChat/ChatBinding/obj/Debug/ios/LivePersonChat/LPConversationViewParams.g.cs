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
	[Register("LPConversationViewParams", true)]
	public unsafe partial class LPConversationViewParams : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("LPConversationViewParams");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected LPConversationViewParams (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LPConversationViewParams (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithConversationQuery:containerViewController:isViewOnly:conversationHistoryControlParam:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public LPConversationViewParams (ConversationParamProtocol conversationQuery, global::UIKit.UIViewController containerViewController, bool isViewOnly, LPConversationHistoryControlParam conversationHistoryControlParam)
			: base (NSObjectFlag.Empty)
		{
			if (conversationQuery == null)
				throw new ArgumentNullException ("conversationQuery");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool_IntPtr (this.Handle, Selector.GetHandle ("initWithConversationQuery:containerViewController:isViewOnly:conversationHistoryControlParam:"), conversationQuery.Handle, containerViewController == null ? IntPtr.Zero : containerViewController.Handle, isViewOnly, conversationHistoryControlParam == null ? IntPtr.Zero : conversationHistoryControlParam.Handle), "initWithConversationQuery:containerViewController:isViewOnly:conversationHistoryControlParam:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithConversationQuery:containerViewController:isViewOnly:conversationHistoryControlParam:"), conversationQuery.Handle, containerViewController == null ? IntPtr.Zero : containerViewController.Handle, isViewOnly, conversationHistoryControlParam == null ? IntPtr.Zero : conversationHistoryControlParam.Handle), "initWithConversationQuery:containerViewController:isViewOnly:conversationHistoryControlParam:");
			}
		}
		
		[Export ("new")]
		[CompilerGenerated]
		public static LPConversationViewParams New ()
		{
			return  Runtime.GetNSObject<LPConversationViewParams> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("new")));
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIViewController ContainerViewController {
			[Export ("containerViewController", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("containerViewController")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("containerViewController")));
				}
				return ret;
			}
			
			[Export ("setContainerViewController:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setContainerViewController:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setContainerViewController:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual LPConversationHistoryControlParam ConversationHistoryControlParam {
			[Export ("conversationHistoryControlParam", ArgumentSemantic.Retain)]
			get {
				LPConversationHistoryControlParam ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<LPConversationHistoryControlParam> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("conversationHistoryControlParam")));
				} else {
					ret =  Runtime.GetNSObject<LPConversationHistoryControlParam> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("conversationHistoryControlParam")));
				}
				return ret;
			}
			
			[Export ("setConversationHistoryControlParam:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setConversationHistoryControlParam:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setConversationHistoryControlParam:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual ConversationParamProtocol ConversationQuery {
			[Export ("conversationQuery", ArgumentSemantic.Retain)]
			get {
				ConversationParamProtocol ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<ConversationParamProtocol> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("conversationQuery")));
				} else {
					ret =  Runtime.GetNSObject<ConversationParamProtocol> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("conversationQuery")));
				}
				return ret;
			}
			
			[Export ("setConversationQuery:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setConversationQuery:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setConversationQuery:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Description {
			[Export ("description")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("description")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("description")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsViewOnly {
			[Export ("isViewOnly")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isViewOnly"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isViewOnly"));
				}
			}
			
			[Export ("setIsViewOnly:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsViewOnly:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsViewOnly:"), value);
				}
			}
		}
		
	} /* class LPConversationViewParams */
}
