using UnityEngine;
using System.Collections;
using System;

public class A_Float_Behaviour : MonoBehaviour {
	
	private bool moving;
	private bool left;
	private bool right;
	private bool up;
	
	
	
	public GameObject obiect;
	
	public int[] routes;
	
	public float sec;
	
	public int newi;

	// Use this for initialization
	void Start () {
		sec = 3;
		
	 	obiect = this.gameObject;
		
		newi=0;
		
		routes = new int[6];
		
		var i=0;
		for (i =0;i<6;i++){
			routes[i]=Randoms();
//			Debug.Log(routes[i] + " - " + obiect);
		}
		newRoute();
	}
	IEnumerator MyCoroutine(){
		floating(routes[newi],1.25f);
		yield return new WaitForSeconds(sec);
		newRoute();
		
	}
	
	public void newRoute (){
//			Debug.Log("apelare " + obiect.rigidbody.IsSleeping() + " " + newi);
		//floating(newi,0.1f);
		if (newi == 5){
			newi = 0;
		}else {
			newi++;
			}
		StartCoroutine(MyCoroutine());
	}
	
	public void floating(int i,float speed){
		if (i == 1){
			floatingup(speed);
		}else if (i == 2){
			floatingleft(speed);
		}else if (i ==3){
			floatingright(speed);
		}else if (i == 4){
			floatingdown(speed);
		} else if (i == 5){
			floatingup(speed);
			floatingleft(speed);
		} else if (i == 6){
			floatingup(speed);
			floatingright(speed);
		} else if (i == 7){
			floatingdown(speed);
			floatingright(speed);
		} else {
			floatingdown(speed);
			floatingleft(speed);
		}
	}
	
	public int Randoms(){
		
		int num;
		var temp = UnityEngine.Random.Range(1,9);
		num = Mathf.RoundToInt(temp);
		
        return num;
		
	}
	
	public void floatingup(float i){	
    obiect.rigidbody.AddForce(0,i,0);
	}
	public void floatingdown(float i){
		obiect.rigidbody.AddForce(0,-i,0);
		rigidbody.AddTorque (0, 10, 0);
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
}
