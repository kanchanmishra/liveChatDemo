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
	public unsafe static partial class LPBrandEntity_LPInfra_Swift_434  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("LPBrandEntity");
		
		[Export ("getConversations:")]
		[CompilerGenerated]
		public static LPConversationEntity[] GetConversations (this LPBrandEntity This, NSPredicate predicate)
		{
			return NSArray.ArrayFromHandle<LPConversationEntity>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("getConversations:"), predicate == null ? IntPtr.Zero : predicate.Handle));
		}
		
		[CompilerGenerated]
		public virtual LPConversationEntity[] Conversations {
			[Export ("getConversations")]
			get {
				LPConversationEntity[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<LPConversationEntity>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getConversations")));
				} else {
					ret = NSArray.ArrayFromHandle<LPConversationEntity>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getConversations")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual LPConversationEntity CreatedConversation {
			[Export ("getCreatedConversation")]
			get {
				LPConversationEntity ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<LPConversationEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getCreatedConversation")));
				} else {
					ret =  Runtime.GetNSObject<LPConversationEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getCreatedConversation")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsAuthenticated {
			[Export ("isAuthenticated")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAuthenticated"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isAuthenticated"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSDate LastMessageTimeStamp {
			[Export ("getLastMessageTimeStamp")]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getLastMessageTimeStamp")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getLastMessageTimeStamp")));
				}
				return ret;
			}
			
		}
		
	} /* class LPBrandEntity_LPInfra_Swift_434 */
}
