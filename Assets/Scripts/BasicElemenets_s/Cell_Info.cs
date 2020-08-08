using UnityEngine;
using System.Collections;

public class Cell_Info : MonoBehaviour {
	
	private GameObject cell;
	
	private GameObject nname;
	
	public int p_property;
	public int e_property;

	// Use this for initialization
	void Start () {
		nname = this.gameObject;
		cell = transform.parent.gameObject;
		
		if (cell.name == "A1_1"){
			p_property = 2;
			e_property = 3;
		} else if (cell.name == "A1_2"){
			p_property = 1;
			e_property = 4;
			} else {
				p_property = 4;
				e_property = 2;
				}
	}
	void OnCollisionEnter(Collision c){
		Debug.Log("im " + cell.name + " and i collided with " + c.gameObject.name);
		
	}
}
