using UnityEngine;
using System.Collections;

public class LookToSound : MonoBehaviour {

	private bool canPlayAudio = false;

	void OnTriggerEnter(Collider other) {
		if (canPlayAudio) {
			canPlayAudio = false;
			audio.Play();
		}
	}

	void OnTriggerExit(Collider other) {
		canPlayAudio = true;
	}
}
