using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.A)){
			
			rigidbody.AddForce (-0.01f,0,0);
			if (rigidbody.velocity.x < -5){
				Debug.Log( " its less" + rigidbody.velocity.ToString());
				rigidbody.velocity.Normalize();
				rigidbody.velocity.Set(-5,0,0);
			}
			
			}
		Debug.Log(rigidbody.velocity.ToString());
		
		if (Input.GetKeyDown(KeyCode.D)){
			rigidbody.AddRelativeForce(0.1f,0,0);
		}
		if (Input.GetKeyDown(KeyCode.W)){
			rigidbody.AddRelativeForce(0,0.1f,0);
		}
		if (Input.GetKeyDown(KeyCode.S)){
			rigidbody.AddRelativeForce(0,-0.1f,0);
		}
	}
}
