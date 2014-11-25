using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour {

    public GameObject followCamera;
    public GameObject distanceText;
    public GameObject mainCamera;

    public float LaunchTime = 5;
    private ForceCounter forceCounter;
    private float time = 0;

	// Use this for initialization
	void Start () {
        forceCounter = GetComponent<ForceCounter>();
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;

        if(time > LaunchTime)
        {
            Launch();
            enabled = false;
        }

	}

    void Launch()
    {
        rigidbody.isKinematic = false;
        rigidbody.useGravity = true;

        Vector3 forceVector = new Vector3(0, forceCounter.force,
            -forceCounter.force);
        rigidbody.AddForce(forceVector);

        followCamera.SetActive(true);
        mainCamera.SetActive(false);
        distanceText.SetActive(true);
    }
}
