using UnityEngine;
using System.Collections;


public class ForceCounter : MonoBehaviour {

    public GameObject followCamera;
    public GameObject mainCamera;

    private float forceSum = 1000;
    private float time = 0;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Force " + forceSum);
        time += Time.deltaTime;
        if(time > 2)
        {
            rigidbody.isKinematic = false;
            rigidbody.useGravity = true;
            Vector3 forceVector = new Vector3(0, forceSum, -forceSum);
            rigidbody.AddForce(forceVector);
            followCamera.SetActive(true);
            mainCamera.SetActive(false);
            this.enabled = false;
            time = 0;
        }
        Debug.Log("Time " + time);
	}

	void OnCollisionEnter(Collision collision)
	{
        forceSum += collision.relativeVelocity.magnitude * 100;
	}
}
