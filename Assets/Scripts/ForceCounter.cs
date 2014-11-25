using UnityEngine;
using System.Collections;


public class ForceCounter : MonoBehaviour {
    public float ForceMultiplier = 10;

    private float forceSum = 1000;

    public float force
    {
        get { return forceSum; }
        set { forceSum = value; }
    }

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision collision)
	{
        forceSum += collision.relativeVelocity.magnitude * ForceMultiplier;
        Debug.Log("ForceSum " + forceSum);
	}
}
