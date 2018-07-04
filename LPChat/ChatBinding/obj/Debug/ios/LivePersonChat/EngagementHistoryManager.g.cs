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
	[Register("EngagementHistoryManager", true)]
	public unsafe partial class EngagementHistoryManager : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("EngagementHistoryManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public EngagementHistoryManager () : base (NSObjectFlag.Empty)
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
		protected EngagementHistoryManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal EngagementHistoryManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("getConsumerMessagesForConversationWithRequest:completion:failure:")]
		[CompilerGenerated]
		public unsafe static void GetConsumerMessagesForConversationWithRequest (EngagementHistoryRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSArray> completion, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSError> failure)
		{
			if (request == null)
				throw new ArgumentNullException ("request");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V0.Handler, completion);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, failure);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("getConsumerMessagesForConversationWithRequest:completion:failure:"), request.Handle, (IntPtr) block_ptr_completion, (IntPtr) block_ptr_failure);
			block_ptr_completion->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("handleConsumerMessagesResponse:")]
		[CompilerGenerated]
		public static LPMessageEntity[] HandleConsumerMessagesResponse (EngagementHistoryConsumerMessagesResponse response)
		{
			if (response == null)
				throw new ArgumentNullException ("response");
			return NSArray.ArrayFromHandle<LPMessageEntity>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("handleConsumerMessagesResponse:"), response.Handle));
		}
		
	} /* class EngagementHistoryManager */
}
