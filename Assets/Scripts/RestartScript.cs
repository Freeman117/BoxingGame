using UnityEngine;
using System.Collections;

public class RestartScript : MonoBehaviour {

    public GameObject restartText;
    public float restartTime = 10;

    private float timer = 0;
    private GUIText restart;

	// Use this for initialization
	void Start () {
        restart = restartText.GetComponent<GUIText>();
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        restart.text = string.Format("Restarting in: {0:F}", restartTime - timer);

        if (timer >= restartTime)
            Application.LoadLevel(Application.loadedLevel);
	}
}
