using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class SingleTapEventToFsm : MonoBehaviour, IInputClickHandler
{
    //FSMがあるゲームオブジェクト
    public GameObject obj;

    //呼び出したいFSM
    public PlayMakerFSM playmakerFSM;

    //呼び出したいイベント名
    public string eventName;

    // Use this for initialization
    void Start()
    {
        //InspectorからFSMを設定しない場合は、Start時にオブジェクトを指定し、GetComponentでFSMを設定する 
        //playmakerFSM = obj.GetComponent<PlayMakerFSM>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // このオブジェクトがタップされると、指定されたイベントがFSMに送られる
    public void OnInputClicked(InputClickedEventData eventData)
    {
        playmakerFSM.Fsm.Event(eventName);
    }
}
