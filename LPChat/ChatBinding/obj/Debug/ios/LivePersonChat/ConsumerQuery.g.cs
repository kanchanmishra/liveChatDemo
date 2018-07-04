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
	[Register("ConsumerQuery", true)]
	public unsafe partial class ConsumerQuery : BrandQuery {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("ConsumerQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ConsumerQuery () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ConsumerQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ConsumerQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithConsumerID:brandID:agentToken:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public ConsumerQuery (string consumerID, string brandID, string agentToken)
			: base (NSObjectFlag.Empty)
		{
			if (consumerID == null)
				throw new ArgumentNullException ("consumerID");
			if (brandID == null)
				throw new ArgumentNullException ("brandID");
			if (agentToken == null)
				throw new ArgumentNullException ("agentToken");
			var nsconsumerID = NSString.CreateNative (consumerID);
			var nsbrandID = NSString.CreateNative (brandID);
			var nsagentToken = NSString.CreateNative (agentToken);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithConsumerID:brandID:agentToken:"), nsconsumerID, nsbrandID, nsagentToken), "initWithConsumerID:brandID:agentToken:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithConsumerID:brandID:agentToken:"), nsconsumerID, nsbrandID, nsagentToken), "initWithConsumerID:brandID:agentToken:");
			}
			NSString.ReleaseNative (nsconsumerID);
			NSString.ReleaseNative (nsbrandID);
			NSString.ReleaseNative (nsagentToken);
			
		}
		
		[Export ("getConversations:")]
		[CompilerGenerated]
		public virtual LPConversationEntity[] GetConversations (NSPredicate predicate)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<LPConversationEntity>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("getConversations:"), predicate == null ? IntPtr.Zero : predicate.Handle));
			} else {
				return NSArray.ArrayFromHandle<LPConversationEntity>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("getConversations:"), predicate == null ? IntPtr.Zero : predicate.Handle));
			}
		}
		
		[Export ("isConversationRelatedToQuery:")]
		[CompilerGenerated]
		public virtual bool IsConversationRelatedToQuery (LPConversationEntity conversation)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isConversationRelatedToQuery:"), conversation.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isConversationRelatedToQuery:"), conversation.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual LPConversationEntity ActiveConversation {
			[Export ("getActiveConversation")]
			get {
				LPConversationEntity ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<LPConversationEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getActiveConversation")));
				} else {
					ret =  Runtime.GetNSObject<LPConversationEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getActiveConversation")));
				}
				return ret;
			}
			
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
		public virtual LPConversationEntity CreateNewConversation {
			[Export ("createNewConversation")]
			get {
				LPConversationEntity ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<LPConversationEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("createNewConversation")));
				} else {
					ret =  Runtime.GetNSObject<LPConversationEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("createNewConversation")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string QueryType {
			[Export ("getQueryType")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getQueryType")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getQueryType")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string QueryUID {
			[Export ("getQueryUID")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getQueryUID")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getQueryUID")));
				}
			}
			
		}
		
	} /* class ConsumerQuery */
}
