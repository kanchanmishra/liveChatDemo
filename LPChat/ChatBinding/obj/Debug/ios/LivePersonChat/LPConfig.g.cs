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
	[Register("LPConfig", true)]
	public unsafe partial class LPConfig : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("LPConfig");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected LPConfig (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LPConfig (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("new")]
		[CompilerGenerated]
		public static LPConfig New ()
		{
			return  Runtime.GetNSObject<LPConfig> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("new")));
		}
		
		[Export ("printAllConfigurations")]
		[CompilerGenerated]
		public static void PrintAllConfigurations ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("printAllConfigurations"));
		}
		
		[Export ("resetToDefaultConfiguration")]
		[CompilerGenerated]
		public virtual void ResetToDefaultConfiguration ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("resetToDefaultConfiguration"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resetToDefaultConfiguration"));
			}
		}
		
		[Export ("setValue:forUndefinedKey:")]
		[CompilerGenerated]
		public virtual void SetValue (NSObject value, string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setValue:forUndefinedKey:"), value == null ? IntPtr.Zero : value.Handle, nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setValue:forUndefinedKey:"), value == null ? IntPtr.Zero : value.Handle, nskey);
			}
			NSString.ReleaseNative (nskey);
			
		}
		
		[CompilerGenerated]
		public virtual LPAccountEnviroment AccountEnvironment {
			[Export ("accountEnvironment", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (LPAccountEnviroment) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("accountEnvironment"));
				} else {
					return (LPAccountEnviroment) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accountEnvironment"));
				}
			}
			
			[Export ("setAccountEnvironment:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setAccountEnvironment:"), (int)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setAccountEnvironment:"), (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AnnounceAgentTyping {
			[Export ("announceAgentTyping")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("announceAgentTyping"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("announceAgentTyping"));
				}
			}
			
			[Export ("setAnnounceAgentTyping:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAnnounceAgentTyping:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAnnounceAgentTyping:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIImage BrandAvatarImage {
			[Export ("brandAvatarImage", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("brandAvatarImage")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("brandAvatarImage")));
				}
				return ret;
			}
			
			[Export ("setBrandAvatarImage:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBrandAvatarImage:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBrandAvatarImage:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string BrandName {
			[Export ("brandName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("brandName")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("brandName")));
				}
			}
			
			[Export ("setBrandName:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBrandName:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBrandName:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual float BubbleBottomPadding {
			[Export ("bubbleBottomPadding")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("bubbleBottomPadding"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bubbleBottomPadding"));
				}
			}
			
			[Export ("setBubbleBottomPadding:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setBubbleBottomPadding:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setBubbleBottomPadding:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string BubbleEmailLinksRegex {
			[Export ("bubbleEmailLinksRegex")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bubbleEmailLinksRegex")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bubbleEmailLinksRegex")));
				}
			}
			
			[Export ("setBubbleEmailLinksRegex:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBubbleEmailLinksRegex:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBubbleEmailLinksRegex:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual float BubbleLeadingPadding {
			[Export ("bubbleLeadingPadding")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("bubbleLeadingPadding"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bubbleLeadingPadding"));
				}
			}
			
			[Export ("setBubbleLeadingPadding:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setBubbleLeadingPadding:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setBubbleLeadingPadding:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string BubblePhoneLinksRegex {
			[Export ("bubblePhoneLinksRegex")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bubblePhoneLinksRegex")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bubblePhoneLinksRegex")));
				}
			}
			
			[Export ("setBubblePhoneLinksRegex:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBubblePhoneLinksRegex:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBubblePhoneLinksRegex:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual float BubbleTimestampBottomPadding {
			[Export ("bubbleTimestampBottomPadding")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("bubbleTimestampBottomPadding"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bubbleTimestampBottomPadding"));
				}
			}
			
			[Export ("setBubbleTimestampBottomPadding:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setBubbleTimestampBottomPadding:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setBubbleTimestampBottomPadding:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float BubbleTimestampTopPadding {
			[Export ("bubbleTimestampTopPadding")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("bubbleTimestampTopPadding"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bubbleTimestampTopPadding"));
				}
			}
			
			[Export ("setBubbleTimestampTopPadding:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setBubbleTimestampTopPadding:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setBubbleTimestampTopPadding:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float BubbleTopPadding {
			[Export ("bubbleTopPadding")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("bubbleTopPadding"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bubbleTopPadding"));
				}
			}
			
			[Export ("setBubbleTopPadding:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setBubbleTopPadding:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setBubbleTopPadding:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float BubbleTrailingPadding {
			[Export ("bubbleTrailingPadding")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("bubbleTrailingPadding"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bubbleTrailingPadding"));
				}
			}
			
			[Export ("setBubbleTrailingPadding:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setBubbleTrailingPadding:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setBubbleTrailingPadding:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string BubbleUrlLinksRegex {
			[Export ("bubbleUrlLinksRegex")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bubbleUrlLinksRegex")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bubbleUrlLinksRegex")));
				}
			}
			
			[Export ("setBubbleUrlLinksRegex:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBubbleUrlLinksRegex:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBubbleUrlLinksRegex:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor CameraButtonDisabledColor {
			[Export ("cameraButtonDisabledColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cameraButtonDisabledColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cameraButtonDisabledColor")));
				}
				return ret;
			}
			
			[Export ("setCameraButtonDisabledColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCameraButtonDisabledColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCameraButtonDisabledColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor CameraButtonEnabledColor {
			[Export ("cameraButtonEnabledColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cameraButtonEnabledColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cameraButtonEnabledColor")));
				}
				return ret;
			}
			
			[Export ("setCameraButtonEnabledColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCameraButtonEnabledColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCameraButtonEnabledColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor CheckmarkColor {
			[Export ("checkmarkColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("checkmarkColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("checkmarkColor")));
				}
				return ret;
			}
			
			[Export ("setCheckmarkColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCheckmarkColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCheckmarkColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor CheckmarkDistributedColor {
			[Export ("checkmarkDistributedColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("checkmarkDistributedColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("checkmarkDistributedColor")));
				}
				return ret;
			}
			
			[Export ("setCheckmarkDistributedColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCheckmarkDistributedColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCheckmarkDistributedColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor CheckmarkReadColor {
			[Export ("checkmarkReadColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("checkmarkReadColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("checkmarkReadColor")));
				}
				return ret;
			}
			
			[Export ("setCheckmarkReadColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCheckmarkReadColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCheckmarkReadColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor CheckmarkSentColor {
			[Export ("checkmarkSentColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("checkmarkSentColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("checkmarkSentColor")));
				}
				return ret;
			}
			
			[Export ("setCheckmarkSentColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCheckmarkSentColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCheckmarkSentColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual CheckmarksState CheckmarkVisibility {
			[Export ("checkmarkVisibility", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (CheckmarksState) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("checkmarkVisibility"));
				} else {
					return (CheckmarksState) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("checkmarkVisibility"));
				}
			}
			
			[Export ("setCheckmarkVisibility:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setCheckmarkVisibility:"), (int)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setCheckmarkVisibility:"), (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string ClientOnlyMaskingRegex {
			[Export ("clientOnlyMaskingRegex")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("clientOnlyMaskingRegex")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clientOnlyMaskingRegex")));
				}
			}
			
			[Export ("setClientOnlyMaskingRegex:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setClientOnlyMaskingRegex:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setClientOnlyMaskingRegex:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor ConnectionStatusConnectingBackgroundColor {
			[Export ("connectionStatusConnectingBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("connectionStatusConnectingBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("connectionStatusConnectingBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setConnectionStatusConnectingBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setConnectionStatusConnectingBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setConnectionStatusConnectingBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor ConnectionStatusConnectingTextColor {
			[Export ("connectionStatusConnectingTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("connectionStatusConnectingTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("connectionStatusConnectingTextColor")));
				}
				return ret;
			}
			
			[Export ("setConnectionStatusConnectingTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setConnectionStatusConnectingTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setConnectionStatusConnectingTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor ConnectionStatusFailedToConnectBackgroundColor {
			[Export ("connectionStatusFailedToConnectBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("connectionStatusFailedToConnectBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("connectionStatusFailedToConnectBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setConnectionStatusFailedToConnectBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setConnectionStatusFailedToConnectBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setConnectionStatusFailedToConnectBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor ConnectionStatusFailedToConnectTextColor {
			[Export ("connectionStatusFailedToConnectTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("connectionStatusFailedToConnectTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("connectionStatusFailedToConnectTextColor")));
				}
				return ret;
			}
			
			[Export ("setConnectionStatusFailedToConnectTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setConnectionStatusFailedToConnectTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setConnectionStatusFailedToConnectTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor ControllerBubbleTextColor {
			[Export ("controllerBubbleTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("controllerBubbleTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("controllerBubbleTextColor")));
				}
				return ret;
			}
			
			[Export ("setControllerBubbleTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setControllerBubbleTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setControllerBubbleTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor ConversationBackgroundColor {
			[Export ("conversationBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("conversationBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("conversationBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setConversationBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setConversationBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setConversationBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor ConversationEmptyStateTextColor {
			[Export ("conversationEmptyStateTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("conversationEmptyStateTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("conversationEmptyStateTextColor")));
				}
				return ret;
			}
			
			[Export ("setConversationEmptyStateTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setConversationEmptyStateTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setConversationEmptyStateTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor ConversationNavigationBackgroundColor {
			[Export ("conversationNavigationBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("conversationNavigationBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("conversationNavigationBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setConversationNavigationBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setConversationNavigationBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setConversationNavigationBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor ConversationNavigationTitleColor {
			[Export ("conversationNavigationTitleColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("conversationNavigationTitleColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("conversationNavigationTitleColor")));
				}
				return ret;
			}
			
			[Export ("setConversationNavigationTitleColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setConversationNavigationTitleColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setConversationNavigationTitleColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float ConversationSeparatorBottomPadding {
			[Export ("conversationSeparatorBottomPadding")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("conversationSeparatorBottomPadding"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("conversationSeparatorBottomPadding"));
				}
			}
			
			[Export ("setConversationSeparatorBottomPadding:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setConversationSeparatorBottomPadding:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setConversationSeparatorBottomPadding:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string ConversationSeparatorFontName {
			[Export ("conversationSeparatorFontName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("conversationSeparatorFontName")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("conversationSeparatorFontName")));
				}
			}
			
			[Export ("setConversationSeparatorFontName:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setConversationSeparatorFontName:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setConversationSeparatorFontName:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ConversationSeparatorFontSize {
			[Export ("conversationSeparatorFontSize")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("conversationSeparatorFontSize")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("conversationSeparatorFontSize")));
				}
			}
			
			[Export ("setConversationSeparatorFontSize:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setConversationSeparatorFontSize:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setConversationSeparatorFontSize:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor ConversationSeparatorTextColor {
			[Export ("conversationSeparatorTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("conversationSeparatorTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("conversationSeparatorTextColor")));
				}
				return ret;
			}
			
			[Export ("setConversationSeparatorTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setConversationSeparatorTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setConversationSeparatorTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float ConversationSeparatorTopPadding {
			[Export ("conversationSeparatorTopPadding")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("conversationSeparatorTopPadding"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("conversationSeparatorTopPadding"));
				}
			}
			
			[Export ("setConversationSeparatorTopPadding:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setConversationSeparatorTopPadding:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setConversationSeparatorTopPadding:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float ConversationSeparatorViewBottomPadding {
			[Export ("conversationSeparatorViewBottomPadding")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("conversationSeparatorViewBottomPadding"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("conversationSeparatorViewBottomPadding"));
				}
			}
			
			[Export ("setConversationSeparatorViewBottomPadding:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setConversationSeparatorViewBottomPadding:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setConversationSeparatorViewBottomPadding:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIStatusBarStyle ConversationStatusBarStyle {
			[Export ("conversationStatusBarStyle", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIStatusBarStyle ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UIStatusBarStyle) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("conversationStatusBarStyle"));
					} else {
						ret = (global::UIKit.UIStatusBarStyle) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("conversationStatusBarStyle"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UIStatusBarStyle) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("conversationStatusBarStyle"));
					} else {
						ret = (global::UIKit.UIStatusBarStyle) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("conversationStatusBarStyle"));
					}
				}
				return ret;
			}
			
			[Export ("setConversationStatusBarStyle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setConversationStatusBarStyle:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setConversationStatusBarStyle:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setConversationStatusBarStyle:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setConversationStatusBarStyle:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Country {
			[Export ("country")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("country")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("country")));
				}
			}
			
			[Export ("setCountry:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCountry:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCountry:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor CsatAgentAvatarBackgroundColor {
			[Export ("csatAgentAvatarBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("csatAgentAvatarBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("csatAgentAvatarBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setCsatAgentAvatarBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCsatAgentAvatarBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCsatAgentAvatarBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor CsatAgentAvatarIconColor {
			[Export ("csatAgentAvatarIconColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("csatAgentAvatarIconColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("csatAgentAvatarIconColor")));
				}
				return ret;
			}
			
			[Export ("setCsatAgentAvatarIconColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCsatAgentAvatarIconColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCsatAgentAvatarIconColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool CsatAgentViewHidden {
			[Export ("csatAgentViewHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("csatAgentViewHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("csatAgentViewHidden"));
				}
			}
			
			[Export ("setCsatAgentViewHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCsatAgentViewHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setCsatAgentViewHidden:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor CsatAllTitlesTextColor {
			[Export ("csatAllTitlesTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("csatAllTitlesTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("csatAllTitlesTextColor")));
				}
				return ret;
			}
			
			[Export ("setCsatAllTitlesTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCsatAllTitlesTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCsatAllTitlesTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor CsatNavigationBackgroundColor {
			[Export ("csatNavigationBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("csatNavigationBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("csatNavigationBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setCsatNavigationBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCsatNavigationBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCsatNavigationBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor CsatNavigationTitleColor {
			[Export ("csatNavigationTitleColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("csatNavigationTitleColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("csatNavigationTitleColor")));
				}
				return ret;
			}
			
			[Export ("setCsatNavigationTitleColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCsatNavigationTitleColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCsatNavigationTitleColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor CsatRatingButtonSelectedColor {
			[Export ("csatRatingButtonSelectedColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("csatRatingButtonSelectedColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("csatRatingButtonSelectedColor")));
				}
				return ret;
			}
			
			[Export ("setCsatRatingButtonSelectedColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCsatRatingButtonSelectedColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCsatRatingButtonSelectedColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor CsatResolutionButtonSelectedColor {
			[Export ("csatResolutionButtonSelectedColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("csatResolutionButtonSelectedColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("csatResolutionButtonSelectedColor")));
				}
				return ret;
			}
			
			[Export ("setCsatResolutionButtonSelectedColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCsatResolutionButtonSelectedColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCsatResolutionButtonSelectedColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool CsatResolutionHidden {
			[Export ("csatResolutionHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("csatResolutionHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("csatResolutionHidden"));
				}
			}
			
			[Export ("setCsatResolutionHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCsatResolutionHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setCsatResolutionHidden:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool CsatShowSurveyView {
			[Export ("csatShowSurveyView")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("csatShowSurveyView"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("csatShowSurveyView"));
				}
			}
			
			[Export ("setCsatShowSurveyView:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCsatShowSurveyView:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setCsatShowSurveyView:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor CsatSkipButtonColor {
			[Export ("csatSkipButtonColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("csatSkipButtonColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("csatSkipButtonColor")));
				}
				return ret;
			}
			
			[Export ("setCsatSkipButtonColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCsatSkipButtonColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCsatSkipButtonColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor CsatSubmitButtonBackgroundColor {
			[Export ("csatSubmitButtonBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("csatSubmitButtonBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("csatSubmitButtonBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setCsatSubmitButtonBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCsatSubmitButtonBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCsatSubmitButtonBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual double CsatSubmitButtonCornerRadius {
			[Export ("csatSubmitButtonCornerRadius")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("csatSubmitButtonCornerRadius"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("csatSubmitButtonCornerRadius"));
				}
			}
			
			[Export ("setCsatSubmitButtonCornerRadius:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setCsatSubmitButtonCornerRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setCsatSubmitButtonCornerRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor CsatSubmitButtonTextColor {
			[Export ("csatSubmitButtonTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("csatSubmitButtonTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("csatSubmitButtonTextColor")));
				}
				return ret;
			}
			
			[Export ("setCsatSubmitButtonTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCsatSubmitButtonTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCsatSubmitButtonTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual nuint CsatSurveyExpirationInMinutes {
			[Export ("csatSurveyExpirationInMinutes")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("csatSurveyExpirationInMinutes"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("csatSurveyExpirationInMinutes"));
				}
			}
			
			[Export ("setCsatSurveyExpirationInMinutes:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setCsatSurveyExpirationInMinutes:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setCsatSurveyExpirationInMinutes:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool CsatThankYouScreenHidden {
			[Export ("csatThankYouScreenHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("csatThankYouScreenHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("csatThankYouScreenHidden"));
				}
			}
			
			[Export ("setCsatThankYouScreenHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCsatThankYouScreenHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setCsatThankYouScreenHidden:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool CsatUIStatusBarStyleLightContent {
			[Export ("csatUIStatusBarStyleLightContent")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("csatUIStatusBarStyleLightContent"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("csatUIStatusBarStyleLightContent"));
				}
			}
			
			[Export ("setCsatUIStatusBarStyleLightContent:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCsatUIStatusBarStyleLightContent:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setCsatUIStatusBarStyleLightContent:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual double CsatYesNoButtonsCornerRadius {
			[Export ("csatYesNoButtonsCornerRadius")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("csatYesNoButtonsCornerRadius"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("csatYesNoButtonsCornerRadius"));
				}
			}
			
			[Export ("setCsatYesNoButtonsCornerRadius:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setCsatYesNoButtonsCornerRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setCsatYesNoButtonsCornerRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string CsdsDomain {
			[Export ("csdsDomain")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("csdsDomain")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("csdsDomain")));
				}
			}
			
			[Export ("setCsdsDomain:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCsdsDomain:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCsdsDomain:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string CustomButtonDescription {
			[Export ("customButtonDescription")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("customButtonDescription")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("customButtonDescription")));
				}
			}
			
			[Export ("setCustomButtonDescription:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCustomButtonDescription:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCustomButtonDescription:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string CustomButtonIconName {
			[Export ("customButtonIconName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("customButtonIconName")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("customButtonIconName")));
				}
			}
			
			[Export ("setCustomButtonIconName:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCustomButtonIconName:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCustomButtonIconName:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIImage CustomButtonImage {
			[Export ("customButtonImage", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("customButtonImage")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("customButtonImage")));
				}
				return ret;
			}
			
			[Export ("setCustomButtonImage:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCustomButtonImage:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCustomButtonImage:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string CustomFontNameConversationFeed {
			[Export ("customFontNameConversationFeed")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("customFontNameConversationFeed")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("customFontNameConversationFeed")));
				}
			}
			
			[Export ("setCustomFontNameConversationFeed:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCustomFontNameConversationFeed:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCustomFontNameConversationFeed:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string CustomFontNameDateSeparator {
			[Export ("customFontNameDateSeparator")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("customFontNameDateSeparator")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("customFontNameDateSeparator")));
				}
			}
			
			[Export ("setCustomFontNameDateSeparator:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCustomFontNameDateSeparator:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCustomFontNameDateSeparator:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string CustomFontNameNonConversationFeed {
			[Export ("customFontNameNonConversationFeed")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("customFontNameNonConversationFeed")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("customFontNameNonConversationFeed")));
				}
			}
			
			[Export ("setCustomFontNameNonConversationFeed:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCustomFontNameNonConversationFeed:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCustomFontNameNonConversationFeed:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual float CustomRefreshControllerAnimationSpeed {
			[Export ("customRefreshControllerAnimationSpeed")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("customRefreshControllerAnimationSpeed"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("customRefreshControllerAnimationSpeed"));
				}
			}
			
			[Export ("setCustomRefreshControllerAnimationSpeed:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setCustomRefreshControllerAnimationSpeed:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setCustomRefreshControllerAnimationSpeed:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIImage[] CustomRefreshControllerImagesArray {
			[Export ("customRefreshControllerImagesArray", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIImage[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<global::UIKit.UIImage>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("customRefreshControllerImagesArray")));
				} else {
					ret = NSArray.ArrayFromHandle<global::UIKit.UIImage>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("customRefreshControllerImagesArray")));
				}
				return ret;
			}
			
			[Export ("setCustomRefreshControllerImagesArray:", ArgumentSemantic.Copy)]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCustomRefreshControllerImagesArray:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCustomRefreshControllerImagesArray:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor DateSeparatorBackgroundColor {
			[Export ("dateSeparatorBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dateSeparatorBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dateSeparatorBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setDateSeparatorBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDateSeparatorBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDateSeparatorBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float DateSeparatorBottomPadding {
			[Export ("dateSeparatorBottomPadding")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("dateSeparatorBottomPadding"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dateSeparatorBottomPadding"));
				}
			}
			
			[Export ("setDateSeparatorBottomPadding:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setDateSeparatorBottomPadding:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setDateSeparatorBottomPadding:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string DateSeparatorFontSize {
			[Export ("dateSeparatorFontSize")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dateSeparatorFontSize")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dateSeparatorFontSize")));
				}
			}
			
			[Export ("setDateSeparatorFontSize:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDateSeparatorFontSize:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDateSeparatorFontSize:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor DateSeparatorLineBackgroundColor {
			[Export ("dateSeparatorLineBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dateSeparatorLineBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dateSeparatorLineBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setDateSeparatorLineBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDateSeparatorLineBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDateSeparatorLineBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor DateSeparatorTextColor {
			[Export ("dateSeparatorTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dateSeparatorTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dateSeparatorTextColor")));
				}
				return ret;
			}
			
			[Export ("setDateSeparatorTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDateSeparatorTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDateSeparatorTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor DateSeparatorTitleBackgroundColor {
			[Export ("dateSeparatorTitleBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dateSeparatorTitleBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dateSeparatorTitleBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setDateSeparatorTitleBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDateSeparatorTitleBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDateSeparatorTitleBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float DateSeparatorTopPadding {
			[Export ("dateSeparatorTopPadding")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("dateSeparatorTopPadding"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dateSeparatorTopPadding"));
				}
			}
			
			[Export ("setDateSeparatorTopPadding:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setDateSeparatorTopPadding:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setDateSeparatorTopPadding:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public static LPConfig DefaultConfiguration {
			[Export ("defaultConfiguration", ArgumentSemantic.Retain)]
			get {
				LPConfig ret;
				ret =  Runtime.GetNSObject<LPConfig> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("defaultConfiguration")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual nuint DeleteClosedConversationOlderThanMonths {
			[Export ("deleteClosedConversationOlderThanMonths")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("deleteClosedConversationOlderThanMonths"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("deleteClosedConversationOlderThanMonths"));
				}
			}
			
			[Export ("setDeleteClosedConversationOlderThanMonths:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setDeleteClosedConversationOlderThanMonths:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setDeleteClosedConversationOlderThanMonths:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor EditTextUnderlineColor {
			[Export ("editTextUnderlineColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("editTextUnderlineColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("editTextUnderlineColor")));
				}
				return ret;
			}
			
			[Export ("setEditTextUnderlineColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setEditTextUnderlineColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setEditTextUnderlineColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool EnableBubblesOverlayOnLongPress {
			[Export ("enableBubblesOverlayOnLongPress")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("enableBubblesOverlayOnLongPress"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enableBubblesOverlayOnLongPress"));
				}
			}
			
			[Export ("setEnableBubblesOverlayOnLongPress:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnableBubblesOverlayOnLongPress:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEnableBubblesOverlayOnLongPress:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool EnableClientOnlyMasking {
			[Export ("enableClientOnlyMasking")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("enableClientOnlyMasking"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enableClientOnlyMasking"));
				}
			}
			
			[Export ("setEnableClientOnlyMasking:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnableClientOnlyMasking:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEnableClientOnlyMasking:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool EnableConversationSeparatorLine {
			[Export ("enableConversationSeparatorLine")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("enableConversationSeparatorLine"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enableConversationSeparatorLine"));
				}
			}
			
			[Export ("setEnableConversationSeparatorLine:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnableConversationSeparatorLine:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEnableConversationSeparatorLine:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool EnableConversationSeparatorTextMessage {
			[Export ("enableConversationSeparatorTextMessage")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("enableConversationSeparatorTextMessage"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enableConversationSeparatorTextMessage"));
				}
			}
			
			[Export ("setEnableConversationSeparatorTextMessage:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnableConversationSeparatorTextMessage:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEnableConversationSeparatorTextMessage:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool EnableLinkPreview {
			[Export ("enableLinkPreview")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("enableLinkPreview"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enableLinkPreview"));
				}
			}
			
			[Export ("setEnableLinkPreview:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnableLinkPreview:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEnableLinkPreview:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool EnablePhotoSharing {
			[Export ("enablePhotoSharing")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("enablePhotoSharing"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enablePhotoSharing"));
				}
			}
			
			[Export ("setEnablePhotoSharing:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnablePhotoSharing:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEnablePhotoSharing:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool EnableRealTimeLinkPreview {
			[Export ("enableRealTimeLinkPreview")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("enableRealTimeLinkPreview"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enableRealTimeLinkPreview"));
				}
			}
			
			[Export ("setEnableRealTimeLinkPreview:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnableRealTimeLinkPreview:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEnableRealTimeLinkPreview:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool EnableRealTimeMasking {
			[Export ("enableRealTimeMasking")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("enableRealTimeMasking"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enableRealTimeMasking"));
				}
			}
			
			[Export ("setEnableRealTimeMasking:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnableRealTimeMasking:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEnableRealTimeMasking:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool EnableStrucutredContent {
			[Export ("enableStrucutredContent")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("enableStrucutredContent"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enableStrucutredContent"));
				}
			}
			
			[Export ("setEnableStrucutredContent:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnableStrucutredContent:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEnableStrucutredContent:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool EnableVibrationOnMessageFromRemoteUser {
			[Export ("enableVibrationOnMessageFromRemoteUser")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("enableVibrationOnMessageFromRemoteUser"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enableVibrationOnMessageFromRemoteUser"));
				}
			}
			
			[Export ("setEnableVibrationOnMessageFromRemoteUser:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnableVibrationOnMessageFromRemoteUser:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEnableVibrationOnMessageFromRemoteUser:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor FileCellLoaderFillColor {
			[Export ("fileCellLoaderFillColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fileCellLoaderFillColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fileCellLoaderFillColor")));
				}
				return ret;
			}
			
			[Export ("setFileCellLoaderFillColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFileCellLoaderFillColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFileCellLoaderFillColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor FileCellLoaderRingBackgroundColor {
			[Export ("fileCellLoaderRingBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fileCellLoaderRingBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fileCellLoaderRingBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setFileCellLoaderRingBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFileCellLoaderRingBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFileCellLoaderRingBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor FileCellLoaderRingProgressColor {
			[Export ("fileCellLoaderRingProgressColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fileCellLoaderRingProgressColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fileCellLoaderRingProgressColor")));
				}
				return ret;
			}
			
			[Export ("setFileCellLoaderRingProgressColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFileCellLoaderRingProgressColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFileCellLoaderRingProgressColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor InputTextViewContainerBackgroundColor {
			[Export ("inputTextViewContainerBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("inputTextViewContainerBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("inputTextViewContainerBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setInputTextViewContainerBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setInputTextViewContainerBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setInputTextViewContainerBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual double InputTextViewCornerRadius {
			[Export ("inputTextViewCornerRadius")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("inputTextViewCornerRadius"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("inputTextViewCornerRadius"));
				}
			}
			
			[Export ("setInputTextViewCornerRadius:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setInputTextViewCornerRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setInputTextViewCornerRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual nfloat InputTextViewMaxHeight {
			[Export ("inputTextViewMaxHeight")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("inputTextViewMaxHeight"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("inputTextViewMaxHeight"));
				}
			}
			
			[Export ("setInputTextViewMaxHeight:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setInputTextViewMaxHeight:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setInputTextViewMaxHeight:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor InputTextViewTopBorderColor {
			[Export ("inputTextViewTopBorderColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("inputTextViewTopBorderColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("inputTextViewTopBorderColor")));
				}
				return ret;
			}
			
			[Export ("setInputTextViewTopBorderColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setInputTextViewTopBorderColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setInputTextViewTopBorderColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsReadReceiptTextMode {
			[Export ("isReadReceiptTextMode")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isReadReceiptTextMode"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isReadReceiptTextMode"));
				}
			}
			
			[Export ("setIsReadReceiptTextMode:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsReadReceiptTextMode:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsReadReceiptTextMode:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsSendMessageButtonInTextMode {
			[Export ("isSendMessageButtonInTextMode")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSendMessageButtonInTextMode"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isSendMessageButtonInTextMode"));
				}
			}
			
			[Export ("setIsSendMessageButtonInTextMode:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsSendMessageButtonInTextMode:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsSendMessageButtonInTextMode:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual LPLanguage Language {
			[Export ("language", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (LPLanguage) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("language"));
				} else {
					return (LPLanguage) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("language"));
				}
			}
			
			[Export ("setLanguage:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setLanguage:"), (int)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setLanguage:"), (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor LinkPreviewBackgroundColor {
			[Export ("linkPreviewBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("linkPreviewBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("linkPreviewBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setLinkPreviewBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLinkPreviewBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLinkPreviewBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor LinkPreviewBorderColor {
			[Export ("linkPreviewBorderColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("linkPreviewBorderColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("linkPreviewBorderColor")));
				}
				return ret;
			}
			
			[Export ("setLinkPreviewBorderColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLinkPreviewBorderColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLinkPreviewBorderColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual double LinkPreviewBorderWidth {
			[Export ("linkPreviewBorderWidth")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("linkPreviewBorderWidth"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("linkPreviewBorderWidth"));
				}
			}
			
			[Export ("setLinkPreviewBorderWidth:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setLinkPreviewBorderWidth:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setLinkPreviewBorderWidth:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor LinkPreviewDescriptionTextColor {
			[Export ("linkPreviewDescriptionTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("linkPreviewDescriptionTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("linkPreviewDescriptionTextColor")));
				}
				return ret;
			}
			
			[Export ("setLinkPreviewDescriptionTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLinkPreviewDescriptionTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLinkPreviewDescriptionTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor LinkPreviewSiteNameTextColor {
			[Export ("linkPreviewSiteNameTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("linkPreviewSiteNameTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("linkPreviewSiteNameTextColor")));
				}
				return ret;
			}
			
			[Export ("setLinkPreviewSiteNameTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLinkPreviewSiteNameTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLinkPreviewSiteNameTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor LinkPreviewTitleTextColor {
			[Export ("linkPreviewTitleTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("linkPreviewTitleTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("linkPreviewTitleTextColor")));
				}
				return ret;
			}
			
			[Export ("setLinkPreviewTitleTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLinkPreviewTitleTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLinkPreviewTitleTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string LpDateFormat {
			[Export ("lpDateFormat")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lpDateFormat")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lpDateFormat")));
				}
			}
			
			[Export ("setLpDateFormat:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLpDateFormat:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLpDateFormat:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string LpDateTimeFormat {
			[Export ("lpDateTimeFormat")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lpDateTimeFormat")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lpDateTimeFormat")));
				}
			}
			
			[Export ("setLpDateTimeFormat:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLpDateTimeFormat:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLpDateTimeFormat:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string LpTagDomain {
			[Export ("lpTagDomain")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lpTagDomain")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lpTagDomain")));
				}
			}
			
			[Export ("setLpTagDomain:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLpTagDomain:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLpTagDomain:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string LpTimeFormat {
			[Export ("lpTimeFormat")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lpTimeFormat")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lpTimeFormat")));
				}
			}
			
			[Export ("setLpTimeFormat:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLpTimeFormat:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLpTimeFormat:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual nuint MaxNumberOfSavedFilesOnDisk {
			[Export ("maxNumberOfSavedFilesOnDisk")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("maxNumberOfSavedFilesOnDisk"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maxNumberOfSavedFilesOnDisk"));
				}
			}
			
			[Export ("setMaxNumberOfSavedFilesOnDisk:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setMaxNumberOfSavedFilesOnDisk:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setMaxNumberOfSavedFilesOnDisk:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual nuint MaxPreviousConversationToPresent {
			[Export ("maxPreviousConversationToPresent")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("maxPreviousConversationToPresent"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maxPreviousConversationToPresent"));
				}
			}
			
			[Export ("setMaxPreviousConversationToPresent:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setMaxPreviousConversationToPresent:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setMaxPreviousConversationToPresent:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool MessageStatusNumericTimestampOnly {
			[Export ("messageStatusNumericTimestampOnly")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("messageStatusNumericTimestampOnly"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("messageStatusNumericTimestampOnly"));
				}
			}
			
			[Export ("setMessageStatusNumericTimestampOnly:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setMessageStatusNumericTimestampOnly:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setMessageStatusNumericTimestampOnly:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual double NotificationShowDurationInSeconds {
			[Export ("notificationShowDurationInSeconds")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("notificationShowDurationInSeconds"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("notificationShowDurationInSeconds"));
				}
			}
			
			[Export ("setNotificationShowDurationInSeconds:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setNotificationShowDurationInSeconds:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setNotificationShowDurationInSeconds:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string OffHoursTimeZoneName {
			[Export ("offHoursTimeZoneName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("offHoursTimeZoneName")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("offHoursTimeZoneName")));
				}
			}
			
			[Export ("setOffHoursTimeZoneName:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setOffHoursTimeZoneName:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setOffHoursTimeZoneName:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIImage PhotoSharingCloseMenuImageButton {
			[Export ("photoSharingCloseMenuImageButton", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("photoSharingCloseMenuImageButton")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("photoSharingCloseMenuImageButton")));
				}
				return ret;
			}
			
			[Export ("setPhotoSharingCloseMenuImageButton:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPhotoSharingCloseMenuImageButton:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPhotoSharingCloseMenuImageButton:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIImage PhotoSharingMenuCameraImage {
			[Export ("photoSharingMenuCameraImage", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("photoSharingMenuCameraImage")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("photoSharingMenuCameraImage")));
				}
				return ret;
			}
			
			[Export ("setPhotoSharingMenuCameraImage:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPhotoSharingMenuCameraImage:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPhotoSharingMenuCameraImage:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIImage PhotoSharingMenuLibraryImage {
			[Export ("photoSharingMenuLibraryImage", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("photoSharingMenuLibraryImage")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("photoSharingMenuLibraryImage")));
				}
				return ret;
			}
			
			[Export ("setPhotoSharingMenuLibraryImage:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPhotoSharingMenuLibraryImage:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPhotoSharingMenuLibraryImage:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIImage PhotoSharingOpenMenuImageButton {
			[Export ("photoSharingOpenMenuImageButton", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("photoSharingOpenMenuImageButton")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("photoSharingOpenMenuImageButton")));
				}
				return ret;
			}
			
			[Export ("setPhotoSharingOpenMenuImageButton:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPhotoSharingOpenMenuImageButton:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPhotoSharingOpenMenuImageButton:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor PhotosharingMenuBackgroundColor {
			[Export ("photosharingMenuBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("photosharingMenuBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("photosharingMenuBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setPhotosharingMenuBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPhotosharingMenuBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPhotosharingMenuBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor PhotosharingMenuButtonsBackgroundColor {
			[Export ("photosharingMenuButtonsBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("photosharingMenuButtonsBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("photosharingMenuButtonsBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setPhotosharingMenuButtonsBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPhotosharingMenuButtonsBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPhotosharingMenuButtonsBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor PhotosharingMenuButtonsTextColor {
			[Export ("photosharingMenuButtonsTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("photosharingMenuButtonsTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("photosharingMenuButtonsTextColor")));
				}
				return ret;
			}
			
			[Export ("setPhotosharingMenuButtonsTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPhotosharingMenuButtonsTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPhotosharingMenuButtonsTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor PhotosharingMenuButtonsTintColor {
			[Export ("photosharingMenuButtonsTintColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("photosharingMenuButtonsTintColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("photosharingMenuButtonsTintColor")));
				}
				return ret;
			}
			
			[Export ("setPhotosharingMenuButtonsTintColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPhotosharingMenuButtonsTintColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPhotosharingMenuButtonsTintColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string ReadReceiptTextDistributed {
			[Export ("readReceiptTextDistributed")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("readReceiptTextDistributed")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("readReceiptTextDistributed")));
				}
			}
			
			[Export ("setReadReceiptTextDistributed:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setReadReceiptTextDistributed:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setReadReceiptTextDistributed:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ReadReceiptTextRead {
			[Export ("readReceiptTextRead")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("readReceiptTextRead")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("readReceiptTextRead")));
				}
			}
			
			[Export ("setReadReceiptTextRead:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setReadReceiptTextRead:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setReadReceiptTextRead:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ReadReceiptTextSent {
			[Export ("readReceiptTextSent")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("readReceiptTextSent")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("readReceiptTextSent")));
				}
			}
			
			[Export ("setReadReceiptTextSent:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setReadReceiptTextSent:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setReadReceiptTextSent:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string RealTimeMaskingRegex {
			[Export ("realTimeMaskingRegex")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("realTimeMaskingRegex")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("realTimeMaskingRegex")));
				}
			}
			
			[Export ("setRealTimeMaskingRegex:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRealTimeMaskingRegex:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRealTimeMaskingRegex:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor RemoteUserAvatarBackgroundColor {
			[Export ("remoteUserAvatarBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("remoteUserAvatarBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remoteUserAvatarBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setRemoteUserAvatarBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRemoteUserAvatarBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRemoteUserAvatarBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor RemoteUserAvatarIconColor {
			[Export ("remoteUserAvatarIconColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("remoteUserAvatarIconColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remoteUserAvatarIconColor")));
				}
				return ret;
			}
			
			[Export ("setRemoteUserAvatarIconColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRemoteUserAvatarIconColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRemoteUserAvatarIconColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float RemoteUserAvatarLeadingPadding {
			[Export ("remoteUserAvatarLeadingPadding")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("remoteUserAvatarLeadingPadding"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remoteUserAvatarLeadingPadding"));
				}
			}
			
			[Export ("setRemoteUserAvatarLeadingPadding:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setRemoteUserAvatarLeadingPadding:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setRemoteUserAvatarLeadingPadding:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float RemoteUserAvatarTrailingPadding {
			[Export ("remoteUserAvatarTrailingPadding")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("remoteUserAvatarTrailingPadding"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remoteUserAvatarTrailingPadding"));
				}
			}
			
			[Export ("setRemoteUserAvatarTrailingPadding:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setRemoteUserAvatarTrailingPadding:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setRemoteUserAvatarTrailingPadding:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor RemoteUserBubbleBackgroundColor {
			[Export ("remoteUserBubbleBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("remoteUserBubbleBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remoteUserBubbleBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setRemoteUserBubbleBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRemoteUserBubbleBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRemoteUserBubbleBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor RemoteUserBubbleBorderColor {
			[Export ("remoteUserBubbleBorderColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("remoteUserBubbleBorderColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remoteUserBubbleBorderColor")));
				}
				return ret;
			}
			
			[Export ("setRemoteUserBubbleBorderColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRemoteUserBubbleBorderColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRemoteUserBubbleBorderColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual double RemoteUserBubbleBorderWidth {
			[Export ("remoteUserBubbleBorderWidth")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("remoteUserBubbleBorderWidth"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remoteUserBubbleBorderWidth"));
				}
			}
			
			[Export ("setRemoteUserBubbleBorderWidth:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setRemoteUserBubbleBorderWidth:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setRemoteUserBubbleBorderWidth:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float RemoteUserBubbleBottomLeftCornerRadius {
			[Export ("remoteUserBubbleBottomLeftCornerRadius")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("remoteUserBubbleBottomLeftCornerRadius"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remoteUserBubbleBottomLeftCornerRadius"));
				}
			}
			
			[Export ("setRemoteUserBubbleBottomLeftCornerRadius:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setRemoteUserBubbleBottomLeftCornerRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setRemoteUserBubbleBottomLeftCornerRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float RemoteUserBubbleBottomRightCornerRadius {
			[Export ("remoteUserBubbleBottomRightCornerRadius")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("remoteUserBubbleBottomRightCornerRadius"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remoteUserBubbleBottomRightCornerRadius"));
				}
			}
			
			[Export ("setRemoteUserBubbleBottomRightCornerRadius:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setRemoteUserBubbleBottomRightCornerRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setRemoteUserBubbleBottomRightCornerRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor RemoteUserBubbleLinkColor {
			[Export ("remoteUserBubbleLinkColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("remoteUserBubbleLinkColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remoteUserBubbleLinkColor")));
				}
				return ret;
			}
			
			[Export ("setRemoteUserBubbleLinkColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRemoteUserBubbleLinkColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRemoteUserBubbleLinkColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float RemoteUserBubbleLongPressOverlayAlpha {
			[Export ("remoteUserBubbleLongPressOverlayAlpha")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("remoteUserBubbleLongPressOverlayAlpha"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remoteUserBubbleLongPressOverlayAlpha"));
				}
			}
			
			[Export ("setRemoteUserBubbleLongPressOverlayAlpha:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setRemoteUserBubbleLongPressOverlayAlpha:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setRemoteUserBubbleLongPressOverlayAlpha:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor RemoteUserBubbleLongPressOverlayColor {
			[Export ("remoteUserBubbleLongPressOverlayColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("remoteUserBubbleLongPressOverlayColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remoteUserBubbleLongPressOverlayColor")));
				}
				return ret;
			}
			
			[Export ("setRemoteUserBubbleLongPressOverlayColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRemoteUserBubbleLongPressOverlayColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRemoteUserBubbleLongPressOverlayColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor RemoteUserBubbleTextColor {
			[Export ("remoteUserBubbleTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("remoteUserBubbleTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remoteUserBubbleTextColor")));
				}
				return ret;
			}
			
			[Export ("setRemoteUserBubbleTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRemoteUserBubbleTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRemoteUserBubbleTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor RemoteUserBubbleTimestampColor {
			[Export ("remoteUserBubbleTimestampColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("remoteUserBubbleTimestampColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remoteUserBubbleTimestampColor")));
				}
				return ret;
			}
			
			[Export ("setRemoteUserBubbleTimestampColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRemoteUserBubbleTimestampColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRemoteUserBubbleTimestampColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float RemoteUserBubbleTopLeftCornerRadius {
			[Export ("remoteUserBubbleTopLeftCornerRadius")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("remoteUserBubbleTopLeftCornerRadius"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remoteUserBubbleTopLeftCornerRadius"));
				}
			}
			
			[Export ("setRemoteUserBubbleTopLeftCornerRadius:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setRemoteUserBubbleTopLeftCornerRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setRemoteUserBubbleTopLeftCornerRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float RemoteUserBubbleTopRightCornerRadius {
			[Export ("remoteUserBubbleTopRightCornerRadius")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("remoteUserBubbleTopRightCornerRadius"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remoteUserBubbleTopRightCornerRadius"));
				}
			}
			
			[Export ("setRemoteUserBubbleTopRightCornerRadius:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setRemoteUserBubbleTopRightCornerRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setRemoteUserBubbleTopRightCornerRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIImage RemoteUserDefaultAvatarImage {
			[Export ("remoteUserDefaultAvatarImage", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("remoteUserDefaultAvatarImage")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remoteUserDefaultAvatarImage")));
				}
				return ret;
			}
			
			[Export ("setRemoteUserDefaultAvatarImage:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRemoteUserDefaultAvatarImage:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRemoteUserDefaultAvatarImage:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor RemoteUserTypingTintColor {
			[Export ("remoteUserTypingTintColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("remoteUserTypingTintColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remoteUserTypingTintColor")));
				}
				return ret;
			}
			
			[Export ("setRemoteUserTypingTintColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRemoteUserTypingTintColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRemoteUserTypingTintColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool RetrieveAssignedAgentFromLastClosedConversation {
			[Export ("retrieveAssignedAgentFromLastClosedConversation")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("retrieveAssignedAgentFromLastClosedConversation"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("retrieveAssignedAgentFromLastClosedConversation"));
				}
			}
			
			[Export ("setRetrieveAssignedAgentFromLastClosedConversation:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRetrieveAssignedAgentFromLastClosedConversation:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRetrieveAssignedAgentFromLastClosedConversation:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor ScrollToBottomButtonArrowColor {
			[Export ("scrollToBottomButtonArrowColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("scrollToBottomButtonArrowColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrollToBottomButtonArrowColor")));
				}
				return ret;
			}
			
			[Export ("setScrollToBottomButtonArrowColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setScrollToBottomButtonArrowColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setScrollToBottomButtonArrowColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor ScrollToBottomButtonBackgroundColor {
			[Export ("scrollToBottomButtonBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("scrollToBottomButtonBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrollToBottomButtonBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setScrollToBottomButtonBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setScrollToBottomButtonBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setScrollToBottomButtonBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor ScrollToBottomButtonBadgeBackgroundColor {
			[Export ("scrollToBottomButtonBadgeBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("scrollToBottomButtonBadgeBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrollToBottomButtonBadgeBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setScrollToBottomButtonBadgeBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setScrollToBottomButtonBadgeBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setScrollToBottomButtonBadgeBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float ScrollToBottomButtonBadgeCornerRadius {
			[Export ("scrollToBottomButtonBadgeCornerRadius")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("scrollToBottomButtonBadgeCornerRadius"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrollToBottomButtonBadgeCornerRadius"));
				}
			}
			
			[Export ("setScrollToBottomButtonBadgeCornerRadius:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setScrollToBottomButtonBadgeCornerRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setScrollToBottomButtonBadgeCornerRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor ScrollToBottomButtonBadgeTextColor {
			[Export ("scrollToBottomButtonBadgeTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("scrollToBottomButtonBadgeTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrollToBottomButtonBadgeTextColor")));
				}
				return ret;
			}
			
			[Export ("setScrollToBottomButtonBadgeTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setScrollToBottomButtonBadgeTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setScrollToBottomButtonBadgeTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float ScrollToBottomButtonCornerRadius {
			[Export ("scrollToBottomButtonCornerRadius")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("scrollToBottomButtonCornerRadius"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrollToBottomButtonCornerRadius"));
				}
			}
			
			[Export ("setScrollToBottomButtonCornerRadius:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setScrollToBottomButtonCornerRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setScrollToBottomButtonCornerRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ScrollToBottomButtonEnabled {
			[Export ("scrollToBottomButtonEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("scrollToBottomButtonEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrollToBottomButtonEnabled"));
				}
			}
			
			[Export ("setScrollToBottomButtonEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setScrollToBottomButtonEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setScrollToBottomButtonEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ScrollToBottomButtonMessagePreviewEnabled {
			[Export ("scrollToBottomButtonMessagePreviewEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("scrollToBottomButtonMessagePreviewEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrollToBottomButtonMessagePreviewEnabled"));
				}
			}
			
			[Export ("setScrollToBottomButtonMessagePreviewEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setScrollToBottomButtonMessagePreviewEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setScrollToBottomButtonMessagePreviewEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor ScrollToBottomButtonMessagePreviewTextColor {
			[Export ("scrollToBottomButtonMessagePreviewTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("scrollToBottomButtonMessagePreviewTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scrollToBottomButtonMessagePreviewTextColor")));
				}
				return ret;
			}
			
			[Export ("setScrollToBottomButtonMessagePreviewTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setScrollToBottomButtonMessagePreviewTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setScrollToBottomButtonMessagePreviewTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor SecureFormBackButtonColor {
			[Export ("secureFormBackButtonColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("secureFormBackButtonColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("secureFormBackButtonColor")));
				}
				return ret;
			}
			
			[Export ("setSecureFormBackButtonColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSecureFormBackButtonColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSecureFormBackButtonColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor SecureFormBubbleBackgroundColor {
			[Export ("secureFormBubbleBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("secureFormBubbleBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("secureFormBubbleBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setSecureFormBubbleBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSecureFormBubbleBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSecureFormBubbleBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor SecureFormBubbleBorderColor {
			[Export ("secureFormBubbleBorderColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("secureFormBubbleBorderColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("secureFormBubbleBorderColor")));
				}
				return ret;
			}
			
			[Export ("setSecureFormBubbleBorderColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSecureFormBubbleBorderColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSecureFormBubbleBorderColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual double SecureFormBubbleBorderWidth {
			[Export ("secureFormBubbleBorderWidth")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("secureFormBubbleBorderWidth"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("secureFormBubbleBorderWidth"));
				}
			}
			
			[Export ("setSecureFormBubbleBorderWidth:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setSecureFormBubbleBorderWidth:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setSecureFormBubbleBorderWidth:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor SecureFormBubbleDescriptionColor {
			[Export ("secureFormBubbleDescriptionColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("secureFormBubbleDescriptionColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("secureFormBubbleDescriptionColor")));
				}
				return ret;
			}
			
			[Export ("setSecureFormBubbleDescriptionColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSecureFormBubbleDescriptionColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSecureFormBubbleDescriptionColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor SecureFormBubbleFillFormButtonBackgroundColor {
			[Export ("secureFormBubbleFillFormButtonBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("secureFormBubbleFillFormButtonBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("secureFormBubbleFillFormButtonBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setSecureFormBubbleFillFormButtonBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSecureFormBubbleFillFormButtonBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSecureFormBubbleFillFormButtonBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor SecureFormBubbleFillFormButtonTextColor {
			[Export ("secureFormBubbleFillFormButtonTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("secureFormBubbleFillFormButtonTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("secureFormBubbleFillFormButtonTextColor")));
				}
				return ret;
			}
			
			[Export ("setSecureFormBubbleFillFormButtonTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSecureFormBubbleFillFormButtonTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSecureFormBubbleFillFormButtonTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor SecureFormBubbleFormImageTintColor {
			[Export ("secureFormBubbleFormImageTintColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("secureFormBubbleFormImageTintColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("secureFormBubbleFormImageTintColor")));
				}
				return ret;
			}
			
			[Export ("setSecureFormBubbleFormImageTintColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSecureFormBubbleFormImageTintColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSecureFormBubbleFormImageTintColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor SecureFormBubbleLoadingIndicatorColor {
			[Export ("secureFormBubbleLoadingIndicatorColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("secureFormBubbleLoadingIndicatorColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("secureFormBubbleLoadingIndicatorColor")));
				}
				return ret;
			}
			
			[Export ("setSecureFormBubbleLoadingIndicatorColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSecureFormBubbleLoadingIndicatorColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSecureFormBubbleLoadingIndicatorColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor SecureFormBubbleTitleColor {
			[Export ("secureFormBubbleTitleColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("secureFormBubbleTitleColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("secureFormBubbleTitleColor")));
				}
				return ret;
			}
			
			[Export ("setSecureFormBubbleTitleColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSecureFormBubbleTitleColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSecureFormBubbleTitleColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string SecureFormCustomFontName {
			[Export ("secureFormCustomFontName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("secureFormCustomFontName")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("secureFormCustomFontName")));
				}
			}
			
			[Export ("setSecureFormCustomFontName:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSecureFormCustomFontName:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSecureFormCustomFontName:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool SecureFormHideLogo {
			[Export ("secureFormHideLogo")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("secureFormHideLogo"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("secureFormHideLogo"));
				}
			}
			
			[Export ("setSecureFormHideLogo:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSecureFormHideLogo:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setSecureFormHideLogo:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor SecureFormNavigationBackgroundColor {
			[Export ("secureFormNavigationBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("secureFormNavigationBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("secureFormNavigationBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setSecureFormNavigationBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSecureFormNavigationBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSecureFormNavigationBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor SecureFormNavigationTitleColor {
			[Export ("secureFormNavigationTitleColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("secureFormNavigationTitleColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("secureFormNavigationTitleColor")));
				}
				return ret;
			}
			
			[Export ("setSecureFormNavigationTitleColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSecureFormNavigationTitleColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSecureFormNavigationTitleColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool SecureFormUIStatusBarStyleLightContent {
			[Export ("secureFormUIStatusBarStyleLightContent")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("secureFormUIStatusBarStyleLightContent"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("secureFormUIStatusBarStyleLightContent"));
				}
			}
			
			[Export ("setSecureFormUIStatusBarStyleLightContent:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSecureFormUIStatusBarStyleLightContent:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setSecureFormUIStatusBarStyleLightContent:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor SendButtonDisabledColor {
			[Export ("sendButtonDisabledColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sendButtonDisabledColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sendButtonDisabledColor")));
				}
				return ret;
			}
			
			[Export ("setSendButtonDisabledColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSendButtonDisabledColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSendButtonDisabledColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor SendButtonDisabledTextColor {
			[Export ("sendButtonDisabledTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sendButtonDisabledTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sendButtonDisabledTextColor")));
				}
				return ret;
			}
			
			[Export ("setSendButtonDisabledTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSendButtonDisabledTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSendButtonDisabledTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor SendButtonEnabledColor {
			[Export ("sendButtonEnabledColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sendButtonEnabledColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sendButtonEnabledColor")));
				}
				return ret;
			}
			
			[Export ("setSendButtonEnabledColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSendButtonEnabledColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSendButtonEnabledColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor SendButtonEnabledTextColor {
			[Export ("sendButtonEnabledTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sendButtonEnabledTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sendButtonEnabledTextColor")));
				}
				return ret;
			}
			
			[Export ("setSendButtonEnabledTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSendButtonEnabledTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSendButtonEnabledTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIImage SendButtonImage {
			[Export ("sendButtonImage", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sendButtonImage")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sendButtonImage")));
				}
				return ret;
			}
			
			[Export ("setSendButtonImage:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSendButtonImage:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSendButtonImage:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual nuint SendingMessageTimeoutInMinutes {
			[Export ("sendingMessageTimeoutInMinutes")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("sendingMessageTimeoutInMinutes"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sendingMessageTimeoutInMinutes"));
				}
			}
			
			[Export ("setSendingMessageTimeoutInMinutes:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setSendingMessageTimeoutInMinutes:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setSendingMessageTimeoutInMinutes:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowOffHoursBanner {
			[Export ("showOffHoursBanner")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showOffHoursBanner"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showOffHoursBanner"));
				}
			}
			
			[Export ("setShowOffHoursBanner:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowOffHoursBanner:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowOffHoursBanner:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowUrgentButtonInTTRNotification {
			[Export ("showUrgentButtonInTTRNotification")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showUrgentButtonInTTRNotification"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showUrgentButtonInTTRNotification"));
				}
			}
			
			[Export ("setShowUrgentButtonInTTRNotification:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowUrgentButtonInTTRNotification:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowUrgentButtonInTTRNotification:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor StructuredContentBubbleBorderColor {
			[Export ("structuredContentBubbleBorderColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("structuredContentBubbleBorderColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("structuredContentBubbleBorderColor")));
				}
				return ret;
			}
			
			[Export ("setStructuredContentBubbleBorderColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setStructuredContentBubbleBorderColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setStructuredContentBubbleBorderColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual double StructuredContentBubbleBorderWidth {
			[Export ("structuredContentBubbleBorderWidth")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("structuredContentBubbleBorderWidth"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("structuredContentBubbleBorderWidth"));
				}
			}
			
			[Export ("setStructuredContentBubbleBorderWidth:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setStructuredContentBubbleBorderWidth:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setStructuredContentBubbleBorderWidth:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual double StructuredContentMapLatitudeDeltaDeltaSpan {
			[Export ("structuredContentMapLatitudeDeltaDeltaSpan")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("structuredContentMapLatitudeDeltaDeltaSpan"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("structuredContentMapLatitudeDeltaDeltaSpan"));
				}
			}
			
			[Export ("setStructuredContentMapLatitudeDeltaDeltaSpan:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setStructuredContentMapLatitudeDeltaDeltaSpan:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setStructuredContentMapLatitudeDeltaDeltaSpan:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual double StructuredContentMapLongitudeDeltaSpan {
			[Export ("structuredContentMapLongitudeDeltaSpan")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("structuredContentMapLongitudeDeltaSpan"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("structuredContentMapLongitudeDeltaSpan"));
				}
			}
			
			[Export ("setStructuredContentMapLongitudeDeltaSpan:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setStructuredContentMapLongitudeDeltaSpan:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setStructuredContentMapLongitudeDeltaSpan:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor SystemBubbleTextColor {
			[Export ("systemBubbleTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("systemBubbleTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("systemBubbleTextColor")));
				}
				return ret;
			}
			
			[Export ("setSystemBubbleTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSystemBubbleTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSystemBubbleTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ToastNotificationsEnabled {
			[Export ("toastNotificationsEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("toastNotificationsEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("toastNotificationsEnabled"));
				}
			}
			
			[Export ("setToastNotificationsEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setToastNotificationsEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setToastNotificationsEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor TtrBannerBackgroundColor {
			[Export ("ttrBannerBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("ttrBannerBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("ttrBannerBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setTtrBannerBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTtrBannerBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTtrBannerBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual double TtrBannerOpacityAlpha {
			[Export ("ttrBannerOpacityAlpha")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("ttrBannerOpacityAlpha"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("ttrBannerOpacityAlpha"));
				}
			}
			
			[Export ("setTtrBannerOpacityAlpha:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setTtrBannerOpacityAlpha:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setTtrBannerOpacityAlpha:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor TtrBannerTextColor {
			[Export ("ttrBannerTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("ttrBannerTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("ttrBannerTextColor")));
				}
				return ret;
			}
			
			[Export ("setTtrBannerTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTtrBannerTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTtrBannerTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual double TtrFirstTimeDelay {
			[Export ("ttrFirstTimeDelay")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("ttrFirstTimeDelay"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("ttrFirstTimeDelay"));
				}
			}
			
			[Export ("setTtrFirstTimeDelay:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setTtrFirstTimeDelay:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setTtrFirstTimeDelay:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool TtrShouldShowTimestamp {
			[Export ("ttrShouldShowTimestamp")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("ttrShouldShowTimestamp"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("ttrShouldShowTimestamp"));
				}
			}
			
			[Export ("setTtrShouldShowTimestamp:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setTtrShouldShowTimestamp:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setTtrShouldShowTimestamp:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual nuint TtrShowFrequencyInSeconds {
			[Export ("ttrShowFrequencyInSeconds")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("ttrShowFrequencyInSeconds"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("ttrShowFrequencyInSeconds"));
				}
			}
			
			[Export ("setTtrShowFrequencyInSeconds:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setTtrShowFrequencyInSeconds:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setTtrShowFrequencyInSeconds:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool TtrShowShiftBanner {
			[Export ("ttrShowShiftBanner")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("ttrShowShiftBanner"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("ttrShowShiftBanner"));
				}
			}
			
			[Export ("setTtrShowShiftBanner:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setTtrShowShiftBanner:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setTtrShowShiftBanner:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float UnreadMessagesCornersRadius {
			[Export ("unreadMessagesCornersRadius")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("unreadMessagesCornersRadius"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("unreadMessagesCornersRadius"));
				}
			}
			
			[Export ("setUnreadMessagesCornersRadius:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setUnreadMessagesCornersRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setUnreadMessagesCornersRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor UnreadMessagesDividerBackgroundColor {
			[Export ("unreadMessagesDividerBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("unreadMessagesDividerBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("unreadMessagesDividerBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setUnreadMessagesDividerBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUnreadMessagesDividerBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUnreadMessagesDividerBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool UnreadMessagesDividerEnabled {
			[Export ("unreadMessagesDividerEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("unreadMessagesDividerEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("unreadMessagesDividerEnabled"));
				}
			}
			
			[Export ("setUnreadMessagesDividerEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setUnreadMessagesDividerEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setUnreadMessagesDividerEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor UnreadMessagesDividerTextColor {
			[Export ("unreadMessagesDividerTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("unreadMessagesDividerTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("unreadMessagesDividerTextColor")));
				}
				return ret;
			}
			
			[Export ("setUnreadMessagesDividerTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUnreadMessagesDividerTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUnreadMessagesDividerTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual LPUrlPreviewStyle UrlPreviewStyle {
			[Export ("urlPreviewStyle", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (LPUrlPreviewStyle) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("urlPreviewStyle"));
				} else {
					return (LPUrlPreviewStyle) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("urlPreviewStyle"));
				}
			}
			
			[Export ("setUrlPreviewStyle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setUrlPreviewStyle:"), (int)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setUrlPreviewStyle:"), (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor UrlRealTimePreviewBackgroundColor {
			[Export ("urlRealTimePreviewBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("urlRealTimePreviewBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("urlRealTimePreviewBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setUrlRealTimePreviewBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUrlRealTimePreviewBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUrlRealTimePreviewBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor UrlRealTimePreviewBorderColor {
			[Export ("urlRealTimePreviewBorderColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("urlRealTimePreviewBorderColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("urlRealTimePreviewBorderColor")));
				}
				return ret;
			}
			
			[Export ("setUrlRealTimePreviewBorderColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUrlRealTimePreviewBorderColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUrlRealTimePreviewBorderColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual nfloat UrlRealTimePreviewBorderWidth {
			[Export ("urlRealTimePreviewBorderWidth")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("urlRealTimePreviewBorderWidth"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("urlRealTimePreviewBorderWidth"));
				}
			}
			
			[Export ("setUrlRealTimePreviewBorderWidth:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setUrlRealTimePreviewBorderWidth:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setUrlRealTimePreviewBorderWidth:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor UrlRealTimePreviewDescriptionTextColor {
			[Export ("urlRealTimePreviewDescriptionTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("urlRealTimePreviewDescriptionTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("urlRealTimePreviewDescriptionTextColor")));
				}
				return ret;
			}
			
			[Export ("setUrlRealTimePreviewDescriptionTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUrlRealTimePreviewDescriptionTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUrlRealTimePreviewDescriptionTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor UrlRealTimePreviewTitleTextColor {
			[Export ("urlRealTimePreviewTitleTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("urlRealTimePreviewTitleTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("urlRealTimePreviewTitleTextColor")));
				}
				return ret;
			}
			
			[Export ("setUrlRealTimePreviewTitleTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUrlRealTimePreviewTitleTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUrlRealTimePreviewTitleTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool UseNonOGTagsForLinkPreview {
			[Export ("useNonOGTagsForLinkPreview")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("useNonOGTagsForLinkPreview"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("useNonOGTagsForLinkPreview"));
				}
			}
			
			[Export ("setUseNonOGTagsForLinkPreview:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setUseNonOGTagsForLinkPreview:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setUseNonOGTagsForLinkPreview:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor UserBubbleBackgroundColor {
			[Export ("userBubbleBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userBubbleBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userBubbleBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setUserBubbleBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserBubbleBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUserBubbleBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor UserBubbleBorderColor {
			[Export ("userBubbleBorderColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userBubbleBorderColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userBubbleBorderColor")));
				}
				return ret;
			}
			
			[Export ("setUserBubbleBorderColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserBubbleBorderColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUserBubbleBorderColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual double UserBubbleBorderWidth {
			[Export ("userBubbleBorderWidth")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("userBubbleBorderWidth"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userBubbleBorderWidth"));
				}
			}
			
			[Export ("setUserBubbleBorderWidth:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setUserBubbleBorderWidth:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setUserBubbleBorderWidth:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float UserBubbleBottomLeftCornerRadius {
			[Export ("userBubbleBottomLeftCornerRadius")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("userBubbleBottomLeftCornerRadius"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userBubbleBottomLeftCornerRadius"));
				}
			}
			
			[Export ("setUserBubbleBottomLeftCornerRadius:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setUserBubbleBottomLeftCornerRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setUserBubbleBottomLeftCornerRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float UserBubbleBottomRightCornerRadius {
			[Export ("userBubbleBottomRightCornerRadius")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("userBubbleBottomRightCornerRadius"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userBubbleBottomRightCornerRadius"));
				}
			}
			
			[Export ("setUserBubbleBottomRightCornerRadius:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setUserBubbleBottomRightCornerRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setUserBubbleBottomRightCornerRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor UserBubbleErrorBorderColor {
			[Export ("userBubbleErrorBorderColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userBubbleErrorBorderColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userBubbleErrorBorderColor")));
				}
				return ret;
			}
			
			[Export ("setUserBubbleErrorBorderColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserBubbleErrorBorderColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUserBubbleErrorBorderColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor UserBubbleErrorTextColor {
			[Export ("userBubbleErrorTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userBubbleErrorTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userBubbleErrorTextColor")));
				}
				return ret;
			}
			
			[Export ("setUserBubbleErrorTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserBubbleErrorTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUserBubbleErrorTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor UserBubbleLinkColor {
			[Export ("userBubbleLinkColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userBubbleLinkColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userBubbleLinkColor")));
				}
				return ret;
			}
			
			[Export ("setUserBubbleLinkColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserBubbleLinkColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUserBubbleLinkColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float UserBubbleLongPressOverlayAlpha {
			[Export ("userBubbleLongPressOverlayAlpha")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("userBubbleLongPressOverlayAlpha"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userBubbleLongPressOverlayAlpha"));
				}
			}
			
			[Export ("setUserBubbleLongPressOverlayAlpha:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setUserBubbleLongPressOverlayAlpha:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setUserBubbleLongPressOverlayAlpha:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor UserBubbleLongPressOverlayColor {
			[Export ("userBubbleLongPressOverlayColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userBubbleLongPressOverlayColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userBubbleLongPressOverlayColor")));
				}
				return ret;
			}
			
			[Export ("setUserBubbleLongPressOverlayColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserBubbleLongPressOverlayColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUserBubbleLongPressOverlayColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor UserBubbleSendStatusTextColor {
			[Export ("userBubbleSendStatusTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userBubbleSendStatusTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userBubbleSendStatusTextColor")));
				}
				return ret;
			}
			
			[Export ("setUserBubbleSendStatusTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserBubbleSendStatusTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUserBubbleSendStatusTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor UserBubbleTextColor {
			[Export ("userBubbleTextColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userBubbleTextColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userBubbleTextColor")));
				}
				return ret;
			}
			
			[Export ("setUserBubbleTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserBubbleTextColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUserBubbleTextColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIColor UserBubbleTimestampColor {
			[Export ("userBubbleTimestampColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userBubbleTimestampColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userBubbleTimestampColor")));
				}
				return ret;
			}
			
			[Export ("setUserBubbleTimestampColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserBubbleTimestampColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUserBubbleTimestampColor:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float UserBubbleTopLeftCornerRadius {
			[Export ("userBubbleTopLeftCornerRadius")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("userBubbleTopLeftCornerRadius"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userBubbleTopLeftCornerRadius"));
				}
			}
			
			[Export ("setUserBubbleTopLeftCornerRadius:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setUserBubbleTopLeftCornerRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setUserBubbleTopLeftCornerRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float UserBubbleTopRightCornerRadius {
			[Export ("userBubbleTopRightCornerRadius")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("userBubbleTopRightCornerRadius"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userBubbleTopRightCornerRadius"));
				}
			}
			
			[Export ("setUserBubbleTopRightCornerRadius:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setUserBubbleTopRightCornerRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setUserBubbleTopRightCornerRadius:"), value);
				}
			}
		}
		
	} /* class LPConfig */
}
