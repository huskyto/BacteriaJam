using UnityEngine;
using System.Collections;

public class EnemyKamikazeScript : MonoBehaviour {
	public Transform target;
	private float _speed = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards (transform.position, target.position, _speed * Time.deltaTime);
	}
}
