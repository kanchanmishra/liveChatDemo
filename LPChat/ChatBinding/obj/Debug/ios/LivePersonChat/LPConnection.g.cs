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
	[Register("LPConnection", true)]
	public unsafe partial class LPConnection : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("LPConnection");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected LPConnection (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LPConnection (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithConsumer:conversations:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public LPConnection (LPUserEntity consumer, LPConversationEntity[] conversations)
			: base (NSObjectFlag.Empty)
		{
			if (consumer == null)
				throw new ArgumentNullException ("consumer");
			if (conversations == null)
				throw new ArgumentNullException ("conversations");
			var nsa_conversations = NSArray.FromNSObjects (conversations);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithConsumer:conversations:"), consumer.Handle, nsa_conversations.Handle), "initWithConsumer:conversations:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithConsumer:conversations:"), consumer.Handle, nsa_conversations.Handle), "initWithConsumer:conversations:");
			}
			nsa_conversations.Dispose ();
			
		}
		
		[Export ("new")]
		[CompilerGenerated]
		public static LPConnection New ()
		{
			return  Runtime.GetNSObject<LPConnection> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("new")));
		}
		
		[CompilerGenerated]
		public virtual LPUserEntity Consumer {
			[Export ("consumer", ArgumentSemantic.Retain)]
			get {
				LPUserEntity ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<LPUserEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("consumer")));
				} else {
					ret =  Runtime.GetNSObject<LPUserEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("consumer")));
				}
				return ret;
			}
			
			[Export ("setConsumer:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setConsumer:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setConsumer:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual LPConversationEntity[] Conversations {
			[Export ("conversations", ArgumentSemantic.Copy)]
			get {
				LPConversationEntity[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<LPConversationEntity>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("conversations")));
				} else {
					ret = NSArray.ArrayFromHandle<LPConversationEntity>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("conversations")));
				}
				return ret;
			}
			
			[Export ("setConversations:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setConversations:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setConversations:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
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
		public virtual NSDate EffectiveTtr {
			[Export ("effectiveTtr", ArgumentSemantic.Copy)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("effectiveTtr")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("effectiveTtr")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual nint HashValue {
			[Export ("hashValue")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("hashValue"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hashValue"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual LPConversationEntity LastConversation {
			[Export ("lastConversation", ArgumentSemantic.Retain)]
			get {
				LPConversationEntity ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<LPConversationEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lastConversation")));
				} else {
					ret =  Runtime.GetNSObject<LPConversationEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lastConversation")));
				}
				return ret;
			}
			
		}
		
	} /* class LPConnection */
}
