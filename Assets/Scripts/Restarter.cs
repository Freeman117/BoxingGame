using UnityEngine;
using System.Collections;

public class Restarter : MonoBehaviour {

    public GameObject EndScreen;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (rigidbody.IsSleeping())
            EndScreen.SetActive(true);
	}
}
