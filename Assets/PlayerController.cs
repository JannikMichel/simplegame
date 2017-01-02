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
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (-moveHorizontal * horSpeed, 0.0f,-speed);

		rb.AddForce (movement*speed,ForceMode.Acceleration);
	}
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Plane_001")
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
		if(col.gameObject.name == "ende")
		{
			SceneManager.LoadScene ("gui");
		}
	}
}
