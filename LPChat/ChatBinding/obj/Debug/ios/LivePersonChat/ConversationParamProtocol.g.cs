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
	[Protocol (Name = "ConversationParamProtocol", WrapperType = typeof (ConversationParamProtocolWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetConversations", Selector = "getConversations:", ReturnType = typeof (LivePersonChat.LPConversationEntity[]), ParameterType = new Type [] { typeof (NSPredicate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetLatestClosedConversation", Selector = "getLatestClosedConversation:", ReturnType = typeof (LivePersonChat.LPConversationEntity[]), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "IsConversationRelatedToQuery", Selector = "isConversationRelatedToQuery:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (LivePersonChat.LPConversationEntity) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Conversations", Selector = "getConversations", PropertyType = typeof (LivePersonChat.LPConversationEntity[]), GetterSelector = "getConversations", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ClosedConversations", Selector = "getClosedConversations", PropertyType = typeof (LivePersonChat.LPConversationEntity[]), GetterSelector = "getClosedConversations", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ActiveConversation", Selector = "getActiveConversation", PropertyType = typeof (LivePersonChat.LPConversationEntity), GetterSelector = "getActiveConversation", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "OpenConversation", Selector = "getOpenConversation", PropertyType = typeof (LivePersonChat.LPConversationEntity), GetterSelector = "getOpenConversation", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CreateNewConversation", Selector = "createNewConversation", PropertyType = typeof (LivePersonChat.LPConversationEntity), GetterSelector = "createNewConversation", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "QueryType", Selector = "getQueryType", PropertyType = typeof (string), GetterSelector = "getQueryType", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "BrandID", Selector = "getBrandID", PropertyType = typeof (string), GetterSelector = "getBrandID", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "QueryUID", Selector = "getQueryUID", PropertyType = typeof (string), GetterSelector = "getQueryUID", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "QueryProperties", Selector = "getQueryProperties", PropertyType = typeof (global::Foundation.NSDictionary<NSString, NSObject>), GetterSelector = "getQueryProperties", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IConversationParamProtocol : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("getConversations:")]
		[Preserve (Conditional = true)]
		LPConversationEntity[] GetConversations (NSPredicate predicate);
		
		[CompilerGenerated]
		[Export ("getLatestClosedConversation:")]
		[Preserve (Conditional = true)]
		LPConversationEntity[] GetLatestClosedConversation (nint conversationsCount);
		
		[CompilerGenerated]
		[Export ("isConversationRelatedToQuery:")]
		[Preserve (Conditional = true)]
		bool IsConversationRelatedToQuery (LPConversationEntity conversation);
		
		[Preserve (Conditional = true)]
		LPConversationEntity[] Conversations {
			[Export ("getConversations")]
			get;
		}
		
		[Preserve (Conditional = true)]
		LPConversationEntity[] ClosedConversations {
			[Export ("getClosedConversations")]
			get;
		}
		
		[Preserve (Conditional = true)]
		LPConversationEntity ActiveConversation {
			[Export ("getActiveConversation")]
			get;
		}
		
		[Preserve (Conditional = true)]
		LPConversationEntity OpenConversation {
			[Export ("getOpenConversation")]
			get;
		}
		
		[Preserve (Conditional = true)]
		LPConversationEntity CreateNewConversation {
			[Export ("createNewConversation")]
			get;
		}
		
		[Preserve (Conditional = true)]
		string QueryType {
			[Export ("getQueryType")]
			get;
		}
		
		[Preserve (Conditional = true)]
		string BrandID {
			[Export ("getBrandID")]
			get;
		}
		
		[Preserve (Conditional = true)]
		string QueryUID {
			[Export ("getQueryUID")]
			get;
		}
		
		[Preserve (Conditional = true)]
		NSDictionary<NSString, NSObject> QueryProperties {
			[Export ("getQueryProperties")]
			get;
		}
		
	}
	
	internal sealed class ConversationParamProtocolWrapper : BaseWrapper, IConversationParamProtocol {
		[Preserve (Conditional = true)]
		public ConversationParamProtocolWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("getConversations:")]
		[CompilerGenerated]
		public LPConversationEntity[] GetConversations (NSPredicate predicate)
		{
			return NSArray.ArrayFromHandle<LPConversationEntity>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("getConversations:"), predicate == null ? IntPtr.Zero : predicate.Handle));
		}
		
		[Export ("getLatestClosedConversation:")]
		[CompilerGenerated]
		public LPConversationEntity[] GetLatestClosedConversation (nint conversationsCount)
		{
			return NSArray.ArrayFromHandle<LPConversationEntity>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nint (this.Handle, Selector.GetHandle ("getLatestClosedConversation:"), conversationsCount));
		}
		
		[Export ("isConversationRelatedToQuery:")]
		[CompilerGenerated]
		public bool IsConversationRelatedToQuery (LPConversationEntity conversation)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isConversationRelatedToQuery:"), conversation.Handle);
		}
		
		[CompilerGenerated]
		public LPConversationEntity[] Conversations {
			[Export ("getConversations")]
			get {
				return NSArray.ArrayFromHandle<LPConversationEntity>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getConversations")));
			}
			
		}
		
		[CompilerGenerated]
		public LPConversationEntity[] ClosedConversations {
			[Export ("getClosedConversations")]
			get {
				return NSArray.ArrayFromHandle<LPConversationEntity>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getClosedConversations")));
			}
			
		}
		
		[CompilerGenerated]
		public LPConversationEntity ActiveConversation {
			[Export ("getActiveConversation")]
			get {
				return  Runtime.GetNSObject<LPConversationEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getActiveConversation")));
			}
			
		}
		
		[CompilerGenerated]
		public LPConversationEntity OpenConversation {
			[Export ("getOpenConversation")]
			get {
				return  Runtime.GetNSObject<LPConversationEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getOpenConversation")));
			}
			
		}
		
		[CompilerGenerated]
		public LPConversationEntity CreateNewConversation {
			[Export ("createNewConversation")]
			get {
				return  Runtime.GetNSObject<LPConversationEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("createNewConversation")));
			}
			
		}
		
		[CompilerGenerated]
		public string QueryType {
			[Export ("getQueryType")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getQueryType")));
			}
			
		}
		
		[CompilerGenerated]
		public string BrandID {
			[Export ("getBrandID")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getBrandID")));
			}
			
		}
		
		[CompilerGenerated]
		public string QueryUID {
			[Export ("getQueryUID")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getQueryUID")));
			}
			
		}
		
		[CompilerGenerated]
		public NSDictionary<NSString, NSObject> QueryProperties {
			[Export ("getQueryProperties")]
			get {
				return  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getQueryProperties")));
			}
			
		}
		
	}
}
