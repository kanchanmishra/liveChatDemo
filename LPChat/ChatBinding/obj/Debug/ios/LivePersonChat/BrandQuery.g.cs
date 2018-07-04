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
	[Register("BrandQuery", true)]
	public unsafe partial class BrandQuery : NSObject, IConversationParamProtocol {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("BrandQuery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected BrandQuery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal BrandQuery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithBrandID:campaignInfo:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public BrandQuery (string brandID, LPCampaignInfo campaignInfo)
			: base (NSObjectFlag.Empty)
		{
			if (brandID == null)
				throw new ArgumentNullException ("brandID");
			var nsbrandID = NSString.CreateNative (brandID);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithBrandID:campaignInfo:"), nsbrandID, campaignInfo == null ? IntPtr.Zero : campaignInfo.Handle), "initWithBrandID:campaignInfo:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithBrandID:campaignInfo:"), nsbrandID, campaignInfo == null ? IntPtr.Zero : campaignInfo.Handle), "initWithBrandID:campaignInfo:");
			}
			NSString.ReleaseNative (nsbrandID);
			
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
		
		[Export ("getLatestClosedConversation:")]
		[CompilerGenerated]
		public virtual LPConversationEntity[] GetLatestClosedConversation (nint conversationsCount)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<LPConversationEntity>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nint (this.Handle, Selector.GetHandle ("getLatestClosedConversation:"), conversationsCount));
			} else {
				return NSArray.ArrayFromHandle<LPConversationEntity>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("getLatestClosedConversation:"), conversationsCount));
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
		
		[Export ("new")]
		[CompilerGenerated]
		public static BrandQuery New ()
		{
			return  Runtime.GetNSObject<BrandQuery> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("new")));
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
		public virtual string BrandID {
			[Export ("getBrandID")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getBrandID")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getBrandID")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual LPCampaignInfo CampaignInfo {
			[Export ("getCampaignInfo")]
			get {
				LPCampaignInfo ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<LPCampaignInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getCampaignInfo")));
				} else {
					ret =  Runtime.GetNSObject<LPCampaignInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getCampaignInfo")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual LPConversationEntity[] ClosedConversations {
			[Export ("getClosedConversations")]
			get {
				LPConversationEntity[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<LPConversationEntity>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getClosedConversations")));
				} else {
					ret = NSArray.ArrayFromHandle<LPConversationEntity>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getClosedConversations")));
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
		public virtual LPConversationEntity OpenConversation {
			[Export ("getOpenConversation")]
			get {
				LPConversationEntity ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<LPConversationEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getOpenConversation")));
				} else {
					ret =  Runtime.GetNSObject<LPConversationEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getOpenConversation")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSDictionary<NSString, NSObject> QueryProperties {
			[Export ("getQueryProperties")]
			get {
				NSDictionary<NSString, NSObject> ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getQueryProperties")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getQueryProperties")));
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
		
	} /* class BrandQuery */
}
