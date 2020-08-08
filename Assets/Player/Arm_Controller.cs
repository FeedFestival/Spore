using UnityEngine;
using System.Collections;

public class Arm_Controller : MonoBehaviour {
	
	public GameObject obiect;
	public Transform bone;

	// Use this for initialization
	void Start () {
		obiect = this.gameObject;
		Debug.Log(obiect.transform.childCount);
		bone = obiect.transform.Find("Armature/Bone_IK");
		Debug.Log(bone);
		
		newp = new Vector3(-2.0f,0,0);
	}
	public Vector3 newp;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftArrow)){
			Debug.Log("apas");
			bone.transform.position = newp;
		}
	}
}
