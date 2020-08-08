using UnityEngine;
using System.Collections;

public class Plasma_Behaviour : MonoBehaviour {

	public float randomNrx;
	public float randomNrz;
	
	private Transform myTransform;
	
	
	void Start () {
		
		myTransform = transform;
		
		
		
		generateNum();
		
	}
	void OnTriggerEnter (Collider other){
		
		Debug.Log( "M-am lovit");
			generateNum();
	
	}
	
	public void generateNum(){
			randomNrx = Random.Range(-2,3);
			randomNrz = Random.Range(-2,3);
			//generateNum();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if (this.gameObject.transform.position.y != 0){
			
			Vector3 position = myTransform.position;
			position.y = 0;	
			myTransform.position = position;
		}
		//if (Input.GetKeyDown(KeyCode.A)){
		 myTransform.Translate(randomNrx * UnityEngine.Time.deltaTime,0,randomNrz * UnityEngine.Time.deltaTime);
		//}	
}
}