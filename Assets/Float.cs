using UnityEngine;
using System.Collections;

public class Float : MonoBehaviour {
	
	private bool floatup;
	
	private Vector3 gravity;

	public GameObject obiect;
	// Use this for initialization
	void Start () {
		gravity = new Vector3 (0,0,0);
		Physics.gravity = gravity;
		obiect = this.gameObject;
		
	}
	void FixedUpdate () {
	    if(Input.GetKeyDown(KeyCode.W)) {
	        floatingup(8);
			}
			if (Input.GetKeyDown(KeyCode.S)) {
	        floatingdown(8);
			}
			 if (Input.GetKeyDown(KeyCode.A)) {
	        floatingleft(8);
			}
			 if(Input.GetKeyDown(KeyCode.D)) {
	        floatingright(8);
			}
	}
	public void floatingup(float i){	
    obiect.rigidbody.AddForce(0,i,0);
	}
	public void floatingdown(float i){
		obiect.rigidbody.AddForce(0,-i,0);
	}
	public void floatingleft(float i){
		obiect.rigidbody.AddForce(-i,0,0);
	}
	public void floatingright(float i){
		obiect.rigidbody.AddForce(i,0,0);
	}
	
	void OnCollisionEnter(Collision c){
		Debug.Log("im " + obiect.name + " and i collided with " + c.gameObject.name);
		
	}
	
	public void Xtremes(){
		
	}
}
