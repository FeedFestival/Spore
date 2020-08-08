using UnityEngine;
using System.Collections;

public class Float_Behaviour : MonoBehaviour {
	
	float seconds;
	
	Transform obiect;
	float obiect_speed;
	
	int randomnr;
	
	// Use this for initialization
	void Start () {
		
		obiect = this.transform;
		
		obiect_speed = 2.0f;
		randomnr = 0;
	 	seconds = 3.0f;
		
		StartCoroutine(Float());
	}
	
	
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
	
	IEnumerator Float(){
		
		var temp = UnityEngine.Random.Range(0,7);
		randomnr = Mathf.RoundToInt(temp);
		Move(randomnr);
		Debug.Log(" - " + randomnr);
		
		yield return new WaitForSeconds(seconds);
		
		
		StartCoroutine(Float());
			
	}
	
	public void Move(int i){
		if ((i == 0) || (i == 4)){
			obiect.rigidbody.AddForce(0,obiect_speed,0);	// up
		} else if ((i == 1) || (i == 5)){
			obiect.rigidbody.AddForce(0,-obiect_speed,0);	// down
		} else if ((i == 2) || (i == 6)){
			obiect.rigidbody.AddForce(-obiect_speed,0,0);	// left
		} else if ((i == 3) || (i == 7)){
			obiect.rigidbody.AddForce(obiect_speed,0,0);	// right
		}
	}
	
}
