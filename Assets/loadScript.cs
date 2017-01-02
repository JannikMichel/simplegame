using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class loadScript : MonoBehaviour {

	// Use this for initialization
	public void loadScene1(){
		SceneManager.LoadScene ("level1");
	}
	public void loadScene2(){
		SceneManager.LoadScene ("level2");
	}
}
