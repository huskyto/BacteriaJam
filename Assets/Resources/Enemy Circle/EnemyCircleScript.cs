using UnityEngine;
using System.Collections;

public class EnemyCircleScript : MonoBehaviour {
	private int _health = 1;
	private float _shootTime = 1;
	private GameObject _bullet;

	// Use this for initialization
	void Start () {

		_bullet = Resources.Load<GameObject> ("Enemy Bullet/Enemy Bullet");
	}
	
	// Update is called once per frame
	void Update () {

		_shootTime -= Time.deltaTime;
		if (_shootTime <= 0) {
			_shootTime += 1;
			for (int i = 0; i < 12; i += 1) {
				GameObject b = Instantiate (_bullet);
				b.transform.position = transform.position;
				b.transform.rotation = Quaternion.AngleAxis (i * 30, Vector3.forward);
			}
		}
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
