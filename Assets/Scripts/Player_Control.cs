using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosLeft = transform.position;
        if (Input.GetKey(KeyCode.D))
        {
            newPosLeft.x += 0.01f;
        }
        transform.position = newPosLeft;

        Vector3 newPosRight = transform.position;
        if (Input.GetKey(KeyCode.A))
        {
            newPosRight.x -= 0.01f;
        }
        transform.position = newPosRight;

        Vector3 newPosUp = transform.position;
        if (Input.GetKey(KeyCode.W))
        {
            newPosUp.z += 0.01f;
        }
        transform.position = newPosUp;

        Vector3 newPosDown = transform.position;
        if (Input.GetKey(KeyCode.S))
        {
            newPosDown.z -= 0.01f;
        }
        transform.position = newPosDown;
    }
}
