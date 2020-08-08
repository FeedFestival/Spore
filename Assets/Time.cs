using UnityEngine;
using System.Collections;
using System;

public class Time : MonoBehaviour {

	public GUIText minutes;
	private float s;
	
	void Start (){
		
	}
	
	void FixedUpdate (){
		s = UnityEngine.Time.time;
		minutes.text = FormatTime(s);
		
	}
	
	public string FormatTime(float fTime){			
  TimeSpan t =  TimeSpan.FromSeconds( fTime );	
  /// You can add more digits by adding more digits eg: {1:D2}:{2:D2}:{3:D2}:{4:D2} to also display milliseconds.
  return string.Format("{1:D2}:{2:D2}", t.Hours, t.Minutes, t.Seconds, t.Milliseconds);
}
	

}
