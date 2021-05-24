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
        Debug.Log("offest is + " + offset);
    }
}


//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//public class FollowPlayer : MonoBehaviour
//{
//    public GameObject Player;
//    // Start is called before the first frame update
//    void Start()
//    {

//    }
//    private Vector3 offset = new Vector3(0, 5, -7);
//    // Update is called once per frame
//    void Update()
//    {
//        // update the camerea to be behind the players vehicle
//        transform.position = Player.transform.position + offset;
//    }
//}