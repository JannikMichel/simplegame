using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class loadScript : MonoBehaviour {

	// Use this for initialization
	public void loadScene1(){
		SceneManager.LoadScene ("level1",LoadSceneMode.Single);
	}
	public void loadScene2(){
		SceneManager.LoadScene ("level2",LoadSceneMode.Single);
	}
	public void loadScene3(){
		SceneManager.LoadScene ("level3",LoadSceneMode.Single);
	}
	public void loadScene4(){
		SceneManager.LoadScene ("big bang level",LoadSceneMode.Single);
	}
	public void loadScene5(){
	SceneManager.LoadScene ("Dino level",LoadSceneMode.Single);
	}
	public void loadScene6(){
		SceneManager.LoadScene ("eiszeit level",LoadSceneMode.Single);
	}
}
