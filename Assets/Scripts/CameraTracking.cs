using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    public GameObject ball;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector3(-0.06f, 2.1f, -7.33f);
        transform.position = ball.transform.position + offset;
    }
}