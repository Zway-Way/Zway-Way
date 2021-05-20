using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private Vector3 offset = new Vector3(-10.02f,1.88f,-6.26f);


    // Update is called once per frame
    void Update()
    {
        transform.position = ball.transform.position + offset;
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