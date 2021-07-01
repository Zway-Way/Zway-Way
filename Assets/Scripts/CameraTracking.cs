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
        //Debug.Log("offest is + " + offset);
    }
}

//public Transform target;

//public float lerpSpeed = -0.06f;

//public float zOffset = -7.33f;

//public float yPos = 2.1f;

//#region Monobehaviour API

//void LateUpdate()
//{
//    var currentPosition = transform.position;

//    var targetPosition = new Vector3(target.position.x, yPos + target.position.y, target.position.z + zOffset);

//    transform.position = Vector3.Lerp(currentPosition, targetPosition, Time.deltaTime * lerpSpeed);
//}

//    #endregion
//}
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