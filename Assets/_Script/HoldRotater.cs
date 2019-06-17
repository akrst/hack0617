using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class HoldRotater : MonoBehaviour , IHoldHandler {
    public bool holding = false; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (holding)
        {
            transform.Rotate(0, 0.5f, 0);
        }
	}


    public void OnHoldStarted(HoldEventData eventData)
    {
        holding = true;
        Debug.Log("holding is true");
    }

    public void OnHoldCompleted(HoldEventData eventData)
    {
        holding = false;
        Debug.Log("holding is false");
    }

    public void OnHoldCanceled(HoldEventData eventData)
    {
        holding = false;
        Debug.Log("holding is false");
    }

}
