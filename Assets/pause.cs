using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {
	bool pause_bool = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void pause_funk(){
		if (pause_bool) {
			Time.timeScale = 1;

		} else {
			Time.timeScale = 0;
		
		}
		pause_bool = !pause_bool;
	}
}
