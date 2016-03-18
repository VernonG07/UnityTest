using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OceanCollider : MonoBehaviour {
	void OnTriggerEnter(Collider other) {
		Debug.Log ("Object has entered the Ocean zone");
	}

	void OnTriggerStay (Collider other) {
		Debug.Log ("Object is in the zone!");

	}

	void OnTriggerExit (Collider other) {
		Debug.Log ("Object Exited the Trigger");
	}
}

