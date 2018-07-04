using System;
using AVFoundation;
using CloudKit;
using CoreAnimation;
using CoreData;
using CoreFoundation;
using CoreGraphics;
using CoreImage;
using CoreLocation;
using CoreVideo;
using FileProvider;
using Foundation;
using IOSurface;
using ImageIO;
using Intents;
using Metal;
using ObjCRuntime;
using OpenGLES;
using Security;
using UIKit;
using WebKit;
using System.Collections.Generic;

namespace LivePersonChat
{


    // @interface GeneralResponse : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface GeneralResponse
    {
        // @property (copy, nonatomic) NSString * _Nullable kind;
        [NullAllowed, Export("kind")]
        string Kind { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable reqId;
        [NullAllowed, Export("reqId")]
        string ReqId { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable type;
        [NullAllowed, Export("type")]
        string Type { get; set; }

        // -(instancetype _Nonnull)initWithJsonDict:(NSDictionary<NSString *,id> * _Nonnull)jsonDict __attribute__((objc_designated_initializer));
        [Export("initWithJsonDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> jsonDict);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull responseDescription;
        [Export("responseDescription")]
        string ResponseDescription { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        GeneralResponse New();
    }

    // @interface AgentStateNotification : GeneralResponse
    [BaseType(typeof(GeneralResponse))]
    interface AgentStateNotification
    {
        // -(instancetype _Nonnull)initWithJsonDict:(NSDictionary<NSString *,id> * _Nonnull)jsonDict __attribute__((objc_designated_initializer));
        [Export("initWithJsonDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> jsonDict);
    }

    // @protocol ConversationParamProtocol

    [Protocol, Model]
    interface ConversationParamProtocol
    {
        // @required -(NSArray<LPConversationEntity *> * _Nullable)getConversations __attribute__((warn_unused_result));
        [Abstract]
        [NullAllowed, Export("getConversations")]

        LPConversationEntity[] Conversations { get; }

        // @required -(NSArray<LPConversationEntity *> * _Nullable)getConversations:(NSPredicate * _Nullable)predicate __attribute__((warn_unused_result));
        [Abstract]
        [Export("getConversations:")]
        [return: NullAllowed]
        LPConversationEntity[] GetConversations([NullAllowed] NSPredicate predicate);

        // @required -(NSArray<LPConversationEntity *> * _Nullable)getClosedConversations __attribute__((warn_unused_result));
        [Abstract]
        [NullAllowed, Export("getClosedConversations")]

        LPConversationEntity[] ClosedConversations { get; }

        // @required -(LPConversationEntity * _Nullable)getActiveConversation __attribute__((warn_unused_result));
        [Abstract]
        [NullAllowed, Export("getActiveConversation")]

        LPConversationEntity ActiveConversation { get; }

        // @required -(LPConversationEntity * _Nullable)getOpenConversation __attribute__((warn_unused_result));
        [Abstract]
        [NullAllowed, Export("getOpenConversation")]

        LPConversationEntity OpenConversation { get; }

        // @required -(NSArray<LPConversationEntity *> * _Nullable)getLatestClosedConversation:(NSInteger)conversationsCount __attribute__((warn_unused_result));
        [Abstract]
        [Export("getLatestClosedConversation:")]
        [return: NullAllowed]
        LPConversationEntity[] GetLatestClosedConversation(nint conversationsCount);

        // @required -(LPConversationEntity * _Nonnull)createNewConversation __attribute__((warn_unused_result));
        [Abstract]
        [Export("createNewConversation")]

        LPConversationEntity CreateNewConversation { get; }

        // @required -(NSString * _Nonnull)getQueryType __attribute__((warn_unused_result));
        [Abstract]
        [Export("getQueryType")]

        string QueryType { get; }

        // @required -(BOOL)isConversationRelatedToQuery:(LPConversationEntity * _Nonnull)conversation __attribute__((warn_unused_result));
        [Abstract]
        [Export("isConversationRelatedToQuery:")]
        bool IsConversationRelatedToQuery(LPConversationEntity conversation);

        // @required -(NSString * _Nonnull)getBrandID __attribute__((warn_unused_result));
        [Abstract]
        [Export("getBrandID")]

        string BrandID { get; }

        // @required -(NSString * _Nonnull)getQueryUID __attribute__((warn_unused_result));
        [Abstract]
        [Export("getQueryUID")]

        string QueryUID { get; }

        // @required -(NSDictionary<NSString *,id> * _Nonnull)getQueryProperties __attribute__((warn_unused_result));
        [Abstract]
        [Export("getQueryProperties")]

        NSDictionary<NSString, NSObject> QueryProperties { get; }
    }

    // @interface BrandQuery : NSObject <ConversationParamProtocol>
    [BaseType(typeof(NSObject))]//, nam = "TtP7LPInfra25ConversationParamProtocol")]
    [DisableDefaultCtor]
    interface BrandQuery : ConversationParamProtocol
    {
        // -(instancetype _Nonnull)initWithBrandID:(NSString * _Nonnull)brandID campaignInfo:(LPCampaignInfo * _Nullable)campaignInfo __attribute__((objc_designated_initializer));
        [Export("initWithBrandID:campaignInfo:")]
        [DesignatedInitializer]
        IntPtr Constructor(string brandID, [NullAllowed] LPCampaignInfo campaignInfo);

        // -(NSArray<LPConversationEntity *> * _Nullable)getConversations __attribute__((warn_unused_result));
        [NullAllowed, Export("getConversations")]

        LPConversationEntity[] Conversations { get; }

        // -(NSArray<LPConversationEntity *> * _Nullable)getConversations:(NSPredicate * _Nullable)predicate __attribute__((warn_unused_result));
        [Export("getConversations:")]
        [return: NullAllowed]
        LPConversationEntity[] GetConversations([NullAllowed] NSPredicate predicate);

        // -(LPConversationEntity * _Nullable)getActiveConversation __attribute__((warn_unused_result));
        [NullAllowed, Export("getActiveConversation")]

        LPConversationEntity ActiveConversation { get; }

        // -(NSArray<LPConversationEntity *> * _Nullable)getClosedConversations __attribute__((warn_unused_result));
        [NullAllowed, Export("getClosedConversations")]

        LPConversationEntity[] ClosedConversations { get; }

        // -(LPConversationEntity * _Nullable)getOpenConversation __attribute__((warn_unused_result));
        [NullAllowed, Export("getOpenConversation")]

        LPConversationEntity OpenConversation { get; }

        // -(NSArray<LPConversationEntity *> * _Nullable)getLatestClosedConversation:(NSInteger)conversationsCount __attribute__((warn_unused_result));
        [Export("getLatestClosedConversation:")]
        [return: NullAllowed]
        LPConversationEntity[] GetLatestClosedConversation(nint conversationsCount);

        // -(LPConversationEntity * _Nonnull)createNewConversation __attribute__((warn_unused_result));
        [Export("createNewConversation")]

        LPConversationEntity CreateNewConversation { get; }

        // -(NSString * _Nonnull)getQueryType __attribute__((warn_unused_result));
        [Export("getQueryType")]

        string QueryType { get; }

        // -(BOOL)isConversationRelatedToQuery:(LPConversationEntity * _Nonnull)conversation __attribute__((warn_unused_result));
        [Export("isConversationRelatedToQuery:")]
        bool IsConversationRelatedToQuery(LPConversationEntity conversation);

        // -(NSString * _Nonnull)getBrandID __attribute__((warn_unused_result));
        [Export("getBrandID")]

        string BrandID { get; }

        // -(NSString * _Nonnull)getQueryUID __attribute__((warn_unused_result));
        [Export("getQueryUID")]

        string QueryUID { get; }

        // -(LPCampaignInfo * _Nullable)getCampaignInfo __attribute__((warn_unused_result));
        [NullAllowed, Export("getCampaignInfo")]

        LPCampaignInfo CampaignInfo { get; }

        // -(NSDictionary<NSString *,id> * _Nonnull)getQueryProperties __attribute__((warn_unused_result));
        [Export("getQueryProperties")]

        NSDictionary<NSString, NSObject> QueryProperties { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        BrandQuery New();
    }

    // @interface CSATModel : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface CSATModel
    {
        // @property (nonatomic) BOOL skipped __attribute__((diagnose_if(0x7fcad78c25b0, "Swift property 'CSATModel.skipped' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("skipped")]
        bool Skipped { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        CSATModel New();
    }

    // @interface ConsumerQuery : BrandQuery
    [BaseType(typeof(BrandQuery))]
    interface ConsumerQuery
    {
        // -(instancetype _Nonnull)initWithConsumerID:(NSString * _Nonnull)consumerID brandID:(NSString * _Nonnull)brandID agentToken:(NSString * _Nonnull)agentToken __attribute__((objc_designated_initializer));
        [Export("initWithConsumerID:brandID:agentToken:")]
        [DesignatedInitializer]
        IntPtr Constructor(string consumerID, string brandID, string agentToken);

        // -(NSArray<LPConversationEntity *> * _Nullable)getConversations __attribute__((warn_unused_result));
        [NullAllowed, Export("getConversations")]

        LPConversationEntity[] Conversations { get; }

        // -(LPConversationEntity * _Nullable)getActiveConversation __attribute__((warn_unused_result));
        [NullAllowed, Export("getActiveConversation")]

        LPConversationEntity ActiveConversation { get; }

        // -(NSArray<LPConversationEntity *> * _Nullable)getConversations:(NSPredicate * _Nullable)predicate __attribute__((warn_unused_result));
        [Export("getConversations:")]
        [return: NullAllowed]
        LPConversationEntity[] GetConversations([NullAllowed] NSPredicate predicate);

        // -(LPConversationEntity * _Nonnull)createNewConversation __attribute__((warn_unused_result));
        [Export("createNewConversation")]

        LPConversationEntity CreateNewConversation { get; }

        // -(NSString * _Nonnull)getQueryType __attribute__((warn_unused_result));
        [Export("getQueryType")]

        string QueryType { get; }

        // -(BOOL)isConversationRelatedToQuery:(LPConversationEntity * _Nonnull)conversation __attribute__((warn_unused_result));
        [Export("isConversationRelatedToQuery:")]
        bool IsConversationRelatedToQuery(LPConversationEntity conversation);

        // -(NSString * _Nonnull)getQueryUID __attribute__((warn_unused_result));
        [Export("getQueryUID")]

        string QueryUID { get; }
    }

    // @interface ConversationChangeNotification : GeneralResponse
    [BaseType(typeof(GeneralResponse))]
    interface ConversationChangeNotification
    {
        // -(instancetype _Nonnull)initWithJsonDict:(NSDictionary<NSString *,id> * _Nonnull)jsonDict __attribute__((objc_designated_initializer));
        [Export("initWithJsonDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> jsonDict);
    }

    // @interface EngagementHistoryConsumerMessagesResponse : GeneralResponse
    [BaseType(typeof(GeneralResponse))]
    interface EngagementHistoryConsumerMessagesResponse
    {
        // @property (copy, nonatomic) NSString * _Nullable ownerConversationID;
        [NullAllowed, Export("ownerConversationID")]
        string OwnerConversationID { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable brandID;
        [NullAllowed, Export("brandID")]
        string BrandID { get; set; }

        // -(instancetype _Nonnull)initWithJsonDict:(NSDictionary<NSString *,id> * _Nonnull)jsonDict __attribute__((objc_designated_initializer));
        [Export("initWithJsonDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> jsonDict);
    }

    // @interface EngagementHistoryRequest : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface EngagementHistoryRequest
    {
        // @property (copy, nonatomic) NSString * _Nonnull brandID __attribute__((diagnose_if(0x7fcad78c5308, "Swift property 'EngagementHistoryRequest.brandID' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("brandID")]
        string BrandID { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable agentBearer __attribute__((diagnose_if(0x7fcad78c5610, "Swift property 'EngagementHistoryRequest.agentBearer' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("agentBearer")]
        string AgentBearer { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable jwt __attribute__((diagnose_if(0x7fcad78c5918, "Swift property 'EngagementHistoryRequest.jwt' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("jwt")]
        string Jwt { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable consumerID __attribute__((diagnose_if(0x7fcad78c5c20, "Swift property 'EngagementHistoryRequest.consumerID' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("consumerID")]
        string ConsumerID { get; set; }

        // @property (copy, nonatomic) NSArray<NSString *> * _Nullable conversationsStatus __attribute__((diagnose_if(0x7fcad78c5fb8, "Swift property 'EngagementHistoryRequest.conversationsStatus' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("conversationsStatus", ArgumentSemantic.Copy)]
        string[] ConversationsStatus { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable sortKeyword __attribute__((diagnose_if(0x7fcad78c6298, "Swift property 'EngagementHistoryRequest.sortKeyword' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("sortKeyword")]
        string SortKeyword { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable searchKeyword __attribute__((diagnose_if(0x7fcad78c65b0, "Swift property 'EngagementHistoryRequest.searchKeyword' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("searchKeyword")]
        string SearchKeyword { get; set; }

        // @property (nonatomic, strong) LPConversationEntity * _Nullable conversation __attribute__((diagnose_if(0x7fcad78c68c0, "Swift property 'EngagementHistoryRequest.conversation' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("conversation", ArgumentSemantic.Strong)]
        LPConversationEntity Conversation { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable url __attribute__((diagnose_if(0x7fcad78c6b90, "Swift property 'EngagementHistoryRequest.url' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("url")]
        string Url { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        EngagementHistoryRequest New();
    }

    // @interface ErrorResponse : GeneralResponse
    [BaseType(typeof(GeneralResponse))]
    interface ErrorResponse
    {
        // -(instancetype _Nonnull)initWithJsonDict:(NSDictionary<NSString *,id> * _Nonnull)jsonDict __attribute__((objc_designated_initializer));
        [Export("initWithJsonDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> jsonDict);
    }

    // @interface ExConversationChangeNotification : GeneralResponse
    [BaseType(typeof(GeneralResponse))]
    interface ExConversationChangeNotification
    {
        // -(instancetype _Nonnull)initWithJsonDict:(NSDictionary<NSString *,id> * _Nonnull)jsonDict __attribute__((objc_designated_initializer));
        [Export("initWithJsonDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> jsonDict);
    }

    // @protocol GeneralManagerProtocol
    //[BaseType(typeof(GeneralManagerProtocol))]
    [Protocol, Model]
    interface GeneralManagerProtocol
    {
        // @required -(void)clearManager;
        [Abstract]
        [Export("clearManager")]
        void ClearManager();
    }

    // @interface SubscribeExConversations : GeneralResponse
    [BaseType(typeof(GeneralResponse))]
    interface SubscribeExConversations
    {
        // -(instancetype _Nonnull)initWithJsonDict:(NSDictionary<NSString *,id> * _Nonnull)jsonDict __attribute__((objc_designated_initializer));
        [Export("initWithJsonDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> jsonDict);
    }

    // @interface GenericSubscribeResponse : SubscribeExConversations
    [BaseType(typeof(SubscribeExConversations))]
    interface GenericSubscribeResponse
    {
        // -(instancetype _Nonnull)initWithJsonDict:(NSDictionary<NSString *,id> * _Nonnull)jsonDict __attribute__((objc_designated_initializer));
        [Export("initWithJsonDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> jsonDict);
    }

    // @interface GetBrandProfile : GeneralResponse
    [BaseType(typeof(GeneralResponse))]
    interface GetBrandProfile
    {
        // -(instancetype _Nonnull)initWithJsonDict:(NSDictionary<NSString *,id> * _Nonnull)jsonDict __attribute__((objc_designated_initializer));
        [Export("initWithJsonDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> jsonDict);
    }

    // @interface GetClock : GeneralResponse
    [BaseType(typeof(GeneralResponse))]
    interface GetClock
    {
        // -(instancetype _Nonnull)initWithJsonDict:(NSDictionary<NSString *,id> * _Nonnull)jsonDict __attribute__((objc_designated_initializer));
        [Export("initWithJsonDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> jsonDict);
    }

    // @interface GetUserProfile : GeneralResponse
    [BaseType(typeof(GeneralResponse))]
    interface GetUserProfile
    {
        // -(instancetype _Nonnull)initWithJsonDict:(NSDictionary<NSString *,id> * _Nonnull)jsonDict __attribute__((objc_designated_initializer));
        [Export("initWithJsonDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> jsonDict);

        // -(instancetype _Nonnull)initWithAcCdnDictionary:(NSDictionary<NSString *,id> * _Nonnull)acCdnDictionary __attribute__((objc_designated_initializer));
        /* [Export("initWithAcCdnDictionary:")]
         [DesignatedInitializer]
         IntPtr Constructor(NSDictionary<NSString, NSObject> acCdnDictionary); */
    }


    // @interface LPAccountEntity : NSManagedObject
    [BaseType(typeof(NSManagedObject))]
    interface LPAccountEntity
    {
        // @property (copy, nonatomic) NSString * _Nonnull accountId;
        [Export("accountId")]
        string AccountId { get; set; }

        // @property (nonatomic, strong) LPBrandEntity * _Nonnull brand;
        [Export("brand", ArgumentSemantic.Strong)]
        LPBrandEntity Brand { get; set; }

        // -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
        [Export("initWithEntity:insertIntoManagedObjectContext:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
    }

    // @interface LPAuthenticationParams : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface LPAuthenticationParams
    {
        // @property (copy, nonatomic) NSString * _Nullable authenticationCode;
        [NullAllowed, Export("authenticationCode")]
        string AuthenticationCode { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable jwt;
        [NullAllowed, Export("jwt")]
        string Jwt { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable redirectURI;
        [NullAllowed, Export("redirectURI")]
        string RedirectURI { get; set; }

        // @property (copy, nonatomic) NSArray<NSString *> * _Nullable certPinningPublicKeys;
        [NullAllowed, Export("certPinningPublicKeys", ArgumentSemantic.Copy)]
        string[] CertPinningPublicKeys { get; set; }

        // -(instancetype _Nonnull)initWithAuthenticationCode:(NSString * _Nullable)authenticationCode jwt:(NSString * _Nullable)jwt redirectURI:(NSString * _Nullable)redirectURI certPinningPublicKeys:(NSArray<NSString *> * _Nullable)certPinningPublicKeys __attribute__((objc_designated_initializer));
        [Export("initWithAuthenticationCode:jwt:redirectURI:certPinningPublicKeys:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] string authenticationCode, [NullAllowed] string jwt, [NullAllowed] string redirectURI, [NullAllowed] string[] certPinningPublicKeys);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        LPAuthenticationParams New();
    }

    // @interface LPBrandEntity : NSManagedObject
    [BaseType(typeof(NSManagedObject))]
    interface LPBrandEntity
    {
        // @property (copy, nonatomic) NSString * _Nonnull iconURL;
        [Export("iconURL")]
        string IconURL { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable imageURL;
        [NullAllowed, Export("imageURL")]
        string ImageURL { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable logoURL;
        [NullAllowed, Export("logoURL")]
        string LogoURL { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull name;
        [Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull uid;
        [Export("uid")]
        string Uid { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull details;
        [Export("details")]
        string Details { get; set; }

        // @property (nonatomic, strong) NSSet * _Nonnull brandCampaigns;
        [Export("brandCampaigns", ArgumentSemantic.Strong)]
        NSSet BrandCampaigns { get; set; }

        // @property (nonatomic, strong) NSSet * _Nonnull brandConversations;
        [Export("brandConversations", ArgumentSemantic.Strong)]
        NSSet BrandConversations { get; set; }

        // @property (copy, nonatomic) NSDate * _Nonnull dateJoined;
        [Export("dateJoined", ArgumentSemantic.Copy)]
        NSDate DateJoined { get; set; }

        // @property (nonatomic) BOOL hidden;
        [Export("hidden")]
        bool Hidden { get; set; }

        // @property (nonatomic, strong) NSSet * _Nonnull accounts;
        [Export("accounts", ArgumentSemantic.Strong)]
        NSSet Accounts { get; set; }

        // @property (nonatomic, strong) LPAuthenticationParams * _Nullable authenticationParams;
        [NullAllowed, Export("authenticationParams", ArgumentSemantic.Strong)]
        LPAuthenticationParams AuthenticationParams { get; set; }

        // -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
        [Export("initWithEntity:insertIntoManagedObjectContext:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
    }

    // @interface LPInfra_Swift_434 (LPBrandEntity)
    [Category]
    [BaseType(typeof(LPBrandEntity))]
    interface LPBrandEntity_LPInfra_Swift_434
    {
        // -(LPConversationEntity * _Nullable)getCreatedConversation __attribute__((warn_unused_result));
        [NullAllowed, Export("getCreatedConversation")]

        LPConversationEntity CreatedConversation { get; }

        // -(NSArray<LPConversationEntity *> * _Nonnull)getConversations __attribute__((warn_unused_result));
        [Export("getConversations")]

        LPConversationEntity[] Conversations { get; }

        // -(NSArray<LPConversationEntity *> * _Nonnull)getConversations:(NSPredicate * _Nullable)predicate __attribute__((warn_unused_result));
        [Export("getConversations:")]
        LPConversationEntity[] GetConversations([NullAllowed] NSPredicate predicate);

        // -(NSDate * _Nullable)getLastMessageTimeStamp __attribute__((warn_unused_result));
        [NullAllowed, Export("getLastMessageTimeStamp")]

        NSDate LastMessageTimeStamp { get; }

        // -(BOOL)isAuthenticated __attribute__((warn_unused_result));
        [Export("isAuthenticated")]

        bool IsAuthenticated { get; }
    }

    // @interface LPCampaignEntity : NSManagedObject
    [BaseType(typeof(NSManagedObject))]
    interface LPCampaignEntity
    {
        // @property (copy, nonatomic) NSString * _Nonnull uid;
        [Export("uid")]
        string Uid { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull name;
        [Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull image;
        [Export("image")]
        string Image { get; set; }

        // @property (nonatomic, strong) LPBrandEntity * _Nonnull ownerBrand;
        [Export("ownerBrand", ArgumentSemantic.Strong)]
        LPBrandEntity OwnerBrand { get; set; }

        // -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
        [Export("initWithEntity:insertIntoManagedObjectContext:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
    }

    // @interface LPCampaignInfo : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface LPCampaignInfo
    {
        // @property (nonatomic) NSInteger campaignId;
        [Export("campaignId")]
        nint CampaignId { get; set; }

        // @property (nonatomic) NSInteger engagementId;
        [Export("engagementId")]
        nint EngagementId { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable sessionId;
        [NullAllowed, Export("sessionId")]
        string SessionId { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable visitorId;
        [NullAllowed, Export("visitorId")]
        string VisitorId { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull contextId;
        [Export("contextId")]
        string ContextId { get; set; }

        // -(instancetype _Nonnull)initWithCampaignId:(NSInteger)campaignId engagementId:(NSInteger)engagementId contextId:(NSString * _Nonnull)contextId sessionId:(NSString * _Nullable)sessionId visitorId:(NSString * _Nullable)visitorId __attribute__((objc_designated_initializer));
        [Export("initWithCampaignId:engagementId:contextId:sessionId:visitorId:")]
        [DesignatedInitializer]
        IntPtr Constructor(nint campaignId, nint engagementId, string contextId, [NullAllowed] string sessionId, [NullAllowed] string visitorId);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        LPCampaignInfo New();
    }

    // @interface LPConfig : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface LPConfig
    {
        // @property (nonatomic, strong) UIColor * _Nonnull remoteUserBubbleBackgroundColor;
        [Export("remoteUserBubbleBackgroundColor", ArgumentSemantic.Strong)]
        UIColor RemoteUserBubbleBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull remoteUserBubbleBorderColor;
        [Export("remoteUserBubbleBorderColor", ArgumentSemantic.Strong)]
        UIColor RemoteUserBubbleBorderColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull remoteUserBubbleLinkColor;
        [Export("remoteUserBubbleLinkColor", ArgumentSemantic.Strong)]
        UIColor RemoteUserBubbleLinkColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull remoteUserBubbleTextColor;
        [Export("remoteUserBubbleTextColor", ArgumentSemantic.Strong)]
        UIColor RemoteUserBubbleTextColor { get; set; }

        // @property (nonatomic) double remoteUserBubbleBorderWidth;
        [Export("remoteUserBubbleBorderWidth")]
        double RemoteUserBubbleBorderWidth { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull remoteUserBubbleTimestampColor;
        [Export("remoteUserBubbleTimestampColor", ArgumentSemantic.Strong)]
        UIColor RemoteUserBubbleTimestampColor { get; set; }

        // @property (nonatomic) BOOL messageStatusNumericTimestampOnly;
        [Export("messageStatusNumericTimestampOnly")]
        bool MessageStatusNumericTimestampOnly { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull remoteUserTypingTintColor;
        [Export("remoteUserTypingTintColor", ArgumentSemantic.Strong)]
        UIColor RemoteUserTypingTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull remoteUserBubbleLongPressOverlayColor;
        [Export("remoteUserBubbleLongPressOverlayColor", ArgumentSemantic.Strong)]
        UIColor RemoteUserBubbleLongPressOverlayColor { get; set; }

        // @property (nonatomic) float remoteUserBubbleLongPressOverlayAlpha;
        [Export("remoteUserBubbleLongPressOverlayAlpha")]
        float RemoteUserBubbleLongPressOverlayAlpha { get; set; }

        // @property (nonatomic) float remoteUserBubbleTopLeftCornerRadius;
        [Export("remoteUserBubbleTopLeftCornerRadius")]
        float RemoteUserBubbleTopLeftCornerRadius { get; set; }

        // @property (nonatomic) float remoteUserBubbleTopRightCornerRadius;
        [Export("remoteUserBubbleTopRightCornerRadius")]
        float RemoteUserBubbleTopRightCornerRadius { get; set; }

        // @property (nonatomic) float remoteUserBubbleBottomLeftCornerRadius;
        [Export("remoteUserBubbleBottomLeftCornerRadius")]
        float RemoteUserBubbleBottomLeftCornerRadius { get; set; }

        // @property (nonatomic) float remoteUserBubbleBottomRightCornerRadius;
        [Export("remoteUserBubbleBottomRightCornerRadius")]
        float RemoteUserBubbleBottomRightCornerRadius { get; set; }

        // @property (nonatomic) float userBubbleTopLeftCornerRadius;
        [Export("userBubbleTopLeftCornerRadius")]
        float UserBubbleTopLeftCornerRadius { get; set; }

        // @property (nonatomic) float userBubbleTopRightCornerRadius;
        [Export("userBubbleTopRightCornerRadius")]
        float UserBubbleTopRightCornerRadius { get; set; }

        // @property (nonatomic) float userBubbleBottomLeftCornerRadius;
        [Export("userBubbleBottomLeftCornerRadius")]
        float UserBubbleBottomLeftCornerRadius { get; set; }

        // @property (nonatomic) float userBubbleBottomRightCornerRadius;
        [Export("userBubbleBottomRightCornerRadius")]
        float UserBubbleBottomRightCornerRadius { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull userBubbleBackgroundColor;
        [Export("userBubbleBackgroundColor", ArgumentSemantic.Strong)]
        UIColor UserBubbleBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull userBubbleBorderColor;
        [Export("userBubbleBorderColor", ArgumentSemantic.Strong)]
        UIColor UserBubbleBorderColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull userBubbleLinkColor;
        [Export("userBubbleLinkColor", ArgumentSemantic.Strong)]
        UIColor UserBubbleLinkColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull userBubbleTextColor;
        [Export("userBubbleTextColor", ArgumentSemantic.Strong)]
        UIColor UserBubbleTextColor { get; set; }

        // @property (nonatomic) double userBubbleBorderWidth;
        [Export("userBubbleBorderWidth")]
        double UserBubbleBorderWidth { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull userBubbleTimestampColor;
        [Export("userBubbleTimestampColor", ArgumentSemantic.Strong)]
        UIColor UserBubbleTimestampColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull userBubbleSendStatusTextColor;
        [Export("userBubbleSendStatusTextColor", ArgumentSemantic.Strong)]
        UIColor UserBubbleSendStatusTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull userBubbleErrorTextColor;
        [Export("userBubbleErrorTextColor", ArgumentSemantic.Strong)]
        UIColor UserBubbleErrorTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull userBubbleErrorBorderColor;
        [Export("userBubbleErrorBorderColor", ArgumentSemantic.Strong)]
        UIColor UserBubbleErrorBorderColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull userBubbleLongPressOverlayColor;
        [Export("userBubbleLongPressOverlayColor", ArgumentSemantic.Strong)]
        UIColor UserBubbleLongPressOverlayColor { get; set; }

        // @property (nonatomic) float userBubbleLongPressOverlayAlpha;
        [Export("userBubbleLongPressOverlayAlpha")]
        float UserBubbleLongPressOverlayAlpha { get; set; }

        // @property (nonatomic) BOOL enableLinkPreview;
        [Export("enableLinkPreview")]
        bool EnableLinkPreview { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull linkPreviewBackgroundColor;
        [Export("linkPreviewBackgroundColor", ArgumentSemantic.Strong)]
        UIColor LinkPreviewBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull linkPreviewTitleTextColor;
        [Export("linkPreviewTitleTextColor", ArgumentSemantic.Strong)]
        UIColor LinkPreviewTitleTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull linkPreviewDescriptionTextColor;
        [Export("linkPreviewDescriptionTextColor", ArgumentSemantic.Strong)]
        UIColor LinkPreviewDescriptionTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull linkPreviewSiteNameTextColor;
        [Export("linkPreviewSiteNameTextColor", ArgumentSemantic.Strong)]
        UIColor LinkPreviewSiteNameTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull linkPreviewBorderColor;
        [Export("linkPreviewBorderColor", ArgumentSemantic.Strong)]
        UIColor LinkPreviewBorderColor { get; set; }

        // @property (nonatomic) double linkPreviewBorderWidth;
        [Export("linkPreviewBorderWidth")]
        double LinkPreviewBorderWidth { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable bubbleEmailLinksRegex;
        [NullAllowed, Export("bubbleEmailLinksRegex")]
        string BubbleEmailLinksRegex { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable bubbleUrlLinksRegex;
        [NullAllowed, Export("bubbleUrlLinksRegex")]
        string BubbleUrlLinksRegex { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable bubblePhoneLinksRegex;
        [NullAllowed, Export("bubblePhoneLinksRegex")]
        string BubblePhoneLinksRegex { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull systemBubbleTextColor;
        [Export("systemBubbleTextColor", ArgumentSemantic.Strong)]
        UIColor SystemBubbleTextColor { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull customButtonIconName;
        [Export("customButtonIconName")]
        string CustomButtonIconName { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable customButtonImage;
        [NullAllowed, Export("customButtonImage", ArgumentSemantic.Strong)]
        UIImage CustomButtonImage { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull customButtonDescription;
        [Export("customButtonDescription")]
        string CustomButtonDescription { get; set; }

        // @property (nonatomic) BOOL announceAgentTyping;
        [Export("announceAgentTyping")]
        bool AnnounceAgentTyping { get; set; }

        // @property (nonatomic) enum CheckmarksState checkmarkVisibility;
        [Export("checkmarkVisibility", ArgumentSemantic.Assign)]
        CheckmarksState CheckmarkVisibility { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull checkmarkSentColor;
        [Export("checkmarkSentColor", ArgumentSemantic.Strong)]
        UIColor CheckmarkSentColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull checkmarkDistributedColor;
        [Export("checkmarkDistributedColor", ArgumentSemantic.Strong)]
        UIColor CheckmarkDistributedColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull checkmarkReadColor;
        [Export("checkmarkReadColor", ArgumentSemantic.Strong)]
        UIColor CheckmarkReadColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull checkmarkColor;
        [Export("checkmarkColor", ArgumentSemantic.Strong)]
        UIColor CheckmarkColor { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull readReceiptTextSent;
        [Export("readReceiptTextSent")]
        string ReadReceiptTextSent { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull readReceiptTextDistributed;
        [Export("readReceiptTextDistributed")]
        string ReadReceiptTextDistributed { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull readReceiptTextRead;
        [Export("readReceiptTextRead")]
        string ReadReceiptTextRead { get; set; }

        // @property (nonatomic) BOOL isReadReceiptTextMode;
        [Export("isReadReceiptTextMode")]
        bool IsReadReceiptTextMode { get; set; }

        // @property (nonatomic) double csatSubmitButtonCornerRadius;
        [Export("csatSubmitButtonCornerRadius")]
        double CsatSubmitButtonCornerRadius { get; set; }

        // @property (nonatomic) double csatYesNoButtonsCornerRadius;
        [Export("csatYesNoButtonsCornerRadius")]
        double CsatYesNoButtonsCornerRadius { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull csatSubmitButtonBackgroundColor;
        [Export("csatSubmitButtonBackgroundColor", ArgumentSemantic.Strong)]
        UIColor CsatSubmitButtonBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull csatSubmitButtonTextColor;
        [Export("csatSubmitButtonTextColor", ArgumentSemantic.Strong)]
        UIColor CsatSubmitButtonTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull csatRatingButtonSelectedColor;
        [Export("csatRatingButtonSelectedColor", ArgumentSemantic.Strong)]
        UIColor CsatRatingButtonSelectedColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull csatResolutionButtonSelectedColor;
        [Export("csatResolutionButtonSelectedColor", ArgumentSemantic.Strong)]
        UIColor CsatResolutionButtonSelectedColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull csatAllTitlesTextColor;
        [Export("csatAllTitlesTextColor", ArgumentSemantic.Strong)]
        UIColor CsatAllTitlesTextColor { get; set; }

        // @property (nonatomic) BOOL csatResolutionHidden;
        [Export("csatResolutionHidden")]
        bool CsatResolutionHidden { get; set; }

        // @property (nonatomic) BOOL csatAgentViewHidden;
        [Export("csatAgentViewHidden")]
        bool CsatAgentViewHidden { get; set; }

        // @property (nonatomic) BOOL csatThankYouScreenHidden;
        [Export("csatThankYouScreenHidden")]
        bool CsatThankYouScreenHidden { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull csatNavigationBackgroundColor;
        [Export("csatNavigationBackgroundColor", ArgumentSemantic.Strong)]
        UIColor CsatNavigationBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull csatNavigationTitleColor;
        [Export("csatNavigationTitleColor", ArgumentSemantic.Strong)]
        UIColor CsatNavigationTitleColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull csatSkipButtonColor;
        [Export("csatSkipButtonColor", ArgumentSemantic.Strong)]
        UIColor CsatSkipButtonColor { get; set; }

        // @property (nonatomic) BOOL csatUIStatusBarStyleLightContent;
        [Export("csatUIStatusBarStyleLightContent")]
        bool CsatUIStatusBarStyleLightContent { get; set; }

        // @property (nonatomic) BOOL csatShowSurveyView;
        [Export("csatShowSurveyView")]
        bool CsatShowSurveyView { get; set; }

        // @property (nonatomic) NSUInteger maxPreviousConversationToPresent;
        [Export("maxPreviousConversationToPresent")]
        nuint MaxPreviousConversationToPresent { get; set; }

        // @property (nonatomic) NSUInteger deleteClosedConversationOlderThanMonths;
        [Export("deleteClosedConversationOlderThanMonths")]
        nuint DeleteClosedConversationOlderThanMonths { get; set; }

        // @property (nonatomic) BOOL isSendMessageButtonInTextMode;
        [Export("isSendMessageButtonInTextMode")]
        bool IsSendMessageButtonInTextMode { get; set; }

        // @property (nonatomic) BOOL enableConversationSeparatorTextMessage;
        [Export("enableConversationSeparatorTextMessage")]
        bool EnableConversationSeparatorTextMessage { get; set; }

        // @property (nonatomic) BOOL enableConversationSeparatorLine;
        [Export("enableConversationSeparatorLine")]
        bool EnableConversationSeparatorLine { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull conversationSeparatorTextColor;
        [Export("conversationSeparatorTextColor", ArgumentSemantic.Strong)]
        UIColor ConversationSeparatorTextColor { get; set; }

        // @property (nonatomic) BOOL enableVibrationOnMessageFromRemoteUser;
        [Export("enableVibrationOnMessageFromRemoteUser")]
        bool EnableVibrationOnMessageFromRemoteUser { get; set; }

        // @property (nonatomic) BOOL enableBubblesOverlayOnLongPress;
        [Export("enableBubblesOverlayOnLongPress")]
        bool EnableBubblesOverlayOnLongPress { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull conversationEmptyStateTextColor;
        [Export("conversationEmptyStateTextColor", ArgumentSemantic.Strong)]
        UIColor ConversationEmptyStateTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull scrollToBottomButtonBackgroundColor;
        [Export("scrollToBottomButtonBackgroundColor", ArgumentSemantic.Strong)]
        UIColor ScrollToBottomButtonBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull scrollToBottomButtonMessagePreviewTextColor;
        [Export("scrollToBottomButtonMessagePreviewTextColor", ArgumentSemantic.Strong)]
        UIColor ScrollToBottomButtonMessagePreviewTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull scrollToBottomButtonBadgeBackgroundColor;
        [Export("scrollToBottomButtonBadgeBackgroundColor", ArgumentSemantic.Strong)]
        UIColor ScrollToBottomButtonBadgeBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull scrollToBottomButtonBadgeTextColor;
        [Export("scrollToBottomButtonBadgeTextColor", ArgumentSemantic.Strong)]
        UIColor ScrollToBottomButtonBadgeTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull scrollToBottomButtonArrowColor;
        [Export("scrollToBottomButtonArrowColor", ArgumentSemantic.Strong)]
        UIColor ScrollToBottomButtonArrowColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull unreadMessagesDividerBackgroundColor;
        [Export("unreadMessagesDividerBackgroundColor", ArgumentSemantic.Strong)]
        UIColor UnreadMessagesDividerBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull unreadMessagesDividerTextColor;
        [Export("unreadMessagesDividerTextColor", ArgumentSemantic.Strong)]
        UIColor UnreadMessagesDividerTextColor { get; set; }

        // @property (nonatomic) BOOL scrollToBottomButtonEnabled;
        [Export("scrollToBottomButtonEnabled")]
        bool ScrollToBottomButtonEnabled { get; set; }

        // @property (nonatomic) BOOL scrollToBottomButtonMessagePreviewEnabled;
        [Export("scrollToBottomButtonMessagePreviewEnabled")]
        bool ScrollToBottomButtonMessagePreviewEnabled { get; set; }

        // @property (nonatomic) float scrollToBottomButtonCornerRadius;
        [Export("scrollToBottomButtonCornerRadius")]
        float ScrollToBottomButtonCornerRadius { get; set; }

        // @property (nonatomic) float scrollToBottomButtonBadgeCornerRadius;
        [Export("scrollToBottomButtonBadgeCornerRadius")]
        float ScrollToBottomButtonBadgeCornerRadius { get; set; }

        // @property (nonatomic) BOOL unreadMessagesDividerEnabled;
        [Export("unreadMessagesDividerEnabled")]
        bool UnreadMessagesDividerEnabled { get; set; }

        // @property (nonatomic) float unreadMessagesCornersRadius;
        [Export("unreadMessagesCornersRadius")]
        float UnreadMessagesCornersRadius { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable lpDateFormat;
        [NullAllowed, Export("lpDateFormat")]
        string LpDateFormat { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable lpTimeFormat;
        [NullAllowed, Export("lpTimeFormat")]
        string LpTimeFormat { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable lpDateTimeFormat;
        [NullAllowed, Export("lpDateTimeFormat")]
        string LpDateTimeFormat { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable country;
        [NullAllowed, Export("country")]
        string Country { get; set; }

        // @property (nonatomic) enum LPLanguage language;
        [Export("language", ArgumentSemantic.Assign)]
        LPLanguage Language { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull brandName;
        [Export("brandName")]
        string BrandName { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull conversationBackgroundColor;
        [Export("conversationBackgroundColor", ArgumentSemantic.Strong)]
        UIColor ConversationBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull dateSeparatorTitleBackgroundColor;
        [Export("dateSeparatorTitleBackgroundColor", ArgumentSemantic.Strong)]
        UIColor DateSeparatorTitleBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull dateSeparatorTextColor;
        [Export("dateSeparatorTextColor", ArgumentSemantic.Strong)]
        UIColor DateSeparatorTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull dateSeparatorLineBackgroundColor;
        [Export("dateSeparatorLineBackgroundColor", ArgumentSemantic.Strong)]
        UIColor DateSeparatorLineBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull dateSeparatorBackgroundColor;
        [Export("dateSeparatorBackgroundColor", ArgumentSemantic.Strong)]
        UIColor DateSeparatorBackgroundColor { get; set; }

        // @property (nonatomic) UIFontTextStyle _Nonnull dateSeparatorFontSize;
        [Export("dateSeparatorFontSize")]
        string DateSeparatorFontSize { get; set; }

        // @property (nonatomic) float dateSeparatorTopPadding;
        [Export("dateSeparatorTopPadding")]
        float DateSeparatorTopPadding { get; set; }

        // @property (nonatomic) float dateSeparatorBottomPadding;
        [Export("dateSeparatorBottomPadding")]
        float DateSeparatorBottomPadding { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable conversationSeparatorFontName;
        [NullAllowed, Export("conversationSeparatorFontName")]
        string ConversationSeparatorFontName { get; set; }

        // @property (nonatomic) UIFontTextStyle _Nonnull conversationSeparatorFontSize;
        [Export("conversationSeparatorFontSize")]
        string ConversationSeparatorFontSize { get; set; }

        // @property (nonatomic) float conversationSeparatorTopPadding;
        [Export("conversationSeparatorTopPadding")]
        float ConversationSeparatorTopPadding { get; set; }

        // @property (nonatomic) float conversationSeparatorBottomPadding;
        [Export("conversationSeparatorBottomPadding")]
        float ConversationSeparatorBottomPadding { get; set; }

        // @property (nonatomic) float conversationSeparatorViewBottomPadding;
        [Export("conversationSeparatorViewBottomPadding")]
        float ConversationSeparatorViewBottomPadding { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull sendButtonDisabledTextColor;
        [Export("sendButtonDisabledTextColor", ArgumentSemantic.Strong)]
        UIColor SendButtonDisabledTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull sendButtonEnabledTextColor;
        [Export("sendButtonEnabledTextColor", ArgumentSemantic.Strong)]
        UIColor SendButtonEnabledTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull sendButtonDisabledColor;
        [Export("sendButtonDisabledColor", ArgumentSemantic.Strong)]
        UIColor SendButtonDisabledColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull sendButtonEnabledColor;
        [Export("sendButtonEnabledColor", ArgumentSemantic.Strong)]
        UIColor SendButtonEnabledColor { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable sendButtonImage;
        [NullAllowed, Export("sendButtonImage", ArgumentSemantic.Strong)]
        UIImage SendButtonImage { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull editTextUnderlineColor;
        [Export("editTextUnderlineColor", ArgumentSemantic.Strong)]
        UIColor EditTextUnderlineColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull inputTextViewContainerBackgroundColor;
        [Export("inputTextViewContainerBackgroundColor", ArgumentSemantic.Strong)]
        UIColor InputTextViewContainerBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull inputTextViewTopBorderColor;
        [Export("inputTextViewTopBorderColor", ArgumentSemantic.Strong)]
        UIColor InputTextViewTopBorderColor { get; set; }

        // @property (nonatomic) double inputTextViewCornerRadius;
        [Export("inputTextViewCornerRadius")]
        double InputTextViewCornerRadius { get; set; }

        // @property (nonatomic) BOOL retrieveAssignedAgentFromLastClosedConversation;
        [Export("retrieveAssignedAgentFromLastClosedConversation")]
        bool RetrieveAssignedAgentFromLastClosedConversation { get; set; }

        // @property (nonatomic) double notificationShowDurationInSeconds;
        [Export("notificationShowDurationInSeconds")]
        double NotificationShowDurationInSeconds { get; set; }

        // @property (nonatomic) NSUInteger sendingMessageTimeoutInMinutes;
        [Export("sendingMessageTimeoutInMinutes")]
        nuint SendingMessageTimeoutInMinutes { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable customFontNameConversationFeed;
        [NullAllowed, Export("customFontNameConversationFeed")]
        string CustomFontNameConversationFeed { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable customFontNameDateSeparator;
        [NullAllowed, Export("customFontNameDateSeparator")]
        string CustomFontNameDateSeparator { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable customFontNameNonConversationFeed;
        [NullAllowed, Export("customFontNameNonConversationFeed")]
        string CustomFontNameNonConversationFeed { get; set; }

        // @property (nonatomic) enum LPAccountEnviroment accountEnvironment;
        [Export("accountEnvironment", ArgumentSemantic.Assign)]
        LPAccountEnviroment AccountEnvironment { get; set; }

        // @property (nonatomic) BOOL ttrShowShiftBanner;
        [Export("ttrShowShiftBanner")]
        bool TtrShowShiftBanner { get; set; }

        // @property (nonatomic) double ttrFirstTimeDelay;
        [Export("ttrFirstTimeDelay")]
        double TtrFirstTimeDelay { get; set; }

        // @property (nonatomic) BOOL ttrShouldShowTimestamp;
        [Export("ttrShouldShowTimestamp")]
        bool TtrShouldShowTimestamp { get; set; }

        // @property (nonatomic) BOOL showUrgentButtonInTTRNotification;
        [Export("showUrgentButtonInTTRNotification")]
        bool ShowUrgentButtonInTTRNotification { get; set; }

        // @property (nonatomic) BOOL showOffHoursBanner;
        [Export("showOffHoursBanner")]
        bool ShowOffHoursBanner { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull ttrBannerBackgroundColor;
        [Export("ttrBannerBackgroundColor", ArgumentSemantic.Strong)]
        UIColor TtrBannerBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull ttrBannerTextColor;
        [Export("ttrBannerTextColor", ArgumentSemantic.Strong)]
        UIColor TtrBannerTextColor { get; set; }

        // @property (nonatomic) double ttrBannerOpacityAlpha;
        [Export("ttrBannerOpacityAlpha")]
        double TtrBannerOpacityAlpha { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull offHoursTimeZoneName;
        [Export("offHoursTimeZoneName")]
        string OffHoursTimeZoneName { get; set; }

        // @property (nonatomic) BOOL toastNotificationsEnabled;
        [Export("toastNotificationsEnabled")]
        bool ToastNotificationsEnabled { get; set; }

        // @property (nonatomic) NSUInteger ttrShowFrequencyInSeconds;
        [Export("ttrShowFrequencyInSeconds")]
        nuint TtrShowFrequencyInSeconds { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull csdsDomain;
        [Export("csdsDomain")]
        string CsdsDomain { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull lpTagDomain;
        [Export("lpTagDomain")]
        string LpTagDomain { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull remoteUserAvatarBackgroundColor;
        [Export("remoteUserAvatarBackgroundColor", ArgumentSemantic.Strong)]
        UIColor RemoteUserAvatarBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull remoteUserAvatarIconColor;
        [Export("remoteUserAvatarIconColor", ArgumentSemantic.Strong)]
        UIColor RemoteUserAvatarIconColor { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable remoteUserDefaultAvatarImage;
        [NullAllowed, Export("remoteUserDefaultAvatarImage", ArgumentSemantic.Strong)]
        UIImage RemoteUserDefaultAvatarImage { get; set; }

        // @property (nonatomic) float remoteUserAvatarLeadingPadding;
        [Export("remoteUserAvatarLeadingPadding")]
        float RemoteUserAvatarLeadingPadding { get; set; }

        // @property (nonatomic) float remoteUserAvatarTrailingPadding;
        [Export("remoteUserAvatarTrailingPadding")]
        float RemoteUserAvatarTrailingPadding { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable brandAvatarImage;
        [NullAllowed, Export("brandAvatarImage", ArgumentSemantic.Strong)]
        UIImage BrandAvatarImage { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull csatAgentAvatarBackgroundColor;
        [Export("csatAgentAvatarBackgroundColor", ArgumentSemantic.Strong)]
        UIColor CsatAgentAvatarBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull csatAgentAvatarIconColor;
        [Export("csatAgentAvatarIconColor", ArgumentSemantic.Strong)]
        UIColor CsatAgentAvatarIconColor { get; set; }

        // @property (nonatomic) NSUInteger csatSurveyExpirationInMinutes;
        [Export("csatSurveyExpirationInMinutes")]
        nuint CsatSurveyExpirationInMinutes { get; set; }

        // @property (nonatomic) BOOL enableClientOnlyMasking;
        [Export("enableClientOnlyMasking")]
        bool EnableClientOnlyMasking { get; set; }

        // @property (nonatomic) BOOL enableRealTimeMasking;
        [Export("enableRealTimeMasking")]
        bool EnableRealTimeMasking { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull clientOnlyMaskingRegex;
        [Export("clientOnlyMaskingRegex")]
        string ClientOnlyMaskingRegex { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull realTimeMaskingRegex;
        [Export("realTimeMaskingRegex")]
        string RealTimeMaskingRegex { get; set; }

        // @property (nonatomic) BOOL enablePhotoSharing;
        [Export("enablePhotoSharing")]
        bool EnablePhotoSharing { get; set; }

        // @property (nonatomic) NSUInteger maxNumberOfSavedFilesOnDisk;
        [Export("maxNumberOfSavedFilesOnDisk")]
        nuint MaxNumberOfSavedFilesOnDisk { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull cameraButtonEnabledColor;
        [Export("cameraButtonEnabledColor", ArgumentSemantic.Strong)]
        UIColor CameraButtonEnabledColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull cameraButtonDisabledColor;
        [Export("cameraButtonDisabledColor", ArgumentSemantic.Strong)]
        UIColor CameraButtonDisabledColor { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable photoSharingMenuCameraImage;
        [NullAllowed, Export("photoSharingMenuCameraImage", ArgumentSemantic.Strong)]
        UIImage PhotoSharingMenuCameraImage { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable photoSharingMenuLibraryImage;
        [NullAllowed, Export("photoSharingMenuLibraryImage", ArgumentSemantic.Strong)]
        UIImage PhotoSharingMenuLibraryImage { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable photoSharingOpenMenuImageButton;
        [NullAllowed, Export("photoSharingOpenMenuImageButton", ArgumentSemantic.Strong)]
        UIImage PhotoSharingOpenMenuImageButton { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable photoSharingCloseMenuImageButton;
        [NullAllowed, Export("photoSharingCloseMenuImageButton", ArgumentSemantic.Strong)]
        UIImage PhotoSharingCloseMenuImageButton { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull fileCellLoaderFillColor;
        [Export("fileCellLoaderFillColor", ArgumentSemantic.Strong)]
        UIColor FileCellLoaderFillColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull fileCellLoaderRingProgressColor;
        [Export("fileCellLoaderRingProgressColor", ArgumentSemantic.Strong)]
        UIColor FileCellLoaderRingProgressColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull fileCellLoaderRingBackgroundColor;
        [Export("fileCellLoaderRingBackgroundColor", ArgumentSemantic.Strong)]
        UIColor FileCellLoaderRingBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull photosharingMenuBackgroundColor;
        [Export("photosharingMenuBackgroundColor", ArgumentSemantic.Strong)]
        UIColor PhotosharingMenuBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull photosharingMenuButtonsBackgroundColor;
        [Export("photosharingMenuButtonsBackgroundColor", ArgumentSemantic.Strong)]
        UIColor PhotosharingMenuButtonsBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull photosharingMenuButtonsTintColor;
        [Export("photosharingMenuButtonsTintColor", ArgumentSemantic.Strong)]
        UIColor PhotosharingMenuButtonsTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull photosharingMenuButtonsTextColor;
        [Export("photosharingMenuButtonsTextColor", ArgumentSemantic.Strong)]
        UIColor PhotosharingMenuButtonsTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull conversationNavigationBackgroundColor;
        [Export("conversationNavigationBackgroundColor", ArgumentSemantic.Strong)]
        UIColor ConversationNavigationBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull conversationNavigationTitleColor;
        [Export("conversationNavigationTitleColor", ArgumentSemantic.Strong)]
        UIColor ConversationNavigationTitleColor { get; set; }

        // @property (nonatomic) UIStatusBarStyle conversationStatusBarStyle;
        [Export("conversationStatusBarStyle", ArgumentSemantic.Assign)]
        UIStatusBarStyle ConversationStatusBarStyle { get; set; }

        // @property (nonatomic) BOOL enableRealTimeLinkPreview;
        [Export("enableRealTimeLinkPreview")]
        bool EnableRealTimeLinkPreview { get; set; }

        // @property (nonatomic) enum LPUrlPreviewStyle urlPreviewStyle;
        [Export("urlPreviewStyle", ArgumentSemantic.Assign)]
        LPUrlPreviewStyle UrlPreviewStyle { get; set; }

        // @property (nonatomic) BOOL useNonOGTagsForLinkPreview;
        [Export("useNonOGTagsForLinkPreview")]
        bool UseNonOGTagsForLinkPreview { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull urlRealTimePreviewBackgroundColor;
        [Export("urlRealTimePreviewBackgroundColor", ArgumentSemantic.Strong)]
        UIColor UrlRealTimePreviewBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull urlRealTimePreviewBorderColor;
        [Export("urlRealTimePreviewBorderColor", ArgumentSemantic.Strong)]
        UIColor UrlRealTimePreviewBorderColor { get; set; }

        // @property (nonatomic) CGFloat urlRealTimePreviewBorderWidth;
        [Export("urlRealTimePreviewBorderWidth")]
        nfloat UrlRealTimePreviewBorderWidth { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull urlRealTimePreviewTitleTextColor;
        [Export("urlRealTimePreviewTitleTextColor", ArgumentSemantic.Strong)]
        UIColor UrlRealTimePreviewTitleTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull urlRealTimePreviewDescriptionTextColor;
        [Export("urlRealTimePreviewDescriptionTextColor", ArgumentSemantic.Strong)]
        UIColor UrlRealTimePreviewDescriptionTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull secureFormBackButtonColor;
        [Export("secureFormBackButtonColor", ArgumentSemantic.Strong)]
        UIColor SecureFormBackButtonColor { get; set; }

        // @property (nonatomic) BOOL secureFormUIStatusBarStyleLightContent;
        [Export("secureFormUIStatusBarStyleLightContent")]
        bool SecureFormUIStatusBarStyleLightContent { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull secureFormNavigationBackgroundColor;
        [Export("secureFormNavigationBackgroundColor", ArgumentSemantic.Strong)]
        UIColor SecureFormNavigationBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull secureFormNavigationTitleColor;
        [Export("secureFormNavigationTitleColor", ArgumentSemantic.Strong)]
        UIColor SecureFormNavigationTitleColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull secureFormBubbleBackgroundColor;
        [Export("secureFormBubbleBackgroundColor", ArgumentSemantic.Strong)]
        UIColor SecureFormBubbleBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull secureFormBubbleBorderColor;
        [Export("secureFormBubbleBorderColor", ArgumentSemantic.Strong)]
        UIColor SecureFormBubbleBorderColor { get; set; }

        // @property (nonatomic) double secureFormBubbleBorderWidth;
        [Export("secureFormBubbleBorderWidth")]
        double SecureFormBubbleBorderWidth { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull secureFormBubbleTitleColor;
        [Export("secureFormBubbleTitleColor", ArgumentSemantic.Strong)]
        UIColor SecureFormBubbleTitleColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull secureFormBubbleDescriptionColor;
        [Export("secureFormBubbleDescriptionColor", ArgumentSemantic.Strong)]
        UIColor SecureFormBubbleDescriptionColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull secureFormBubbleFillFormButtonTextColor;
        [Export("secureFormBubbleFillFormButtonTextColor", ArgumentSemantic.Strong)]
        UIColor SecureFormBubbleFillFormButtonTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull secureFormBubbleFillFormButtonBackgroundColor;
        [Export("secureFormBubbleFillFormButtonBackgroundColor", ArgumentSemantic.Strong)]
        UIColor SecureFormBubbleFillFormButtonBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull secureFormBubbleFormImageTintColor;
        [Export("secureFormBubbleFormImageTintColor", ArgumentSemantic.Strong)]
        UIColor SecureFormBubbleFormImageTintColor { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull secureFormCustomFontName;
        [Export("secureFormCustomFontName")]
        string SecureFormCustomFontName { get; set; }

        // @property (nonatomic) BOOL secureFormHideLogo;
        [Export("secureFormHideLogo")]
        bool SecureFormHideLogo { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull secureFormBubbleLoadingIndicatorColor;
        [Export("secureFormBubbleLoadingIndicatorColor", ArgumentSemantic.Strong)]
        UIColor SecureFormBubbleLoadingIndicatorColor { get; set; }

        // @property (nonatomic) double structuredContentBubbleBorderWidth;
        [Export("structuredContentBubbleBorderWidth")]
        double StructuredContentBubbleBorderWidth { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull structuredContentBubbleBorderColor;
        [Export("structuredContentBubbleBorderColor", ArgumentSemantic.Strong)]
        UIColor StructuredContentBubbleBorderColor { get; set; }

        // @property (nonatomic) double structuredContentMapLatitudeDeltaDeltaSpan;
        [Export("structuredContentMapLatitudeDeltaDeltaSpan")]
        double StructuredContentMapLatitudeDeltaDeltaSpan { get; set; }

        // @property (nonatomic) double structuredContentMapLongitudeDeltaSpan;
        [Export("structuredContentMapLongitudeDeltaSpan")]
        double StructuredContentMapLongitudeDeltaSpan { get; set; }

        // @property (nonatomic) BOOL enableStrucutredContent;
        [Export("enableStrucutredContent")]
        bool EnableStrucutredContent { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull connectionStatusConnectingBackgroundColor;
        [Export("connectionStatusConnectingBackgroundColor", ArgumentSemantic.Strong)]
        UIColor ConnectionStatusConnectingBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull connectionStatusConnectingTextColor;
        [Export("connectionStatusConnectingTextColor", ArgumentSemantic.Strong)]
        UIColor ConnectionStatusConnectingTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull connectionStatusFailedToConnectBackgroundColor;
        [Export("connectionStatusFailedToConnectBackgroundColor", ArgumentSemantic.Strong)]
        UIColor ConnectionStatusFailedToConnectBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull connectionStatusFailedToConnectTextColor;
        [Export("connectionStatusFailedToConnectTextColor", ArgumentSemantic.Strong)]
        UIColor ConnectionStatusFailedToConnectTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull controllerBubbleTextColor;
        [Export("controllerBubbleTextColor", ArgumentSemantic.Strong)]
        UIColor ControllerBubbleTextColor { get; set; }

        // @property (nonatomic) float bubbleTopPadding;
        [Export("bubbleTopPadding")]
        float BubbleTopPadding { get; set; }

        // @property (nonatomic) float bubbleBottomPadding;
        [Export("bubbleBottomPadding")]
        float BubbleBottomPadding { get; set; }

        // @property (nonatomic) float bubbleLeadingPadding;
        [Export("bubbleLeadingPadding")]
        float BubbleLeadingPadding { get; set; }

        // @property (nonatomic) float bubbleTrailingPadding;
        [Export("bubbleTrailingPadding")]
        float BubbleTrailingPadding { get; set; }

        // @property (nonatomic) float bubbleTimestampTopPadding;
        [Export("bubbleTimestampTopPadding")]
        float BubbleTimestampTopPadding { get; set; }

        // @property (nonatomic) float bubbleTimestampBottomPadding;
        [Export("bubbleTimestampBottomPadding")]
        float BubbleTimestampBottomPadding { get; set; }

        // @property (copy, nonatomic) NSArray<UIImage *> * _Nullable customRefreshControllerImagesArray;
        [NullAllowed, Export("customRefreshControllerImagesArray", ArgumentSemantic.Copy)]
        UIImage[] CustomRefreshControllerImagesArray { get; set; }

        // @property (nonatomic) float customRefreshControllerAnimationSpeed;
        [Export("customRefreshControllerAnimationSpeed")]
        float CustomRefreshControllerAnimationSpeed { get; set; }

        // @property (nonatomic) CGFloat inputTextViewMaxHeight;
        [Export("inputTextViewMaxHeight")]
        nfloat InputTextViewMaxHeight { get; set; }

        // @property (readonly, nonatomic, strong, class) LPConfig * _Nonnull defaultConfiguration;
        [Static]
        [Export("defaultConfiguration", ArgumentSemantic.Strong)]
        LPConfig DefaultConfiguration { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        LPConfig New();

        // -(void)resetToDefaultConfiguration;
        [Export("resetToDefaultConfiguration")]
        void ResetToDefaultConfiguration();

        // -(void)setValue:(id _Nullable)value forUndefinedKey:(NSString * _Nonnull)key;
        [Export("setValue:forUndefinedKey:")]
        void SetValue([NullAllowed] NSObject value, string key);

        // +(void)printAllConfigurations;
        [Static]
        [Export("printAllConfigurations")]
        void PrintAllConfigurations();
    }

    // @interface LPConnection : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface LPConnection
    {
        // @property (nonatomic, strong) LPUserEntity * _Null_unspecified consumer __attribute__((diagnose_if(0x7fcad7915bc8, "Swift property 'LPConnection.consumer' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("consumer", ArgumentSemantic.Strong)]
        LPUserEntity Consumer { get; set; }

        // @property (copy, nonatomic) NSArray<LPConversationEntity *> * _Null_unspecified conversations __attribute__((diagnose_if(0x7fcad7915f68, "Swift property 'LPConnection.conversations' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("conversations", ArgumentSemantic.Copy)]
        LPConversationEntity[] Conversations { get; set; }

        // @property (readonly, nonatomic) NSInteger hashValue;
        [Export("hashValue")]
        nint HashValue { get; }

        // -(instancetype _Nonnull)initWithConsumer:(LPUserEntity * _Nonnull)consumer conversations:(NSArray<LPConversationEntity *> * _Nonnull)conversations __attribute__((diagnose_if(0x7fcad79164f8, "Swift initializer 'LPConnection.init(consumer:conversations:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((objc_designated_initializer));
        [Export("initWithConsumer:conversations:")]
        [DesignatedInitializer]
        IntPtr Constructor(LPUserEntity consumer, LPConversationEntity[] conversations);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // @property (readonly, nonatomic, strong) LPConversationEntity * _Nullable lastConversation __attribute__((diagnose_if(0x7fcad79168f8, "Swift property 'LPConnection.lastConversation' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("lastConversation", ArgumentSemantic.Strong)]
        LPConversationEntity LastConversation { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable effectiveTtr __attribute__((diagnose_if(0x7fcad7916bf8, "Swift property 'LPConnection.effectiveTtr' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("effectiveTtr", ArgumentSemantic.Copy)]
        NSDate EffectiveTtr { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        LPConnection New();
    }

    // @interface LPInfra_Swift_984 (LPConnection)
    [Category]
    [BaseType(typeof(LPConnection))]
    interface LPConnection_LPInfra_Swift_984
    {
        // @property (readonly, nonatomic) NSInteger numberOfUnreadMessages __attribute__((diagnose_if(0x7fcad7917768, "Swift property 'LPConnection.numberOfUnreadMessages' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("numberOfUnreadMessages")]
        nint NumberOfUnreadMessages { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull titleLabel __attribute__((diagnose_if(0x7fcad7917aa0, "Swift property 'LPConnection.titleLabel' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("titleLabel")]
        string TitleLabel { get; }
    }

    // @interface LPConversationEntity : NSManagedObject
    [BaseType(typeof(NSManagedObject))]
    interface LPConversationEntity
    {
        // @property (copy, nonatomic) NSString * _Nullable uid;
        [NullAllowed, Export("uid")]
        string Uid { get; set; }

        // @property (copy, nonatomic) NSDate * _Nonnull creationDate;
        [Export("creationDate", ArgumentSemantic.Copy)]
        NSDate CreationDate { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull handlerId;
        [Export("handlerId")]
        string HandlerId { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable lastMessage;
        [NullAllowed, Export("lastMessage")]
        string LastMessage { get; set; }

        // @property (copy, nonatomic) NSDate * _Nullable lastMessageDate;
        [NullAllowed, Export("lastMessageDate", ArgumentSemantic.Copy)]
        NSDate LastMessageDate { get; set; }

        // @property (nonatomic, strong) LPBrandEntity * _Nonnull ownerBrand;
        [Export("ownerBrand", ArgumentSemantic.Strong)]
        LPBrandEntity OwnerBrand { get; set; }

        // @property (nonatomic, strong) NSSet * _Nonnull participants;
        [Export("participants", ArgumentSemantic.Strong)]
        NSSet Participants { get; set; }

        // @property (nonatomic, strong) NSOrderedSet * _Nonnull conversationMessages;
        [Export("conversationMessages", ArgumentSemantic.Strong)]
        NSOrderedSet ConversationMessages { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull stateRaw;
        [Export("stateRaw")]
        string StateRaw { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nonnull lastReceivedSequence;
        [Export("lastReceivedSequence", ArgumentSemantic.Strong)]
        NSNumber LastReceivedSequence { get; set; }

        // @property (nonatomic) BOOL hidden;
        [Export("hidden")]
        bool Hidden { get; set; }

        // @property (nonatomic) BOOL resolved;
        [Export("resolved")]
        bool Resolved { get; set; }

        // @property (nonatomic) BOOL isResolvedByRemoteUser;
        [Export("isResolvedByRemoteUser")]
        bool IsResolvedByRemoteUser { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable closeReason;
        [NullAllowed, Export("closeReason")]
        string CloseReason { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull ttrTypeRaw;
        [Export("ttrTypeRaw")]
        string TtrTypeRaw { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable type;
        [NullAllowed, Export("type")]
        string Type { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable assignedAgentId;
        [NullAllowed, Export("assignedAgentId")]
        string AssignedAgentId { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable consumerId;
        [NullAllowed, Export("consumerId")]
        string ConsumerId { get; set; }

        // @property (nonatomic, strong) TTRModel * _Nullable ttrModel;
        [NullAllowed, Export("ttrModel", ArgumentSemantic.Strong)]
        TTRModel TtrModel { get; set; }

        // @property (nonatomic, strong) NSMutableSet * _Nonnull currentlyAcceptedSequences __attribute__((diagnose_if(0x7fcad7919498, "Swift property 'LPConversationEntity.currentlyAcceptedSequences' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("currentlyAcceptedSequences", ArgumentSemantic.Strong)]
        NSMutableSet CurrentlyAcceptedSequences { get; set; }

        // @property (nonatomic) BOOL isHistoryFilterEnable __attribute__((diagnose_if(0x7fcad7919798, "Swift property 'LPConversationEntity.isHistoryFilterEnable' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("isHistoryFilterEnable")]
        bool IsHistoryFilterEnable { get; set; }

        // @property (nonatomic) BOOL presented __attribute__((diagnose_if(0x7fcad7919a88, "Swift property 'LPConversationEntity.presented' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("presented")]
        bool Presented { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
        [Export("initWithEntity:insertIntoManagedObjectContext:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
    }

    // @interface LPInfra_Swift_1032 (LPConversationEntity)
    [Category]
    [BaseType(typeof(LPConversationEntity))]
    interface LPConversationEntity_LPInfra_Swift_1032
    {
        // @property (readonly, copy, nonatomic) NSArray<LPMessageEntity *> * _Nonnull sortedMessages __attribute__((diagnose_if(0x7fcad791c418, "Swift property 'LPConversationEntity.sortedMessages' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("sortedMessages", ArgumentSemantic.Copy)]
        LPMessageEntity[] SortedMessages { get; }

        // @property (readonly, copy, nonatomic) NSArray<LPMessageEntity *> * _Nonnull unreadMessages __attribute__((diagnose_if(0x7fcad791c768, "Swift property 'LPConversationEntity.unreadMessages' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("unreadMessages", ArgumentSemantic.Copy)]
        LPMessageEntity[] UnreadMessages { get; }

        // @property (readonly, nonatomic, strong) LPMessageEntity * _Nullable lastMessageObj __attribute__((diagnose_if(0x7fcad791ca78, "Swift property 'LPConversationEntity.lastMessageObj' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("lastMessageObj", ArgumentSemantic.Strong)]
        LPMessageEntity LastMessageObj { get; }

        // @property (readonly, nonatomic, strong) LPUserEntity * _Nullable lastMessageOriginator __attribute__((diagnose_if(0x7fcad7920da8, "Swift property 'LPConversationEntity.lastMessageOriginator' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("lastMessageOriginator", ArgumentSemantic.Strong)]
        LPUserEntity LastMessageOriginator { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull relatedSocketID __attribute__((diagnose_if(0x7fcad7921088, "Swift property 'LPConversationEntity.relatedSocketID' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("relatedSocketID")]
        string RelatedSocketID { get; }

        // -(BOOL)isActivityInIdle __attribute__((diagnose_if(0x7fcad7921358, "Swift method 'LPConversationEntity.isActivityInIdle()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
        [Export("isActivityInIdle")]

        bool IsActivityInIdle { get; }

        // -(NSArray<LPMessageEntity *> * _Nonnull)getMessagesPage:(NSInteger)from pageSize:(NSInteger)pageSize __attribute__((diagnose_if(0x7fcad79217c0, "Swift method 'LPConversationEntity.getMessagesPage(_:pageSize:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
        [Export("getMessagesPage:pageSize:")]
        LPMessageEntity[] GetMessagesPage(nint from, nint pageSize);

        // -(BOOL)isCurrentlyUrgent __attribute__((diagnose_if(0x7fcad7921aa8, "Swift method 'LPConversationEntity.isCurrentlyUrgent()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
        [Export("isCurrentlyUrgent")]

        bool IsCurrentlyUrgent { get; }

        // @property (readonly, nonatomic) BOOL isResolvedAutomatically __attribute__((diagnose_if(0x7fcad7921d78, "Swift property 'LPConversationEntity.isResolvedAutomatically' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("isResolvedAutomatically")]
        bool IsResolvedAutomatically { get; }

        // -(void)acceptSequence:(NSInteger)seq __attribute__((diagnose_if(0x7fcad79220e8, "Swift method 'LPConversationEntity.acceptSequence(_:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("acceptSequence:")]
        void AcceptSequence(nint seq);

        // -(void)resolve __attribute__((diagnose_if(0x7fcad79223b0, "Swift method 'LPConversationEntity.resolve()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((diagnose_if(0x7fcad79223b0, "Swift method 'LPConversationEntity.resolve()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("resolve")]
        void Resolve();

        // -(void)resolve:(NSString * _Nonnull)closeReason __attribute__((diagnose_if(0x7fcad79227c8, "Swift method 'LPConversationEntity.resolve(_:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("resolve:")]
        void Resolve(string closeReason);

        // -(NSString * _Nonnull)getResolveDateString:(NSDate * _Nonnull)date __attribute__((diagnose_if(0x7fcad7922bb0, "Swift method 'LPConversationEntity.getResolveDateString(_:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
        [Export("getResolveDateString:")]
        string GetResolveDateString(NSDate date);

        // +(LPConversationEntity * _Nonnull)createNewConversation:(LPBrandEntity * _Nonnull)brand __attribute__((diagnose_if(0x7fcad7922f50, "Swift method 'LPConversationEntity.createNewConversation(_:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
        [Static]
        [Export("createNewConversation:")]
        LPConversationEntity CreateNewConversation(LPBrandEntity brand);

        // @property (readonly, nonatomic) BOOL shouldQueryMessages;
        [Export("shouldQueryMessages")]
        bool ShouldQueryMessages { get; }

        // @property (readonly, nonatomic) BOOL isOpen __attribute__((diagnose_if(0x7fcad79232d8, "Swift property 'LPConversationEntity.isOpen' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("isOpen")]
        bool IsOpen { get; }

        // @property (readonly, nonatomic) BOOL canShowCSAT __attribute__((diagnose_if(0x7fcad79235a8, "Swift property 'LPConversationEntity.canShowCSAT' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("canShowCSAT")]
        bool CanShowCSAT { get; }

        // -(void)updateTTRModelWithReset:(BOOL)reset __attribute__((diagnose_if(0x7fcad7923910, "Swift method 'LPConversationEntity.updateTTRModel(reset:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("updateTTRModelWithReset:")]
        void UpdateTTRModelWithReset(bool reset);
    }

    // @interface LPConversationHistoryControlParam : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface LPConversationHistoryControlParam
    {
        // @property (nonatomic) NSInteger historyConversationsMaxDays;
        [Export("historyConversationsMaxDays")]
        nint HistoryConversationsMaxDays { get; set; }

        // @property (nonatomic) enum LPConversationsHistoryStateToDisplay historyConversationsStateToDisplay;
        [Export("historyConversationsStateToDisplay", ArgumentSemantic.Assign)]
        LPConversationsHistoryStateToDisplay HistoryConversationsStateToDisplay { get; set; }

        // @property (nonatomic) enum LPConversationHistoryMaxDaysDateType historyConversationMaxDaysType;
        [Export("historyConversationMaxDaysType", ArgumentSemantic.Assign)]
        LPConversationHistoryMaxDaysDateType HistoryConversationMaxDaysType { get; set; }

        // @property (readonly, nonatomic) BOOL isEnable;
        [Export("isEnable")]
        bool IsEnable { get; }

        // -(instancetype _Nonnull)initWithHistoryConversationsStateToDisplay:(enum LPConversationsHistoryStateToDisplay)historyConversationsStateToDisplay historyConversationsMaxDays:(NSInteger)historyConversationsMaxDays historyMaxDaysType:(enum LPConversationHistoryMaxDaysDateType)historyMaxDaysType __attribute__((objc_designated_initializer));
        [Export("initWithHistoryConversationsStateToDisplay:historyConversationsMaxDays:historyMaxDaysType:")]
        [DesignatedInitializer]
        IntPtr Constructor(LPConversationsHistoryStateToDisplay historyConversationsStateToDisplay, nint historyConversationsMaxDays, LPConversationHistoryMaxDaysDateType historyMaxDaysType);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        LPConversationHistoryControlParam New();
    }

    // @interface LPConversationViewParams : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface LPConversationViewParams
    {
        // @property (nonatomic, strong) id<ConversationParamProtocol> _Nonnull conversationQuery;
        [Export("conversationQuery", ArgumentSemantic.Strong)]
        ConversationParamProtocol ConversationQuery { get; set; }

        // @property (nonatomic, strong) UIViewController * _Nullable containerViewController;
        [NullAllowed, Export("containerViewController", ArgumentSemantic.Strong)]
        UIViewController ContainerViewController { get; set; }

        // @property (nonatomic) BOOL isViewOnly;
        [Export("isViewOnly")]
        bool IsViewOnly { get; set; }

        // @property (nonatomic, strong) LPConversationHistoryControlParam * _Nullable conversationHistoryControlParam;
        [NullAllowed, Export("conversationHistoryControlParam", ArgumentSemantic.Strong)]
        LPConversationHistoryControlParam ConversationHistoryControlParam { get; set; }

        // -(instancetype _Nonnull)initWithConversationQuery:(id<ConversationParamProtocol> _Nonnull)conversationQuery containerViewController:(UIViewController * _Nullable)containerViewController isViewOnly:(BOOL)isViewOnly conversationHistoryControlParam:(LPConversationHistoryControlParam * _Nullable)conversationHistoryControlParam __attribute__((objc_designated_initializer));
        [Export("initWithConversationQuery:containerViewController:isViewOnly:conversationHistoryControlParam:")]
        [DesignatedInitializer]
        IntPtr Constructor(ConversationParamProtocol conversationQuery, [NullAllowed] UIViewController containerViewController, bool isViewOnly, [NullAllowed] LPConversationHistoryControlParam conversationHistoryControlParam);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        LPConversationViewParams New();
    }

    // @interface LPCustomBoardEntity : NSManagedObject
    [BaseType(typeof(NSManagedObject))]
    interface LPCustomBoardEntity
    {
        // @property (copy, nonatomic) NSString * _Nonnull uid;
        [Export("uid")]
        string Uid { get; set; }

        // @property (nonatomic, strong) NSOrderedSet * _Nonnull linkPreviewItems;
        [Export("linkPreviewItems", ArgumentSemantic.Strong)]
        NSOrderedSet LinkPreviewItems { get; set; }

        // @property (nonatomic, strong) LPMessageEntity * _Nonnull ownerMessage;
        [Export("ownerMessage", ArgumentSemantic.Strong)]
        LPMessageEntity OwnerMessage { get; set; }

        // -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
        [Export("initWithEntity:insertIntoManagedObjectContext:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
    }

    // @protocol LPDataManagerSDKDelegate
    [Protocol, Model]
    interface LPDataManagerSDKDelegate
    {
        // @required -(void)LPMessagingSDKDataEncryptionFailed:(NSError * _Nonnull)error;
        [Abstract]
        [Export("LPMessagingSDKDataEncryptionFailed:")]
        void LPMessagingSDKDataEncryptionFailed(NSError error);
    }

    // @interface LPFileEntity : NSManagedObject
    [BaseType(typeof(NSManagedObject))]
    interface LPFileEntity
    {
        // @property (copy, nonatomic) NSString * _Nullable fileExtension;
        [NullAllowed, Export("fileExtension")]
        string FileExtension { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull uid;
        [Export("uid")]
        string Uid { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable state;
        [NullAllowed, Export("state")]
        string State { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable fileName;
        [NullAllowed, Export("fileName")]
        string FileName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable relativeFilePath;
        [NullAllowed, Export("relativeFilePath")]
        string RelativeFilePath { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable relativeThumbnailPath;
        [NullAllowed, Export("relativeThumbnailPath")]
        string RelativeThumbnailPath { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nullable fileSize;
        [NullAllowed, Export("fileSize", ArgumentSemantic.Strong)]
        NSNumber FileSize { get; set; }

        // @property (nonatomic, strong) NSDate * _Nullable creationDate;
        [NullAllowed, Export("creationDate", ArgumentSemantic.Strong)]
        NSDate CreationDate { get; set; }

        // @property (nonatomic, strong) LPMessageEntity * _Nullable ownerMessage;
        [NullAllowed, Export("ownerMessage", ArgumentSemantic.Strong)]
        LPMessageEntity OwnerMessage { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable swiftRelativePath;
        [NullAllowed, Export("swiftRelativePath")]
        string SwiftRelativePath { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable thumbnailImage;
        [NullAllowed, Export("thumbnailImage", ArgumentSemantic.Strong)]
        UIImage ThumbnailImage { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(void) completion;
        [NullAllowed, Export("completion", ArgumentSemantic.Copy)]
        Action Completion { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(NSError * _Nonnull) failure;
        [NullAllowed, Export("failure", ArgumentSemantic.Copy)]
        Action<NSError> Failure { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(void) preUpload;
        [NullAllowed, Export("preUpload", ArgumentSemantic.Copy)]
        Action PreUpload { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(void) preDownload;
        [NullAllowed, Export("preDownload", ArgumentSemantic.Copy)]
        Action PreDownload { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(double) uploading;
        [NullAllowed, Export("uploading", ArgumentSemantic.Copy)]
        Action<double> Uploading { get; set; }

        // @property (nonatomic) CGFloat uploadPercentage;
        [Export("uploadPercentage")]
        nfloat UploadPercentage { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(double) downloading;
        [NullAllowed, Export("downloading", ArgumentSemantic.Copy)]
        Action<double> Downloading { get; set; }

        // @property (nonatomic) CGFloat downloadPercentage;
        [Export("downloadPercentage")]
        nfloat DownloadPercentage { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(void) synced;
        [NullAllowed, Export("synced", ArgumentSemantic.Copy)]
        Action Synced { get; set; }

        // -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
        [Export("initWithEntity:insertIntoManagedObjectContext:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
    }

    // @interface LPInfra_Swift_1155 (LPFileEntity)
    [Category]
    [BaseType(typeof(LPFileEntity))]
    interface LPFileEntity_LPInfra_Swift_1155
    {
        // -(UIImage * _Nullable)getThumbnailImage __attribute__((warn_unused_result));
        [NullAllowed, Export("getThumbnailImage")]

        UIImage ThumbnailImage { get; }

        // @property (readonly, nonatomic) BOOL isTransferring;
        [Export("isTransferring")]
        bool IsTransferring { get; }

        // -(void)clearFileBlocks;
        [Export("clearFileBlocks")]
        void ClearFileBlocks();
    }

    // @interface LPFormEntity : NSManagedObject
    [BaseType(typeof(NSManagedObject))]
    interface LPFormEntity
    {
        // @property (copy, nonatomic) NSString * _Nullable formID;
        [NullAllowed, Export("formID")]
        string FormID { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull invitationID;
        [Export("invitationID")]
        string InvitationID { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull state;
        [Export("state")]
        string State { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable submissionID;
        [NullAllowed, Export("submissionID")]
        string SubmissionID { get; set; }

        // @property (nonatomic, strong) NSOrderedSet * _Nonnull ownerMessages;
        [Export("ownerMessages", ArgumentSemantic.Strong)]
        NSOrderedSet OwnerMessages { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable readOTK;
        [NullAllowed, Export("readOTK")]
        string ReadOTK { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable writeOTK;
        [NullAllowed, Export("writeOTK")]
        string WriteOTK { get; set; }

        // @property (copy, nonatomic) NSURL * _Nullable url;
        [NullAllowed, Export("url", ArgumentSemantic.Copy)]
        NSUrl Url { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
        [Export("initWithEntity:insertIntoManagedObjectContext:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
    }

    // @interface LPInfra_Swift_1183 (LPFormEntity)
    [Category]
    [BaseType(typeof(LPFormEntity))]
    interface LPFormEntity_LPInfra_Swift_1183
    {
        // +(LPFormEntity * _Nonnull)createNewFormWithFormID:(NSString * _Nullable)formID invitationID:(NSString * _Nonnull)invitationID title:(NSString * _Nullable)title ownerMessage:(LPMessageEntity * _Nonnull)ownerMessage __attribute__((warn_unused_result));
        [Static]
        [Export("createNewFormWithFormID:invitationID:title:ownerMessage:")]
        LPFormEntity CreateNewFormWithFormID([NullAllowed] string formID, string invitationID, [NullAllowed] string title, LPMessageEntity ownerMessage);

        // @property (readonly, nonatomic, strong) LPConversationEntity * _Nonnull ownerConversation;
        [Export("ownerConversation", ArgumentSemantic.Strong)]
        LPConversationEntity OwnerConversation { get; }
    }

    // @interface LPInfraFacade : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface LPInfraFacade
    {
        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        LPInfraFacade New();

        // +(BOOL)initializeInfra __attribute__((warn_unused_result));
        [Static]
        [Export("initializeInfra")]

        bool InitializeInfra { get; }

        // +(id<ConversationParamProtocol> _Nonnull)getConversationBrandQuery:(NSString * _Nonnull)brandID campaignInfo:(LPCampaignInfo * _Nullable)campaignInfo __attribute__((warn_unused_result));
        [Static]
        [Export("getConversationBrandQuery:campaignInfo:")]
        ConversationParamProtocol GetConversationBrandQuery(string brandID, [NullAllowed] LPCampaignInfo campaignInfo);

        // +(id<ConversationParamProtocol> _Nonnull)getConversationConsumerQuery:(NSString * _Nullable)consumerID brandID:(NSString * _Nonnull)brandID agentToken:(NSString * _Nonnull)agentToken __attribute__((warn_unused_result));
        [Static]
        [Export("getConversationConsumerQuery:brandID:agentToken:")]
        ConversationParamProtocol GetConversationConsumerQuery([NullAllowed] string consumerID, string brandID, string agentToken);

        // +(LPWebSocket * _Nullable)getSocket:(NSString * _Nonnull)brandID __attribute__((warn_unused_result));
        [Static]
        [Export("getSocket:")]
        [return: NullAllowed]
        LPWebSocket GetSocket(string brandID);

        // +(void)openAllSockets;
        [Static]
        [Export("openAllSockets")]
        void OpenAllSockets();

        // +(void)openSocket:(LPWebSocket * _Nonnull)webSocket;
        [Static]
        [Export("openSocket:")]
        void OpenSocket(LPWebSocket webSocket);

        // +(void)closeAllSockets;
        [Static]
        [Export("closeAllSockets")]
        void CloseAllSockets();

        // +(void)removeSockets;
        [Static]
        [Export("removeSockets")]
        void RemoveSockets();

        // +(void)saveData:(NSManagedObjectContext * _Nullable)givenContext;
        [Static]
        [Export("saveData:")]
        void SaveData([NullAllowed] NSManagedObjectContext givenContext);

        // +(void)saveContext;
        [Static]
        [Export("saveContext")]
        void SaveContext();

        // +(NSManagedObjectContext * _Nullable)getContext __attribute__((warn_unused_result));
        [Static]
        [NullAllowed, Export("getContext")]

        NSManagedObjectContext Context { get; }

        // +(void)saveDataWithGetContextFrom:(NSManagedObject * _Nullable)obj;
        [Static]
        [Export("saveDataWithGetContextFrom:")]
        void SaveDataWithGetContextFrom([NullAllowed] NSManagedObject obj);

        // +(BOOL)deleteManagedObject:(NSManagedObject * _Nonnull)object context:(NSManagedObjectContext * _Nullable)givenContext __attribute__((warn_unused_result));
        [Static]
        [Export("deleteManagedObject:context:")]
        bool DeleteManagedObject(NSManagedObject @object, [NullAllowed] NSManagedObjectContext givenContext);

        // +(void)resetDatabaseWithCompletion:(void (^ _Nonnull)(BOOL))completion;
        [Static]
        [Export("resetDatabaseWithCompletion:")]
        void ResetDatabaseWithCompletion(Action<bool> completion);

        // +(void)refreshDatabase;
        [Static]
        [Export("refreshDatabase")]
        void RefreshDatabase();

        // +(void)clearManagers;
        [Static]
        [Export("clearManagers")]
        void ClearManagers();

        // +(void)uploadFileWithFile:(LPFileEntity * _Nonnull)file uploadRelativePath:(NSString * _Nonnull)uploadRelativePath tempURLSig:(NSString * _Nonnull)tempURLSig tempURLExpiry:(NSString * _Nonnull)tempURLExpiry completion:(void (^ _Nonnull)(LPFileEntity * _Nonnull))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("uploadFileWithFile:uploadRelativePath:tempURLSig:tempURLExpiry:completion:failure:")]
        void UploadFileWithFile(LPFileEntity file, string uploadRelativePath, string tempURLSig, string tempURLExpiry, Action<LPFileEntity> completion, Action<NSError> failure);

        // +(void)downloadFileWithFile:(LPFileEntity * _Nonnull)file relativePath:(NSString * _Nonnull)relativePath tempURLSig:(NSString * _Nonnull)tempURLSig tempURLExpiry:(NSString * _Nonnull)tempURLExpiry completion:(void (^ _Nonnull)(LPFileEntity * _Nonnull))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("downloadFileWithFile:relativePath:tempURLSig:tempURLExpiry:completion:failure:")]
        void DownloadFileWithFile(LPFileEntity file, string relativePath, string tempURLSig, string tempURLExpiry, Action<LPFileEntity> completion, Action<NSError> failure);

        // +(void)getPhotoFromFileWithFile:(LPFileEntity * _Nonnull)file completion:(void (^ _Nonnull)(UIImage * _Nullable))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("getPhotoFromFileWithFile:completion:failure:")]
        void GetPhotoFromFileWithFile(LPFileEntity file, Action<UIImage> completion, Action<NSError> failure);

        // +(UIImage * _Nullable)getThumbnailFromFileWithFile:(LPFileEntity * _Nonnull)file __attribute__((warn_unused_result));
        [Static]
        [Export("getThumbnailFromFileWithFile:")]
        [return: NullAllowed]
        UIImage GetThumbnailFromFileWithFile(LPFileEntity file);

        // +(void)getBase64ThumbnailStringWithFile:(LPFileEntity * _Nonnull)file completion:(void (^ _Nonnull)(NSString * _Nonnull))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("getBase64ThumbnailStringWithFile:completion:failure:")]
        void GetBase64ThumbnailStringWithFile(LPFileEntity file, Action<NSString> completion, Action<NSError> failure);

        // +(void)deleteFileFromDiskWithFile:(LPFileEntity * _Nonnull)file;
        [Static]
        [Export("deleteFileFromDiskWithFile:")]
        void DeleteFileFromDiskWithFile(LPFileEntity file);

        // +(void)deleteAllFilesFromDisk;
        [Static]
        [Export("deleteAllFilesFromDisk")]
        void DeleteAllFilesFromDisk();

        // +(void)deleteAllFilesFromDiskWithCompletion:(void (^ _Nonnull)(void))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("deleteAllFilesFromDiskWithCompletion:failure:")]
        void DeleteAllFilesFromDiskWithCompletion(Action completion, Action<NSError> failure);

        // +(void)handleMaxNumberOfSavedFilesOnDisk;
        [Static]
        [Export("handleMaxNumberOfSavedFilesOnDisk")]
        void HandleMaxNumberOfSavedFilesOnDisk();

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull filesDirectoryPath;
        [Static]
        [Export("filesDirectoryPath")]
        string FilesDirectoryPath { get; }

        // +(LPBrandEntity * _Nonnull)getOrCreateBrandByAccountID:(NSString * _Nonnull)accountID __attribute__((warn_unused_result));
        [Static]
        [Export("getOrCreateBrandByAccountID:")]
        LPBrandEntity GetOrCreateBrandByAccountID(string accountID);

        // +(BOOL)clearConversationFromDB:(LPConversationEntity * _Nonnull)conversation __attribute__((warn_unused_result));
        [Static]
        [Export("clearConversationFromDB:")]
        bool ClearConversationFromDB(LPConversationEntity conversation);

        // +(BOOL)clearHistory:(id<ConversationParamProtocol> _Nonnull)conversationQuery __attribute__((warn_unused_result));
        [Static]
        [Export("clearHistory:")]
        bool ClearHistory(ConversationParamProtocol conversationQuery);

        // +(void)deleteOldConversations;
        [Static]
        [Export("deleteOldConversations")]
        void DeleteOldConversations();

        // +(NSArray<LPConversationEntity *> * _Nullable)getAllClosedConversations:(NSDate * _Nullable)olderThanDate __attribute__((warn_unused_result));
        [Static]
        [Export("getAllClosedConversations:")]
        [return: NullAllowed]
        LPConversationEntity[] GetAllClosedConversations([NullAllowed] NSDate olderThanDate);

        // +(NSArray<LPConversationEntity *> * _Nonnull)getConversationsSortedByDate:(id<ConversationParamProtocol> _Nonnull)query conversationHistoryControlParam:(LPConversationHistoryControlParam * _Nullable)conversationHistoryControlParam __attribute__((warn_unused_result));
        [Static]
        [Export("getConversationsSortedByDate:conversationHistoryControlParam:")]
        LPConversationEntity[] GetConversationsSortedByDate(ConversationParamProtocol query, [NullAllowed] LPConversationHistoryControlParam conversationHistoryControlParam);

        // +(LPConversationEntity * _Nullable)getConversationByHandlerID:(NSString * _Nonnull)handlerID __attribute__((warn_unused_result));
        [Static]
        [Export("getConversationByHandlerID:")]
        [return: NullAllowed]
        LPConversationEntity GetConversationByHandlerID(string handlerID);

        // +(LPConversationEntity * _Nullable)getOpenConveration __attribute__((warn_unused_result));
        [Static]
        [NullAllowed, Export("getOpenConveration")]

        LPConversationEntity OpenConveration { get; }

        // +(NSArray<NSString *> * _Nullable)getConsumerIdsRelatedToMessagesThatContainsWithText:(NSString * _Nonnull)text __attribute__((warn_unused_result));
        [Static]
        [Export("getConsumerIdsRelatedToMessagesThatContainsWithText:")]
        [return: NullAllowed]
        string[] GetConsumerIdsRelatedToMessagesThatContainsWithText(string text);

        // +(void)getUserDetailsFromACCDN:(NSString * _Nonnull)brandID userID:(NSString * _Nonnull)userID completion:(void (^ _Nullable)(LPUserEntity * _Nonnull))completion failure:(void (^ _Nullable)(NSError * _Nonnull))failure;
        [Static]
        [Export("getUserDetailsFromACCDN:userID:completion:failure:")]
        void GetUserDetailsFromACCDN(string brandID, string userID, [NullAllowed] Action<LPUserEntity> completion, [NullAllowed] Action<NSError> failure);

        // +(void)attachMyUserCompletion:(void (^ _Nonnull)(NSString * _Nonnull))completion;
        [Static]
        [Export("attachMyUserCompletion:")]
        void AttachMyUserCompletion(Action<NSString> completion);

        // +(LPUserEntity * _Nullable)getUserFromDatabaseWithUserID:(NSString * _Nonnull)userID __attribute__((warn_unused_result));
        [Static]
        [Export("getUserFromDatabaseWithUserID:")]
        [return: NullAllowed]
        LPUserEntity GetUserFromDatabaseWithUserID(string userID);

        // +(void)refreshUserProfileWithBrandID:(NSString * _Nonnull)brandID user:(LPUserEntity * _Nonnull)user;
        [Static]
        [Export("refreshUserProfileWithBrandID:user:")]
        void RefreshUserProfileWithBrandID(string brandID, LPUserEntity user);

        // +(void)setUserProfileWithDetails:(LPUser * _Nonnull)lpuser brandID:(NSString * _Nonnull)brandID;
        [Static]
        [Export("setUserProfileWithDetails:brandID:")]
        void SetUserProfileWithDetails(LPUser lpuser, string brandID);

        // @property (readonly, copy, nonatomic, class) NSString * _Nullable myUserID;
        [Static]
        [NullAllowed, Export("myUserID")]
        string MyUserID { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nullable myAgentVepUserID;
        [Static]
        [NullAllowed, Export("myAgentVepUserID")]
        string MyAgentVepUserID { get; }

        // +(void)agentDetailsDidFetchWithUser:(LPUserEntity * _Nullable)user;
        [Static]
        [Export("agentDetailsDidFetchWithUser:")]
        void AgentDetailsDidFetchWithUser([NullAllowed] LPUserEntity user);

        // @property (readonly, nonatomic, class) BOOL isNetworkReachable;
        [Static]
        [Export("isNetworkReachable")]
        bool IsNetworkReachable { get; }

        // +(void)setImageByURL:(UIImage * _Nonnull)image url:(NSString * _Nonnull)url;
        [Static]
        [Export("setImageByURL:url:")]
        void SetImageByURL(UIImage image, string url);

        // +(UIImage * _Nullable)getImageByURL:(NSString * _Nonnull)url __attribute__((warn_unused_result));
        [Static]
        [Export("getImageByURL:")]
        [return: NullAllowed]
        UIImage GetImageByURL(string url);

        // +(void)sendLocalNotification:(NSString * _Nonnull)text uid:(NSString * _Nullable)uid;
        [Static]
        [Export("sendLocalNotification:uid:")]
        void SendLocalNotification(string text, [NullAllowed] string uid);

        // +(NSString * _Nonnull)getAppIdentifier __attribute__((warn_unused_result));
        [Static]
        [Export("getAppIdentifier")]

        string AppIdentifier { get; }

        // +(void)registerPusher:(LPBrandEntity * _Nonnull)brand;
        [Static]
        [Export("registerPusher:")]
        void RegisterPusher(LPBrandEntity brand);

        // +(void)getUnreadMessagesCount:(id<ConversationParamProtocol> _Nonnull)conversationQuery completion:(void (^ _Nonnull)(NSInteger))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("getUnreadMessagesCount:completion:failure:")]
        void GetUnreadMessagesCount(ConversationParamProtocol conversationQuery, Action<nint> completion, Action<NSError> failure);

        // +(void)unregisterPusher:(LPBrandEntity * _Nonnull)brand completion:(void (^ _Nonnull)(void))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("unregisterPusher:completion:failure:")]
        void UnregisterPusher(LPBrandEntity brand, Action completion, Action<NSError> failure);

        // +(NSString * _Nullable)keychainStringForKey:(NSString * _Nonnull)keyName __attribute__((warn_unused_result));
        [Static]
        [Export("keychainStringForKey:")]
        [return: NullAllowed]
        string KeychainStringForKey(string keyName);

        // +(BOOL)setKeychainString:(NSString * _Nonnull)value forKey:(NSString * _Nonnull)keyName __attribute__((warn_unused_result));
        [Static]
        [Export("setKeychainString:forKey:")]
        bool SetKeychainString(string value, string keyName);

        // +(BOOL)removeKeychainStringForKey:(NSString * _Nonnull)keyName __attribute__((warn_unused_result));
        [Static]
        [Export("removeKeychainStringForKey:")]
        bool RemoveKeychainStringForKey(string keyName);

        // +(BOOL)removeAllKeychainObjects __attribute__((warn_unused_result));
        [Static]
        [Export("removeAllKeychainObjects")]

        bool RemoveAllKeychainObjects { get; }

        // +(NSArray<LPMessageEntity *> * _Nullable)getMessagesOfLatestConversation:(id<ConversationParamProtocol> _Nonnull)query __attribute__((warn_unused_result));
        [Static]
        [Export("getMessagesOfLatestConversation:")]
        [return: NullAllowed]
        LPMessageEntity[] GetMessagesOfLatestConversation(ConversationParamProtocol query);

        // +(NSArray<LPMessageEntity *> * _Nonnull)getMessagesFromConversationWithConversation:(LPConversationEntity * _Nonnull)conversation __attribute__((warn_unused_result));
        [Static]
        [Export("getMessagesFromConversationWithConversation:")]
        LPMessageEntity[] GetMessagesFromConversationWithConversation(LPConversationEntity conversation);

        // +(NSDate * _Nullable)getLastMessageTimeStamp:(id<ConversationParamProtocol> _Nonnull)query __attribute__((warn_unused_result));
        [Static]
        [Export("getLastMessageTimeStamp:")]
        [return: NullAllowed]
        NSDate GetLastMessageTimeStamp(ConversationParamProtocol query);

        // +(LPConversationEntity * _Nullable)getNextConversationForQueryMessagesIfExists:(id<ConversationParamProtocol> _Nonnull)query __attribute__((warn_unused_result));
        [Static]
        [Export("getNextConversationForQueryMessagesIfExists:")]
        [return: NullAllowed]
        LPConversationEntity GetNextConversationForQueryMessagesIfExists(ConversationParamProtocol query);

        // +(NSArray<LPConversationEntity *> * _Nullable)getConversations:(id<ConversationParamProtocol> _Nonnull)query predicate:(NSPredicate * _Nullable)predicate __attribute__((warn_unused_result));
        [Static]
        [Export("getConversations:predicate:")]
        [return: NullAllowed]
        LPConversationEntity[] GetConversations(ConversationParamProtocol query, [NullAllowed] NSPredicate predicate);

        // +(LPConversationEntity * _Nullable)getActiveConversation:(id<ConversationParamProtocol> _Nonnull)query __attribute__((warn_unused_result));
        [Static]
        [Export("getActiveConversation:")]
        [return: NullAllowed]
        LPConversationEntity GetActiveConversation(ConversationParamProtocol query);

        // +(NSArray<LPConversationEntity *> * _Nullable)getLatestClosedConversations:(id<ConversationParamProtocol> _Nonnull)query conversationsCount:(NSInteger)conversationsCount __attribute__((warn_unused_result));
        [Static]
        [Export("getLatestClosedConversations:conversationsCount:")]
        [return: NullAllowed]
        LPConversationEntity[] GetLatestClosedConversations(ConversationParamProtocol query, nint conversationsCount);

        // +(LPConversationEntity * _Nonnull)createConversation:(id<ConversationParamProtocol> _Nonnull)query __attribute__((warn_unused_result));
        [Static]
        [Export("createConversation:")]
        LPConversationEntity CreateConversation(ConversationParamProtocol query);

        // +(BOOL)clearInitialCreatedConversation:(LPConversationEntity * _Nonnull)conversation __attribute__((warn_unused_result));
        [Static]
        [Export("clearInitialCreatedConversation:")]
        bool ClearInitialCreatedConversation(LPConversationEntity conversation);

        // +(LPUserEntity * _Nullable)getAssignedAgent:(id<ConversationParamProtocol> _Nonnull)query __attribute__((warn_unused_result));
        [Static]
        [Export("getAssignedAgent:")]
        [return: NullAllowed]
        LPUserEntity GetAssignedAgent(ConversationParamProtocol query);

        // +(void)getMessageBoardsWithUrl:(NSURL * _Nonnull)url completion:(void (^ _Nonnull)(NSArray<LPCustomBoardEntity *> * _Nonnull))completion failure:(void (^ _Nonnull)(NSError * _Nullable))failure;
        [Static]
        [Export("getMessageBoardsWithUrl:completion:failure:")]
        void GetMessageBoardsWithUrl(NSUrl url, Action<NSArray> completion, Action<NSError> failure);

        // +(void)deleteAllPreviewImagesFromDiskWithCompletion:(void (^ _Nonnull)(void))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("deleteAllPreviewImagesFromDiskWithCompletion:failure:")]
        void DeleteAllPreviewImagesFromDiskWithCompletion(Action completion, Action<NSError> failure);

        // +(NSDate * _Nullable)getExpirationDateFromJWT:(NSString * _Nonnull)jwtToken __attribute__((warn_unused_result));
        [Static]
        [Export("getExpirationDateFromJWT:")]
        [return: NullAllowed]
        NSDate GetExpirationDateFromJWT(string jwtToken);

        // +(NSString * _Nullable)getUserIDFromJWT:(NSString * _Nonnull)jwtToken __attribute__((warn_unused_result));
        [Static]
        [Export("getUserIDFromJWT:")]
        [return: NullAllowed]
        string GetUserIDFromJWT(string jwtToken);



    }

    // @interface LPLinkPreviewEntity : NSManagedObject
    [BaseType(typeof(NSObject))]
    interface LPLinkPreviewEntity
    {
        // @property (copy, nonatomic) NSString * _Nonnull uid;
        [Export("uid")]
        string Uid { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull type;
        [Export("type")]
        string Type { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull url;
        [Export("url")]
        string Url { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable captionTitle;
        [NullAllowed, Export("captionTitle")]
        string CaptionTitle { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable captionDescription;
        [NullAllowed, Export("captionDescription")]
        string CaptionDescription { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable captionSiteName;
        [NullAllowed, Export("captionSiteName")]
        string CaptionSiteName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable relativeImagePath;
        [NullAllowed, Export("relativeImagePath")]
        string RelativeImagePath { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable imageURL;
        [NullAllowed, Export("imageURL")]
        string ImageURL { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable imageState;
        [NullAllowed, Export("imageState")]
        string ImageState { get; set; }

        // @property (nonatomic, strong) LPCustomBoardEntity * _Nonnull ownerCustomBoard;
        [Export("ownerCustomBoard", ArgumentSemantic.Strong)]
        LPCustomBoardEntity OwnerCustomBoard { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(UIImage * _Nullable) imageDownloadCompleted;
        [NullAllowed, Export("imageDownloadCompleted", ArgumentSemantic.Copy)]
        Action<UIImage> ImageDownloadCompleted { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(NSError * _Nonnull) imageDownloadFailed;
        [NullAllowed, Export("imageDownloadFailed", ArgumentSemantic.Copy)]
        Action<NSError> ImageDownloadFailed { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
        //[Export("initWithEntity:insertIntoManagedObjectContext:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
    }

    // @interface LPInfra_Swift_1549 (LPLinkPreviewEntity)
    [Category]
    [BaseType(typeof(LPLinkPreviewEntity))]
    interface LPLinkPreviewEntity_LPInfra_Swift_1549
    {
        // -(void)setImageWithImage:(UIImage * _Nullable)image relativePath:(NSString * _Nonnull)relativePath;
        [Export("setImageWithImage:relativePath:")]
        void SetImageWithImage([NullAllowed] UIImage image, string relativePath);

        // -(void)getImageWithCompletion:(void (^ _Nonnull)(UIImage * _Nullable))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Export("getImageWithCompletion:failure:")]
        void GetImageWithCompletion(Action<UIImage> completion, Action<NSError> failure);

        // -(UIImage * _Nullable)getImageFromCache __attribute__((warn_unused_result));
        [NullAllowed, Export("getImageFromCache")]

        UIImage ImageFromCache { get; }
    }

    // @interface LPLog : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface LPLog
    {
        // @property (copy, nonatomic) NSString * _Nullable timestamp;
        [NullAllowed, Export("timestamp")]
        string Timestamp { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable className;
        [NullAllowed, Export("className")]
        string ClassName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable funcName;
        [NullAllowed, Export("funcName")]
        string FuncName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable text;
        [NullAllowed, Export("text")]
        string Text { get; set; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        LPLog New();
    }

    // @interface LPMessageEntity : NSManagedObject
    [BaseType(typeof(NSManagedObject))]
    interface LPMessageEntity
    {
        // @property (copy, nonatomic) NSDate * _Nonnull timestamp;
        [Export("timestamp", ArgumentSemantic.Copy)]
        NSDate Timestamp { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull content;
        [Export("content")]
        string Content { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable uid;
        [NullAllowed, Export("uid")]
        string Uid { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull statusRaw;
        [Export("statusRaw")]
        string StatusRaw { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull contentType;
        [Export("contentType")]
        string ContentType { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull messageType;
        [Export("messageType")]
        string MessageType { get; set; }

        // @property (nonatomic, strong) LPConversationEntity * _Nonnull ownerConversation;
        [Export("ownerConversation", ArgumentSemantic.Strong)]
        LPConversationEntity OwnerConversation { get; set; }

        // @property (nonatomic, strong) LPUserEntity * _Nullable ownerUser;
        [NullAllowed, Export("ownerUser", ArgumentSemantic.Strong)]
        LPUserEntity OwnerUser { get; set; }

        // @property (nonatomic, strong) LPFileEntity * _Nullable file;
        [NullAllowed, Export("file", ArgumentSemantic.Strong)]
        LPFileEntity File { get; set; }

        // @property (nonatomic, strong) LPFormEntity * _Nullable form;
        [NullAllowed, Export("form", ArgumentSemantic.Strong)]
        LPFormEntity Form { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable eventId;
        [NullAllowed, Export("eventId")]
        string EventId { get; set; }

        // @property (nonatomic, strong) NSOrderedSet * _Nullable customBoards;
        [NullAllowed, Export("customBoards", ArgumentSemantic.Strong)]
        NSOrderedSet CustomBoards { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable linkPreviewState;
        [NullAllowed, Export("linkPreviewState")]
        string LinkPreviewState { get; set; }

        // @property (nonatomic, strong) StructuredContentItemContainer * _Nullable structuredContentItemContainer;
        [NullAllowed, Export("structuredContentItemContainer", ArgumentSemantic.Strong)]
        StructuredContentItemContainer StructuredContentItemContainer { get; set; }

        // @property (nonatomic) BOOL presented;
        [Export("presented")]
        bool Presented { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(NSArray<LPCustomBoardEntity *> * _Nonnull) boardsBuildCompleted __attribute__((diagnose_if(0x7fcad793e6f8, "Swift property 'LPMessageEntity.boardsBuildCompleted' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("boardsBuildCompleted", ArgumentSemantic.Copy)]
        Action<NSArray> BoardsBuildCompleted { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(NSError * _Nonnull) boardsBuildFailed __attribute__((diagnose_if(0x7fcad793ea80, "Swift property 'LPMessageEntity.boardsBuildFailed' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("boardsBuildFailed", ArgumentSemantic.Copy)]
        Action<NSError> BoardsBuildFailed { get; set; }

        // @property (copy, nonatomic) NSDate * _Nullable requestedToShowSendingState __attribute__((diagnose_if(0x7fcad793ed88, "Swift property 'LPMessageEntity.requestedToShowSendingState' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("requestedToShowSendingState", ArgumentSemantic.Copy)]
        NSDate RequestedToShowSendingState { get; set; }

        // @property (copy, nonatomic) NSDate * _Nonnull lastSendingTimestamp __attribute__((diagnose_if(0x7fcad793f068, "Swift property 'LPMessageEntity.lastSendingTimestamp' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("lastSendingTimestamp", ArgumentSemantic.Copy)]
        NSDate LastSendingTimestamp { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable maskedContent __attribute__((diagnose_if(0x7fcad793f338, "Swift property 'LPMessageEntity.maskedContent' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("maskedContent")]
        string MaskedContent { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    // @interface LPInfra_Swift_1601 (LPMessageEntity)
    [Category]
    [BaseType(typeof(LPMessageEntity))]
    interface LPMessageEntity_LPInfra_Swift_1601
    {
        // @property (readonly, nonatomic) BOOL isSystemMessage __attribute__((diagnose_if(0x7fcad7941828, "Swift property 'LPMessageEntity.isSystemMessage' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("isSystemMessage")]
        bool IsSystemMessage { get; }

        // @property (readonly, nonatomic) BOOL isRemoteMessage __attribute__((diagnose_if(0x7fcad7941ad0, "Swift property 'LPMessageEntity.isRemoteMessage' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("isRemoteMessage")]
        bool IsRemoteMessage { get; }

        // @property (readonly, nonatomic) BOOL isUserMessage __attribute__((diagnose_if(0x7fcad7941d78, "Swift property 'LPMessageEntity.isUserMessage' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("isUserMessage")]
        bool IsUserMessage { get; }

        // @property (readonly, nonatomic) BOOL isControllerMessage __attribute__((diagnose_if(0x7fcad7942028, "Swift property 'LPMessageEntity.isControllerMessage' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("isControllerMessage")]
        bool IsControllerMessage { get; }

        // @property (readonly, nonatomic) BOOL isLinkPreview __attribute__((diagnose_if(0x7fcad79422d8, "Swift property 'LPMessageEntity.isLinkPreview' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("isLinkPreview")]
        bool IsLinkPreview { get; }

        // @property (readonly, nonatomic) BOOL isStructuredContent __attribute__((diagnose_if(0x7fcad794e798, "Swift property 'LPMessageEntity.isStructuredContent' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("isStructuredContent")]
        bool IsStructuredContent { get; }

        // +(NSString * _Nonnull)buildUID:(NSString * _Nonnull)convUID sequence:(NSInteger)sequence __attribute__((diagnose_if(0x7fcad794eb90, "Swift method 'LPMessageEntity.buildUID(_:sequence:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
        [Static]
        [Export("buildUID:sequence:")]
        string BuildUID(string convUID, nint sequence);

        // +(NSPredicate * _Nonnull)byDate:(NSDate * _Nonnull)date __attribute__((diagnose_if(0x7fcad794ef48, "Swift method 'LPMessageEntity.byDate(_:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
        [Static]
        [Export("byDate:")]
        NSPredicate ByDate(NSDate date);

        // -(void)getBoardsWithCompletion:(void (^ _Nonnull)(NSArray<LPCustomBoardEntity *> * _Nonnull))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure __attribute__((diagnose_if(0x7fcad794f550, "Swift method 'LPMessageEntity.getBoards(completion:failure:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("getBoardsWithCompletion:failure:")]
        void GetBoardsWithCompletion(Action<NSArray> completion, Action<NSError> failure);
    }

    // @interface LPOperation : NSOperation
    [BaseType(typeof(NSOperation))]
    interface LPOperation
    {
        // @property (getter = isExecuting, nonatomic) BOOL executing;
        [Export("executing")]
        bool Executing { [Bind("isExecuting")] get; set; }

        // @property (getter = isFinished, nonatomic) BOOL finished;
        [Export("finished")]
        bool Finished { [Bind("isFinished")] get; set; }

        // @property (readonly, getter = isAsynchronous, nonatomic) BOOL asynchronous;
        [Export("asynchronous")]
        bool Asynchronous { [Bind("isAsynchronous")] get; }

        // -(void)main;
        [Export("main")]
        void Main();

        // -(void)start;
        [Export("start")]
        void Start();

        // -(void)finishOperation __attribute__((diagnose_if(0x7fcad7950430, "Swift method 'LPOperation.finishOperation()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("finishOperation")]
        void FinishOperation();

        // -(void)cancel;
        [Export("cancel")]
        void Cancel();

        // -(void)clearOperationOnCancel __attribute__((diagnose_if(0x7fcad79507f8, "Swift method 'LPOperation.clearOperationOnCancel()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("clearOperationOnCancel")]
        void ClearOperationOnCancel();
    }

    // @interface LPSDKManager : NSObject <GeneralManagerProtocol>
    [BaseType(typeof(NSObject))]
    interface LPSDKManager : GeneralManagerProtocol
    {
        // @property (nonatomic, strong) id<ConversationParamProtocol> _Nullable conversationQuery;
        [NullAllowed, Export("conversationQuery", ArgumentSemantic.Strong)]
        ConversationParamProtocol ConversationQuery { get; set; }

        // @property (nonatomic) BOOL isWindowMode;
        [Export("isWindowMode")]
        bool IsWindowMode { get; set; }

        // @property (readonly, nonatomic, strong, class) LPSDKManager * _Nonnull instance;
        [Static]
        [Export("instance", ArgumentSemantic.Strong)]
        LPSDKManager Instance { get; }

        // +(NSBundle * _Nullable)getBundle __attribute__((warn_unused_result));
        [Static]
        [NullAllowed, Export("getBundle")]

        NSBundle Bundle { get; }

        // +(NSString * _Nullable)getSDKVersion __attribute__((warn_unused_result));
        [Static]
        [NullAllowed, Export("getSDKVersion")]

        string SDKVersion { get; }

        // +(void)isVersionApplicableWithBrandID:(NSString * _Nonnull)brandID configurationKey:(NSString * _Nullable)configurationKey useCacheIfExists:(BOOL)useCacheIfExists completion:(void (^ _Nonnull)(BOOL, BOOL))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("isVersionApplicableWithBrandID:configurationKey:useCacheIfExists:completion:failure:")]
        void IsVersionApplicableWithBrandID(string brandID, [NullAllowed] string configurationKey, bool useCacheIfExists, Action<bool, bool> completion, Action<NSError> failure);

        // +(void)isFeatureEnabledWithFeature:(enum LPMessagingSDKFeature)feature brandID:(NSString * _Nonnull)brandID useCacheIfExists:(BOOL)useCacheIfExists completion:(void (^ _Nonnull)(BOOL))completion;
        [Static]
        [Export("isFeatureEnabledWithFeature:brandID:useCacheIfExists:completion:")]
        void IsFeatureEnabledWithFeature(LPMessagingSDKFeature feature, string brandID, bool useCacheIfExists, Action<bool> completion);

        // -(void)clearManager;
        [Export("clearManager")]
        void ClearManager();
    }

    // @interface LPTimer : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface LPTimer
    {
        // -(instancetype _Nonnull)initWithDuration:(NSTimeInterval)duration handler:(void (^ _Nonnull)(NSTimeInterval))handler __attribute__((diagnose_if(0x7fcad7953488, "Swift initializer 'LPTimer.init(duration:handler:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((objc_designated_initializer));
        [Export("initWithDuration:handler:")]
        [DesignatedInitializer]
        IntPtr Constructor(double duration, Action<double> handler);

        // -(void)start __attribute__((diagnose_if(0x7fcad7953790, "Swift method 'LPTimer.start()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("start")]
        void Start();

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        LPTimer New();
    }

    // @interface LPUser : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface LPUser
    {
        // @property (copy, nonatomic) NSString * _Nullable firstName;
        [NullAllowed, Export("firstName")]
        string FirstName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable lastName;
        [NullAllowed, Export("lastName")]
        string LastName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable nickName;
        [NullAllowed, Export("nickName")]
        string NickName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable profileImageURL;
        [NullAllowed, Export("profileImageURL")]
        string ProfileImageURL { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable phoneNumber;
        [NullAllowed, Export("phoneNumber")]
        string PhoneNumber { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable employeeID;
        [NullAllowed, Export("employeeID")]
        string EmployeeID { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable uid;
        [NullAllowed, Export("uid")]
        string Uid { get; set; }

        // -(instancetype _Nonnull)initWithUser:(LPUserEntity * _Nonnull)user;
        [Export("initWithUser:")]
        IntPtr Constructor(LPUserEntity user);

        // -(instancetype _Nonnull)initWithFirstName:(NSString * _Nullable)firstName lastName:(NSString * _Nullable)lastName nickName:(NSString * _Nullable)nickName uid:(NSString * _Nullable)uid profileImageURL:(NSString * _Nullable)profileImageURL phoneNumber:(NSString * _Nullable)phoneNumber employeeID:(NSString * _Nullable)employeeID __attribute__((objc_designated_initializer));
        [Export("initWithFirstName:lastName:nickName:uid:profileImageURL:phoneNumber:employeeID:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] string firstName, [NullAllowed] string lastName, [NullAllowed] string nickName, [NullAllowed] string uid, [NullAllowed] string profileImageURL, [NullAllowed] string phoneNumber, [NullAllowed] string employeeID);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        LPUser New();
    }

    // @interface LPUserEntity : NSManagedObject
    [BaseType(typeof(NSManagedObject))]
    interface LPUserEntity
    {
        // @property (copy, nonatomic) NSString * _Nonnull uid;
        [Export("uid")]
        string Uid { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull firstName;
        [Export("firstName")]
        string FirstName { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull lastName;
        [Export("lastName")]
        string LastName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable nickName;
        [NullAllowed, Export("nickName")]
        string NickName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable profileImageURL;
        [NullAllowed, Export("profileImageURL")]
        string ProfileImageURL { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable coverImageURL;
        [NullAllowed, Export("coverImageURL")]
        string CoverImageURL { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable phoneNumber;
        [NullAllowed, Export("phoneNumber")]
        string PhoneNumber { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull typeRaw;
        [Export("typeRaw")]
        string TypeRaw { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable bio;
        [NullAllowed, Export("bio")]
        string Bio { get; set; }

        // @property (nonatomic, strong) NSSet * _Nonnull userMessages;
        [Export("userMessages", ArgumentSemantic.Strong)]
        NSSet UserMessages { get; set; }

        // @property (nonatomic) BOOL isSaved;
        [Export("isSaved")]
        bool IsSaved { get; set; }

        // @property (copy, nonatomic) NSDate * _Nullable lastUpdated;
        [NullAllowed, Export("lastUpdated", ArgumentSemantic.Copy)]
        NSDate LastUpdated { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable employeeID;
        [NullAllowed, Export("employeeID")]
        string EmployeeID { get; set; }

        // -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
        [Export("initWithEntity:insertIntoManagedObjectContext:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
    }

    // @interface LPInfra_Swift_1762 (LPUserEntity)
    [Category]
    [BaseType(typeof(LPUserEntity))]
    interface LPUserEntity_LPInfra_Swift_1762
    {
        // @property (readonly, nonatomic) BOOL isConsumer;
        [Export("isConsumer")]
        bool IsConsumer { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull fullName;
        [Export("fullName")]
        string FullName { get; }

        // @property (readonly, nonatomic) BOOL isMe;
        [Export("isMe")]
        bool IsMe { get; }

        // @property (readonly, nonatomic) BOOL isController;
        [Export("isController")]
        bool IsController { get; }
    }

    // @interface LPUserProfileEntity : LPUserEntity
    [BaseType(typeof(LPUserEntity))]
    interface LPUserProfileEntity
    {
        // -(instancetype _Nonnull)initWithEntity:(NSEntityDescription * _Nonnull)entity insertIntoManagedObjectContext:(NSManagedObjectContext * _Nullable)context __attribute__((objc_designated_initializer));
        [Export("initWithEntity:insertIntoManagedObjectContext:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSEntityDescription entity, [NullAllowed] NSManagedObjectContext context);
    }

    // @interface LPWebSocket
    interface LPWebSocket
    {
        // @property (copy, nonatomic) NSString * _Nonnull requestIndex __attribute__((diagnose_if(0x7fcad79586b0, "Swift property 'LPWebSocket.requestIndex' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("requestIndex")]
        string RequestIndex { get; set; }

        // @property (copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nullable headers __attribute__((diagnose_if(0x7fcad7958a48, "Swift property 'LPWebSocket.headers' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("headers", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSString> Headers { get; set; }

        // @property (readonly, nonatomic) BOOL isOpen __attribute__((diagnose_if(0x7fcad7958d20, "Swift property 'LPWebSocket.isOpen' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("isOpen")]
        bool IsOpen { get; }

        // @property (readonly, nonatomic) BOOL isClosed __attribute__((diagnose_if(0x7fcad7958ff0, "Swift property 'LPWebSocket.isClosed' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("isClosed")]
        bool IsClosed { get; }

        // @property (readonly, nonatomic) BOOL isReadyToOpen __attribute__((diagnose_if(0x7fcad7959290, "Swift property 'LPWebSocket.isReadyToOpen' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("isReadyToOpen")]
        bool IsReadyToOpen { get; }

        // -(void)flushQueue __attribute__((diagnose_if(0x7fcad7959588, "Swift method 'LPWebSocket.flushQueue()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("flushQueue")]
        void FlushQueue();

        // @property (copy, nonatomic) NSURL * _Null_unspecified socketURL __attribute__((diagnose_if(0x7fcad7959840, "Swift property 'LPWebSocket.socketURL' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("socketURL", ArgumentSemantic.Copy)]
        NSUrl SocketURL { get; set; }

        // -(void)cancelRequest:(NSString * _Nonnull)requestIndex __attribute__((diagnose_if(0x7fcad7959b88, "Swift method 'LPWebSocket.cancelRequest(_:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("cancelRequest:")]
        void CancelRequest(string requestIndex);

        // -(void)open;
        [Export("open")]
        void Open();

        // -(void)close;
        [Export("close")]
        void Close();
    }

    // @interface LanguagesManager : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface LanguagesManager
    {
        // @property (readonly, copy, nonatomic, class) NSDictionary<NSString *,NSString *> * _Nonnull supportedLanguages;
        [Static]
        [Export("supportedLanguages", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSString> SupportedLanguages { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        LanguagesManager New();

        // @property (readonly, nonatomic, strong, class) LanguagesManager * _Nonnull instance;
        [Static]
        [Export("instance", ArgumentSemantic.Strong)]
        LanguagesManager Instance { get; }

        // +(void)printAllKeys;
        [Static]
        [Export("printAllKeys")]
        void PrintAllKeys();

        // +(void)printSupportedLanguages;
        [Static]
        [Export("printSupportedLanguages")]
        void PrintSupportedLanguages();

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)getAllSupportedLanguages __attribute__((warn_unused_result));
        [Static]
        [Export("getAllSupportedLanguages")]

        NSDictionary<NSString, NSString> AllSupportedLanguages { get; }

        // +(NSString * _Nonnull)getFormattedLocale __attribute__((warn_unused_result));
        [Static]
        [Export("getFormattedLocale")]

        string FormattedLocale { get; }

        // +(NSString * _Nonnull)sdkLanguageFromLocalePreferredLanguage __attribute__((warn_unused_result));
        [Static]
        [Export("sdkLanguageFromLocalePreferredLanguage")]

        string SdkLanguageFromLocalePreferredLanguage { get; }
    }

    // @interface LogEvent : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface LogEvent
    {
        // @property (readonly, nonatomic) enum LogLevel logLevel;
        [Export("logLevel")]
        LogLevel LogLevel { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull className;
        [Export("className")]
        string ClassName { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull functionName;
        [Export("functionName")]
        string FunctionName { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull message;
        [Export("message")]
        string Message { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nonnull timestamp;
        [Export("timestamp", ArgumentSemantic.Copy)]
        NSDate Timestamp { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        LogEvent New();
    }

    // @interface MessagingEventNotification : GeneralResponse
    [BaseType(typeof(GeneralResponse))]
    interface MessagingEventNotification
    {
        // @property (copy, nonatomic) NSString * _Nullable conversationID;
        [NullAllowed, Export("conversationID")]
        string ConversationID { get; set; }

        // -(instancetype _Nonnull)initWithJsonDict:(NSDictionary<NSString *,id> * _Nonnull)jsonDict __attribute__((objc_designated_initializer));
        [Export("initWithJsonDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> jsonDict);
    }

    // @interface MessagingServiceEvent : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MessagingServiceEvent
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable eventId;
        [NullAllowed, Export("eventId")]
        string EventId { get; }

        // @property (readonly, nonatomic, strong) LPConversationEntity * _Null_unspecified conversation;
        [Export("conversation", ArgumentSemantic.Strong)]
        LPConversationEntity Conversation { get; }

        // @property (readonly, nonatomic, strong) LPUserEntity * _Nullable sender;
        [NullAllowed, Export("sender", ArgumentSemantic.Strong)]
        LPUserEntity Sender { get; }

        // @property (copy, nonatomic) void (^ _Nullable)(LPMessageEntity * _Nonnull) fileMessageCompletion;
        [NullAllowed, Export("fileMessageCompletion", ArgumentSemantic.Copy)]
        Action<LPMessageEntity> FileMessageCompletion { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(NSError * _Nonnull) fileMessageFailure;
        [NullAllowed, Export("fileMessageFailure", ArgumentSemantic.Copy)]
        Action<NSError> FileMessageFailure { get; set; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        MessagingServiceEvent New();
    }

    // @interface LPInfra_Swift_1877 (NSManagedObject)
    [Category]
    [BaseType(typeof(NSManagedObject))]
    interface NSManagedObject_LPInfra_Swift_1877
    {
        // -(void)saveContext __attribute__((diagnose_if(0x7fcad795e180, "Swift method 'NSManagedObject.saveContext()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("saveContext")]
        void SaveContext();

        // @property (readonly, nonatomic) BOOL isValid __attribute__((diagnose_if(0x7fcad795e450, "Swift property 'NSManagedObject.isValid' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("isValid")]
        bool IsValid { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable objectIDPermanentString __attribute__((diagnose_if(0x7fcad795e798, "Swift property 'NSManagedObject.objectIDPermanentString' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("objectIDPermanentString")]
        string ObjectIDPermanentString { get; }
    }

    // @interface LPInfra_Swift_1886 (NSObject)
    [Category]
    [BaseType(typeof(NSObject))]
    interface NSObject_LPInfra_Swift_1886
    {
        // -(NSDictionary<NSString *,id> * _Nonnull)serializeToDictionary __attribute__((diagnose_if(0x7fcad795ed68, "Swift method 'NSObject.serializeToDictionary()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
        [Export("serializeToDictionary")]

        NSDictionary<NSString, NSObject> SerializeToDictionary { get; }
    }

    // @interface LPInfra_Swift_1895 (NSOperationQueue)
    [Category]
    [BaseType(typeof(NSOperationQueue))]
    interface NSOperationQueue_LPInfra_Swift_1895
    {
        // +(NSOperationQueue * _Nonnull)sharedOperationQueue __attribute__((diagnose_if(0x7fcad795f170, "Swift method 'OperationQueue.sharedOperationQueue()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
        [Static]
        [Export("sharedOperationQueue")]

        NSOperationQueue SharedOperationQueue { get; }
    }

    // @interface PublishEvent : GeneralResponse
    [BaseType(typeof(GeneralResponse))]
    interface PublishEvent
    {
        // -(instancetype _Nonnull)initWithJsonDict:(NSDictionary<NSString *,id> * _Nonnull)jsonDict __attribute__((objc_designated_initializer));
        [Export("initWithJsonDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> jsonDict);
    }

    // @interface RequestConversation : GeneralResponse
    [BaseType(typeof(GeneralResponse))]
    interface RequestConversation
    {
        // -(instancetype _Nonnull)initWithJsonDict:(NSDictionary<NSString *,id> * _Nonnull)jsonDict __attribute__((objc_designated_initializer));
        [Export("initWithJsonDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> jsonDict);
    }

    // @interface RequestSwiftURL : GeneralResponse
    [BaseType(typeof(GeneralResponse))]
    interface RequestSwiftURL
    {
        // -(instancetype _Nonnull)initWithJsonDict:(NSDictionary<NSString *,id> * _Nonnull)jsonDict __attribute__((objc_designated_initializer));
        [Export("initWithJsonDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> jsonDict);
    }

    // @interface Ring : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface Ring
    {
        // @property (copy, nonatomic) NSString * _Nullable ringID __attribute__((diagnose_if(0x7fcad7960368, "Swift property 'Ring.ringID' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("ringID")]
        string RingID { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable brandId __attribute__((diagnose_if(0x7fcad7960648, "Swift property 'Ring.brandId' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("brandId")]
        string BrandId { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable conversationID __attribute__((diagnose_if(0x7fcad79608f8, "Swift property 'Ring.conversationID' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("conversationID")]
        string ConversationID { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable consumerId __attribute__((diagnose_if(0x7fcad7960ba8, "Swift property 'Ring.consumerId' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("consumerId")]
        string ConsumerId { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable skillId __attribute__((diagnose_if(0x7fcad7960e50, "Swift property 'Ring.skillId' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("skillId")]
        string SkillId { get; set; }

        // @property (copy, nonatomic) NSDate * _Nullable ringExpiration __attribute__((diagnose_if(0x7fcad7961100, "Swift property 'Ring.ringExpiration' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("ringExpiration", ArgumentSemantic.Copy)]
        NSDate RingExpiration { get; set; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        Ring New();
    }

    // @interface RingUpdated : GeneralResponse
    [BaseType(typeof(GeneralResponse))]
    interface RingUpdated
    {
        // -(instancetype _Nonnull)initWithJsonDict:(NSDictionary<NSString *,id> * _Nonnull)jsonDict __attribute__((objc_designated_initializer));
        [Export("initWithJsonDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> jsonDict);
    }

    // @interface RoutingTaskNotification : GeneralResponse
    [BaseType(typeof(GeneralResponse))]
    interface RoutingTaskNotification
    {
        // -(instancetype _Nonnull)initWithJsonDict:(NSDictionary<NSString *,id> * _Nonnull)jsonDict __attribute__((objc_designated_initializer));
        [Export("initWithJsonDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> jsonDict);
    }

    // @interface SecureFormReadOTKResponse : GeneralResponse
    [BaseType(typeof(GeneralResponse))]
    interface SecureFormReadOTKResponse
    {
        // -(instancetype _Nonnull)initWithJsonDict:(NSDictionary<NSString *,id> * _Nonnull)jsonDict __attribute__((objc_designated_initializer));
        [Export("initWithJsonDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> jsonDict);
    }

    // @interface StructuredContentAction : NSObject <NSCoding>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface StructuredContentAction : INSCoding
    {
        // @property (copy, nonatomic) NSString * _Nonnull ID __attribute__((diagnose_if(0x7fcad7962f08, "Swift property 'StructuredContentAction.ID' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("ID")]
        string ID { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull type __attribute__((diagnose_if(0x7fcad79631d0, "Swift property 'StructuredContentAction.type' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("type")]
        string Type { get; set; }

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSCoder aDecoder);

        // -(void)encodeWithCoder:(NSCoder * _Nonnull)aCoder;
        [Export("encodeWithCoder:")]
        void EncodeWithCoder(NSCoder aCoder);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        StructuredContentAction New();
    }

    // @interface StructuredContentItem : NSObject <NSCoding>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface StructuredContentItem : INSCoding
    {
        // @property (copy, nonatomic) NSString * _Nonnull ID __attribute__((diagnose_if(0x7fcad79640f0, "Swift property 'StructuredContentItem.ID' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("ID")]
        string ID { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull type __attribute__((diagnose_if(0x7fcad79643b0, "Swift property 'StructuredContentItem.type' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("type")]
        string Type { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable tooltip __attribute__((diagnose_if(0x7fcad7964678, "Swift property 'StructuredContentItem.tooltip' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("tooltip")]
        string Tooltip { get; set; }

        // @property (nonatomic, strong) StructuredContentClick * _Nullable click __attribute__((diagnose_if(0x7fcad79649a8, "Swift property 'StructuredContentItem.click' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("click", ArgumentSemantic.Strong)]
        StructuredContentClick Click { get; set; }

        // @property (nonatomic, strong) StructuredContentStyle * _Nullable style __attribute__((diagnose_if(0x7fcad7964cd8, "Swift property 'StructuredContentItem.style' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("style", ArgumentSemantic.Strong)]
        StructuredContentStyle Style { get; set; }

        // @property (nonatomic) BOOL requiresBorder __attribute__((diagnose_if(0x7fcad7964f88, "Swift property 'StructuredContentItem.requiresBorder' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("requiresBorder")]
        bool RequiresBorder { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull structuredContentAccessibilityLabel __attribute__((diagnose_if(0x7fcad79652b8, "Swift property 'StructuredContentItem.structuredContentAccessibilityLabel' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("structuredContentAccessibilityLabel")]
        string StructuredContentAccessibilityLabel { get; }

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSCoder aDecoder);

        // -(void)encodeWithCoder:(NSCoder * _Nonnull)aCoder;
        [Export("encodeWithCoder:")]
        void EncodeWithCoder(NSCoder aCoder);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        StructuredContentItem New();
    }

    // @interface StructuredContentButtonItem : StructuredContentItem
    [BaseType(typeof(StructuredContentItem))]
    interface StructuredContentButtonItem
    {
        // @property (copy, nonatomic) NSString * _Nullable title __attribute__((diagnose_if(0x7fcad7966708, "Swift property 'StructuredContentButtonItem.title' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("title")]
        string Title { get; set; }

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSCoder aDecoder);

        // -(void)encodeWithCoder:(NSCoder * _Nonnull)aCoder;
        [Export("encodeWithCoder:")]
        void EncodeWithCoder(NSCoder aCoder);
    }

    // @interface StructuredContentClick : NSObject <NSCoding>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface StructuredContentClick : INSCoding
    {
        // @property (copy, nonatomic) NSString * _Nonnull ID __attribute__((diagnose_if(0x7fcad7967088, "Swift property 'StructuredContentClick.ID' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("ID")]
        string ID { get; set; }

        // @property (copy, nonatomic) NSArray<NSDictionary<NSString *,id> *> * _Nullable metadata __attribute__((diagnose_if(0x7fcad7967460, "Swift property 'StructuredContentClick.metadata' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("metadata", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject>[] Metadata { get; set; }

        // @property (copy, nonatomic) NSArray<StructuredContentAction *> * _Nullable actions __attribute__((diagnose_if(0x7fcad7967868, "Swift property 'StructuredContentClick.actions' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("actions", ArgumentSemantic.Copy)]
        StructuredContentAction[] Actions { get; set; }

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSCoder aDecoder);

        // -(void)encodeWithCoder:(NSCoder * _Nonnull)aCoder;
        [Export("encodeWithCoder:")]
        void EncodeWithCoder(NSCoder aCoder);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        StructuredContentClick New();
    }

    // @interface StructuredContentImageItem : StructuredContentItem
    [BaseType(typeof(StructuredContentItem))]
    interface StructuredContentImageItem
    {
        // @property (nonatomic, strong) UIImage * _Nullable image __attribute__((diagnose_if(0x7fcad7968788, "Swift property 'StructuredContentImageItem.image' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull imageURL __attribute__((diagnose_if(0x7fcad7968a58, "Swift property 'StructuredContentImageItem.imageURL' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("imageURL")]
        string ImageURL { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable relativeImagePath __attribute__((diagnose_if(0x7fcad7968d38, "Swift property 'StructuredContentImageItem.relativeImagePath' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("relativeImagePath")]
        string RelativeImagePath { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable imageState __attribute__((diagnose_if(0x7fcad7969018, "Swift property 'StructuredContentImageItem.imageState' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("imageState")]
        string ImageState { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable imageCaption __attribute__((diagnose_if(0x7fcad79692f0, "Swift property 'StructuredContentImageItem.imageCaption' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("imageCaption")]
        string ImageCaption { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(UIImage * _Nullable) imageLoadingCompleted __attribute__((diagnose_if(0x7fcad79696b8, "Swift property 'StructuredContentImageItem.imageLoadingCompleted' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("imageLoadingCompleted", ArgumentSemantic.Copy)]
        Action<UIImage> ImageLoadingCompleted { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(NSError * _Nonnull) imageLoadingFailed __attribute__((diagnose_if(0x7fcad7969a50, "Swift property 'StructuredContentImageItem.imageLoadingFailed' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("imageLoadingFailed", ArgumentSemantic.Copy)]
        Action<NSError> ImageLoadingFailed { get; set; }

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSCoder aDecoder);

        // -(void)encodeWithCoder:(NSCoder * _Nonnull)aCoder;
        [Export("encodeWithCoder:")]
        void EncodeWithCoder(NSCoder aCoder);
    }

    // @interface LPInfra_Swift_2046 (StructuredContentItem)
    [Category]
    [BaseType(typeof(StructuredContentItem))]
    interface StructuredContentItem_LPInfra_Swift_2046
    {
        // -(void)iterateThroughWithIterationStep:(void (^ _Nonnull)(StructuredContentItem * _Nonnull))iterationStep __attribute__((diagnose_if(0x7fcad796af28, "Swift method 'StructuredContentItem.iterateThrough(iterationStep:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("iterateThroughWithIterationStep:")]
        void IterateThroughWithIterationStep(Action<StructuredContentItem> iterationStep);
    }

    // @interface StructuredContentItemContainer : NSObject <NSCoding>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface StructuredContentItemContainer : INSCoding
    {
        // @property (copy, nonatomic) NSString * _Nonnull ID __attribute__((diagnose_if(0x7fcad796b428, "Swift property 'StructuredContentItemContainer.ID' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("ID")]
        string ID { get; set; }

        // @property (nonatomic, strong) StructuredContentItem * _Nullable item __attribute__((diagnose_if(0x7fcad796b738, "Swift property 'StructuredContentItemContainer.item' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("item", ArgumentSemantic.Strong)]
        StructuredContentItem Item { get; set; }

        // -(instancetype _Nonnull)initWithStructuredContentItem:(StructuredContentItem * _Nonnull)structuredContentItem __attribute__((diagnose_if(0x7fcad796bb10, "Swift initializer 'StructuredContentItemContainer.init(structuredContentItem:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((objc_designated_initializer));
        [Export("initWithStructuredContentItem:")]
        [DesignatedInitializer]
        IntPtr Constructor(StructuredContentItem structuredContentItem);

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSCoder aDecoder);

        // -(void)encodeWithCoder:(NSCoder * _Nonnull)aCoder;
        [Export("encodeWithCoder:")]
        void EncodeWithCoder(NSCoder aCoder);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        StructuredContentItemContainer New();
    }

    // @interface StructuredContentLayoutItem : StructuredContentItem
    [BaseType(typeof(StructuredContentItem))]
    interface StructuredContentLayoutItem
    {
        // @property (copy, nonatomic) NSArray<StructuredContentItem *> * _Nullable itemsArray __attribute__((diagnose_if(0x7fcad796ca28, "Swift property 'StructuredContentLayoutItem.itemsArray' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("itemsArray", ArgumentSemantic.Copy)]
        StructuredContentItem[] ItemsArray { get; set; }

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)decoder __attribute__((objc_designated_initializer));
        [Export("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSCoder decoder);

        // -(void)encodeWithCoder:(NSCoder * _Nonnull)aCoder;
        [Export("encodeWithCoder:")]
        void EncodeWithCoder(NSCoder aCoder);
    }

    // @interface StructuredContentLinkAction : StructuredContentAction
    [BaseType(typeof(StructuredContentAction))]
    interface StructuredContentLinkAction
    {
        // @property (copy, nonatomic) NSString * _Nonnull uri __attribute__((diagnose_if(0x7fcad796d3e0, "Swift property 'StructuredContentLinkAction.uri' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("uri")]
        string Uri { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable deepLinkUri __attribute__((diagnose_if(0x7fcad796d6b0, "Swift property 'StructuredContentLinkAction.deepLinkUri' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("deepLinkUri")]
        string DeepLinkUri { get; set; }

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSCoder aDecoder);

        // -(void)encodeWithCoder:(NSCoder * _Nonnull)aCoder;
        [Export("encodeWithCoder:")]
        void EncodeWithCoder(NSCoder aCoder);
    }

    // @interface StructuredContentLinkPreviewItem : StructuredContentItem
    [BaseType(typeof(StructuredContentItem))]
    interface StructuredContentLinkPreviewItem
    {
        // @property (copy, nonatomic) NSString * _Nonnull url __attribute__((diagnose_if(0x7fcad796e1d8, "Swift property 'StructuredContentLinkPreviewItem.url' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("url")]
        string Url { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable title __attribute__((diagnose_if(0x7fcad796e4b0, "Swift property 'StructuredContentLinkPreviewItem.title' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("title")]
        string Title { get; set; }

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSCoder aDecoder);

        // -(void)encodeWithCoder:(NSCoder * _Nonnull)aCoder;
        [Export("encodeWithCoder:")]
        void EncodeWithCoder(NSCoder aCoder);
    }

    // @interface StructuredContentMapItem : StructuredContentItem
    [BaseType(typeof(StructuredContentItem))]
    interface StructuredContentMapItem
    {
        // @property (nonatomic) int latitude __attribute__((diagnose_if(0x7fcad79765b8, "Swift property 'StructuredContentMapItem.latitude' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("latitude")]
        int Latitude { get; set; }

        // @property (nonatomic) int longitude __attribute__((diagnose_if(0x7fcad7976878, "Swift property 'StructuredContentMapItem.longitude' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("longitude")]
        int Longitude { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable snapShotImage __attribute__((diagnose_if(0x7fcad7976b50, "Swift property 'StructuredContentMapItem.snapShotImage' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("snapShotImage", ArgumentSemantic.Strong)]
        UIImage SnapShotImage { get; set; }

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSCoder aDecoder);

        // -(void)encodeWithCoder:(NSCoder * _Nonnull)aCoder;
        [Export("encodeWithCoder:")]
        void EncodeWithCoder(NSCoder aCoder);
    }

    // @interface StructuredContentNavigateAction : StructuredContentAction
    [BaseType(typeof(StructuredContentAction))]
    interface StructuredContentNavigateAction
    {
        // @property (nonatomic) int latitude __attribute__((diagnose_if(0x7fcad7977818, "Swift property 'StructuredContentNavigateAction.latitude' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("latitude")]
        int Latitude { get; set; }

        // @property (nonatomic) int longitude __attribute__((diagnose_if(0x7fcad7977ae0, "Swift property 'StructuredContentNavigateAction.longitude' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("longitude")]
        int Longitude { get; set; }

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSCoder aDecoder);

        // -(void)encodeWithCoder:(NSCoder * _Nonnull)aCoder;
        [Export("encodeWithCoder:")]
        void EncodeWithCoder(NSCoder aCoder);
    }

    // @interface StructuredContentPublishTextAction : StructuredContentAction
    [BaseType(typeof(StructuredContentAction))]
    interface StructuredContentPublishTextAction
    {
        // @property (copy, nonatomic) NSString * _Nonnull text __attribute__((diagnose_if(0x7fcad7978658, "Swift property 'StructuredContentPublishTextAction.text' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("text")]
        string Text { get; set; }

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSCoder aDecoder);

        // -(void)encodeWithCoder:(NSCoder * _Nonnull)aCoder;
        [Export("encodeWithCoder:")]
        void EncodeWithCoder(NSCoder aCoder);
    }

    // @interface StructuredContentStyle : NSObject <NSCoding>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface StructuredContentStyle : INSCoding
    {
        // @property (nonatomic, strong) UIColor * _Nullable color __attribute__((diagnose_if(0x7fcad7978fd8, "Swift property 'StructuredContentStyle.color' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("color", ArgumentSemantic.Strong)]
        UIColor Color { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable backgroundColor __attribute__((diagnose_if(0x7fcad79792a8, "Swift property 'StructuredContentStyle.backgroundColor' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable size __attribute__((diagnose_if(0x7fcad7979578, "Swift property 'StructuredContentStyle.size' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("size")]
        string Size { get; set; }

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSCoder aDecoder);

        // -(void)encodeWithCoder:(NSCoder * _Nonnull)aCoder;
        [Export("encodeWithCoder:")]
        void EncodeWithCoder(NSCoder aCoder);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        StructuredContentStyle New();
    }

    // @interface StructuredContentTextItem : StructuredContentItem
    [BaseType(typeof(StructuredContentItem))]
    interface StructuredContentTextItem
    {
        // @property (copy, nonatomic) NSString * _Nullable text __attribute__((diagnose_if(0x7fcad797a498, "Swift property 'StructuredContentTextItem.text' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("text")]
        string Text { get; set; }

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSCoder aDecoder);

        // -(void)encodeWithCoder:(NSCoder * _Nonnull)aCoder;
        [Export("encodeWithCoder:")]
        void EncodeWithCoder(NSCoder aCoder);
    }

    // @interface StructuredContentWebviewItem : StructuredContentItem
    [BaseType(typeof(StructuredContentItem))]
    interface StructuredContentWebviewItem
    {
        // @property (copy, nonatomic) NSString * _Nonnull url __attribute__((diagnose_if(0x7fcad797ae40, "Swift property 'StructuredContentWebviewItem.url' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("url")]
        string Url { get; set; }

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSCoder aDecoder);

        // -(void)encodeWithCoder:(NSCoder * _Nonnull)aCoder;
        [Export("encodeWithCoder:")]
        void EncodeWithCoder(NSCoder aCoder);
    }

    // @interface SubscribeConversations : GeneralResponse
    [BaseType(typeof(GeneralResponse))]
    interface SubscribeConversations
    {
        // -(instancetype _Nonnull)initWithJsonDict:(NSDictionary<NSString *,id> * _Nonnull)jsonDict __attribute__((objc_designated_initializer));
        [Export("initWithJsonDict:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> jsonDict);
    }

    // @interface TTRModel : NSObject <NSCoding>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface TTRModel : INSCoding
    {
        // @property (copy, nonatomic) NSDate * _Null_unspecified effectiveTTR __attribute__((diagnose_if(0x7fcad797bc28, "Swift property 'TTRModel.effectiveTTR' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("effectiveTTR", ArgumentSemantic.Copy)]
        NSDate EffectiveTTR { get; set; }

        // @property (copy, nonatomic) NSDate * _Nullable manualETTR __attribute__((diagnose_if(0x7fcad797bee0, "Swift property 'TTRModel.manualETTR' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("manualETTR", ArgumentSemantic.Copy)]
        NSDate ManualETTR { get; set; }

        // @property (nonatomic) NSInteger ttrValue __attribute__((diagnose_if(0x7fcad797c178, "Swift property 'TTRModel.ttrValue' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("ttrValue")]
        nint TtrValue { get; set; }

        // @property (copy, nonatomic) NSDate * _Nullable delay __attribute__((diagnose_if(0x7fcad797c428, "Swift property 'TTRModel.delay' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("delay", ArgumentSemantic.Copy)]
        NSDate Delay { get; set; }

        // -(instancetype _Nonnull)initWithEffectiveTTR:(NSDate * _Nonnull)effectiveTTR manualETTR:(NSDate * _Nullable)manualETTR ttrValue:(NSInteger)ttrValue delay:(NSDate * _Nullable)delay __attribute__((diagnose_if(0x7fcad797c958, "Swift initializer 'TTRModel.init(effectiveTTR:manualETTR:ttrValue:delay:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((objc_designated_initializer));
        [Export("initWithEffectiveTTR:manualETTR:ttrValue:delay:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDate effectiveTTR, [NullAllowed] NSDate manualETTR, nint ttrValue, [NullAllowed] NSDate delay);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // -(void)encodeWithCoder:(NSCoder * _Nonnull)aCoder;
        [Export("encodeWithCoder:")]
        void EncodeWithCoder(NSCoder aCoder);

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSCoder aDecoder);

        // -(BOOL)compareWithOther:(TTRModel * _Nonnull)other __attribute__((diagnose_if(0x7fcad797d0b0, "Swift method 'TTRModel.compare(other:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
        [Export("compareWithOther:")]
        bool CompareWithOther(TTRModel other);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        TTRModel New();
    }

    // @interface Toast : UIView
    [BaseType(typeof(UIView))]
    interface Toast
    {
        // @property (copy, nonatomic) NSString * _Nullable name __attribute__((diagnose_if(0x7fcad797dec8, "Swift property 'Toast.name' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(void) didShow __attribute__((diagnose_if(0x7fcad797e1f8, "Swift property 'Toast.didShow' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("didShow", ArgumentSemantic.Copy)]
        Action DidShow { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(void) didDismiss __attribute__((diagnose_if(0x7fcad797e560, "Swift property 'Toast.didDismiss' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("didDismiss", ArgumentSemantic.Copy)]
        Action DidDismiss { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(void) didTap __attribute__((diagnose_if(0x7fcad797e890, "Swift property 'Toast.didTap' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("didTap", ArgumentSemantic.Copy)]
        Action DidTap { get; set; }

        // @property (nonatomic) BOOL showAboveStatusBar __attribute__((diagnose_if(0x7fcad797eb20, "Swift property 'Toast.showAboveStatusBar' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("showAboveStatusBar")]
        bool ShowAboveStatusBar { get; set; }

        // -(void)awakeFromNib __attribute__((objc_requires_super));
        [Export("awakeFromNib")]

        void AwakeFromNib();

        // -(void)changeTextWithText:(NSString * _Nonnull)text __attribute__((diagnose_if(0x7fcad797ef68, "Swift method 'Toast.changeText(text:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("changeTextWithText:")]
        void ChangeTextWithText(string text);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface Toaster : UIView
    [BaseType(typeof(UIView))]
    interface Toaster
    {
        // @property (readonly, nonatomic, strong) Toast * _Nullable current __attribute__((diagnose_if(0x7fcad7980028, "Swift property 'Toaster.current' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [NullAllowed, Export("current", ArgumentSemantic.Strong)]
        Toast Current { get; }

        // -(instancetype _Nonnull)initWithContainerViewController:(UIViewController * _Nonnull)containerViewController __attribute__((diagnose_if(0x7fcad79803c8, "Swift initializer 'Toaster.init(containerViewController:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("initWithContainerViewController:")]
        IntPtr Constructor(UIViewController containerViewController);

        // -(instancetype _Nonnull)initWithContainerView:(UIView * _Nonnull)containerView __attribute__((diagnose_if(0x7fcad7980750, "Swift initializer 'Toaster.init(containerView:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("initWithContainerView:")]
        IntPtr Constructor(UIView containerView);

        // -(void)addWithToast:(Toast * _Nonnull)toast __attribute__((diagnose_if(0x7fcad7980b00, "Swift method 'Toaster.add(toast:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("addWithToast:")]
        void AddWithToast(Toast toast);

        // -(void)dismissWithToast:(Toast * _Nonnull)toast __attribute__((diagnose_if(0x7fcad7980e68, "Swift method 'Toaster.dismiss(toast:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("dismissWithToast:")]
        void DismissWithToast(Toast toast);

        // -(void)dismissToastByName:(NSString * _Nonnull)name __attribute__((diagnose_if(0x7fcad79811e0, "Swift method 'Toaster.dismissToast(byName:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("dismissToastByName:")]
        void DismissToastByName(string name);

        // -(void)dismissAll __attribute__((diagnose_if(0x7fcad79814c8, "Swift method 'Toaster.dismissAll()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("dismissAll")]
        void DismissAll();

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface LPInfra_Swift_2279 (UIColor)
    [Category]
    [BaseType(typeof(UIColor))]
    interface UIColor_LPInfra_Swift_2279
    {
        // -(instancetype _Nonnull)initWithRgba:(NSString * _Nonnull)rgba __attribute__((diagnose_if(0x7fcad7981ce8, "Swift initializer 'UIColor.init(rgba:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("initWithRgba:")]
        IntPtr Constructor(string rgba);
    }

    // @interface LPInfra_Swift_2284 (UIDevice)
    [Category]
    [BaseType(typeof(UIDevice))]
    interface UIDevice_LPInfra_Swift_2284
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull modelNameIdentifier __attribute__((diagnose_if(0x7fcad79820e8, "Swift property 'UIDevice.modelNameIdentifier' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("modelNameIdentifier")]
        string ModelNameIdentifier { get; }
    }

    // @interface LPInfra_Swift_2293 (UIFont)
    [Category]
    [BaseType(typeof(UIFont))]
    interface UIFont_LPInfra_Swift_2293
    {
        // -(CGSize)sizeOfStringWithString:(NSString * _Nonnull)string constrainedToWidth:(double)width __attribute__((diagnose_if(0x7fcad7982690, "Swift method 'UIFont.sizeOfString(string:constrainedToWidth:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
        [Export("sizeOfStringWithString:constrainedToWidth:")]
        CGSize SizeOfStringWithString(string @string, double width);
    }

    // @interface LPInfra_Swift_2306 (UIImage)
    [Category]
    [BaseType(typeof(UIImage))]
    interface UIImage_LPInfra_Swift_2306
    {
        // -(UIImage * _Nonnull)imageWithTint:(UIColor * _Nonnull)tint __attribute__((diagnose_if(0x7fcad7982b28, "Swift method 'UIImage.imageWithTint(_:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
        [Export("imageWithTint:")]
        UIImage ImageWithTint(UIColor tint);

        // -(UIImage * _Nonnull)resizeImageWithTargetSize:(CGSize)targetSize scale:(CGFloat)scale __attribute__((diagnose_if(0x7fcad7982f30, "Swift method 'UIImage.resizeImage(targetSize:scale:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
        [Export("resizeImageWithTargetSize:scale:")]
        UIImage ResizeImageWithTargetSize(CGSize targetSize, nfloat scale);

        // +(CGSize)getResizedImageSizeWithImage:(UIImage * _Nonnull)image maxHeight:(CGFloat)maxHeight maxWidth:(CGFloat)maxWidth __attribute__((diagnose_if(0x7fcad79833c8, "Swift method 'UIImage.getResizedImageSize(image:maxHeight:maxWidth:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
        [Static]
        [Export("getResizedImageSizeWithImage:maxHeight:maxWidth:")]
        CGSize GetResizedImageSizeWithImage(UIImage image, nfloat maxHeight, nfloat maxWidth);

        // -(UIImage * _Nullable)blurImageWithRadius:(CGFloat)radius size:(CGSize)size __attribute__((diagnose_if(0x7fcad79837e8, "Swift method 'UIImage.blurImage(radius:size:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
        [Export("blurImageWithRadius:size:")]
        [return: NullAllowed]
        UIImage BlurImageWithRadius(nfloat radius, CGSize size);
    }

    // @interface LPInfra_Swift_2318 (UINavigationController)
    [Category]
    [BaseType(typeof(UINavigationController))]
    interface UINavigationController_LPInfra_Swift_2318
    {
        // -(UIFont * _Nullable)getNavigationBarTitleFont __attribute__((diagnose_if(0x7fcad7983c20, "Swift method 'UINavigationController.getNavigationBarTitleFont()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
        [NullAllowed, Export("getNavigationBarTitleFont")]

        UIFont NavigationBarTitleFont { get; }
    }

    // @interface LPInfra_Swift_2327 (UIWindow)
    [Category]
    [BaseType(typeof(UIWindow))]
    interface UIWindow_LPInfra_Swift_2327
    {
        // -(UIViewController * _Nullable)topRootPresentedViewController __attribute__((diagnose_if(0x7fcad7984068, "Swift method 'UIWindow.topRootPresentedViewController()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
        [NullAllowed, Export("topRootPresentedViewController")]

        UIViewController TopRootPresentedViewController { get; }

        // -(UIViewController * _Nullable)topViewControllerWithBase:(UIViewController * _Nullable)base __attribute__((diagnose_if(0x7fcad7984420, "Swift method 'UIWindow.topViewController(base:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
        [Export("topViewControllerWithBase:")]
        [return: NullAllowed]
        UIViewController TopViewControllerWithBase([NullAllowed] UIViewController @base);
    }

    // @interface LPInfra_Swift_2337 (NSUserDefaults)
    [Category]
    [BaseType(typeof(NSUserDefaults))]
    interface NSUserDefaults_LPInfra_Swift_2337
    {
        // @property (readonly, nonatomic, strong, class) NSUserDefaults * _Nonnull lpStandard __attribute__((diagnose_if(0x7fcad7984800, "Swift property 'UserDefaults.lpStandard' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Static]
        [Export("lpStandard", ArgumentSemantic.Strong)]
        NSUserDefaults LpStandard { get; }
    }

    // @interface Utils : NSObject
    [BaseType(typeof(NSObject))]
    interface Utils
    {
        // @property (readonly, nonatomic, strong, class) dispatch_queue_t _Nonnull backgroundQueue;
        [Static]
        [Export("backgroundQueue", ArgumentSemantic.Strong)]
        DispatchQueue BackgroundQueue { get; }

        // +(NSString * _Nullable)JSONStringify:(NSDictionary<NSString *,id> * _Nonnull)value prettyPrinted:(BOOL)prettyPrinted __attribute__((warn_unused_result));
        [Static]
        [Export("JSONStringify:prettyPrinted:")]
        [return: NullAllowed]
        string JSONStringify(NSDictionary<NSString, NSObject> value, bool prettyPrinted);

        // +(id _Nullable)JSONDictionaryFromString:(NSString * _Nonnull)string __attribute__((warn_unused_result));
        [Static]
        [Export("JSONDictionaryFromString:")]
        [return: NullAllowed]
        NSObject JSONDictionaryFromString(string @string);

        // +(NSString * _Nonnull)formatDate:(NSDate * _Nonnull)date __attribute__((warn_unused_result));
        [Static]
        [Export("formatDate:")]
        string FormatDate(NSDate date);

        // +(NSString * _Nonnull)trim:(NSString * _Nonnull)str __attribute__((warn_unused_result));
        [Static]
        [Export("trim:")]
        string Trim(string str);

        // +(BOOL)isValidEmail:(NSString * _Nonnull)testStr __attribute__((warn_unused_result));
        [Static]
        [Export("isValidEmail:")]
        bool IsValidEmail(string testStr);

        // +(void)delay:(double)delay closure:(void (^ _Nonnull)(void))closure;
        [Static]
        [Export("delay:closure:")]
        void Delay(double delay, Action closure);

        // +(NSInteger)minutesBetweenDates:(NSDate * _Nonnull)startDate endDate:(NSDate * _Nonnull)endDate __attribute__((warn_unused_result));
        [Static]
        [Export("minutesBetweenDates:endDate:")]
        nint MinutesBetweenDates(NSDate startDate, NSDate endDate);

        // +(void)backgroundThread:(void (^ _Nonnull)(void))job;
        [Static]
        [Export("backgroundThread:")]
        void BackgroundThread(Action job);

        // +(BOOL)isJWTExpired:(NSString * _Nonnull)jwtToken __attribute__((warn_unused_result));
        [Static]
        [Export("isJWTExpired:")]
        bool IsJWTExpired(string jwtToken);

        // +(void)mainThread:(void (^ _Nonnull)(void))job;
        [Static]
        [Export("mainThread:")]
        void MainThread(Action job);

        // +(NSInteger)randWithMin:(NSInteger)min max:(NSInteger)max __attribute__((warn_unused_result));
        [Static]
        [Export("randWithMin:max:")]
        nint RandWithMin(nint min, nint max);

        // +(CGSize)getResizedImageSizeWithImage:(UIImage * _Nonnull)image maxHeight:(CGFloat)maxHeight maxWidth:(CGFloat)maxWidth __attribute__((warn_unused_result));
        [Static]
        [Export("getResizedImageSizeWithImage:maxHeight:maxWidth:")]
        CGSize GetResizedImageSizeWithImage(UIImage image, nfloat maxHeight, nfloat maxWidth);

        // +(id _Nonnull)unwrapWithAny:(id _Nonnull)any __attribute__((warn_unused_result));
        [Static]
        [Export("unwrapWithAny:")]
        NSObject UnwrapWithAny(NSObject any);

        // +(void)showLocalNotification:(NSString * _Nonnull)text uid:(NSString * _Nullable)uid;
        [Static]
        [Export("showLocalNotification:uid:")]
        void ShowLocalNotification(string text, [NullAllowed] string uid);

        // +(void)playVibrationSound;
        [Static]
        [Export("playVibrationSound")]
        void PlayVibrationSound();
    }



    // @interface ConnectionStateManager : NSObject <GeneralManagerProtocol>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ConnectionStateManager : GeneralManagerProtocol
    {
        // @property (readonly, nonatomic, strong, class) ConnectionStateManager * _Nonnull instance __attribute__((diagnose_if(0x7fcad798da78, "Swift property 'ConnectionStateManager.instance' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Static]
        [Export("instance", ArgumentSemantic.Strong)]
        ConnectionStateManager Instance { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        ConnectionStateManager New();

        // -(void)clearManager;
        [Export("clearManager")]
        void ClearManager();
    }

    // @interface EngagementHistoryManager : NSObject
    [BaseType(typeof(NSObject))]
    interface EngagementHistoryManager
    {
        // +(void)getConsumerMessagesForConversationWithRequest:(EngagementHistoryRequest * _Nonnull)request completion:(void (^ _Nonnull)(NSArray<LPMessageEntity *> * _Nonnull))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure __attribute__((diagnose_if(0x7fcad798ecf8, "Swift method 'EngagementHistoryManager.getConsumerMessagesForConversation(request:completion:failure:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Static]
        [Export("getConsumerMessagesForConversationWithRequest:completion:failure:")]
        void GetConsumerMessagesForConversationWithRequest(EngagementHistoryRequest request, Action<NSArray> completion, Action<NSError> failure);

        // +(NSArray<LPMessageEntity *> * _Nonnull)handleConsumerMessagesResponse:(EngagementHistoryConsumerMessagesResponse * _Nonnull)response __attribute__((diagnose_if(0x7fcad798f1c8, "Swift method 'EngagementHistoryManager.handleConsumerMessagesResponse(_:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
        [Static]
        [Export("handleConsumerMessagesResponse:")]
        LPMessageEntity[] HandleConsumerMessagesResponse(EngagementHistoryConsumerMessagesResponse response);
    }

    // @interface LPAMSFacade : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface LPAMSFacade
    {
        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        LPAMSFacade New();

        // +(BOOL)initializeAMS __attribute__((warn_unused_result));
        [Static]
        [Export("initializeAMS")]

        bool InitializeAMS { get; }

        // +(void)connectToSocket:(id<ConversationParamProtocol> _Nonnull)conversationQuery readyCompletion:(void (^ _Nullable)(void))readyCompletion;
        [Static]
        [Export("connectToSocket:readyCompletion:")]
        void ConnectToSocket(ConversationParamProtocol conversationQuery, [NullAllowed] Action readyCompletion);

        // +(void)reconnectToSocket:(id<ConversationParamProtocol> _Nonnull)conversationQuery authenticationParams:(LPAuthenticationParams * _Nonnull)authenticationParams readyCompletion:(void (^ _Nullable)(void))readyCompletion;
        [Static]
        [Export("reconnectToSocket:authenticationParams:readyCompletion:")]
        void ReconnectToSocket(ConversationParamProtocol conversationQuery, LPAuthenticationParams authenticationParams, [NullAllowed] Action readyCompletion);

        // +(void)disconnectSocket:(id<ConversationParamProtocol> _Nonnull)conversationQuery;
        [Static]
        [Export("disconnectSocket:")]
        void DisconnectSocket(ConversationParamProtocol conversationQuery);

        // +(BOOL)clearHistory:(id<ConversationParamProtocol> _Nonnull)conversationQuery __attribute__((warn_unused_result));
        [Static]
        [Export("clearHistory:")]
        bool ClearHistory(ConversationParamProtocol conversationQuery);

        // +(void)deleteOldConversations;
        [Static]
        [Export("deleteOldConversations")]
        void DeleteOldConversations();

        // +(void)setDelegate:(id<LPAMSFacadeDelegate> _Nonnull)delegate;
        [Static]
        [Export("setDelegate:")]
        void SetDelegate(LPAMSFacadeDelegate @delegate);

        // +(void)removeDelegate:(id<LPAMSFacadeDelegate> _Nonnull)delegate;
        [Static]
        [Export("removeDelegate:")]
        void RemoveDelegate(LPAMSFacadeDelegate @delegate);

        // +(LPConversationEntity * _Nonnull)createConversation:(LPBrandEntity * _Nonnull)brand __attribute__((warn_unused_result));
        [Static]
        [Export("createConversation:")]
        LPConversationEntity CreateConversation(LPBrandEntity brand);

        // +(void)sendMessageInConversation:(LPConversationEntity * _Nonnull)conversation message:(LPMessageEntity * _Nonnull)message completion:(void (^ _Nonnull)(LPMessageEntity * _Nonnull))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("sendMessageInConversation:message:completion:failure:")]
        void SendMessageInConversation(LPConversationEntity conversation, LPMessageEntity message, Action<LPMessageEntity> completion, Action<NSError> failure);

        // +(void)sendMessageInConversation:(LPConversationEntity * _Nonnull)conversation text:(NSString * _Nonnull)text completion:(void (^ _Nonnull)(LPMessageEntity * _Nonnull))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("sendMessageInConversation:text:completion:failure:")]
        void SendMessageInConversation(LPConversationEntity conversation, string text, Action<LPMessageEntity> completion, Action<NSError> failure);

        // +(void)resolveConversation:(LPConversationEntity * _Nonnull)conversation;
        [Static]
        [Export("resolveConversation:")]
        void ResolveConversation(LPConversationEntity conversation);

        // +(void)resolveConversationForConversationQuery:(id<ConversationParamProtocol> _Nonnull)conversationQuery;
        [Static]
        [Export("resolveConversationForConversationQuery:")]
        void ResolveConversationForConversationQuery(ConversationParamProtocol conversationQuery);

        // +(LPUser * _Nullable)getAssignedAgent:(id<ConversationParamProtocol> _Nonnull)conversationQuery __attribute__((warn_unused_result));
        [Static]
        [Export("getAssignedAgent:")]
        [return: NullAllowed]
        LPUser GetAssignedAgent(ConversationParamProtocol conversationQuery);

        // +(BOOL)requestUrgentResponse:(LPConversationEntity * _Nonnull)conversation urgent:(BOOL)urgent __attribute__((warn_unused_result));
        [Static]
        [Export("requestUrgentResponse:urgent:")]
        bool RequestUrgentResponse(LPConversationEntity conversation, bool urgent);

        // +(void)changeUrgentState:(id<ConversationParamProtocol> _Nonnull)conversationQuery isUrgent:(BOOL)isUrgent;
        [Static]
        [Export("changeUrgentState:isUrgent:")]
        void ChangeUrgentState(ConversationParamProtocol conversationQuery, bool isUrgent);

        // +(void)retrieveNewMessagesForConversation:(LPConversationEntity * _Nonnull)conversation completion:(void (^ _Nullable)(NSArray<LPMessageEntity *> * _Nonnull))completion failure:(void (^ _Nullable)(NSError * _Nonnull))failure;
        [Static]
        [Export("retrieveNewMessagesForConversation:completion:failure:")]
        void RetrieveNewMessagesForConversation(LPConversationEntity conversation, [NullAllowed] Action<NSArray> completion, [NullAllowed] Action<NSError> failure);

        // +(void)sendCSAT:(LPConversationEntity * _Nonnull)conversation csat:(CSATModel * _Nonnull)csat;
        [Static]
        [Export("sendCSAT:csat:")]
        void SendCSAT(LPConversationEntity conversation, CSATModel csat);

        // +(void)subscribeConversationNotifications:(NSString * _Nonnull)brandID userID:(NSString * _Nonnull)userID socketType:(enum SocketType)socketType completion:(void (^ _Nullable)(NSString * _Nonnull))completion failure:(void (^ _Nullable)(NSError * _Nonnull))failure;
        [Static]
        [Export("subscribeConversationNotifications:userID:socketType:completion:failure:")]
        void SubscribeConversationNotifications(string brandID, string userID, SocketType socketType, [NullAllowed] Action<NSString> completion, [NullAllowed] Action<NSError> failure);

        // +(void)unsubscribeConversationNotifications:(NSString * _Nonnull)brandID subscriptionID:(NSString * _Nonnull)subscriptionID;
        [Static]
        [Export("unsubscribeConversationNotifications:subscriptionID:")]
        void UnsubscribeConversationNotifications(string brandID, string subscriptionID);

        // +(void)subscribeRoutingTasks:(NSString * _Nonnull)brandID agentID:(NSString * _Nonnull)agentID completion:(void (^ _Nullable)(NSString * _Nonnull))completion failure:(void (^ _Nullable)(NSError * _Nonnull))failure;
        [Static]
        [Export("subscribeRoutingTasks:agentID:completion:failure:")]
        void SubscribeRoutingTasks(string brandID, string agentID, [NullAllowed] Action<NSString> completion, [NullAllowed] Action<NSError> failure);

        // +(BOOL)isBrandReady:(NSString * _Nonnull)brandID __attribute__((warn_unused_result));
        [Static]
        [Export("isBrandReady:")]
        bool IsBrandReady(string brandID);

        // +(BOOL)isUrgent:(id<ConversationParamProtocol> _Nonnull)conversationQuery __attribute__((warn_unused_result));
        [Static]
        [Export("isUrgent:")]
        bool IsUrgent(ConversationParamProtocol conversationQuery);

        // +(BOOL)checkActiveConversation:(id<ConversationParamProtocol> _Nonnull)conversationQuery __attribute__((warn_unused_result));
        [Static]
        [Export("checkActiveConversation:")]
        bool CheckActiveConversation(ConversationParamProtocol conversationQuery);

        // +(BOOL)didFetchHistoryMessagingEventNotifications __attribute__((warn_unused_result));
        [Static]
        [Export("didFetchHistoryMessagingEventNotifications")]

        bool DidFetchHistoryMessagingEventNotifications { get; }

        // +(BOOL)isFetchingHistoryMessages __attribute__((warn_unused_result));
        [Static]
        [Export("isFetchingHistoryMessages")]

        bool IsFetchingHistoryMessages { get; }

        // +(NSString * _Nullable)agentNameUIRepresentation:(LPConversationEntity * _Nullable)conversation __attribute__((warn_unused_result));
        [Static]
        [Export("agentNameUIRepresentation:")]
        [return: NullAllowed]
        string AgentNameUIRepresentation([NullAllowed] LPConversationEntity conversation);

        // +(LPMessageEntity * _Nullable)createResolveLocalMessage:(LPConversationEntity * _Nonnull)conversation endTime:(NSDate * _Nonnull)endTime __attribute__((warn_unused_result));
        [Static]
        [Export("createResolveLocalMessage:endTime:")]
        [return: NullAllowed]
        LPMessageEntity CreateResolveLocalMessage(LPConversationEntity conversation, NSDate endTime);

        // +(LPMessageEntity * _Nullable)createMessageMaskedLocalMessage:(LPConversationEntity * _Nonnull)conversation isRealTimeMasking:(BOOL)isRealTimeMasking __attribute__((warn_unused_result));
        [Static]
        [Export("createMessageMaskedLocalMessage:isRealTimeMasking:")]
        [return: NullAllowed]
        LPMessageEntity CreateMessageMaskedLocalMessage(LPConversationEntity conversation, bool isRealTimeMasking);

        // +(LPMessageEntity * _Nullable)createWelcomeLocalMessage:(LPConversationEntity * _Nonnull)conversation __attribute__((warn_unused_result));
        [Static]
        [Export("createWelcomeLocalMessage:")]
        [return: NullAllowed]
        LPMessageEntity CreateWelcomeLocalMessage(LPConversationEntity conversation);

        // +(NSString * _Nonnull)clientPropertiesString __attribute__((warn_unused_result));
        [Static]
        [Export("clientPropertiesString")]

        string ClientPropertiesString { get; }

        // +(void)uploadFileFromImageInfoWithImageInfo:(NSDictionary<NSString *,id> * _Nonnull)imageInfo caption:(NSString * _Nonnull)caption conversation:(LPConversationEntity * _Null_unspecified)conversation completion:(void (^ _Nonnull)(void))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("uploadFileFromImageInfoWithImageInfo:caption:conversation:completion:failure:")]
        void UploadFileFromImageInfoWithImageInfo(NSDictionary<NSString, NSObject> imageInfo, string caption, LPConversationEntity conversation, Action completion, Action<NSError> failure);

        // +(void)uploadFileFromDiskWithMessage:(LPMessageEntity * _Nonnull)message conversation:(LPConversationEntity * _Nonnull)conversation completion:(void (^ _Nonnull)(void))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("uploadFileFromDiskWithMessage:conversation:completion:failure:")]
        void UploadFileFromDiskWithMessage(LPMessageEntity message, LPConversationEntity conversation, Action completion, Action<NSError> failure);

        // +(void)downloadFileWithConversation:(LPConversationEntity * _Nonnull)conversation file:(LPFileEntity * _Nonnull)file completion:(void (^ _Nonnull)(UIImage * _Nonnull))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("downloadFileWithConversation:file:completion:failure:")]
        void DownloadFileWithConversation(LPConversationEntity conversation, LPFileEntity file, Action<UIImage> completion, Action<NSError> failure);

        // +(void)requestUploadURLWithConversation:(LPConversationEntity * _Nonnull)conversation fileSize:(double)fileSize fileExtention:(NSString * _Nonnull)fileExtention completion:(void (^ _Nonnull)(RequestSwiftURL * _Nonnull))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("requestUploadURLWithConversation:fileSize:fileExtention:completion:failure:")]
        void RequestUploadURLWithConversation(LPConversationEntity conversation, double fileSize, string fileExtention, Action<RequestSwiftURL> completion, Action<NSError> failure);

        // +(void)requestDownloadURLWithConversation:(LPConversationEntity * _Nonnull)conversation file:(LPFileEntity * _Nonnull)file completion:(void (^ _Nonnull)(RequestSwiftURL * _Nonnull))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("requestDownloadURLWithConversation:file:completion:failure:")]
        void RequestDownloadURLWithConversation(LPConversationEntity conversation, LPFileEntity file, Action<RequestSwiftURL> completion, Action<NSError> failure);

        // +(NSURL * _Nullable)linkPreviewUrlFrom:(NSString * _Nonnull)messageContent __attribute__((warn_unused_result));
        [Static]
        [Export("linkPreviewUrlFrom:")]
        [return: NullAllowed]
        NSUrl LinkPreviewUrlFrom(string messageContent);

        // +(void)prepareSecureFormWithForm:(LPFormEntity * _Nonnull)form completion:(void (^ _Nonnull)(void))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("prepareSecureFormWithForm:completion:failure:")]
        void PrepareSecureFormWithForm(LPFormEntity form, Action completion, Action<NSError> failure);

        // +(BOOL)hasSecureFormAlreadyLoadedInWebViewWithForm:(LPFormEntity * _Nonnull)form __attribute__((warn_unused_result));
        [Static]
        [Export("hasSecureFormAlreadyLoadedInWebViewWithForm:")]
        bool HasSecureFormAlreadyLoadedInWebViewWithForm(LPFormEntity form);

        // +(WKWebView * _Nullable)getPreparedSecureFormWebViewWithForm:(LPFormEntity * _Nonnull)form __attribute__((warn_unused_result));
        [Static]
        [Export("getPreparedSecureFormWebViewWithForm:")]
        [return: NullAllowed]
        WKWebView GetPreparedSecureFormWebViewWithForm(LPFormEntity form);

        // +(void)acceptRing:(Ring * _Nonnull)ring agentToken:(NSString * _Nonnull)agentToken completion:(void (^ _Nonnull)(LPConversationEntity * _Nonnull))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("acceptRing:agentToken:completion:failure:")]
        void AcceptRing(Ring ring, string agentToken, Action<LPConversationEntity> completion, Action<NSError> failure);

        // +(void)backToQueue:(NSString * _Nonnull)userID conversation:(LPConversationEntity * _Nonnull)conversation completion:(void (^ _Nonnull)(void))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("backToQueue:conversation:completion:failure:")]
        void BackToQueue(string userID, LPConversationEntity conversation, Action completion, Action<NSError> failure);

        // +(void)subscribeAgentState:(id<ConversationParamProtocol> _Nonnull)conversationQuery agentID:(NSString * _Nonnull)agentID;
        [Static]
        [Export("subscribeAgentState:agentID:")]
        void SubscribeAgentState(ConversationParamProtocol conversationQuery, string agentID);

        // +(void)setAgentState:(id<ConversationParamProtocol> _Nonnull)conversationQuery agentID:(NSString * _Nonnull)agentID channels:(NSArray<NSString *> * _Nullable)channels availability:(NSString * _Nonnull)availability description:(NSString * _Nonnull)description;
        [Static]
        [Export("setAgentState:agentID:channels:availability:description:")]
        void SetAgentState(ConversationParamProtocol conversationQuery, string agentID, [NullAllowed] string[] channels, string availability, string description);

        // +(void)agentRequestConversation:(id<ConversationParamProtocol> _Nonnull)conversationQuery context:(NSDictionary<NSString *,NSString *> * _Nonnull)context ttrDefName:(NSString * _Nonnull)ttrDefName channelType:(NSString * _Nonnull)channelType consumerId:(NSString * _Nonnull)consumerId completion:(void (^ _Nonnull)(void))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("agentRequestConversation:context:ttrDefName:channelType:consumerId:completion:failure:")]
        void AgentRequestConversation(ConversationParamProtocol conversationQuery, NSDictionary<NSString, NSString> context, string ttrDefName, string channelType, string consumerId, Action completion, Action<NSError> failure);

        // +(NSArray<LPMessageEntity *> * _Nullable)getLoadingStructuredContentMessages __attribute__((warn_unused_result));
        [Static]
        [NullAllowed, Export("getLoadingStructuredContentMessages")]

        LPMessageEntity[] LoadingStructuredContentMessages { get; }

        // +(NSArray<LPMessageEntity *> * _Nullable)getLatestUnreadMessages __attribute__((warn_unused_result));
        [Static]
        [NullAllowed, Export("getLatestUnreadMessages")]

        LPMessageEntity[] LatestUnreadMessages { get; }

        // +(NSArray<LPLinkPreviewEntity *> * _Nullable)getLoadingStructuredContentCustomItems __attribute__((warn_unused_result));
        [Static]
        [NullAllowed, Export("getLoadingStructuredContentCustomItems")]

        LPLinkPreviewEntity[] LoadingStructuredContentCustomItems { get; }

        // +(BOOL)hasActiveController:(NSString * _Nonnull)brandID __attribute__((warn_unused_result));
        [Static]
        [Export("hasActiveController:")]
        bool HasActiveController(string brandID);

        // +(NSArray<NSString *> * _Nonnull)getAllConsumersID __attribute__((warn_unused_result));
        [Static]
        [Export("getAllConsumersID")]

        string[] AllConsumersID { get; }

        // +(void)clearManagers;
        [Static]
        [Export("clearManagers")]
        void ClearManagers();
    }

    // @protocol LPAMSFacadeDelegate
    //[BaseType(typeof(LPAMSFacadeDelegate))]
    [Protocol, Model]
    interface LPAMSFacadeDelegate
    {
        // @optional -(void)conversationDidResolve:(LPConversationEntity * _Nonnull)conversation isAgentSide:(BOOL)isAgentSide endTime:(NSDate * _Nullable)endTime;
        [Export("conversationDidResolve:isAgentSide:endTime:")]
        void ConversationDidResolve(LPConversationEntity conversation, bool isAgentSide, [NullAllowed] NSDate endTime);

        // @optional -(void)conversationWasSentToQueueRemotely:(LPConversationEntity * _Nonnull)conversation;
        [Export("conversationWasSentToQueueRemotely:")]
        void ConversationWasSentToQueueRemotely(LPConversationEntity conversation);

        // @optional -(void)retrieveHistoryMessagingEventNotificationsDidProgressWithConversationQuery:(id<ConversationParamProtocol> _Nonnull)conversationQuery completed:(NSInteger)completed total:(NSInteger)total;
        [Export("retrieveHistoryMessagingEventNotificationsDidProgressWithConversationQuery:completed:total:")]
        void RetrieveHistoryMessagingEventNotificationsDidProgressWithConversationQuery(ConversationParamProtocol conversationQuery, nint completed, nint total);

        // @optional -(void)retrieveHistoryEngagementHistoryDidProgressWithConversationQuery:(id<ConversationParamProtocol> _Nonnull)conversationQuery completed:(NSInteger)completed total:(NSInteger)total;
        [Export("retrieveHistoryEngagementHistoryDidProgressWithConversationQuery:completed:total:")]
        void RetrieveHistoryEngagementHistoryDidProgressWithConversationQuery(ConversationParamProtocol conversationQuery, nint completed, nint total);

        // @optional -(void)retrieveHistoryMessagingEventNotificationStateDidChangeWithConversationQuery:(id<ConversationParamProtocol> _Nonnull)conversationQuery isFinished:(BOOL)isFinished fetchedConversationCount:(NSInteger)fetchedConversationCount fetchedMessages:(NSArray<LPMessageEntity *> * _Nullable)fetchedMessages increaseNumberOfPresentedConversationsBy:(NSInteger)increaseNumberOfPresentedConversationsBy;
        [Export("retrieveHistoryMessagingEventNotificationStateDidChangeWithConversationQuery:isFinished:fetchedConversationCount:fetchedMessages:increaseNumberOfPresentedConversationsBy:")]
        void RetrieveHistoryMessagingEventNotificationStateDidChangeWithConversationQuery(ConversationParamProtocol conversationQuery, bool isFinished, nint fetchedConversationCount, [NullAllowed] LPMessageEntity[] fetchedMessages, nint increaseNumberOfPresentedConversationsBy);

        // @optional -(void)didSendMessages:(LPConversationEntity * _Nonnull)conversation messages:(NSArray<LPMessageEntity *> * _Nonnull)messages;
        [Export("didSendMessages:messages:")]
        void DidSendMessages(LPConversationEntity conversation, LPMessageEntity[] messages);

        // @optional -(void)willReceiveMessages;
        [Export("willReceiveMessages")]
        void WillReceiveMessages();

        // @optional -(void)didReceiveMessages:(LPConversationEntity * _Nonnull)conversation messages:(NSArray<LPMessageEntity *> * _Nonnull)messages;
        [Export("didReceiveMessages:messages:")]
        void DidReceiveMessages(LPConversationEntity conversation, LPMessageEntity[] messages);

        // @optional -(void)resolveConvesationDidFail:(LPConversationEntity * _Nonnull)conversation error:(NSError * _Nonnull)error;
        [Export("resolveConvesationDidFail:error:")]
        void ResolveConvesationDidFail(LPConversationEntity conversation, NSError error);

        // @optional -(void)resolveConvesationRequestDidFinish:(LPConversationEntity * _Nonnull)conversation;
        [Export("resolveConvesationRequestDidFinish:")]
        void ResolveConvesationRequestDidFinish(LPConversationEntity conversation);

        // @optional -(void)newConversationCreated:(LPConversationEntity * _Nonnull)conversation;
        [Export("newConversationCreated:")]
        void NewConversationCreated(LPConversationEntity conversation);

        // @optional -(void)urgentRequestDidFinish:(LPConversationEntity * _Nonnull)conversation;
        [Export("urgentRequestDidFinish:")]
        void UrgentRequestDidFinish(LPConversationEntity conversation);

        // @optional -(void)urgentRequestDidFail:(LPConversationEntity * _Nonnull)conversation error:(NSError * _Nonnull)error;
        [Export("urgentRequestDidFail:error:")]
        void UrgentRequestDidFail(LPConversationEntity conversation, NSError error);

        // @optional -(void)chatStateDidChange:(LPConversationEntity * _Nonnull)conversation state:(NSString * _Nonnull)state userID:(NSString * _Nonnull)userID;
        [Export("chatStateDidChange:state:userID:")]
        void ChatStateDidChange(LPConversationEntity conversation, string state, string userID);

        // @optional -(void)messagesStatusDidChange:(LPConversationEntity * _Nonnull)conversation messages:(NSArray<LPMessageEntity *> * _Nonnull)messages;
        [Export("messagesStatusDidChange:messages:")]
        void MessagesStatusDidChange(LPConversationEntity conversation, LPMessageEntity[] messages);

        // @optional -(void)conversationInitializedOnAMS:(LPConversationEntity * _Nonnull)conversation;
        [Export("conversationInitializedOnAMS:")]
        void ConversationInitializedOnAMS(LPConversationEntity conversation);

        // @optional -(void)didReceiveTTRUpdate:(LPConversationEntity * _Nonnull)conversation ttr:(TTRModel * _Nonnull)ttr;
        [Export("didReceiveTTRUpdate:ttr:")]
        void DidReceiveTTRUpdate(LPConversationEntity conversation, TTRModel ttr);

        // @optional -(void)didUpdateUserProfile:(LPConversationEntity * _Nonnull)conversation userID:(NSString * _Nonnull)userID;
        [Export("didUpdateUserProfile:userID:")]
        void DidUpdateUserProfile(LPConversationEntity conversation, string userID);

        // @optional -(void)csatScoreSubmissionDidFinish:(LPConversationEntity * _Nonnull)conversation csat:(CSATModel * _Nonnull)csat;
        [Export("csatScoreSubmissionDidFinish:csat:")]
        void CsatScoreSubmissionDidFinish(LPConversationEntity conversation, CSATModel csat);

        // @optional -(void)csatScoreSubmissionDidFail:(LPConversationEntity * _Nonnull)conversation error:(NSError * _Nonnull)error;
        [Export("csatScoreSubmissionDidFail:error:")]
        void CsatScoreSubmissionDidFail(LPConversationEntity conversation, NSError error);

        // @optional -(BOOL)isConversationViewControllerPresentedWithForceTopConversation:(BOOL)forceTopConversation __attribute__((warn_unused_result));
        [Export("isConversationViewControllerPresentedWithForceTopConversation:")]
        bool IsConversationViewControllerPresentedWithForceTopConversation(bool forceTopConversation);

        // @optional -(NSString * _Nullable)brandAccountID __attribute__((warn_unused_result));
        [NullAllowed, Export("brandAccountID")]

        string BrandAccountID { get; }

        // @optional -(void)sdkFeatureToggledWithFeature:(enum LPMessagingSDKFeature)feature toggle:(BOOL)toggle;
        [Export("sdkFeatureToggledWithFeature:toggle:")]
        void SdkFeatureToggledWithFeature(LPMessagingSDKFeature feature, bool toggle);

        // @optional -(id<ConversationParamProtocol> _Nullable)getCurrentConversationQuery __attribute__((warn_unused_result));
        [NullAllowed, Export("getCurrentConversationQuery")]

        ConversationParamProtocol CurrentConversationQuery { get; }

        // @optional -(void)historyCleared;
        [Export("historyCleared")]
        void HistoryCleared();

        // @optional -(void)didReceiveRingUpdate:(NSString * _Nonnull)conversationID ring:(Ring * _Nonnull)ring;
        [Export("didReceiveRingUpdate:ring:")]
        void DidReceiveRingUpdate(string conversationID, Ring ring);

        // @optional -(void)didAcceptRingWithConversation:(LPConversationEntity * _Nonnull)conversation connection:(LPConnection * _Nonnull)connection;
        [Export("didAcceptRingWithConversation:connection:")]
        void DidAcceptRingWithConversation(LPConversationEntity conversation, LPConnection connection);

        // @optional -(void)agentStateDidChange:(LPUserEntity * _Nonnull)agent state:(NSString * _Nonnull)state;
        [Export("agentStateDidChange:state:")]
        void AgentStateDidChange(LPUserEntity agent, string state);
    }



    // @protocol ConversationViewControllerAgentDelegate
    [Protocol, Model]
    interface ConversationViewControllerAgentDelegate
    {
        // @optional -(void)agentDidChangeUserInputText:(NSString * _Nonnull)text;
        [Export("agentDidChangeUserInputText:")]
        void AgentDidChangeUserInputText(string text);

        // @optional -(void)setUIAdapterDelegate:(id<UIAdapterDelegate> _Nonnull)delegate;
        [Export("setUIAdapterDelegate:")]
        void SetUIAdapterDelegate(UIAdapterDelegate @delegate);
    }

    // @interface LPMessagingAPI : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface LPMessagingAPI
    {
        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        LPMessagingAPI New();

        // +(BOOL)initializeAPI __attribute__((warn_unused_result));
        [Static]
        [Export("initializeAPI")]

        bool InitializeAPI { get; }

        // +(void)setDelegate:(id<LPMessagingAPIDelegate> _Nonnull)delegate;
        [Static]
        [Export("setDelegate:")]
        void SetDelegate(LPMessagingAPIDelegate @delegate);

        // +(void)removeDelegate:(id<LPMessagingAPIDelegate> _Nonnull)delegate;
        [Static]
        [Export("removeDelegate:")]
        void RemoveDelegate(LPMessagingAPIDelegate @delegate);

        // +(void)setUserProfileWithDetails:(LPUser * _Nonnull)lpuser brandID:(NSString * _Nonnull)brandID;
        [Static]
        [Export("setUserProfileWithDetails:brandID:")]
        void SetUserProfileWithDetails(LPUser lpuser, string brandID);

        // +(void)registerPushNotificationsWithToken:(NSData * _Nonnull)token notificationDelegate:(id<LPMessagingSDKNotificationDelegate> _Nullable)notificationDelegate alternateBundleID:(NSString * _Nullable)alternateBundleID;
        [Static]
        [Export("registerPushNotificationsWithToken:notificationDelegate:alternateBundleID:")]
        void RegisterPushNotificationsWithToken(NSData token, [NullAllowed] LPMessagingSDKNotificationDelegate notificationDelegate, [NullAllowed] string alternateBundleID);

        // +(id<ConversationParamProtocol> _Nonnull)getConversationBrandQuery:(NSString * _Nonnull)brandID campaignInfo:(LPCampaignInfo * _Nullable)campaignInfo __attribute__((warn_unused_result));
        [Static]
        [Export("getConversationBrandQuery:campaignInfo:")]
        ConversationParamProtocol GetConversationBrandQuery(string brandID, [NullAllowed] LPCampaignInfo campaignInfo);

        // +(id<ConversationParamProtocol> _Nonnull)getConversationConsumerQuery:(NSString * _Nullable)consumerID brandID:(NSString * _Nonnull)brandID agentToken:(NSString * _Nonnull)agentToken __attribute__((warn_unused_result));
        [Static]
        [Export("getConversationConsumerQuery:brandID:agentToken:")]
        ConversationParamProtocol GetConversationConsumerQuery([NullAllowed] string consumerID, string brandID, string agentToken);

        // +(BOOL)checkActiveConversation:(id<ConversationParamProtocol> _Nonnull)conversationQuery __attribute__((warn_unused_result));
        [Static]
        [Export("checkActiveConversation:")]
        bool CheckActiveConversation(ConversationParamProtocol conversationQuery);

        // +(BOOL)isUrgent:(id<ConversationParamProtocol> _Nonnull)conversationQuery __attribute__((warn_unused_result));
        [Static]
        [Export("isUrgent:")]
        bool IsUrgent(ConversationParamProtocol conversationQuery);

        // +(void)changeUrgentState:(id<ConversationParamProtocol> _Nonnull)conversationQuery isUrgent:(BOOL)isUrgent;
        [Static]
        [Export("changeUrgentState:isUrgent:")]
        void ChangeUrgentState(ConversationParamProtocol conversationQuery, bool isUrgent);

        // +(void)resolveConversationForConversationQuery:(id<ConversationParamProtocol> _Nonnull)conversationQuery;
        [Static]
        [Export("resolveConversationForConversationQuery:")]
        void ResolveConversationForConversationQuery(ConversationParamProtocol conversationQuery);

        // +(LPUser * _Nullable)getAssignedAgent:(id<ConversationParamProtocol> _Nonnull)conversationQuery __attribute__((warn_unused_result));
        [Static]
        [Export("getAssignedAgent:")]
        [return: NullAllowed]
        LPUser GetAssignedAgent(ConversationParamProtocol conversationQuery);

        // +(BOOL)isBrandReady:(NSString * _Nonnull)brandID __attribute__((warn_unused_result));
        [Static]
        [Export("isBrandReady:")]
        bool IsBrandReady(string brandID);

        // +(NSString * _Nullable)getSDKVersion __attribute__((warn_unused_result));
        [Static]
        [NullAllowed, Export("getSDKVersion")]

        string SDKVersion { get; }

        // +(void)resetConversationScreenSavedScrollPosition;
        [Static]
        [Export("resetConversationScreenSavedScrollPosition")]
        void ResetConversationScreenSavedScrollPosition();

        // +(NSTimeInterval)getInactiveUserInteractionTimeInterval:(id<ConversationParamProtocol> _Nonnull)conversationQuery __attribute__((warn_unused_result));
        [Static]
        [Export("getInactiveUserInteractionTimeInterval:")]
        double GetInactiveUserInteractionTimeInterval(ConversationParamProtocol conversationQuery);

        // +(void)connectToSocket:(id<ConversationParamProtocol> _Nonnull)conversationQuery readyCompletion:(void (^ _Nullable)(void))readyCompletion;
        [Static]
        [Export("connectToSocket:readyCompletion:")]
        void ConnectToSocket(ConversationParamProtocol conversationQuery, [NullAllowed] Action readyCompletion);

        // +(void)reconnectToSocket:(id<ConversationParamProtocol> _Nonnull)conversationQuery authenticationParams:(LPAuthenticationParams * _Nonnull)authenticationParams readyCompletion:(void (^ _Nullable)(void))readyCompletion;
        [Static]
        [Export("reconnectToSocket:authenticationParams:readyCompletion:")]
        void ReconnectToSocket(ConversationParamProtocol conversationQuery, LPAuthenticationParams authenticationParams, [NullAllowed] Action readyCompletion);

        // +(void)disconnectSocket:(id<ConversationParamProtocol> _Nonnull)conversationQuery;
        [Static]
        [Export("disconnectSocket:")]
        void DisconnectSocket(ConversationParamProtocol conversationQuery);

        // +(BOOL)clearHistory:(id<ConversationParamProtocol> _Nonnull)conversationQuery __attribute__((warn_unused_result));
        [Static]
        [Export("clearHistory:")]
        bool ClearHistory(ConversationParamProtocol conversationQuery);

        // +(void)deleteOldConversations;
        [Static]
        [Export("deleteOldConversations")]
        void DeleteOldConversations();

        // +(LPConversationEntity * _Nonnull)createConversation:(LPBrandEntity * _Nonnull)brand __attribute__((warn_unused_result));
        [Static]
        [Export("createConversation:")]
        LPConversationEntity CreateConversation(LPBrandEntity brand);

        // +(void)sendMessageInConversation:(LPConversationEntity * _Nonnull)conversation message:(LPMessageEntity * _Nonnull)message completion:(void (^ _Nonnull)(LPMessageEntity * _Nonnull))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("sendMessageInConversation:message:completion:failure:")]
        void SendMessageInConversation(LPConversationEntity conversation, LPMessageEntity message, Action<LPMessageEntity> completion, Action<NSError> failure);

        // +(void)sendMessageInConversation:(LPConversationEntity * _Nonnull)conversation text:(NSString * _Nonnull)text completion:(void (^ _Nonnull)(LPMessageEntity * _Nonnull))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("sendMessageInConversation:text:completion:failure:")]
        void SendMessageInConversation(LPConversationEntity conversation, string text, Action<LPMessageEntity> completion, Action<NSError> failure);

        // +(void)resolveConversation:(LPConversationEntity * _Nonnull)conversation;
        [Static]
        [Export("resolveConversation:")]
        void ResolveConversation(LPConversationEntity conversation);

        // +(BOOL)requestUrgentResponse:(LPConversationEntity * _Nonnull)conversation urgent:(BOOL)urgent __attribute__((warn_unused_result));
        [Static]
        [Export("requestUrgentResponse:urgent:")]
        bool RequestUrgentResponse(LPConversationEntity conversation, bool urgent);

        // +(void)retrieveNewMessagesForConversation:(LPConversationEntity * _Nonnull)conversation completion:(void (^ _Nullable)(NSArray<LPMessageEntity *> * _Nonnull))completion failure:(void (^ _Nullable)(NSError * _Nonnull))failure;
        [Static]
        [Export("retrieveNewMessagesForConversation:completion:failure:")]
        void RetrieveNewMessagesForConversation(LPConversationEntity conversation, [NullAllowed] Action<NSArray> completion, [NullAllowed] Action<NSError> failure);

        // +(void)sendCSAT:(LPConversationEntity * _Nonnull)conversation csat:(CSATModel * _Nonnull)csat;
        [Static]
        [Export("sendCSAT:csat:")]
        void SendCSAT(LPConversationEntity conversation, CSATModel csat);

        // +(void)subscribeConversationNotifications:(NSString * _Nonnull)brandID userID:(NSString * _Nonnull)userID socketType:(enum SocketType)socketType completion:(void (^ _Nullable)(NSString * _Nonnull))completion failure:(void (^ _Nullable)(NSError * _Nonnull))failure;
        [Static]
        [Export("subscribeConversationNotifications:userID:socketType:completion:failure:")]
        void SubscribeConversationNotifications(string brandID, string userID, SocketType socketType, [NullAllowed] Action<NSString> completion, [NullAllowed] Action<NSError> failure);

        // +(void)unsubscribeConversationNotifications:(NSString * _Nonnull)brandID subscriptionID:(NSString * _Nonnull)subscriptionID;
        [Static]
        [Export("unsubscribeConversationNotifications:subscriptionID:")]
        void UnsubscribeConversationNotifications(string brandID, string subscriptionID);

        // +(void)subscribeRoutingTasks:(NSString * _Nonnull)brandID agentID:(NSString * _Nonnull)agentID completion:(void (^ _Nullable)(NSString * _Nonnull))completion failure:(void (^ _Nullable)(NSError * _Nonnull))failure;
        [Static]
        [Export("subscribeRoutingTasks:agentID:completion:failure:")]
        void SubscribeRoutingTasks(string brandID, string agentID, [NullAllowed] Action<NSString> completion, [NullAllowed] Action<NSError> failure);

        // +(BOOL)didFetchHistoryMessagingEventNotifications __attribute__((warn_unused_result));
        [Static]
        [Export("didFetchHistoryMessagingEventNotifications")]

        bool DidFetchHistoryMessagingEventNotifications { get; }

        // +(BOOL)isFetchingHistoryMessages __attribute__((warn_unused_result));
        [Static]
        [Export("isFetchingHistoryMessages")]

        bool IsFetchingHistoryMessages { get; }

        // +(NSString * _Nullable)agentNameUIRepresentation:(LPConversationEntity * _Nullable)conversation __attribute__((warn_unused_result));
        [Static]
        [Export("agentNameUIRepresentation:")]
        [return: NullAllowed]
        string AgentNameUIRepresentation([NullAllowed] LPConversationEntity conversation);

        // +(LPMessageEntity * _Nullable)createResolveLocalMessage:(LPConversationEntity * _Nonnull)conversation endTime:(NSDate * _Nonnull)endTime __attribute__((warn_unused_result));
        [Static]
        [Export("createResolveLocalMessage:endTime:")]
        [return: NullAllowed]
        LPMessageEntity CreateResolveLocalMessage(LPConversationEntity conversation, NSDate endTime);

        // +(LPMessageEntity * _Nullable)createMessageMaskedLocalMessage:(LPConversationEntity * _Nonnull)conversation isRealTimeMasking:(BOOL)isRealTimeMasking __attribute__((warn_unused_result));
        [Static]
        [Export("createMessageMaskedLocalMessage:isRealTimeMasking:")]
        [return: NullAllowed]
        LPMessageEntity CreateMessageMaskedLocalMessage(LPConversationEntity conversation, bool isRealTimeMasking);

        // +(LPMessageEntity * _Nullable)createWelcomeLocalMessage:(LPConversationEntity * _Nonnull)conversation __attribute__((warn_unused_result));
        [Static]
        [Export("createWelcomeLocalMessage:")]
        [return: NullAllowed]
        LPMessageEntity CreateWelcomeLocalMessage(LPConversationEntity conversation);

        // +(void)uploadFileFromImageInfoWithImageInfo:(NSDictionary<NSString *,id> * _Nonnull)imageInfo caption:(NSString * _Nonnull)caption conversation:(LPConversationEntity * _Null_unspecified)conversation completion:(void (^ _Nonnull)(void))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("uploadFileFromImageInfoWithImageInfo:caption:conversation:completion:failure:")]
        void UploadFileFromImageInfoWithImageInfo(NSDictionary<NSString, NSObject> imageInfo, string caption, LPConversationEntity conversation, Action completion, Action<NSError> failure);

        // +(void)uploadFileFromDiskWithMessage:(LPMessageEntity * _Nonnull)message conversation:(LPConversationEntity * _Nonnull)conversation completion:(void (^ _Nonnull)(void))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("uploadFileFromDiskWithMessage:conversation:completion:failure:")]
        void UploadFileFromDiskWithMessage(LPMessageEntity message, LPConversationEntity conversation, Action completion, Action<NSError> failure);

        // +(void)downloadFileWithConversation:(LPConversationEntity * _Nonnull)conversation file:(LPFileEntity * _Nonnull)file completion:(void (^ _Nonnull)(UIImage * _Nonnull))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("downloadFileWithConversation:file:completion:failure:")]
        void DownloadFileWithConversation(LPConversationEntity conversation, LPFileEntity file, Action<UIImage> completion, Action<NSError> failure);

        // +(void)requestUploadURLWithConversation:(LPConversationEntity * _Nonnull)conversation fileSize:(double)fileSize fileExtention:(NSString * _Nonnull)fileExtention completion:(void (^ _Nonnull)(RequestSwiftURL * _Nonnull))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("requestUploadURLWithConversation:fileSize:fileExtention:completion:failure:")]
        void RequestUploadURLWithConversation(LPConversationEntity conversation, double fileSize, string fileExtention, Action<RequestSwiftURL> completion, Action<NSError> failure);

        // +(void)requestDownloadURLWithConversation:(LPConversationEntity * _Nonnull)conversation file:(LPFileEntity * _Nonnull)file completion:(void (^ _Nonnull)(RequestSwiftURL * _Nonnull))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("requestDownloadURLWithConversation:file:completion:failure:")]
        void RequestDownloadURLWithConversation(LPConversationEntity conversation, LPFileEntity file, Action<RequestSwiftURL> completion, Action<NSError> failure);

        // +(void)clearManagers;
        [Static]
        [Export("clearManagers")]
        void ClearManagers();

        // +(void)acceptRing:(Ring * _Nonnull)ring agentToken:(NSString * _Nonnull)agentToken completion:(void (^ _Nonnull)(LPConversationEntity * _Nonnull))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("acceptRing:agentToken:completion:failure:")]
        void AcceptRing(Ring ring, string agentToken, Action<LPConversationEntity> completion, Action<NSError> failure);

        // +(void)backToQueue:(NSString * _Nonnull)userID conversation:(LPConversationEntity * _Nonnull)conversation completion:(void (^ _Nonnull)(void))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("backToQueue:conversation:completion:failure:")]
        void BackToQueue(string userID, LPConversationEntity conversation, Action completion, Action<NSError> failure);

        // +(void)subscribeAgentState:(id<ConversationParamProtocol> _Nonnull)conversationQuery agentID:(NSString * _Nonnull)agentID;
        [Static]
        [Export("subscribeAgentState:agentID:")]
        void SubscribeAgentState(ConversationParamProtocol conversationQuery, string agentID);

        // +(void)setAgentState:(id<ConversationParamProtocol> _Nonnull)conversationQuery agentID:(NSString * _Nonnull)agentID channels:(NSArray<NSString *> * _Nullable)channels availability:(NSString * _Nonnull)availability description:(NSString * _Nonnull)description;
        [Static]
        [Export("setAgentState:agentID:channels:availability:description:")]
        void SetAgentState(ConversationParamProtocol conversationQuery, string agentID, [NullAllowed] string[] channels, string availability, string description);

        // +(void)agentRequestConversation:(id<ConversationParamProtocol> _Nonnull)conversationQuery context:(NSDictionary<NSString *,NSString *> * _Nonnull)context ttrDefName:(NSString * _Nonnull)ttrDefName channelType:(NSString * _Nonnull)channelType consumerId:(NSString * _Nonnull)consumerId completion:(void (^ _Nonnull)(void))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("agentRequestConversation:context:ttrDefName:channelType:consumerId:completion:failure:")]
        void AgentRequestConversation(ConversationParamProtocol conversationQuery, NSDictionary<NSString, NSString> context, string ttrDefName, string channelType, string consumerId, Action completion, Action<NSError> failure);

        // +(NSArray<NSString *> * _Nonnull)getAllConsumersID __attribute__((warn_unused_result));
        [Static]
        [Export("getAllConsumersID")]

        string[] AllConsumersID { get; }

        // +(void)prepareSecureFormWithForm:(LPFormEntity * _Nonnull)form completion:(void (^ _Nonnull)(void))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("prepareSecureFormWithForm:completion:failure:")]
        void PrepareSecureFormWithForm(LPFormEntity form, Action completion, Action<NSError> failure);

        // +(NSArray<LPMessageEntity *> * _Nullable)getLoadingStructuredContentMessages __attribute__((warn_unused_result));
        [Static]
        [NullAllowed, Export("getLoadingStructuredContentMessages")]

        LPMessageEntity[] LoadingStructuredContentMessages { get; }

        // +(NSArray<LPLinkPreviewEntity *> * _Nullable)getLoadingStructuredContentCustomItems __attribute__((warn_unused_result));
        [Static]
        [NullAllowed, Export("getLoadingStructuredContentCustomItems")]

        LPLinkPreviewEntity[] LoadingStructuredContentCustomItems { get; }

        // +(BOOL)hasActiveController:(NSString * _Nonnull)brandID __attribute__((warn_unused_result));
        [Static]
        [Export("hasActiveController:")]
        bool HasActiveController(string brandID);

        // +(LPWebSocket * _Nullable)getSocket:(NSString * _Nonnull)brandID __attribute__((warn_unused_result));
        [Static]
        [Export("getSocket:")]
        [return: NullAllowed]
        LPWebSocket GetSocket(string brandID);

        // +(void)openAllSockets;
        [Static]
        [Export("openAllSockets")]
        void OpenAllSockets();

        // +(void)openSocket:(LPWebSocket * _Nonnull)webSocket;
        [Static]
        [Export("openSocket:")]
        void OpenSocket(LPWebSocket webSocket);

        // +(void)closeAllSockets;
        [Static]
        [Export("closeAllSockets")]
        void CloseAllSockets();

        // +(void)uploadFileWithFile:(LPFileEntity * _Nonnull)file uploadRelativePath:(NSString * _Nonnull)uploadRelativePath tempURLSig:(NSString * _Nonnull)tempURLSig tempURLExpiry:(NSString * _Nonnull)tempURLExpiry completion:(void (^ _Nonnull)(LPFileEntity * _Nonnull))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("uploadFileWithFile:uploadRelativePath:tempURLSig:tempURLExpiry:completion:failure:")]
        void UploadFileWithFile(LPFileEntity file, string uploadRelativePath, string tempURLSig, string tempURLExpiry, Action<LPFileEntity> completion, Action<NSError> failure);

        // +(void)downloadFileWithFile:(LPFileEntity * _Nonnull)file relativePath:(NSString * _Nonnull)relativePath tempURLSig:(NSString * _Nonnull)tempURLSig tempURLExpiry:(NSString * _Nonnull)tempURLExpiry completion:(void (^ _Nonnull)(LPFileEntity * _Nonnull))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("downloadFileWithFile:relativePath:tempURLSig:tempURLExpiry:completion:failure:")]
        void DownloadFileWithFile(LPFileEntity file, string relativePath, string tempURLSig, string tempURLExpiry, Action<LPFileEntity> completion, Action<NSError> failure);

        // +(void)getPhotoFromFileWithFile:(LPFileEntity * _Nonnull)file completion:(void (^ _Nonnull)(UIImage * _Nullable))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("getPhotoFromFileWithFile:completion:failure:")]
        void GetPhotoFromFileWithFile(LPFileEntity file, Action<UIImage> completion, Action<NSError> failure);

        // +(UIImage * _Nullable)getThumbnailFromFileWithFile:(LPFileEntity * _Nonnull)file __attribute__((warn_unused_result));
        [Static]
        [Export("getThumbnailFromFileWithFile:")]
        [return: NullAllowed]
        UIImage GetThumbnailFromFileWithFile(LPFileEntity file);

        // +(void)getBase64ThumbnailStringWithFile:(LPFileEntity * _Nonnull)file completion:(void (^ _Nonnull)(NSString * _Nonnull))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("getBase64ThumbnailStringWithFile:completion:failure:")]
        void GetBase64ThumbnailStringWithFile(LPFileEntity file, Action<NSString> completion, Action<NSError> failure);

        // +(void)deleteFileFromDiskWithFile:(LPFileEntity * _Nonnull)file;
        [Static]
        [Export("deleteFileFromDiskWithFile:")]
        void DeleteFileFromDiskWithFile(LPFileEntity file);

        // +(void)deleteAllFilesFromDiskWithCompletion:(void (^ _Nonnull)(void))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("deleteAllFilesFromDiskWithCompletion:failure:")]
        void DeleteAllFilesFromDiskWithCompletion(Action completion, Action<NSError> failure);

        // +(void)handleMaxNumberOfSavedFilesOnDisk;
        [Static]
        [Export("handleMaxNumberOfSavedFilesOnDisk")]
        void HandleMaxNumberOfSavedFilesOnDisk();

        // +(LPBrandEntity * _Nonnull)getOrCreateBrandByAccountID:(NSString * _Nonnull)accountID __attribute__((warn_unused_result));
        [Static]
        [Export("getOrCreateBrandByAccountID:")]
        LPBrandEntity GetOrCreateBrandByAccountID(string accountID);

        // +(BOOL)clearConversationFromDB:(LPConversationEntity * _Nonnull)conversation __attribute__((warn_unused_result));
        [Static]
        [Export("clearConversationFromDB:")]
        bool ClearConversationFromDB(LPConversationEntity conversation);

        // +(NSArray<LPConversationEntity *> * _Nullable)getAllClosedConversations:(NSDate * _Nullable)olderThanDate __attribute__((warn_unused_result));
        [Static]
        [Export("getAllClosedConversations:")]
        [return: NullAllowed]
        LPConversationEntity[] GetAllClosedConversations([NullAllowed] NSDate olderThanDate);

        // +(NSArray<LPConversationEntity *> * _Nonnull)getConversationsSortedByDate:(id<ConversationParamProtocol> _Nonnull)query conversationHistoryControlParam:(LPConversationHistoryControlParam * _Nullable)conversationHistoryControlParam __attribute__((warn_unused_result));
        [Static]
        [Export("getConversationsSortedByDate:conversationHistoryControlParam:")]
        LPConversationEntity[] GetConversationsSortedByDate(ConversationParamProtocol query, [NullAllowed] LPConversationHistoryControlParam conversationHistoryControlParam);

        // +(void)attachMyUserCompletion:(void (^ _Nonnull)(NSString * _Nonnull))completion;
        [Static]
        [Export("attachMyUserCompletion:")]
        void AttachMyUserCompletion(Action<NSString> completion);

        // +(LPUserEntity * _Nullable)getUserFromDatabaseWithUserID:(NSString * _Nonnull)userID __attribute__((warn_unused_result));
        [Static]
        [Export("getUserFromDatabaseWithUserID:")]
        [return: NullAllowed]
        LPUserEntity GetUserFromDatabaseWithUserID(string userID);

        // +(void)refreshUserProfileWithBrandID:(NSString * _Nonnull)brandID user:(LPUserEntity * _Nonnull)user;
        [Static]
        [Export("refreshUserProfileWithBrandID:user:")]
        void RefreshUserProfileWithBrandID(string brandID, LPUserEntity user);

        // +(void)setPusherTokenWithToken:(NSData * _Nonnull)token alternateBundleID:(NSString * _Nullable)alternateBundleID;
        [Static]
        [Export("setPusherTokenWithToken:alternateBundleID:")]
        void SetPusherTokenWithToken(NSData token, [NullAllowed] string alternateBundleID);

        // +(void)setPusherVoipTokenWithToken:(NSData * _Nonnull)token alternateBundleID:(NSString * _Nullable)alternateBundleID;
        [Static]
        [Export("setPusherVoipTokenWithToken:alternateBundleID:")]
        void SetPusherVoipTokenWithToken(NSData token, [NullAllowed] string alternateBundleID);

        // +(void)registerPusher:(LPBrandEntity * _Nonnull)brand;
        [Static]
        [Export("registerPusher:")]
        void RegisterPusher(LPBrandEntity brand);

        // +(void)getUnreadMessagesCount:(id<ConversationParamProtocol> _Nonnull)conversationQuery completion:(void (^ _Nonnull)(NSInteger))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("getUnreadMessagesCount:completion:failure:")]
        void GetUnreadMessagesCount(ConversationParamProtocol conversationQuery, Action<nint> completion, Action<NSError> failure);

        // +(void)unregisterPusher:(LPBrandEntity * _Nonnull)brand completion:(void (^ _Nonnull)(void))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("unregisterPusher:completion:failure:")]
        void UnregisterPusher(LPBrandEntity brand, Action completion, Action<NSError> failure);

        // +(void)getCSDSDomain:(NSString * _Nonnull)accountID serviceName:(NSString * _Nonnull)serviceName completion:(void (^ _Nonnull)(NSString * _Nonnull))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("getCSDSDomain:serviceName:completion:failure:")]
        void GetCSDSDomain(string accountID, string serviceName, Action<NSString> completion, Action<NSError> failure);

        // +(void)loadImageFromURLWithImageUrl:(NSString * _Nullable)imageUrl completion:(void (^ _Nonnull)(UIImage * _Nullable, BOOL))completion failure:(void (^ _Nullable)(void))failure;
        [Static]
        [Export("loadImageFromURLWithImageUrl:completion:failure:")]
        void LoadImageFromURLWithImageUrl([NullAllowed] string imageUrl, Action<UIImage, bool> completion, [NullAllowed] Action failure);

        // +(void)setImageByURL:(UIImage * _Nonnull)image url:(NSString * _Nonnull)url;
        [Static]
        [Export("setImageByURL:url:")]
        void SetImageByURL(UIImage image, string url);

        // +(UIImage * _Nullable)getImageByURL:(NSString * _Nonnull)url __attribute__((warn_unused_result));
        [Static]
        [Export("getImageByURL:")]
        [return: NullAllowed]
        UIImage GetImageByURL(string url);

        // @property (readonly, nonatomic, class) BOOL isNetworkReachable;
        [Static]
        [Export("isNetworkReachable")]
        bool IsNetworkReachable { get; }

        // +(LPConversationEntity * _Nullable)getOpenConveration __attribute__((warn_unused_result));
        [Static]
        [NullAllowed, Export("getOpenConveration")]

        LPConversationEntity OpenConveration { get; }

        // +(NSArray<NSString *> * _Nullable)getConsumerIdsRelatedToMessagesThatContains:(NSString * _Nonnull)text __attribute__((warn_unused_result));
        [Static]
        [Export("getConsumerIdsRelatedToMessagesThatContains:")]
        [return: NullAllowed]
        string[] GetConsumerIdsRelatedToMessagesThatContains(string text);
    }

    // @protocol LPMessagingAPIDelegate <LPAMSFacadeDelegate>

    [Protocol, Model]
    interface LPMessagingAPIDelegate : LPAMSFacadeDelegate
    {
    }

    // @interface LPMessagingSDK : NSObject <UINavigationControllerDelegate>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface LPMessagingSDK : IUINavigationControllerDelegate
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        LPMessagingSDKdelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<LPMessagingSDKdelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        [Wrap("WeakNotificationDelegate")]
        [NullAllowed]
        LPMessagingSDKNotificationDelegate NotificationDelegate { get; set; }

        // @property (nonatomic, weak) id<LPMessagingSDKNotificationDelegate> _Nullable notificationDelegate;
        [NullAllowed, Export("notificationDelegate", ArgumentSemantic.Weak)]
        NSObject WeakNotificationDelegate { get; set; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        LPMessagingSDK New();

        // @property (readonly, nonatomic, strong, class) LPMessagingSDK * _Nonnull instance;
        [Static]
        [Export("instance", ArgumentSemantic.Strong)]
        LPMessagingSDK Instance { get; }

        // -(BOOL)initialize:(NSString * _Nullable)brandID monitoringInitParams:(LPMonitoringInitParams * _Nullable)monitoringInitParams error:(NSError * _Nullable * _Nullable)error;
        [Export("initialize:monitoringInitParams:error:")]
        bool Initialize([NullAllowed] string brandID, [NullAllowed] LPMonitoringInitParams monitoringInitParams, [NullAllowed] out NSError error);

        // -(void)showConversation:(id<ConversationParamProtocol> _Nonnull)conversationQuery authenticationCode:(NSString * _Nullable)authenticationCode containerViewController:(UIViewController * _Nullable)containerViewController;
        [Export("showConversation:authenticationCode:containerViewController:")]
        void ShowConversation(ConversationParamProtocol conversationQuery, [NullAllowed] string authenticationCode, [NullAllowed] UIViewController containerViewController);

        // -(void)showConversation:(LPConversationViewParams * _Nonnull)conversationViewParams authenticationParams:(LPAuthenticationParams * _Nullable)authenticationParams;
        [Export("showConversation:authenticationParams:")]
        void ShowConversation(LPConversationViewParams conversationViewParams, [NullAllowed] LPAuthenticationParams authenticationParams);

        // -(void)removeConversation:(id<ConversationParamProtocol> _Nonnull)conversationQuery;
        [Export("removeConversation:")]
        void RemoveConversation(ConversationParamProtocol conversationQuery);

        // -(void)reconnect:(id<ConversationParamProtocol> _Nonnull)conversationQuery authenticationCode:(NSString * _Nonnull)authenticationCode;
        [Export("reconnect:authenticationCode:")]
        void Reconnect(ConversationParamProtocol conversationQuery, string authenticationCode);

        // -(void)reconnect:(id<ConversationParamProtocol> _Nonnull)conversationQuery authenticationParams:(LPAuthenticationParams * _Nonnull)authenticationParams;
        [Export("reconnect:authenticationParams:")]
        void Reconnect(ConversationParamProtocol conversationQuery, LPAuthenticationParams authenticationParams);

        // -(void)toggleChatActions:(NSString * _Nonnull)accountID sender:(UIBarButtonItem * _Nullable)sender;
        [Export("toggleChatActions:sender:")]
        void ToggleChatActions(string accountID, [NullAllowed] UIBarButtonItem sender);

        // -(void)setUserProfile:(LPUser * _Nonnull)lpuser brandID:(NSString * _Nonnull)brandID;
        [Export("setUserProfile:brandID:")]
        void SetUserProfile(LPUser lpuser, string brandID);

        // -(void)handlePush:(NSDictionary * _Nonnull)userInfo;
        [Export("handlePush:")]
        void HandlePush(NSDictionary userInfo);

        // -(void)registerPushNotificationsWithToken:(NSData * _Nonnull)token notificationDelegate:(id<LPMessagingSDKNotificationDelegate> _Nullable)notificationDelegate alternateBundleID:(NSString * _Nullable)alternateBundleID;
        [Export("registerPushNotificationsWithToken:notificationDelegate:alternateBundleID:")]
        void RegisterPushNotificationsWithToken(NSData token, [NullAllowed] LPMessagingSDKNotificationDelegate notificationDelegate, [NullAllowed] string alternateBundleID);

        // -(void)registerVoipPushNotificationsWithToken:(NSData * _Nonnull)token alternateBundleID:(NSString * _Nullable)alternateBundleID;
        [Export("registerVoipPushNotificationsWithToken:alternateBundleID:")]
        void RegisterVoipPushNotificationsWithToken(NSData token, [NullAllowed] string alternateBundleID);

        // -(id<ConversationParamProtocol> _Nonnull)getConversationBrandQuery:(NSString * _Nonnull)brandID campaignInfo:(LPCampaignInfo * _Nullable)campaignInfo __attribute__((warn_unused_result));
        [Export("getConversationBrandQuery:campaignInfo:")]
        ConversationParamProtocol GetConversationBrandQuery(string brandID, [NullAllowed] LPCampaignInfo campaignInfo);

        // -(id<ConversationParamProtocol> _Nonnull)getConversationConsumerQuery:(NSString * _Nullable)consumerID brandID:(NSString * _Nonnull)brandID agentToken:(NSString * _Nonnull)agentToken __attribute__((warn_unused_result));
        [Export("getConversationConsumerQuery:brandID:agentToken:")]
        ConversationParamProtocol GetConversationConsumerQuery([NullAllowed] string consumerID, string brandID, string agentToken);

        // -(BOOL)checkActiveConversation:(id<ConversationParamProtocol> _Nonnull)conversationQuery __attribute__((warn_unused_result));
        [Export("checkActiveConversation:")]
        bool CheckActiveConversation(ConversationParamProtocol conversationQuery);

        // -(void)setCustomButton:(UIImage * _Nullable)image;
        [Export("setCustomButton:")]
        void SetCustomButton([NullAllowed] UIImage image);

        // -(void)addContentToMessageWithText:(NSString * _Nonnull)text;
        [Export("addContentToMessageWithText:")]
        void AddContentToMessageWithText(string text);

        // -(BOOL)isUrgent:(id<ConversationParamProtocol> _Nonnull)conversationQuery __attribute__((warn_unused_result));
        [Export("isUrgent:")]
        bool IsUrgent(ConversationParamProtocol conversationQuery);

        // -(void)markAsUrgent:(id<ConversationParamProtocol> _Nonnull)conversationQuery;
        [Export("markAsUrgent:")]
        void MarkAsUrgent(ConversationParamProtocol conversationQuery);

        // -(void)dismissUrgent:(id<ConversationParamProtocol> _Nonnull)conversationQuery;
        [Export("dismissUrgent:")]
        void DismissUrgent(ConversationParamProtocol conversationQuery);

        // -(void)resolveConversation:(id<ConversationParamProtocol> _Nonnull)conversationQuery;
        [Export("resolveConversation:")]
        void ResolveConversation(ConversationParamProtocol conversationQuery);

        // -(LPUser * _Nullable)getAssignedAgent:(id<ConversationParamProtocol> _Nonnull)conversationQuery __attribute__((warn_unused_result));
        [Export("getAssignedAgent:")]
        [return: NullAllowed]
        LPUser GetAssignedAgent(ConversationParamProtocol conversationQuery);

        // -(BOOL)isBrandReady:(NSString * _Nonnull)brandID __attribute__((warn_unused_result));
        [Export("isBrandReady:")]
        bool IsBrandReady(string brandID);

        // -(NSString * _Nullable)getSDKVersion __attribute__((warn_unused_result));
        [NullAllowed, Export("getSDKVersion")]

        string SDKVersion { get; }

        // -(NSTimeInterval)getInactiveUserInteractionTimeInterval:(id<ConversationParamProtocol> _Nonnull)conversationQuery __attribute__((warn_unused_result));
        [Export("getInactiveUserInteractionTimeInterval:")]
        double GetInactiveUserInteractionTimeInterval(ConversationParamProtocol conversationQuery);

        // +(void)getUnreadMessagesCount:(id<ConversationParamProtocol> _Nonnull)conversationQuery completion:(void (^ _Nonnull)(NSInteger))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Static]
        [Export("getUnreadMessagesCount:completion:failure:")]
        void GetUnreadMessagesCount(ConversationParamProtocol conversationQuery, Action<nint> completion, Action<NSError> failure);

        // -(BOOL)clearHistory:(id<ConversationParamProtocol> _Nonnull)conversationQuery error:(NSError * _Nullable * _Nullable)error;
        [Export("clearHistory:error:")]
        bool ClearHistory(ConversationParamProtocol conversationQuery, [NullAllowed] out NSError error);

        // -(void)subscribeLogEvents:(enum LogLevel)logLevel logEvent:(void (^ _Nonnull)(LPLog * _Nonnull))logEvent;
        [Export("subscribeLogEvents:logEvent:")]
        void SubscribeLogEvents(LogLevel logLevel, Action<LPLog> logEvent);

        // -(void)printAllLocalizedKeys;
        [Export("printAllLocalizedKeys")]
        void PrintAllLocalizedKeys();

        // -(void)printSupportedLanguages;
        [Export("printSupportedLanguages")]
        void PrintSupportedLanguages();

        // -(NSDictionary<NSString *,NSString *> * _Nonnull)getAllSupportedLanguages __attribute__((warn_unused_result));
        [Export("getAllSupportedLanguages")]

        NSDictionary<NSString, NSString> AllSupportedLanguages { get; }
    }

    // @interface LPMessagingSDK_Swift_729 (LPMessagingSDK)
    [Category]
    [BaseType(typeof(LPMessagingSDK))]
    interface LPMessagingSDK_LPMessagingSDK_Swift_729
    {
        // -(void)initSocketForBrandID:(NSString * _Nonnull)brandID agentToken:(NSString * _Nonnull)agentToken readyCompletion:(void (^ _Nullable)(void))readyCompletion __attribute__((objc_method_family("none")));
        [Export("initSocketForBrandID:agentToken:readyCompletion:")]
        void InitSocketForBrandID(string brandID, string agentToken, [NullAllowed] Action readyCompletion);

        // -(id<ConversationViewControllerAgentDelegate> _Nonnull)showAgentConversationWithConversationViewParams:(LPConversationViewParams * _Nonnull)conversationViewParams __attribute__((warn_unused_result));
        [Export("showAgentConversationWithConversationViewParams:")]
        ConversationViewControllerAgentDelegate ShowAgentConversationWithConversationViewParams(LPConversationViewParams conversationViewParams);
    }

    // @interface LPMessagingSDK_Swift_737 (LPMessagingSDK)
    [Category]
    [BaseType(typeof(LPMessagingSDK))]
    interface LPMessagingSDK_LPMessagingSDK_Swift_737
    {
        // -(void)logout;
        [Export("logout")]
        void Logout();

        // -(void)logoutWithCompletion:(void (^ _Nonnull)(void))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Export("logoutWithCompletion:failure:")]
        void LogoutWithCompletion(Action completion, Action<NSError> failure);

        // -(void)destruct;
        [Export("destruct")]
        void Destruct();
    }

    // @protocol LPMessagingSDKNotificationDelegate
    [Protocol, Model]
    interface LPMessagingSDKNotificationDelegate
    {
        // @optional -(void)LPMessagingSDKNotificationWithDidReceivePushNotification:(LPNotification * _Nonnull)notification;
        [Export("LPMessagingSDKNotificationWithDidReceivePushNotification:")]
        void LPMessagingSDKNotificationWithDidReceivePushNotification(LPNotification notification);

        // @optional -(BOOL)LPMessagingSDKNotificationWithShouldShowPushNotification:(LPNotification * _Nonnull)notification __attribute__((warn_unused_result));
        [Export("LPMessagingSDKNotificationWithShouldShowPushNotification:")]
        bool LPMessagingSDKNotificationWithShouldShowPushNotification(LPNotification notification);

        // @optional -(UIView * _Nonnull)LPMessagingSDKNotificationWithCustomLocalPushNotificationView:(LPNotification * _Nonnull)notification __attribute__((warn_unused_result));
        [Export("LPMessagingSDKNotificationWithCustomLocalPushNotificationView:")]
        UIView LPMessagingSDKNotificationWithCustomLocalPushNotificationView(LPNotification notification);

        // @optional -(void)LPMessagingSDKNotificationWithNotificationTapped:(LPNotification * _Nonnull)notification;
        [Export("LPMessagingSDKNotificationWithNotificationTapped:")]
        void LPMessagingSDKNotificationWithNotificationTapped(LPNotification notification);
    }

    // @protocol LPMessagingSDKdelegate
    [Protocol, Model]
    interface LPMessagingSDKdelegate
    {
        // @optional -(void)LPMessagingSDKCustomButtonTapped;
        [Export("LPMessagingSDKCustomButtonTapped")]
        void LPMessagingSDKCustomButtonTapped();

        // @optional -(void)LPMessagingSDKAgentDetails:(LPUser * _Nullable)agent;
        [Export("LPMessagingSDKAgentDetails:")]
        void LPMessagingSDKAgentDetails([NullAllowed] LPUser agent);

        // @optional -(void)LPMessagingSDKAgentAvatarTapped:(LPUser * _Nullable)agent;
        [Export("LPMessagingSDKAgentAvatarTapped:")]
        void LPMessagingSDKAgentAvatarTapped([NullAllowed] LPUser agent);

        // @optional -(void)LPMessagingSDKActionsMenuToggled:(BOOL)toggled;
        [Export("LPMessagingSDKActionsMenuToggled:")]
        void LPMessagingSDKActionsMenuToggled(bool toggled);

        // @optional -(void)LPMessagingSDKHasConnectionError:(NSString * _Nullable)error;
        [Export("LPMessagingSDKHasConnectionError:")]
        void LPMessagingSDKHasConnectionError([NullAllowed] string error);

        // @optional -(void)LPMessagingSDKCSATScoreSubmissionDidFinish:(NSString * _Nonnull)brandID rating:(NSInteger)rating;
        [Export("LPMessagingSDKCSATScoreSubmissionDidFinish:rating:")]
        void LPMessagingSDKCSATScoreSubmissionDidFinish(string brandID, nint rating);

        // @optional -(UIView * _Nonnull)LPMessagingSDKCSATCustomTitleView:(NSString * _Nonnull)brandID __attribute__((warn_unused_result));
        [Export("LPMessagingSDKCSATCustomTitleView:")]
        UIView LPMessagingSDKCSATCustomTitleView(string brandID);

        // @optional -(void)LPMessagingSDKConversationCSATSkipped:(NSString * _Nullable)conversationID;
        [Export("LPMessagingSDKConversationCSATSkipped:")]
        void LPMessagingSDKConversationCSATSkipped([NullAllowed] string conversationID);

        // @optional -(void)LPMessagingSDKUserDeniedPermission:(enum LPPermissionTypes)permissionType;
        [Export("LPMessagingSDKUserDeniedPermission:")]
        void LPMessagingSDKUserDeniedPermission(LPPermissionTypes permissionType);

        // @required -(void)LPMessagingSDKObseleteVersion:(NSError * _Nonnull)error;
        [Abstract]
        [Export("LPMessagingSDKObseleteVersion:")]
        void LPMessagingSDKObseleteVersion(NSError error);

        // @required -(void)LPMessagingSDKAuthenticationFailed:(NSError * _Nonnull)error;
        [Abstract]
        [Export("LPMessagingSDKAuthenticationFailed:")]
        void LPMessagingSDKAuthenticationFailed(NSError error);

        // @required -(void)LPMessagingSDKTokenExpired:(NSString * _Nonnull)brandID;
        [Abstract]
        [Export("LPMessagingSDKTokenExpired:")]
        void LPMessagingSDKTokenExpired(string brandID);

        // @required -(void)LPMessagingSDKError:(NSError * _Nonnull)error;
        [Abstract]
        [Export("LPMessagingSDKError:")]
        void LPMessagingSDKError(NSError error);

        // @optional -(void)LPMessagingSDKConnectionRetriesFailed:(NSError * _Nonnull)error;
        [Export("LPMessagingSDKConnectionRetriesFailed:")]
        void LPMessagingSDKConnectionRetriesFailed(NSError error);

        // @optional -(void)LPMessagingSDKAgentIsTypingStateChanged:(BOOL)isTyping;
        [Export("LPMessagingSDKAgentIsTypingStateChanged:")]
        void LPMessagingSDKAgentIsTypingStateChanged(bool isTyping);

        // @optional -(void)LPMessagingSDKConversationStarted:(NSString * _Nullable)conversationID;
        [Export("LPMessagingSDKConversationStarted:")]
        void LPMessagingSDKConversationStarted([NullAllowed] string conversationID);

        // @optional -(void)LPMessagingSDKConversationEnded:(NSString * _Nullable)conversationID;
        [Export("LPMessagingSDKConversationEnded:")]
        void LPMessagingSDKConversationEnded([NullAllowed] string conversationID);

        // @optional -(void)LPMessagingSDKConversationEnded:(NSString * _Nullable)conversationID closeReason:(enum LPConversationCloseReason)closeReason;
        [Export("LPMessagingSDKConversationEnded:closeReason:")]
        void LPMessagingSDKConversationEnded([NullAllowed] string conversationID, LPConversationCloseReason closeReason);

        // @optional -(void)LPMessagingSDKConversationCSATDismissedOnSubmittion:(NSString * _Nullable)conversationID;
        [Export("LPMessagingSDKConversationCSATDismissedOnSubmittion:")]
        void LPMessagingSDKConversationCSATDismissedOnSubmittion([NullAllowed] string conversationID);

        // @optional -(void)LPMessagingSDKConversationCSATDidLoad:(NSString * _Nullable)conversationID;
        [Export("LPMessagingSDKConversationCSATDidLoad:")]
        void LPMessagingSDKConversationCSATDidLoad([NullAllowed] string conversationID);

        // @optional -(void)LPMessagingSDKConnectionStateChanged:(BOOL)isReady brandID:(NSString * _Nonnull)brandID;
        [Export("LPMessagingSDKConnectionStateChanged:brandID:")]
        void LPMessagingSDKConnectionStateChanged(bool isReady, string brandID);

        // @optional -(void)LPMessagingSDKOffHoursStateChanged:(BOOL)isOffHours brandID:(NSString * _Nonnull)brandID;
        [Export("LPMessagingSDKOffHoursStateChanged:brandID:")]
        void LPMessagingSDKOffHoursStateChanged(bool isOffHours, string brandID);

        // @optional -(void)LPMessagingSDKConversationViewControllerDidDismiss;
        [Export("LPMessagingSDKConversationViewControllerDidDismiss")]
        void LPMessagingSDKConversationViewControllerDidDismiss();

        // @optional -(void)LPMessagingSDKCertPinningFailed:(NSError * _Nonnull)error;
        [Export("LPMessagingSDKCertPinningFailed:")]
        void LPMessagingSDKCertPinningFailed(NSError error);
    }

    // @interface LPNotification : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface LPNotification
    {
        // @property (copy, nonatomic) NSString * _Nonnull text;
        [Export("text")]
        string Text { get; set; }

        // @property (nonatomic, strong) LPUser * _Nonnull user;
        [Export("user", ArgumentSemantic.Strong)]
        LPUser User { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull accountID;
        [Export("accountID")]
        string AccountID { get; set; }

        // @property (nonatomic) BOOL isRemote;
        [Export("isRemote")]
        bool IsRemote { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull toString;
        [Export("toString")]
        string ToString { get; }

        // -(instancetype _Nonnull)initWithText:(NSString * _Nonnull)text firstName:(NSString * _Nullable)firstName lastName:(NSString * _Nullable)lastName uid:(NSString * _Nullable)uid accountID:(NSString * _Nonnull)accountID isRemote:(BOOL)isRemote;
        [Export("initWithText:firstName:lastName:uid:accountID:isRemote:")]
        IntPtr Constructor(string text, [NullAllowed] string firstName, [NullAllowed] string lastName, [NullAllowed] string uid, string accountID, bool isRemote);

        // -(instancetype _Nonnull)initWithMessage:(LPMessageEntity * _Nonnull)message isRemote:(BOOL)isRemote;
        [Export("initWithMessage:isRemote:")]
        IntPtr Constructor(LPMessageEntity message, bool isRemote);

        // -(instancetype _Nonnull)initWithText:(NSString * _Nonnull)text user:(LPUser * _Nonnull)user accountID:(NSString * _Nonnull)accountID isRemote:(BOOL)isRemote __attribute__((objc_designated_initializer));
        [Export("initWithText:user:accountID:isRemote:")]
        [DesignatedInitializer]
        IntPtr Constructor(string text, LPUser user, string accountID, bool isRemote);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        LPNotification New();
    }

    // @interface LPRadialProgressBar : UIView
    [BaseType(typeof(UIView))]
    interface LPRadialProgressBar
    {
        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface NSBouncyView : UIView
    [BaseType(typeof(UIView))]
    interface NSBouncyView
    {
        // -(void)setView:(UIView * _Nonnull)view __attribute__((diagnose_if(0x7fcad73da810, "Swift method 'NSBouncyView.setView(_:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("setView:")]
        void SetView(UIView view);

        // -(void)setColorWithColor:(UIColor * _Nonnull)color __attribute__((diagnose_if(0x7fcad73dab58, "Swift method 'NSBouncyView.setColor(color:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("setColorWithColor:")]
        void SetColorWithColor(UIColor color);

        // -(void)toggleVisibilityWithShow:(BOOL)show willStart:(void (^ _Nonnull)(void))willStart didComplete:(void (^ _Nonnull)(void))didComplete didFail:(void (^ _Nonnull)(void))didFail __attribute__((diagnose_if(0x7fcad73db248, "Swift method 'NSBouncyView.toggleVisibility(show:willStart:didComplete:didFail:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("toggleVisibilityWithShow:willStart:didComplete:didFail:")]
        void ToggleVisibilityWithShow(bool show, Action willStart, Action didComplete, Action didFail);

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface RemoteUserIsTypingView : UIView
    [BaseType(typeof(UIView))]
    interface RemoteUserIsTypingView
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSCoder aDecoder);

        // -(void)awakeFromNib __attribute__((objc_requires_super));
        [Export("awakeFromNib")]

        void AwakeFromNib();
    }

    // @protocol UIAdapterDelegate
    [Protocol, Model]
    interface UIAdapterDelegate
    {
        // @optional -(BOOL)sendClickedWithMessage:(NSString * _Nonnull)message inConversation:(LPConversationEntity * _Nonnull)inConversation __attribute__((warn_unused_result));
        [Export("sendClickedWithMessage:inConversation:")]
        bool SendClickedWithMessage(string message, LPConversationEntity inConversation);

        // @optional -(void)executeActionAtIndex:(UIViewController * _Nonnull)viewController index:(NSInteger)index conversation:(LPConversationEntity * _Nullable)conversation complition:(void (^ _Nonnull)(void))complition;
        [Export("executeActionAtIndex:index:conversation:complition:")]
        void ExecuteActionAtIndex(UIViewController viewController, nint index, [NullAllowed] LPConversationEntity conversation, Action complition);

        // @optional -(void)textViewDidBeginEditingWithConversation:(LPConversationEntity * _Nullable)conversation;
        [Export("textViewDidBeginEditingWithConversation:")]
        void TextViewDidBeginEditingWithConversation([NullAllowed] LPConversationEntity conversation);

        // @optional -(void)textViewDidEndEditingWithConversation:(LPConversationEntity * _Nullable)conversation;
        [Export("textViewDidEndEditingWithConversation:")]
        void TextViewDidEndEditingWithConversation([NullAllowed] LPConversationEntity conversation);

        // @optional -(BOOL)textView:(UITextView * _Nonnull)textView shouldChangeTextInRange:(NSRange)range replacementText:(NSString * _Nonnull)text conversation:(LPConversationEntity * _Nullable)conversation __attribute__((warn_unused_result));
        [Export("textView:shouldChangeTextInRange:replacementText:conversation:")]
        bool TextView(UITextView textView, NSRange range, string text, [NullAllowed] LPConversationEntity conversation);

        // @optional -(BOOL)shouldSetUIReadOnly:(LPConversationEntity * _Nullable)conversation __attribute__((warn_unused_result));
        [Export("shouldSetUIReadOnly:")]
        bool ShouldSetUIReadOnly([NullAllowed] LPConversationEntity conversation);

        // @optional -(UIColor * _Nonnull)getTableViewBackgroundColor:(id<ConversationParamProtocol> _Nonnull)conversationQuery __attribute__((warn_unused_result));
        [Export("getTableViewBackgroundColor:")]
        UIColor GetTableViewBackgroundColor(ConversationParamProtocol conversationQuery);

        // @optional -(UIImage * _Nonnull)getDefaultRecepientAvatarImage:(id<ConversationParamProtocol> _Nonnull)conversationQuery __attribute__((warn_unused_result));
        [Export("getDefaultRecepientAvatarImage:")]
        UIImage GetDefaultRecepientAvatarImage(ConversationParamProtocol conversationQuery);

        // @optional -(UIGestureRecognizer * _Nonnull)getTableViewCustomGestureRecognizer __attribute__((warn_unused_result));
        [Export("getTableViewCustomGestureRecognizer")]

        UIGestureRecognizer TableViewCustomGestureRecognizer { get; }
    }




    // @interface LPEngagementDetails : NSObject
    [BaseType(typeof(NSObject))]
    interface LPEngagementDetails
    {
        // @property (nonatomic) NSInteger campaignId;
        [Export("campaignId")]
        nint CampaignId { get; set; }

        // @property (nonatomic) NSInteger engagementId;
        [Export("engagementId")]
        nint EngagementId { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable conversationId;
        [NullAllowed, Export("conversationId")]
        string ConversationId { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable status;
        [NullAllowed, Export("status")]
        string Status { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable contextId;
        [NullAllowed, Export("contextId")]
        string ContextId { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    // @interface LPGetEngagementResponse : NSObject
    [BaseType(typeof(NSObject))]
    interface LPGetEngagementResponse
    {
        // @property (copy, nonatomic) NSArray<LPEngagementDetails *> * _Nullable engagementDetails;
        [NullAllowed, Export("engagementDetails", ArgumentSemantic.Copy)]
        LPEngagementDetails[] EngagementDetails { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable sessionId;
        [NullAllowed, Export("sessionId")]
        string SessionId { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable visitorId;
        [NullAllowed, Export("visitorId")]
        string VisitorId { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable pageId;
        [NullAllowed, Export("pageId")]
        string PageId { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    // @interface LPMonitoringAPI : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface LPMonitoringAPI
    {
        // @property (readonly, nonatomic, strong, class) LPMonitoringAPI * _Nonnull instance;
        [Static]
        [Export("instance", ArgumentSemantic.Strong)]
        LPMonitoringAPI Instance { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        LPMonitoringAPI New();

        // -(void)getEngagementWithConsumerID:(NSString * _Nullable)consumerID monitoringParams:(LPMonitoringParams * _Nullable)monitoringParams completion:(void (^ _Nonnull)(LPGetEngagementResponse * _Nonnull))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Export("getEngagementWithConsumerID:monitoringParams:completion:failure:")]
        void GetEngagementWithConsumerID([NullAllowed] string consumerID, [NullAllowed] LPMonitoringParams monitoringParams, Action<LPGetEngagementResponse> completion, Action<NSError> failure);

        // -(void)sendSDEWithConsumerID:(NSString * _Nonnull)consumerID monitoringParams:(LPMonitoringParams * _Nonnull)monitoringParams completion:(void (^ _Nonnull)(LPSendSDEResponse * _Nonnull))completion failure:(void (^ _Nonnull)(NSError * _Nonnull))failure;
        [Export("sendSDEWithConsumerID:monitoringParams:completion:failure:")]
        void SendSDEWithConsumerID(string consumerID, LPMonitoringParams monitoringParams, Action<LPSendSDEResponse> completion, Action<NSError> failure);
    }

    // @interface LPMonitoringDataManager : NSObject <GeneralManagerProtocol>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface LPMonitoringDataManager : GeneralManagerProtocol
    {
        // @property (readonly, nonatomic) BOOL isInitialized __attribute__((diagnose_if(0x7fcad73f2230, "Swift property 'LPMonitoringDataManager.isInitialized' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("isInitialized")]
        bool IsInitialized { get; }

        // @property (readonly, nonatomic, strong, class) LPMonitoringDataManager * _Nonnull instance __attribute__((diagnose_if(0x7fcad73f2568, "Swift property 'LPMonitoringDataManager.instance' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Static]
        [Export("instance", ArgumentSemantic.Strong)]
        LPMonitoringDataManager Instance { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        LPMonitoringDataManager New();

        // -(void)initializeWithAccountId:(NSString * _Nonnull)accountId monitoringInitParms:(LPMonitoringInitParams * _Nonnull)monitoringInitParms __attribute__((diagnose_if(0x7fcad73f2f60, "Swift method 'LPMonitoringDataManager.initialize(accountId:monitoringInitParms:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
        [Export("initializeWithAccountId:monitoringInitParms:")]
        void InitializeWithAccountId(string accountId, LPMonitoringInitParams monitoringInitParms);

        // -(void)clearManager;
        [Export("clearManager")]
        void ClearManager();
    }

    // @interface LPMonitoringInitParams : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface LPMonitoringInitParams
    {
        // -(instancetype _Nonnull)initWithAppInstallID:(NSString * _Nonnull)appInstallID __attribute__((objc_designated_initializer));
        [Export("initWithAppInstallID:")]
        [DesignatedInitializer]
        IntPtr Constructor(string appInstallID);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        LPMonitoringInitParams New();
    }

    // @interface LPMonitoringParams : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface LPMonitoringParams
    {
        // @property (copy, nonatomic) NSArray<NSString *> * _Nullable entryPoints;
        [NullAllowed, Export("entryPoints", ArgumentSemantic.Copy)]
        string[] EntryPoints { get; set; }

        // @property (copy, nonatomic) NSArray<NSDictionary<NSString *,id> *> * _Nullable engagementAttributes;
        [NullAllowed, Export("engagementAttributes", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject>[] EngagementAttributes { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable pageId;
        [NullAllowed, Export("pageId")]
        string PageId { get; set; }

        // -(instancetype _Nonnull)initWithEntryPoints:(NSArray<NSString *> * _Nullable)entryPoints engagementAttributes:(NSArray<NSDictionary<NSString *,id> *> * _Nullable)engagementAttributes pageId:(NSString * _Nullable)pageId __attribute__((objc_designated_initializer));
        [Export("initWithEntryPoints:engagementAttributes:pageId:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] string[] entryPoints, [NullAllowed] NSDictionary<NSString, NSObject>[] engagementAttributes, [NullAllowed] string pageId);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        LPMonitoringParams New();
    }

    // @interface LPSendSDEResponse : NSObject
    [BaseType(typeof(NSObject))]
    interface LPSendSDEResponse
    {
        // @property (copy, nonatomic) NSString * _Nullable sessionId;
        [NullAllowed, Export("sessionId")]
        string SessionId { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable visitorId;
        [NullAllowed, Export("visitorId")]
        string VisitorId { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable pageId;
        [NullAllowed, Export("pageId")]
        string PageId { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    // @interface LivePersonChat : NSObject
    [BaseType(typeof(NSObject))]
    interface LivePersonChat
    {
    }

    // @interface LivePersonMonitoring : NSObject
    [BaseType(typeof(NSObject))]
    interface LivePersonMonitoring
    {
    }


}
