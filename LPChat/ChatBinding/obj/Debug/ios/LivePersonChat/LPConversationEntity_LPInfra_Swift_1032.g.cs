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
	public unsafe static partial class LPConversationEntity_LPInfra_Swift_1032  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("LPConversationEntity");
		
		[Export ("acceptSequence:")]
		[CompilerGenerated]
		public static void AcceptSequence (this LPConversationEntity This, nint seq)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nint (This.Handle, Selector.GetHandle ("acceptSequence:"), seq);
		}
		
		[Export ("createNewConversation:")]
		[CompilerGenerated]
		public static LPConversationEntity CreateNewConversation (this LPConversationEntity This, LPBrandEntity brand)
		{
			if (brand == null)
				throw new ArgumentNullException ("brand");
			return  Runtime.GetNSObject<LPConversationEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("createNewConversation:"), brand.Handle));
		}
		
		[Export ("getMessagesPage:pageSize:")]
		[CompilerGenerated]
		public static LPMessageEntity[] GetMessagesPage (this LPConversationEntity This, nint from, nint pageSize)
		{
			return NSArray.ArrayFromHandle<LPMessageEntity>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nint_nint (This.Handle, Selector.GetHandle ("getMessagesPage:pageSize:"), from, pageSize));
		}
		
		[Export ("getResolveDateString:")]
		[CompilerGenerated]
		public static string GetResolveDateString (this LPConversationEntity This, NSDate date)
		{
			if (date == null)
				throw new ArgumentNullException ("date");
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("getResolveDateString:"), date.Handle));
		}
		
		[Export ("resolve")]
		[CompilerGenerated]
		public static void Resolve (this LPConversationEntity This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("resolve"));
		}
		
		[Export ("resolve:")]
		[CompilerGenerated]
		public static void Resolve (this LPConversationEntity This, string closeReason)
		{
			if (closeReason == null)
				throw new ArgumentNullException ("closeReason");
			var nscloseReason = NSString.CreateNative (closeReason);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("resolve:"), nscloseReason);
			NSString.ReleaseNative (nscloseReason);
			
		}
		
		[Export ("updateTTRModelWithReset:")]
		[CompilerGenerated]
		public static void UpdateTTRModelWithReset (this LPConversationEntity This, bool reset)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("updateTTRModelWithReset:"), reset);
		}
		
		[CompilerGenerated]
		public virtual bool CanShowCSAT {
			[Export ("canShowCSAT")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canShowCSAT"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("canShowCSAT"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsActivityInIdle {
			[Export ("isActivityInIdle")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isActivityInIdle"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isActivityInIdle"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsCurrentlyUrgent {
			[Export ("isCurrentlyUrgent")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isCurrentlyUrgent"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isCurrentlyUrgent"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsOpen {
			[Export ("isOpen")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isOpen"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isOpen"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsResolvedAutomatically {
			[Export ("isResolvedAutomatically")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isResolvedAutomatically"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isResolvedAutomatically"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual LPMessageEntity LastMessageObj {
			[Export ("lastMessageObj", ArgumentSemantic.Retain)]
			get {
				LPMessageEntity ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<LPMessageEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lastMessageObj")));
				} else {
					ret =  Runtime.GetNSObject<LPMessageEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lastMessageObj")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual LPUserEntity LastMessageOriginator {
			[Export ("lastMessageOriginator", ArgumentSemantic.Retain)]
			get {
				LPUserEntity ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<LPUserEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lastMessageOriginator")));
				} else {
					ret =  Runtime.GetNSObject<LPUserEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lastMessageOriginator")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string RelatedSocketID {
			[Export ("relatedSocketID")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("relatedSocketID")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("relatedSocketID")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ShouldQueryMessages {
			[Export ("shouldQueryMessages")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldQueryMessages"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldQueryMessages"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual LPMessageEntity[] SortedMessages {
			[Export ("sortedMessages", ArgumentSemantic.Copy)]
			get {
				LPMessageEntity[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<LPMessageEntity>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sortedMessages")));
				} else {
					ret = NSArray.ArrayFromHandle<LPMessageEntity>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sortedMessages")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual LPMessageEntity[] UnreadMessages {
			[Export ("unreadMessages", ArgumentSemantic.Copy)]
			get {
				LPMessageEntity[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<LPMessageEntity>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("unreadMessages")));
				} else {
					ret = NSArray.ArrayFromHandle<LPMessageEntity>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("unreadMessages")));
				}
				return ret;
			}
			
		}
		
	} /* class LPConversationEntity_LPInfra_Swift_1032 */
}
