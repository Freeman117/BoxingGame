using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour {

    public GameObject followCamera;
    public GameObject distanceText;
    public GameObject timerTextObject;
    public GameObject mainCamera;

    public float LaunchTime = 5;
    private ForceCounter forceCounter;
    private GUIText timerText;
    private Restarter restarter;
    private float time = 0;

	// Use this for initialization
	void Start () {
        forceCounter = GetComponent<ForceCounter>();
        timerText = timerTextObject.GetComponent<GUIText>();
        restarter = GetComponent<Restarter>();
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        timerText.text = string.Format("Time Left: {0:F} s", LaunchTime - time);

        if(time > LaunchTime)
        {
            timerTextObject.SetActive(false);
            Launch();
            restarter.enabled = true;
            enabled = false;
        }

	}

    void Launch()
    {
        rigidbody.isKinematic = false;
        rigidbody.useGravity = true;

        Vector3 forceVector = new Vector3(0, forceCounter.force*0.5f,
            -forceCounter.force*2);
        rigidbody.AddForce(forceVector);

        followCamera.SetActive(true);
        mainCamera.SetActive(false);
        distanceText.SetActive(true);
    }
}
