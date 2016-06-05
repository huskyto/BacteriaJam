using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	private const int _moveSpeed = 3;
	private const int _rotationSpeed = 360;
	private float _angle = 0.0f;
	private GameObject _bullet;
	private Rigidbody2D _rigidbody2D;

	// Use this for initialization
	void Start () {
		_rigidbody2D = GetComponent<Rigidbody2D> ();
		_rigidbody2D.AddForce (new Vector2 (0, 100));

		_bullet = Resources.Load<GameObject> ("Player Bullet/Player Bullet");
	}
	
	// Update is called once per frame
	void Update () {
		// Get inputs
		bool left = Input.GetKey(KeyCode.LeftArrow);
		bool right = Input.GetKey(KeyCode.RightArrow);
		bool toggleShoot = Input.GetKeyDown(KeyCode.Space);

		// Set rotation
		if (left) {
			_angle += Time.deltaTime * _rotationSpeed;
		}
		else if(right) {
			_angle -= Time.deltaTime * _rotationSpeed;
		}
		//transform.rotation = Quaternion.AngleAxis (_angle, Vector3.forward);

		// Set speed
		_rigidbody2D.velocity = new Vector2 (-Mathf.Sin(_angle * Mathf.Deg2Rad) * _moveSpeed, Mathf.Cos(_angle * Mathf.Deg2Rad) * _moveSpeed); //transform.up * _moveSpeed;

		// Shoot
		if (toggleShoot) {
			GameObject b = Instantiate (_bullet);
			b.transform.position = transform.position;
			b.transform.rotation = Quaternion.AngleAxis (_angle, Vector3.forward);
		}

		// Camera follow
		Vector3 pos = transform.position;
		pos.z = -10;
		Camera.main.transform.position = pos;
	}
}
