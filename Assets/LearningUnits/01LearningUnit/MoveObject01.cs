using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject01 : MonoBehaviour
{
    [SerializeField] Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {

    }
    

    // Update is called once per frame
    void Update()
    {
        // My position equals my position PLUS 
        // where I want to be by the end of this frame...
// When you solve the unit, write a comment in the code explaining what you did and why it worked.
        //I added the moveDirection to the current position --> moveDirection is a serializable field, so when it is negative it will move to the left
        transform.position = transform.position + moveDirection;
    }
}
