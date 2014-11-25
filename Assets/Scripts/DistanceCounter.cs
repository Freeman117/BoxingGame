using UnityEngine;
using System.Collections;

public class DistanceCounter : MonoBehaviour {

    public GameObject PunchBag;

    private GUIText text;

	// Use this for initialization
	void Start () {
        text = GetComponent<GUIText>();
	}
	
	// Update is called once per frame
	void Update () {
        text.text = string.Format("{0} m", (int)Mathf.Abs(PunchBag.transform.position.z));
	}
}
