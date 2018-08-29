using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateIndiv : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (Random.Range(0.0f, 15.0f), Random.Range(0.0f, 30.0f), Random.Range(0.0f, 45.0f)) * Time.deltaTime);
	}
}
