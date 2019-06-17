using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleTapEventToFsm : MonoBehaviour
{
    //FSMがあるゲームオブジェクト
    public GameObject obj;

    //呼び出したいFSM
    public PlayMakerFSM playmakerFSM;

    //呼び出したいイベント名
    public string eventName;

    //GestureRecognizer使用準備
    UnityEngine.XR.WSA.Input.GestureRecognizer gestureRecognizer;

    void Start()
    {
        gestureRecognizer = new UnityEngine.XR.WSA.Input.GestureRecognizer();
        gestureRecognizer.SetRecognizableGestures(UnityEngine.XR.WSA.Input.GestureSettings.DoubleTap);
        gestureRecognizer.TappedEvent += GestureRecognizer_TappedEvent;
        gestureRecognizer.StartCapturingGestures();
    }

    private void GestureRecognizer_TappedEvent(UnityEngine.XR.WSA.Input.InteractionSourceKind source, int tapCount, Ray headRay)
    {
        if (tapCount == 2)
        {
            playmakerFSM.Fsm.Event(eventName);
        }
    }
}
