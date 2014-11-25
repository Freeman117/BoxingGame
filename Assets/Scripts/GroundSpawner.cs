using UnityEngine;
using System.Collections;

public class GroundSpawner : MonoBehaviour {

    public GameObject prefab;
    public int Amount = 10;

	// Use this for initialization
	void Start () {

        var spawnPos = -prefab.renderer.bounds.size.z;

        for (int i = 0; i < Amount; i++)
        {
            var go = (GameObject)Instantiate(prefab,
                new Vector3(0, 0, spawnPos * i + spawnPos / 2), prefab.transform.rotation);
            go.transform.parent = transform;

            var text = go.GetComponentInChildren<TextMesh>();
            text.text = string.Format("{0} m", (i+1) * 100);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
