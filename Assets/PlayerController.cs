using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
	public float speed;
	public float horSpeed;
	public GameObject go;
	private Rigidbody rb;

	void Awake() {
		Application.targetFrameRate = 60;
	}
	void Start ()
	{
		
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = 0;
		//float moveHorizontal = Input.GetAxis ("Horizontal");
		//float moveVertical = Input.GetAxis ("Vertical");
		if (Input.touchCount > 0)
		{
			var touch = Input.GetTouch(0);
			if (touch.position.x < Screen.width/2)
			{
				moveHorizontal = -1;
			}
			else if (touch.position.x > Screen.width/2)
			{
				 moveHorizontal = 1;
			}
		}

		Vector3 movement = new Vector3 (-moveHorizontal * horSpeed, 0.0f,-speed);

		rb.AddForce (movement*speed,ForceMode.Acceleration);
	}
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Plane_001" ||col.gameObject.name == "Plane_004" )
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
		if(col.gameObject.name == "ende"||col.gameObject.name == "Cube_002")
		{
			SceneManager.LoadScene ("gui");
		}
	}
}
