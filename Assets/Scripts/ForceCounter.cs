using UnityEngine;
using System.Collections;


public class ForceCounter : MonoBehaviour {
    public float ForceMultiplier = 10;

    public float StartForce = 0;

    private float forceSum;

    public float force
    {
        get { return forceSum; }
        set { forceSum = value; }
    }

	// Use this for initialization
	void Start () {
        forceSum = StartForce;
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
