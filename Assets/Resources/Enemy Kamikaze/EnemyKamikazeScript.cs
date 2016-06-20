using UnityEngine;
using System.Collections;

public class EnemyKamikazeScript : MonoBehaviour {
	public Transform target;
	private int _health = 1;
	private float _speed = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards (transform.position, target.position, _speed * Time.deltaTime);
	}

	void OnTriggerEnter2D (Collider2D collider2d) {
		if (collider2d.tag == "Player Ammo") {
			Destroy (collider2d.gameObject);
			_health -= 1;
			if (_health <= 0) {
				Destroy (gameObject);
			}
		}
	}
}
