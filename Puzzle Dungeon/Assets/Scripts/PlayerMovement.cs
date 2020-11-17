using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovementLoop();
    }

    private void MovementLoop()
    {
        if (Input.GetButtonDown("Forward"))
        {
            this.transform.position += new Vector3(0,1,0);
        }

        if (Input.GetButtonDown("Backward"))
        {
            this.transform.position -= new Vector3(0,1,0);
        }

        if (Input.GetButtonDown("Right"))
        {
            this.transform.position += Vector3.right;
        }

        if (Input.GetButtonDown("Left"))
        {
            this.transform.position += Vector3.left;
        }

    }


}
