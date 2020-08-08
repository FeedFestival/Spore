using UnityEngine;
using System.Collections;

public class Xtremes_Behaviour : MonoBehaviour {
	
	private GameObject cell;
	
	private GameObject nname;

	// Use this for initialization
	void Start () {
		nname = this.gameObject;
		cell = transform.parent.gameObject;
		//Debug.Log("-" + transform.parent + " " + cell);
	}
	
	void OnTriggerEnter(Collider c){
		if (c.transform.parent){
			
//			Debug.Log("im " + cell.name + " and " + c.transform.parent.name + " hit me at " + nname.name + " distance");
		}else {
			
//			Debug.Log("im " + cell.name + " and " + c.name + " hit me at " + nname.name + " distance");
		}
	}
	
	
}
