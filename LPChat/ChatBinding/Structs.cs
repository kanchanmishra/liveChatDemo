using System;

namespace LivePersonChat
{

    
    public enum CheckmarksState
    {
        SentOnly = 1,
        SentAndAccepted = 2,
        All = 3
    }

   
    
  
    
    public enum LPAccountEnviroment 
    {
        Production = 0,
        Alpha = 1,
        Qa = 2
    }

    
    public enum LPConversationCloseReason 
    {
        Agent = 0,
        Consumer = 1,
        System = 2
    }

    
    public enum LPConversationHistoryMaxDaysDateType 
    {
        StartConversationDate = 0,
        EndConversationDate = 1
    }

    
    public enum LPConversationsHistoryStateToDisplay 
    {
        Open = 0,
        Close = 1,
        None = 2
    }

    
    public enum LPLanguage 
    {
        Device = 0,
        En = 1,
        En_GB = 2,
        Pt = 3,
        Pt_PT = 4,
        Fr = 5,
        Bg = 6,
        Cs = 7,
        Da = 8,
        Sr = 9,
        De = 10,
        El = 11,
        He = 12,
        He_IL = 13,
        Es = 14,
        Et = 15,
        Fi = 16,
        Hi = 17,
        Hr = 18,
        Hu = 19,
        It = 20,
        Ja = 21,
        Ko = 22,
        Lt = 23,
        Lv = 24,
        Mk = 25,
        Nb = 26,
        Nl = 27,
        Pl = 28,
        Ro = 29,
        Ru = 30,
        Sl = 31,
        Sk = 32,
        Sv = 33,
        Th = 34,
        Tr = 35,
        Uk = 36,
        Vi = 37,
        Zh = 38,
        Zh_Hans = 39,
        Zh_Hant_hk = 40
    }

    
    public enum LPMessagingSDKFeature 
    {
        LPMessagingSDKFeaturePhotoSharing = 0
    }

    
    public enum LPPermissionTypes 
    {
        Location = 0,
        Contacts = 1,
        Calendars = 2,
        Reminders = 3,
        Photos = 4,
        Bluetooth = 5,
        Microphone = 6,
        SpeechRecognition = 7,
        Camera = 8,
        Health = 9,
        Homekit = 10,
        MediaLibrary = 11,
        MotionAndFitness = 12
    }

    
    public enum LPUrlPreviewStyle 
    {
        Slim = 0,
        Large = 1
    }

    
    public enum LogLevel 
    {
        Trace = 0,
        Debug = 1,
        Info = 2,
        Warning = 3,
        Error = 4,
        Off = 5
    }

    
    public enum SocketType 
    {
        Consumer = 0,
        Agent = 1
    }
}
