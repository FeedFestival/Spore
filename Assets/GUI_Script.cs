using UnityEngine;
using System.Collections;

public class GUI_Script : MonoBehaviour {
	
	Transform camt;
	
	// Use this for initialization
	void Start () {
	camt = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI () {
        // Make a background box
        GUI.Box(new Rect(10,10,100,90), "Zoom");
    
        // Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
        if(GUI.Button(new Rect(20,40,80,20), "+5")) {
            camt.camera.orthographicSize = camt.camera.orthographicSize + 5;
        }
    
        // Make the second button.
        if(GUI.Button(new Rect(20,70,80,20), "-5")) {
            camt.camera.orthographicSize = camt.camera.orthographicSize - 5;
        }
		
		GUI.Box(new Rect(120,10,220,130), "Move");
		
		if(GUI.Button(new Rect(190,40,80,20), "Up")) {
            camt.transform.position = new Vector3(camt.transform.position.x,camt.transform.position.y + 2,camt.transform.position.z);
        }
		
		if(GUI.Button(new Rect(190,100,80,20), "Down")) {
             camt.transform.position = new Vector3(camt.transform.position.x,camt.transform.position.y - 2,camt.transform.position.z);
        }
    
        // Make the second button.
        if(GUI.Button(new Rect(130,70,80,20), "Left")) {
             camt.transform.position = new Vector3(camt.transform.position.x - 2,camt.transform.position.y,camt.transform.position.z);
        }
		
		// Make the second button.
        if(GUI.Button(new Rect(250,70,80,20), "Right")) {
            camt.transform.position = new Vector3(camt.transform.position.x + 2,camt.transform.position.y,camt.transform.position.z);
        }
    }
}
