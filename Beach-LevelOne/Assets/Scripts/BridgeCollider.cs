using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BridgeCollider : MonoBehaviour {
	void OnTriggerEnter(Collider other) {
		Debug.Log ("Object has entered the bridge, change footsteps");

	}

	void OnTriggerStay (Collider other) {
		Debug.Log ("Object is in the zone!");

	}

	void OnTriggerExit (Collider other) {
		Debug.Log ("Object Exited the Trigger");
	}
}
