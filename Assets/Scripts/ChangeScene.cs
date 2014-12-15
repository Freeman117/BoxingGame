using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

    public float TimeToChange = 10;

    public int LevelToLoad = -1;

    private float time = 0;
	// Use this for initialization
	void Start () {
        if (LevelToLoad == -1)
        {
            Debug.Log("Please set the level to load");
            enabled = false;
        }
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;

        if (time > TimeToChange)
            Application.LoadLevel(LevelToLoad);
	}
}
