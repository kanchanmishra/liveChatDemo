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
	[Protocol (Name = "LPAMSFacadeDelegate", WrapperType = typeof (LPAMSFacadeDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConversationDidResolve", Selector = "conversationDidResolve:isAgentSide:endTime:", ParameterType = new Type [] { typeof (LivePersonChat.LPConversationEntity), typeof (bool), typeof (NSDate) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConversationWasSentToQueueRemotely", Selector = "conversationWasSentToQueueRemotely:", ParameterType = new Type [] { typeof (LivePersonChat.LPConversationEntity) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RetrieveHistoryMessagingEventNotificationsDidProgressWithConversationQuery", Selector = "retrieveHistoryMessagingEventNotificationsDidProgressWithConversationQuery:completed:total:", ParameterType = new Type [] { typeof (LivePersonChat.ConversationParamProtocol), typeof (nint), typeof (nint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RetrieveHistoryEngagementHistoryDidProgressWithConversationQuery", Selector = "retrieveHistoryEngagementHistoryDidProgressWithConversationQuery:completed:total:", ParameterType = new Type [] { typeof (LivePersonChat.ConversationParamProtocol), typeof (nint), typeof (nint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RetrieveHistoryMessagingEventNotificationStateDidChangeWithConversationQuery", Selector = "retrieveHistoryMessagingEventNotificationStateDidChangeWithConversationQuery:isFinished:fetchedConversationCount:fetchedMessages:increaseNumberOfPresentedConversationsBy:", ParameterType = new Type [] { typeof (LivePersonChat.ConversationParamProtocol), typeof (bool), typeof (nint), typeof (LivePersonChat.LPMessageEntity[]), typeof (nint) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSendMessages", Selector = "didSendMessages:messages:", ParameterType = new Type [] { typeof (LivePersonChat.LPConversationEntity), typeof (LivePersonChat.LPMessageEntity[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillReceiveMessages", Selector = "willReceiveMessages")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveMessages", Selector = "didReceiveMessages:messages:", ParameterType = new Type [] { typeof (LivePersonChat.LPConversationEntity), typeof (LivePersonChat.LPMessageEntity[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveConvesationDidFail", Selector = "resolveConvesationDidFail:error:", ParameterType = new Type [] { typeof (LivePersonChat.LPConversationEntity), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveConvesationRequestDidFinish", Selector = "resolveConvesationRequestDidFinish:", ParameterType = new Type [] { typeof (LivePersonChat.LPConversationEntity) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "NewConversationCreated", Selector = "newConversationCreated:", ParameterType = new Type [] { typeof (LivePersonChat.LPConversationEntity) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UrgentRequestDidFinish", Selector = "urgentRequestDidFinish:", ParameterType = new Type [] { typeof (LivePersonChat.LPConversationEntity) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UrgentRequestDidFail", Selector = "urgentRequestDidFail:error:", ParameterType = new Type [] { typeof (LivePersonChat.LPConversationEntity), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ChatStateDidChange", Selector = "chatStateDidChange:state:userID:", ParameterType = new Type [] { typeof (LivePersonChat.LPConversationEntity), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MessagesStatusDidChange", Selector = "messagesStatusDidChange:messages:", ParameterType = new Type [] { typeof (LivePersonChat.LPConversationEntity), typeof (LivePersonChat.LPMessageEntity[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConversationInitializedOnAMS", Selector = "conversationInitializedOnAMS:", ParameterType = new Type [] { typeof (LivePersonChat.LPConversationEntity) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveTTRUpdate", Selector = "didReceiveTTRUpdate:ttr:", ParameterType = new Type [] { typeof (LivePersonChat.LPConversationEntity), typeof (LivePersonChat.TTRModel) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateUserProfile", Selector = "didUpdateUserProfile:userID:", ParameterType = new Type [] { typeof (LivePersonChat.LPConversationEntity), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CsatScoreSubmissionDidFinish", Selector = "csatScoreSubmissionDidFinish:csat:", ParameterType = new Type [] { typeof (LivePersonChat.LPConversationEntity), typeof (LivePersonChat.CSATModel) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CsatScoreSubmissionDidFail", Selector = "csatScoreSubmissionDidFail:error:", ParameterType = new Type [] { typeof (LivePersonChat.LPConversationEntity), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsConversationViewControllerPresentedWithForceTopConversation", Selector = "isConversationViewControllerPresentedWithForceTopConversation:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SdkFeatureToggledWithFeature", Selector = "sdkFeatureToggledWithFeature:toggle:", ParameterType = new Type [] { typeof (LivePersonChat.LPMessagingSDKFeature), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HistoryCleared", Selector = "historyCleared")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveRingUpdate", Selector = "didReceiveRingUpdate:ring:", ParameterType = new Type [] { typeof (string), typeof (LivePersonChat.Ring) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAcceptRingWithConversation", Selector = "didAcceptRingWithConversation:connection:", ParameterType = new Type [] { typeof (LivePersonChat.LPConversationEntity), typeof (LivePersonChat.LPConnection) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AgentStateDidChange", Selector = "agentStateDidChange:state:", ParameterType = new Type [] { typeof (LivePersonChat.LPUserEntity), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "BrandAccountID", Selector = "brandAccountID", PropertyType = typeof (string), GetterSelector = "brandAccountID", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "CurrentConversationQuery", Selector = "getCurrentConversationQuery", PropertyType = typeof (LivePersonChat.ConversationParamProtocol), GetterSelector = "getCurrentConversationQuery", ArgumentSemantic = ArgumentSemantic.None)]
	public interface ILPAMSFacadeDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class LPAMSFacadeDelegate_Extensions {
		[CompilerGenerated]
		public static void ConversationDidResolve (this ILPAMSFacadeDelegate This, LPConversationEntity conversation, bool isAgentSide, NSDate endTime)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool_IntPtr (This.Handle, Selector.GetHandle ("conversationDidResolve:isAgentSide:endTime:"), conversation.Handle, isAgentSide, endTime == null ? IntPtr.Zero : endTime.Handle);
		}
		
		[CompilerGenerated]
		public static void ConversationWasSentToQueueRemotely (this ILPAMSFacadeDelegate This, LPConversationEntity conversation)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("conversationWasSentToQueueRemotely:"), conversation.Handle);
		}
		
		[CompilerGenerated]
		public static void RetrieveHistoryMessagingEventNotificationsDidProgressWithConversationQuery (this ILPAMSFacadeDelegate This, ConversationParamProtocol conversationQuery, nint completed, nint total)
		{
			if (conversationQuery == null)
				throw new ArgumentNullException ("conversationQuery");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nint_nint (This.Handle, Selector.GetHandle ("retrieveHistoryMessagingEventNotificationsDidProgressWithConversationQuery:completed:total:"), conversationQuery.Handle, completed, total);
		}
		
		[CompilerGenerated]
		public static void RetrieveHistoryEngagementHistoryDidProgressWithConversationQuery (this ILPAMSFacadeDelegate This, ConversationParamProtocol conversationQuery, nint completed, nint total)
		{
			if (conversationQuery == null)
				throw new ArgumentNullException ("conversationQuery");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nint_nint (This.Handle, Selector.GetHandle ("retrieveHistoryEngagementHistoryDidProgressWithConversationQuery:completed:total:"), conversationQuery.Handle, completed, total);
		}
		
		[CompilerGenerated]
		public static void RetrieveHistoryMessagingEventNotificationStateDidChangeWithConversationQuery (this ILPAMSFacadeDelegate This, ConversationParamProtocol conversationQuery, bool isFinished, nint fetchedConversationCount, LPMessageEntity[] fetchedMessages, nint increaseNumberOfPresentedConversationsBy)
		{
			if (conversationQuery == null)
				throw new ArgumentNullException ("conversationQuery");
			var nsa_fetchedMessages = fetchedMessages == null ? null : NSArray.FromNSObjects (fetchedMessages);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool_nint_IntPtr_nint (This.Handle, Selector.GetHandle ("retrieveHistoryMessagingEventNotificationStateDidChangeWithConversationQuery:isFinished:fetchedConversationCount:fetchedMessages:increaseNumberOfPresentedConversationsBy:"), conversationQuery.Handle, isFinished, fetchedConversationCount, nsa_fetchedMessages == null ? IntPtr.Zero : nsa_fetchedMessages.Handle, increaseNumberOfPresentedConversationsBy);
			if (nsa_fetchedMessages != null)
				nsa_fetchedMessages.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static void DidSendMessages (this ILPAMSFacadeDelegate This, LPConversationEntity conversation, LPMessageEntity[] messages)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			if (messages == null)
				throw new ArgumentNullException ("messages");
			var nsa_messages = NSArray.FromNSObjects (messages);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("didSendMessages:messages:"), conversation.Handle, nsa_messages.Handle);
			nsa_messages.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static void WillReceiveMessages (this ILPAMSFacadeDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("willReceiveMessages"));
		}
		
		[CompilerGenerated]
		public static void DidReceiveMessages (this ILPAMSFacadeDelegate This, LPConversationEntity conversation, LPMessageEntity[] messages)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			if (messages == null)
				throw new ArgumentNullException ("messages");
			var nsa_messages = NSArray.FromNSObjects (messages);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("didReceiveMessages:messages:"), conversation.Handle, nsa_messages.Handle);
			nsa_messages.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static void ResolveConvesationDidFail (this ILPAMSFacadeDelegate This, LPConversationEntity conversation, NSError error)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("resolveConvesationDidFail:error:"), conversation.Handle, error.Handle);
		}
		
		[CompilerGenerated]
		public static void ResolveConvesationRequestDidFinish (this ILPAMSFacadeDelegate This, LPConversationEntity conversation)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("resolveConvesationRequestDidFinish:"), conversation.Handle);
		}
		
		[CompilerGenerated]
		public static void NewConversationCreated (this ILPAMSFacadeDelegate This, LPConversationEntity conversation)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("newConversationCreated:"), conversation.Handle);
		}
		
		[CompilerGenerated]
		public static void UrgentRequestDidFinish (this ILPAMSFacadeDelegate This, LPConversationEntity conversation)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("urgentRequestDidFinish:"), conversation.Handle);
		}
		
		[CompilerGenerated]
		public static void UrgentRequestDidFail (this ILPAMSFacadeDelegate This, LPConversationEntity conversation, NSError error)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("urgentRequestDidFail:error:"), conversation.Handle, error.Handle);
		}
		
		[CompilerGenerated]
		public static void ChatStateDidChange (this ILPAMSFacadeDelegate This, LPConversationEntity conversation, string state, string userID)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			if (state == null)
				throw new ArgumentNullException ("state");
			if (userID == null)
				throw new ArgumentNullException ("userID");
			var nsstate = NSString.CreateNative (state);
			var nsuserID = NSString.CreateNative (userID);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("chatStateDidChange:state:userID:"), conversation.Handle, nsstate, nsuserID);
			NSString.ReleaseNative (nsstate);
			NSString.ReleaseNative (nsuserID);
			
		}
		
		[CompilerGenerated]
		public static void MessagesStatusDidChange (this ILPAMSFacadeDelegate This, LPConversationEntity conversation, LPMessageEntity[] messages)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			if (messages == null)
				throw new ArgumentNullException ("messages");
			var nsa_messages = NSArray.FromNSObjects (messages);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("messagesStatusDidChange:messages:"), conversation.Handle, nsa_messages.Handle);
			nsa_messages.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static void ConversationInitializedOnAMS (this ILPAMSFacadeDelegate This, LPConversationEntity conversation)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("conversationInitializedOnAMS:"), conversation.Handle);
		}
		
		[CompilerGenerated]
		public static void DidReceiveTTRUpdate (this ILPAMSFacadeDelegate This, LPConversationEntity conversation, TTRModel ttr)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			if (ttr == null)
				throw new ArgumentNullException ("ttr");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("didReceiveTTRUpdate:ttr:"), conversation.Handle, ttr.Handle);
		}
		
		[CompilerGenerated]
		public static void DidUpdateUserProfile (this ILPAMSFacadeDelegate This, LPConversationEntity conversation, string userID)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			if (userID == null)
				throw new ArgumentNullException ("userID");
			var nsuserID = NSString.CreateNative (userID);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("didUpdateUserProfile:userID:"), conversation.Handle, nsuserID);
			NSString.ReleaseNative (nsuserID);
			
		}
		
		[CompilerGenerated]
		public static void CsatScoreSubmissionDidFinish (this ILPAMSFacadeDelegate This, LPConversationEntity conversation, CSATModel csat)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			if (csat == null)
				throw new ArgumentNullException ("csat");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("csatScoreSubmissionDidFinish:csat:"), conversation.Handle, csat.Handle);
		}
		
		[CompilerGenerated]
		public static void CsatScoreSubmissionDidFail (this ILPAMSFacadeDelegate This, LPConversationEntity conversation, NSError error)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("csatScoreSubmissionDidFail:error:"), conversation.Handle, error.Handle);
		}
		
		[CompilerGenerated]
		public static bool IsConversationViewControllerPresentedWithForceTopConversation (this ILPAMSFacadeDelegate This, bool forceTopConversation)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (This.Handle, Selector.GetHandle ("isConversationViewControllerPresentedWithForceTopConversation:"), forceTopConversation);
		}
		
		[CompilerGenerated]
		public static void SdkFeatureToggledWithFeature (this ILPAMSFacadeDelegate This, LPMessagingSDKFeature feature, bool toggle)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_int_bool (This.Handle, Selector.GetHandle ("sdkFeatureToggledWithFeature:toggle:"), (int)feature, toggle);
		}
		
		[CompilerGenerated]
		public static void HistoryCleared (this ILPAMSFacadeDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("historyCleared"));
		}
		
		[CompilerGenerated]
		public static void DidReceiveRingUpdate (this ILPAMSFacadeDelegate This, string conversationID, Ring ring)
		{
			if (conversationID == null)
				throw new ArgumentNullException ("conversationID");
			if (ring == null)
				throw new ArgumentNullException ("ring");
			var nsconversationID = NSString.CreateNative (conversationID);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("didReceiveRingUpdate:ring:"), nsconversationID, ring.Handle);
			NSString.ReleaseNative (nsconversationID);
			
		}
		
		[CompilerGenerated]
		public static void DidAcceptRingWithConversation (this ILPAMSFacadeDelegate This, LPConversationEntity conversation, LPConnection connection)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			if (connection == null)
				throw new ArgumentNullException ("connection");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("didAcceptRingWithConversation:connection:"), conversation.Handle, connection.Handle);
		}
		
		[CompilerGenerated]
		public static void AgentStateDidChange (this ILPAMSFacadeDelegate This, LPUserEntity agent, string state)
		{
			if (agent == null)
				throw new ArgumentNullException ("agent");
			if (state == null)
				throw new ArgumentNullException ("state");
			var nsstate = NSString.CreateNative (state);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("agentStateDidChange:state:"), agent.Handle, nsstate);
			NSString.ReleaseNative (nsstate);
			
		}
		
		[CompilerGenerated]
		public static string GetBrandAccountID (this ILPAMSFacadeDelegate This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("brandAccountID")));
		}
		
		[CompilerGenerated]
		public static ConversationParamProtocol GetCurrentConversationQuery (this ILPAMSFacadeDelegate This)
		{
			return  Runtime.GetNSObject<ConversationParamProtocol> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getCurrentConversationQuery")));
		}
		
	}
	
	internal sealed class LPAMSFacadeDelegateWrapper : BaseWrapper, ILPAMSFacadeDelegate {
		[Preserve (Conditional = true)]
		public LPAMSFacadeDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
