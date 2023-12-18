using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinner : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0,100 * Time.deltaTime,0); //rotates 50 degrees per second around z axis
    }
}
