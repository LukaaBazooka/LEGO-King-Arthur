using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    Rigidbody m_Rigidbody;



    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();

    }
    void Update()
    {
        StartCoroutine(Moverr());
    }

    public IEnumerator Moverr()
    {
        transform.position += new Vector3(0, 0, 0.03f);
        yield return new WaitForSeconds(0.1f);
    }
}
