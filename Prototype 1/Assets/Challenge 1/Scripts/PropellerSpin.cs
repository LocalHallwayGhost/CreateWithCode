using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    //Initialize variable
    private float turnSpeed = 0.9f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Spin the propeller 
        transform.Rotate(Vector3.forward, turnSpeed);
    }
}
