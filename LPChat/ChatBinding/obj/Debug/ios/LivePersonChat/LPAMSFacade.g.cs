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
	[Register("LPAMSFacade", true)]
	public unsafe partial class LPAMSFacade : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("LPAMSFacade");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected LPAMSFacade (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LPAMSFacade (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("acceptRing:agentToken:completion:failure:")]
		[CompilerGenerated]
		public unsafe static void AcceptRing (Ring ring, string agentToken, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<LPConversationEntity> completion, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSError> failure)
		{
			if (ring == null)
				throw new ArgumentNullException ("ring");
			if (agentToken == null)
				throw new ArgumentNullException ("agentToken");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			var nsagentToken = NSString.CreateNative (agentToken);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V2.Handler, completion);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, failure);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("acceptRing:agentToken:completion:failure:"), ring.Handle, nsagentToken, (IntPtr) block_ptr_completion, (IntPtr) block_ptr_failure);
			NSString.ReleaseNative (nsagentToken);
			block_ptr_completion->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("agentNameUIRepresentation:")]
		[CompilerGenerated]
		public static string AgentNameUIRepresentation (LPConversationEntity conversation)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("agentNameUIRepresentation:"), conversation == null ? IntPtr.Zero : conversation.Handle));
		}
		
		[Export ("agentRequestConversation:context:ttrDefName:channelType:consumerId:completion:failure:")]
		[CompilerGenerated]
		public unsafe static void AgentRequestConversation (ConversationParamProtocol conversationQuery, NSDictionary<NSString, NSString> context, string ttrDefName, string channelType, string consumerId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSError> failure)
		{
			if (conversationQuery == null)
				throw new ArgumentNullException ("conversationQuery");
			if (context == null)
				throw new ArgumentNullException ("context");
			if (ttrDefName == null)
				throw new ArgumentNullException ("ttrDefName");
			if (channelType == null)
				throw new ArgumentNullException ("channelType");
			if (consumerId == null)
				throw new ArgumentNullException ("consumerId");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			var nsttrDefName = NSString.CreateNative (ttrDefName);
			var nschannelType = NSString.CreateNative (channelType);
			var nsconsumerId = NSString.CreateNative (consumerId);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDAction.Handler, completion);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, failure);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("agentRequestConversation:context:ttrDefName:channelType:consumerId:completion:failure:"), conversationQuery.Handle, context.Handle, nsttrDefName, nschannelType, nsconsumerId, (IntPtr) block_ptr_completion, (IntPtr) block_ptr_failure);
			NSString.ReleaseNative (nsttrDefName);
			NSString.ReleaseNative (nschannelType);
			NSString.ReleaseNative (nsconsumerId);
			block_ptr_completion->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("backToQueue:conversation:completion:failure:")]
		[CompilerGenerated]
		public unsafe static void BackToQueue (string userID, LPConversationEntity conversation, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSError> failure)
		{
			if (userID == null)
				throw new ArgumentNullException ("userID");
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			var nsuserID = NSString.CreateNative (userID);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDAction.Handler, completion);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, failure);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("backToQueue:conversation:completion:failure:"), nsuserID, conversation.Handle, (IntPtr) block_ptr_completion, (IntPtr) block_ptr_failure);
			NSString.ReleaseNative (nsuserID);
			block_ptr_completion->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("changeUrgentState:isUrgent:")]
		[CompilerGenerated]
		public static void ChangeUrgentState (ConversationParamProtocol conversationQuery, bool isUrgent)
		{
			if (conversationQuery == null)
				throw new ArgumentNullException ("conversationQuery");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (class_ptr, Selector.GetHandle ("changeUrgentState:isUrgent:"), conversationQuery.Handle, isUrgent);
		}
		
		[Export ("checkActiveConversation:")]
		[CompilerGenerated]
		public static bool CheckActiveConversation (ConversationParamProtocol conversationQuery)
		{
			if (conversationQuery == null)
				throw new ArgumentNullException ("conversationQuery");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("checkActiveConversation:"), conversationQuery.Handle);
		}
		
		[Export ("clearHistory:")]
		[CompilerGenerated]
		public static bool ClearHistory (ConversationParamProtocol conversationQuery)
		{
			if (conversationQuery == null)
				throw new ArgumentNullException ("conversationQuery");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("clearHistory:"), conversationQuery.Handle);
		}
		
		[Export ("clearManagers")]
		[CompilerGenerated]
		public static void ClearManagers ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("clearManagers"));
		}
		
		[Export ("connectToSocket:readyCompletion:")]
		[CompilerGenerated]
		public unsafe static void ConnectToSocket (ConversationParamProtocol conversationQuery, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action readyCompletion)
		{
			if (conversationQuery == null)
				throw new ArgumentNullException ("conversationQuery");
			BlockLiteral *block_ptr_readyCompletion;
			BlockLiteral block_readyCompletion;
			if (readyCompletion == null){
				block_ptr_readyCompletion = null;
			} else {
				block_readyCompletion = new BlockLiteral ();
				block_ptr_readyCompletion = &block_readyCompletion;
				block_readyCompletion.SetupBlockUnsafe (Trampolines.SDAction.Handler, readyCompletion);
			}
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("connectToSocket:readyCompletion:"), conversationQuery.Handle, (IntPtr) block_ptr_readyCompletion);
			if (block_ptr_readyCompletion != null)
				block_ptr_readyCompletion->CleanupBlock ();
			
		}
		
		[Export ("createConversation:")]
		[CompilerGenerated]
		public static LPConversationEntity CreateConversation (LPBrandEntity brand)
		{
			if (brand == null)
				throw new ArgumentNullException ("brand");
			return  Runtime.GetNSObject<LPConversationEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("createConversation:"), brand.Handle));
		}
		
		[Export ("createMessageMaskedLocalMessage:isRealTimeMasking:")]
		[CompilerGenerated]
		public static LPMessageEntity CreateMessageMaskedLocalMessage (LPConversationEntity conversation, bool isRealTimeMasking)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			return  Runtime.GetNSObject<LPMessageEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_bool (class_ptr, Selector.GetHandle ("createMessageMaskedLocalMessage:isRealTimeMasking:"), conversation.Handle, isRealTimeMasking));
		}
		
		[Export ("createResolveLocalMessage:endTime:")]
		[CompilerGenerated]
		public static LPMessageEntity CreateResolveLocalMessage (LPConversationEntity conversation, NSDate endTime)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			if (endTime == null)
				throw new ArgumentNullException ("endTime");
			return  Runtime.GetNSObject<LPMessageEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("createResolveLocalMessage:endTime:"), conversation.Handle, endTime.Handle));
		}
		
		[Export ("createWelcomeLocalMessage:")]
		[CompilerGenerated]
		public static LPMessageEntity CreateWelcomeLocalMessage (LPConversationEntity conversation)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			return  Runtime.GetNSObject<LPMessageEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("createWelcomeLocalMessage:"), conversation.Handle));
		}
		
		[Export ("deleteOldConversations")]
		[CompilerGenerated]
		public static void DeleteOldConversations ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("deleteOldConversations"));
		}
		
		[Export ("disconnectSocket:")]
		[CompilerGenerated]
		public static void DisconnectSocket (ConversationParamProtocol conversationQuery)
		{
			if (conversationQuery == null)
				throw new ArgumentNullException ("conversationQuery");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("disconnectSocket:"), conversationQuery.Handle);
		}
		
		[Export ("downloadFileWithConversation:file:completion:failure:")]
		[CompilerGenerated]
		public unsafe static void DownloadFileWithConversation (LPConversationEntity conversation, LPFileEntity file, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V3))]global::System.Action<global::UIKit.UIImage> completion, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSError> failure)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			if (file == null)
				throw new ArgumentNullException ("file");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V3.Handler, completion);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, failure);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("downloadFileWithConversation:file:completion:failure:"), conversation.Handle, file.Handle, (IntPtr) block_ptr_completion, (IntPtr) block_ptr_failure);
			block_ptr_completion->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("getAssignedAgent:")]
		[CompilerGenerated]
		public static LPUser GetAssignedAgent (ConversationParamProtocol conversationQuery)
		{
			if (conversationQuery == null)
				throw new ArgumentNullException ("conversationQuery");
			return  Runtime.GetNSObject<LPUser> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("getAssignedAgent:"), conversationQuery.Handle));
		}
		
		[Export ("getPreparedSecureFormWebViewWithForm:")]
		[CompilerGenerated]
		public static global::WebKit.WKWebView GetPreparedSecureFormWebViewWithForm (LPFormEntity form)
		{
			if (form == null)
				throw new ArgumentNullException ("form");
			return  Runtime.GetNSObject<global::WebKit.WKWebView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("getPreparedSecureFormWebViewWithForm:"), form.Handle));
		}
		
		[Export ("hasActiveController:")]
		[CompilerGenerated]
		public static bool HasActiveController (string brandID)
		{
			if (brandID == null)
				throw new ArgumentNullException ("brandID");
			var nsbrandID = NSString.CreateNative (brandID);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("hasActiveController:"), nsbrandID);
			NSString.ReleaseNative (nsbrandID);
			
			return ret;
		}
		
		[Export ("hasSecureFormAlreadyLoadedInWebViewWithForm:")]
		[CompilerGenerated]
		public static bool HasSecureFormAlreadyLoadedInWebViewWithForm (LPFormEntity form)
		{
			if (form == null)
				throw new ArgumentNullException ("form");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("hasSecureFormAlreadyLoadedInWebViewWithForm:"), form.Handle);
		}
		
		[Export ("isBrandReady:")]
		[CompilerGenerated]
		public static bool IsBrandReady (string brandID)
		{
			if (brandID == null)
				throw new ArgumentNullException ("brandID");
			var nsbrandID = NSString.CreateNative (brandID);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("isBrandReady:"), nsbrandID);
			NSString.ReleaseNative (nsbrandID);
			
			return ret;
		}
		
		[Export ("isUrgent:")]
		[CompilerGenerated]
		public static bool IsUrgent (ConversationParamProtocol conversationQuery)
		{
			if (conversationQuery == null)
				throw new ArgumentNullException ("conversationQuery");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("isUrgent:"), conversationQuery.Handle);
		}
		
		[Export ("linkPreviewUrlFrom:")]
		[CompilerGenerated]
		public static NSUrl LinkPreviewUrlFrom (string messageContent)
		{
			if (messageContent == null)
				throw new ArgumentNullException ("messageContent");
			var nsmessageContent = NSString.CreateNative (messageContent);
			
			NSUrl ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("linkPreviewUrlFrom:"), nsmessageContent));
			NSString.ReleaseNative (nsmessageContent);
			
			return ret;
		}
		
		[Export ("new")]
		[CompilerGenerated]
		public static LPAMSFacade New ()
		{
			return  Runtime.GetNSObject<LPAMSFacade> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("new")));
		}
		
		[Export ("prepareSecureFormWithForm:completion:failure:")]
		[CompilerGenerated]
		public unsafe static void PrepareSecureFormWithForm (LPFormEntity form, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSError> failure)
		{
			if (form == null)
				throw new ArgumentNullException ("form");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDAction.Handler, completion);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, failure);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("prepareSecureFormWithForm:completion:failure:"), form.Handle, (IntPtr) block_ptr_completion, (IntPtr) block_ptr_failure);
			block_ptr_completion->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("reconnectToSocket:authenticationParams:readyCompletion:")]
		[CompilerGenerated]
		public unsafe static void ReconnectToSocket (ConversationParamProtocol conversationQuery, LPAuthenticationParams authenticationParams, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action readyCompletion)
		{
			if (conversationQuery == null)
				throw new ArgumentNullException ("conversationQuery");
			if (authenticationParams == null)
				throw new ArgumentNullException ("authenticationParams");
			BlockLiteral *block_ptr_readyCompletion;
			BlockLiteral block_readyCompletion;
			if (readyCompletion == null){
				block_ptr_readyCompletion = null;
			} else {
				block_readyCompletion = new BlockLiteral ();
				block_ptr_readyCompletion = &block_readyCompletion;
				block_readyCompletion.SetupBlockUnsafe (Trampolines.SDAction.Handler, readyCompletion);
			}
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("reconnectToSocket:authenticationParams:readyCompletion:"), conversationQuery.Handle, authenticationParams.Handle, (IntPtr) block_ptr_readyCompletion);
			if (block_ptr_readyCompletion != null)
				block_ptr_readyCompletion->CleanupBlock ();
			
		}
		
		[Export ("removeDelegate:")]
		[CompilerGenerated]
		public static void RemoveDelegate (LPAMSFacadeDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("removeDelegate:"), @delegate.Handle);
		}
		
		[Export ("requestDownloadURLWithConversation:file:completion:failure:")]
		[CompilerGenerated]
		public unsafe static void RequestDownloadURLWithConversation (LPConversationEntity conversation, LPFileEntity file, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V4))]global::System.Action<RequestSwiftURL> completion, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSError> failure)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			if (file == null)
				throw new ArgumentNullException ("file");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V4.Handler, completion);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, failure);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("requestDownloadURLWithConversation:file:completion:failure:"), conversation.Handle, file.Handle, (IntPtr) block_ptr_completion, (IntPtr) block_ptr_failure);
			block_ptr_completion->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("requestUploadURLWithConversation:fileSize:fileExtention:completion:failure:")]
		[CompilerGenerated]
		public unsafe static void RequestUploadURLWithConversation (LPConversationEntity conversation, double fileSize, string fileExtention, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V4))]global::System.Action<RequestSwiftURL> completion, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSError> failure)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			if (fileExtention == null)
				throw new ArgumentNullException ("fileExtention");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			var nsfileExtention = NSString.CreateNative (fileExtention);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V4.Handler, completion);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, failure);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Double_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("requestUploadURLWithConversation:fileSize:fileExtention:completion:failure:"), conversation.Handle, fileSize, nsfileExtention, (IntPtr) block_ptr_completion, (IntPtr) block_ptr_failure);
			NSString.ReleaseNative (nsfileExtention);
			block_ptr_completion->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("requestUrgentResponse:urgent:")]
		[CompilerGenerated]
		public static bool RequestUrgentResponse (LPConversationEntity conversation, bool urgent)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool (class_ptr, Selector.GetHandle ("requestUrgentResponse:urgent:"), conversation.Handle, urgent);
		}
		
		[Export ("resolveConversation:")]
		[CompilerGenerated]
		public static void ResolveConversation (LPConversationEntity conversation)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("resolveConversation:"), conversation.Handle);
		}
		
		[Export ("resolveConversationForConversationQuery:")]
		[CompilerGenerated]
		public static void ResolveConversationForConversationQuery (ConversationParamProtocol conversationQuery)
		{
			if (conversationQuery == null)
				throw new ArgumentNullException ("conversationQuery");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("resolveConversationForConversationQuery:"), conversationQuery.Handle);
		}
		
		[Export ("retrieveNewMessagesForConversation:completion:failure:")]
		[CompilerGenerated]
		public unsafe static void RetrieveNewMessagesForConversation (LPConversationEntity conversation, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSArray> completion, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSError> failure)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V0.Handler, completion);
			}
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			if (failure == null){
				block_ptr_failure = null;
			} else {
				block_failure = new BlockLiteral ();
				block_ptr_failure = &block_failure;
				block_failure.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, failure);
			}
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("retrieveNewMessagesForConversation:completion:failure:"), conversation.Handle, (IntPtr) block_ptr_completion, (IntPtr) block_ptr_failure);
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			if (block_ptr_failure != null)
				block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("sendCSAT:csat:")]
		[CompilerGenerated]
		public static void SendCSAT (LPConversationEntity conversation, CSATModel csat)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			if (csat == null)
				throw new ArgumentNullException ("csat");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("sendCSAT:csat:"), conversation.Handle, csat.Handle);
		}
		
		[Export ("sendMessageInConversation:message:completion:failure:")]
		[CompilerGenerated]
		public unsafe static void SendMessageInConversation (LPConversationEntity conversation, LPMessageEntity message, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V5))]global::System.Action<LPMessageEntity> completion, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSError> failure)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			if (message == null)
				throw new ArgumentNullException ("message");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V5.Handler, completion);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, failure);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("sendMessageInConversation:message:completion:failure:"), conversation.Handle, message.Handle, (IntPtr) block_ptr_completion, (IntPtr) block_ptr_failure);
			block_ptr_completion->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("sendMessageInConversation:text:completion:failure:")]
		[CompilerGenerated]
		public unsafe static void SendMessageInConversation (LPConversationEntity conversation, string text, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V5))]global::System.Action<LPMessageEntity> completion, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSError> failure)
		{
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			if (text == null)
				throw new ArgumentNullException ("text");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			var nstext = NSString.CreateNative (text);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V5.Handler, completion);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, failure);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("sendMessageInConversation:text:completion:failure:"), conversation.Handle, nstext, (IntPtr) block_ptr_completion, (IntPtr) block_ptr_failure);
			NSString.ReleaseNative (nstext);
			block_ptr_completion->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("setAgentState:agentID:channels:availability:description:")]
		[CompilerGenerated]
		public static void SetAgentState (ConversationParamProtocol conversationQuery, string agentID, string[] channels, string availability, string description)
		{
			if (conversationQuery == null)
				throw new ArgumentNullException ("conversationQuery");
			if (agentID == null)
				throw new ArgumentNullException ("agentID");
			if (availability == null)
				throw new ArgumentNullException ("availability");
			if (description == null)
				throw new ArgumentNullException ("description");
			var nsagentID = NSString.CreateNative (agentID);
			var nsa_channels = channels == null ? null : NSArray.FromStrings (channels);
			var nsavailability = NSString.CreateNative (availability);
			var nsdescription = NSString.CreateNative (description);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("setAgentState:agentID:channels:availability:description:"), conversationQuery.Handle, nsagentID, nsa_channels == null ? IntPtr.Zero : nsa_channels.Handle, nsavailability, nsdescription);
			NSString.ReleaseNative (nsagentID);
			if (nsa_channels != null)
				nsa_channels.Dispose ();
			NSString.ReleaseNative (nsavailability);
			NSString.ReleaseNative (nsdescription);
			
		}
		
		[Export ("setDelegate:")]
		[CompilerGenerated]
		public static void SetDelegate (LPAMSFacadeDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setDelegate:"), @delegate.Handle);
		}
		
		[Export ("subscribeAgentState:agentID:")]
		[CompilerGenerated]
		public static void SubscribeAgentState (ConversationParamProtocol conversationQuery, string agentID)
		{
			if (conversationQuery == null)
				throw new ArgumentNullException ("conversationQuery");
			if (agentID == null)
				throw new ArgumentNullException ("agentID");
			var nsagentID = NSString.CreateNative (agentID);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("subscribeAgentState:agentID:"), conversationQuery.Handle, nsagentID);
			NSString.ReleaseNative (nsagentID);
			
		}
		
		[Export ("subscribeConversationNotifications:userID:socketType:completion:failure:")]
		[CompilerGenerated]
		public unsafe static void SubscribeConversationNotifications (string brandID, string userID, SocketType socketType, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V6))]global::System.Action<NSString> completion, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSError> failure)
		{
			if (brandID == null)
				throw new ArgumentNullException ("brandID");
			if (userID == null)
				throw new ArgumentNullException ("userID");
			var nsbrandID = NSString.CreateNative (brandID);
			var nsuserID = NSString.CreateNative (userID);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V6.Handler, completion);
			}
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			if (failure == null){
				block_ptr_failure = null;
			} else {
				block_failure = new BlockLiteral ();
				block_ptr_failure = &block_failure;
				block_failure.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, failure);
			}
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("subscribeConversationNotifications:userID:socketType:completion:failure:"), nsbrandID, nsuserID, (int)socketType, (IntPtr) block_ptr_completion, (IntPtr) block_ptr_failure);
			NSString.ReleaseNative (nsbrandID);
			NSString.ReleaseNative (nsuserID);
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			if (block_ptr_failure != null)
				block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("subscribeRoutingTasks:agentID:completion:failure:")]
		[CompilerGenerated]
		public unsafe static void SubscribeRoutingTasks (string brandID, string agentID, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V6))]global::System.Action<NSString> completion, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSError> failure)
		{
			if (brandID == null)
				throw new ArgumentNullException ("brandID");
			if (agentID == null)
				throw new ArgumentNullException ("agentID");
			var nsbrandID = NSString.CreateNative (brandID);
			var nsagentID = NSString.CreateNative (agentID);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V6.Handler, completion);
			}
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			if (failure == null){
				block_ptr_failure = null;
			} else {
				block_failure = new BlockLiteral ();
				block_ptr_failure = &block_failure;
				block_failure.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, failure);
			}
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("subscribeRoutingTasks:agentID:completion:failure:"), nsbrandID, nsagentID, (IntPtr) block_ptr_completion, (IntPtr) block_ptr_failure);
			NSString.ReleaseNative (nsbrandID);
			NSString.ReleaseNative (nsagentID);
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			if (block_ptr_failure != null)
				block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("unsubscribeConversationNotifications:subscriptionID:")]
		[CompilerGenerated]
		public static void UnsubscribeConversationNotifications (string brandID, string subscriptionID)
		{
			if (brandID == null)
				throw new ArgumentNullException ("brandID");
			if (subscriptionID == null)
				throw new ArgumentNullException ("subscriptionID");
			var nsbrandID = NSString.CreateNative (brandID);
			var nssubscriptionID = NSString.CreateNative (subscriptionID);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("unsubscribeConversationNotifications:subscriptionID:"), nsbrandID, nssubscriptionID);
			NSString.ReleaseNative (nsbrandID);
			NSString.ReleaseNative (nssubscriptionID);
			
		}
		
		[Export ("uploadFileFromDiskWithMessage:conversation:completion:failure:")]
		[CompilerGenerated]
		public unsafe static void UploadFileFromDiskWithMessage (LPMessageEntity message, LPConversationEntity conversation, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSError> failure)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDAction.Handler, completion);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, failure);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("uploadFileFromDiskWithMessage:conversation:completion:failure:"), message.Handle, conversation.Handle, (IntPtr) block_ptr_completion, (IntPtr) block_ptr_failure);
			block_ptr_completion->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("uploadFileFromImageInfoWithImageInfo:caption:conversation:completion:failure:")]
		[CompilerGenerated]
		public unsafe static void UploadFileFromImageInfoWithImageInfo (NSDictionary<NSString, NSObject> imageInfo, string caption, LPConversationEntity conversation, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSError> failure)
		{
			if (imageInfo == null)
				throw new ArgumentNullException ("imageInfo");
			if (caption == null)
				throw new ArgumentNullException ("caption");
			if (conversation == null)
				throw new ArgumentNullException ("conversation");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			var nscaption = NSString.CreateNative (caption);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDAction.Handler, completion);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, failure);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("uploadFileFromImageInfoWithImageInfo:caption:conversation:completion:failure:"), imageInfo.Handle, nscaption, conversation.Handle, (IntPtr) block_ptr_completion, (IntPtr) block_ptr_failure);
			NSString.ReleaseNative (nscaption);
			block_ptr_completion->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public static string[] AllConsumersID {
			[Export ("getAllConsumersID")]
			get {
				return NSArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getAllConsumersID")));
			}
			
		}
		
		[CompilerGenerated]
		public static string ClientPropertiesString {
			[Export ("clientPropertiesString")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("clientPropertiesString")));
			}
			
		}
		
		[CompilerGenerated]
		public static bool DidFetchHistoryMessagingEventNotifications {
			[Export ("didFetchHistoryMessagingEventNotifications")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("didFetchHistoryMessagingEventNotifications"));
			}
			
		}
		
		[CompilerGenerated]
		public static bool InitializeAMS {
			[Export ("initializeAMS")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("initializeAMS"));
			}
			
		}
		
		[CompilerGenerated]
		public static bool IsFetchingHistoryMessages {
			[Export ("isFetchingHistoryMessages")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isFetchingHistoryMessages"));
			}
			
		}
		
		[CompilerGenerated]
		public static LPMessageEntity[] LatestUnreadMessages {
			[Export ("getLatestUnreadMessages")]
			get {
				LPMessageEntity[] ret;
				ret = NSArray.ArrayFromHandle<LPMessageEntity>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getLatestUnreadMessages")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static LPLinkPreviewEntity[] LoadingStructuredContentCustomItems {
			[Export ("getLoadingStructuredContentCustomItems")]
			get {
				LPLinkPreviewEntity[] ret;
				ret = NSArray.ArrayFromHandle<LPLinkPreviewEntity>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getLoadingStructuredContentCustomItems")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static LPMessageEntity[] LoadingStructuredContentMessages {
			[Export ("getLoadingStructuredContentMessages")]
			get {
				LPMessageEntity[] ret;
				ret = NSArray.ArrayFromHandle<LPMessageEntity>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getLoadingStructuredContentMessages")));
				return ret;
			}
			
		}
		
	} /* class LPAMSFacade */
}
