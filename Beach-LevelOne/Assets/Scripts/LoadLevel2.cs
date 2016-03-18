using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadLevel2 : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		Debug.Log ("Object has entered the final zone");
		SceneManager.LoadScene ("Level2-ROAD");
	}

	void OnTriggerStay (Collider other) {
		Debug.Log ("Object is in the zone!");

	}

	void OnTriggerExit (Collider other) {
		Debug.Log ("Object Exited the Trigger");
	}
}
