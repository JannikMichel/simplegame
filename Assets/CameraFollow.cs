using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject player;
	public float cameraHeight = 20.0f;

	void Update() {
		Vector3 pos = player.transform.position;
		pos.y += cameraHeight;
		transform.position = pos;
	}
}
