using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Initialize variables
    public GameObject player;
    private Vector3 offset = new Vector3(0, 6, -9);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Follow player with camera
        transform.position = player.transform.position + offset;
    }
}
