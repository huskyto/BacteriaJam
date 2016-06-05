using UnityEngine;
using System.Collections;

public class BgmScript : MonoBehaviour {
	private AudioSource _audioSource;
	private bool _isIntro = true;

	// Use this for initialization
	void Start () {
		_audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (_isIntro && !_audioSource.isPlaying) {
			_isIntro = false;
			_audioSource.clip = Resources.Load<AudioClip> ("BGM/bacterock-loop");
			_audioSource.loop = true;
			_audioSource.Play ();
		}
	}
}
