using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	private const int _moveSpeed = 5;
	private const int _rotationSpeed = 360;
	private Rigidbody2D _rigidbody2D;

	// Use this for initialization
	void Start () {
		_rigidbody2D = GetComponent<Rigidbody2D> ();
		_rigidbody2D.AddForce (new Vector2 (0, 100));
	}
	
	// Update is called once per frame
	void Update () {
		// Get inputs
		bool left = Input.GetKey(KeyCode.LeftArrow);
		bool right = Input.GetKey(KeyCode.RightArrow);
		bool toggleShoot = Input.GetKeyDown(KeyCode.Space);

		// Set rotation
		if (left) {
			transform.Rotate(Vector3.forward * Time.deltaTime * _rotationSpeed);
		}
		else if(right) {
			transform.Rotate(Vector3.back * Time.deltaTime * _rotationSpeed);
		}

		// Set speed
		GetComponent<Rigidbody2D>().velocity = transform.up * _moveSpeed;

		// Camera follow
		Vector3 pos = transform.position;
		pos.z = -10;
		Camera.main.transform.position = pos;
	}
}
