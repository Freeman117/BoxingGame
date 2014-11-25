using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {

    private Quaternion startRotation;

	// Use this for initialization
	void Start () {
        startRotation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = startRotation;
	}
}
