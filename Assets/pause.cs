using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class pause : MonoBehaviour {
	bool pause_bool = false;
	// Use this for initialization
	public GameObject menu;
	public GameObject pausebutton;
	void Start () {
		menu.SetActive(false);
		pausebutton.SetActive (true);
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void pause_funk(){
		Time.timeScale = 0;
		menu.SetActive (true);
		pausebutton.SetActive (false);
	}
	public void resume_funk(){
		menu.SetActive (false);
		pausebutton.SetActive (true);
		Time.timeScale = 1;
	}
	public void menu_funk(){
		SceneManager.LoadScene ("gui", LoadSceneMode.Single);
	}
}
