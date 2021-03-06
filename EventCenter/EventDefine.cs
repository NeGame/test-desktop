using UnityEngine;
using System.Collections;

public enum EGameEvent
{
    eGameEvent_ErrorStr = 1,
    eGameEvent_ConnectServerFail,   //z连接服务器失败
    eGameEvent_ConnectServerSuccess,//z连接服务器成功

    //UIGuide // register guide
    eGameEvent_UIGuideTriggerRegister = -5000,
    eGameEvent_UIGuideTriggerNewsGuide = -5001,
    eGameEvent_UIGuideTriggerSelfDefGame = -5002,
    eGameEvent_UIGuideTriggerCreateRoom = -5003,
    eGameEvent_UIGuideTriggerBackLobby = -5004,
    eGameEvent_UIGuideTriggerMatchGame = -5005, 
    eGameEvent_UIGuideTriggerSelectHero = -5006,
    eGameEvent_UIGuideTriggerRoomBeginGame = -5007,

}
