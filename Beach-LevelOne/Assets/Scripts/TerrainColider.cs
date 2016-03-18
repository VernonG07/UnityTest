using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TerrainColider : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		Debug.Log ("Object has entered the TERRAIN");
		SceneManager.LoadScene ("Level2-ROAD");
	}

	void OnTriggerStay (Collider other) {
		Debug.Log ("Object is in the zone!");

	}

	void OnTriggerExit (Collider other) {
		Debug.Log ("Object Exited the Trigger");
	}
}
