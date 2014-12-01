using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour
{

    private Quaternion startRotation;

    // Use this for initialization
    void Start()
    {
        startRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = startRotation;
        transform.position = new Vector3(-transform.parent.position.y*1.2f-10, transform.parent.position.y/2+1, transform.parent.position.z);
    }
}
