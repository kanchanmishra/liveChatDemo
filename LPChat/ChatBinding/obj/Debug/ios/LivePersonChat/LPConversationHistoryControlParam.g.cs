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
	[Register("LPConversationHistoryControlParam", true)]
	public unsafe partial class LPConversationHistoryControlParam : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("LPConversationHistoryControlParam");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected LPConversationHistoryControlParam (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LPConversationHistoryControlParam (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithHistoryConversationsStateToDisplay:historyConversationsMaxDays:historyMaxDaysType:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public LPConversationHistoryControlParam (LPConversationsHistoryStateToDisplay historyConversationsStateToDisplay, nint historyConversationsMaxDays, LPConversationHistoryMaxDaysDateType historyMaxDaysType)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int_nint_int (this.Handle, Selector.GetHandle ("initWithHistoryConversationsStateToDisplay:historyConversationsMaxDays:historyMaxDaysType:"), (int)historyConversationsStateToDisplay, historyConversationsMaxDays, (int)historyMaxDaysType), "initWithHistoryConversationsStateToDisplay:historyConversationsMaxDays:historyMaxDaysType:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int_nint_int (this.SuperHandle, Selector.GetHandle ("initWithHistoryConversationsStateToDisplay:historyConversationsMaxDays:historyMaxDaysType:"), (int)historyConversationsStateToDisplay, historyConversationsMaxDays, (int)historyMaxDaysType), "initWithHistoryConversationsStateToDisplay:historyConversationsMaxDays:historyMaxDaysType:");
			}
		}
		
		[Export ("new")]
		[CompilerGenerated]
		public static LPConversationHistoryControlParam New ()
		{
			return  Runtime.GetNSObject<LPConversationHistoryControlParam> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("new")));
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
		public virtual LPConversationHistoryMaxDaysDateType HistoryConversationMaxDaysType {
			[Export ("historyConversationMaxDaysType", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (LPConversationHistoryMaxDaysDateType) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("historyConversationMaxDaysType"));
				} else {
					return (LPConversationHistoryMaxDaysDateType) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("historyConversationMaxDaysType"));
				}
			}
			
			[Export ("setHistoryConversationMaxDaysType:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setHistoryConversationMaxDaysType:"), (int)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setHistoryConversationMaxDaysType:"), (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual nint HistoryConversationsMaxDays {
			[Export ("historyConversationsMaxDays")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("historyConversationsMaxDays"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("historyConversationsMaxDays"));
				}
			}
			
			[Export ("setHistoryConversationsMaxDays:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setHistoryConversationsMaxDays:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setHistoryConversationsMaxDays:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual LPConversationsHistoryStateToDisplay HistoryConversationsStateToDisplay {
			[Export ("historyConversationsStateToDisplay", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (LPConversationsHistoryStateToDisplay) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("historyConversationsStateToDisplay"));
				} else {
					return (LPConversationsHistoryStateToDisplay) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("historyConversationsStateToDisplay"));
				}
			}
			
			[Export ("setHistoryConversationsStateToDisplay:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setHistoryConversationsStateToDisplay:"), (int)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setHistoryConversationsStateToDisplay:"), (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsEnable {
			[Export ("isEnable")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isEnable"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isEnable"));
				}
			}
			
		}
		
	} /* class LPConversationHistoryControlParam */
}
