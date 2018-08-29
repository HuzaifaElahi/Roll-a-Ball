using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_Up_8_Rotate : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (Random.Range(0.0f, 90.0f), Random.Range(0.0f, 90.0f), Random.Range(0.0f, 90.0f)) * Time.deltaTime);
	}
}
