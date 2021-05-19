using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {

    }
    private Vector3 offset = new Vector3(0, 5, -7);
    // Update is called once per frame
    void Update()
    {
        // update the camerea to be behind the players vehicle
        transform.position = Player.transform.position + offset;
    }
}