using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float orbitSpeed = .1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Update()
    {
        transform.Rotate(new UnityEngine.Vector3(0, 0, orbitSpeed)); ;
    }
}
