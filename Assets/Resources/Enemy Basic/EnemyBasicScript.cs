using UnityEngine;
using System.Collections;

public class EnemyBasicScript : MonoBehaviour {
	private int _health = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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
