using UnityEngine;
using System.Collections;

public class PlayerBulletScript : MonoBehaviour {
	private float _lifeTime = 2;
	private Rigidbody2D _rigidbody2D;

	// Use this for initialization
	void Start () {
		_rigidbody2D = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		_rigidbody2D.velocity = transform.up * 10;

		_lifeTime -= Time.deltaTime;
		if (_lifeTime <= 0) {
			Destroy (gameObject);
		}
	}
}
