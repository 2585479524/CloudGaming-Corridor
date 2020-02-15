using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sa_ScreenCapture : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.F12))
        {
            ScreenCapture.CaptureScreenshot("corridor_"+ System.DateTime.Now.Year +"_"+ System.DateTime.Now.Month +"_"+ System.DateTime.Now.Day +"_"+ System.DateTime.Now.Hour +"_"+ System.DateTime.Now.Minute +"_"+ System.DateTime.Now.Millisecond + ".png");
        }
	}
}
