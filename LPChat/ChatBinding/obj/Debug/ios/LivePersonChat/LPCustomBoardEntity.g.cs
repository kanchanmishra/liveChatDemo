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
	[Register("LPCustomBoardEntity", true)]
	public unsafe partial class LPCustomBoardEntity : global::CoreData.NSManagedObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("LPCustomBoardEntity");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public LPCustomBoardEntity () : base (NSObjectFlag.Empty)
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
		protected LPCustomBoardEntity (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LPCustomBoardEntity (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithEntity:insertIntoManagedObjectContext:")]
		[DesignatedInitializer]
		[CompilerGenerated]
		public LPCustomBoardEntity (global::CoreData.NSEntityDescription entity, global::CoreData.NSManagedObjectContext context)
			: base (NSObjectFlag.Empty)
		{
			if (entity == null)
				throw new ArgumentNullException ("entity");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithEntity:insertIntoManagedObjectContext:"), entity.Handle, context == null ? IntPtr.Zero : context.Handle), "initWithEntity:insertIntoManagedObjectContext:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithEntity:insertIntoManagedObjectContext:"), entity.Handle, context == null ? IntPtr.Zero : context.Handle), "initWithEntity:insertIntoManagedObjectContext:");
			}
		}
		
		[CompilerGenerated]
		public virtual NSOrderedSet LinkPreviewItems {
			[Export ("linkPreviewItems", ArgumentSemantic.Retain)]
			get {
				NSOrderedSet ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSOrderedSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("linkPreviewItems")));
				} else {
					ret =  Runtime.GetNSObject<NSOrderedSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("linkPreviewItems")));
				}
				return ret;
			}
			
			[Export ("setLinkPreviewItems:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLinkPreviewItems:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLinkPreviewItems:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual LPMessageEntity OwnerMessage {
			[Export ("ownerMessage", ArgumentSemantic.Retain)]
			get {
				LPMessageEntity ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<LPMessageEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("ownerMessage")));
				} else {
					ret =  Runtime.GetNSObject<LPMessageEntity> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("ownerMessage")));
				}
				return ret;
			}
			
			[Export ("setOwnerMessage:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setOwnerMessage:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setOwnerMessage:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Uid {
			[Export ("uid")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("uid")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("uid")));
				}
			}
			
			[Export ("setUid:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUid:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUid:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
	} /* class LPCustomBoardEntity */
}
