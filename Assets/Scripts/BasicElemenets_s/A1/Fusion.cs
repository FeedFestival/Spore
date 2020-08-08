using UnityEngine;
using System.Collections;

public class Fusion : MonoBehaviour {
	
	public GameObject tie;
	private GameObject sphere1;
	public GameObject sphere2;
	public FixedJoint sphereFJ;
	
	private bool lookat;

	// Use this for initialization
	void Start () {
		
		lookat = false;
		sphere1 = this.gameObject;
		sphereFJ = sphere1.GetComponent<FixedJoint>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		tie.transform.LookAt(sphere2.transform);
		if (Input.GetKeyDown(KeyCode.X)){
			lookat = true;
			
			
			sphereFJ.connectedBody = sphere2.rigidbody;
			//sphere1.AddComponent<FixedJoint>();
			
		}
		if (lookat = true){
			tie.transform.LookAt(sphere2.transform);
			tie.transform.position = sphere1.gameObject.transform.position;
		}
	}
}
