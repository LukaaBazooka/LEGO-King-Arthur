using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using UnityEngine;

public class Lavawave : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject lavawave;

    Rigidbody m_Rigidbody;



    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        StartCoroutine(LavaWave());
    }
    public IEnumerator LavaWave()
    {
        yield return new WaitForSeconds(Random.Range(20f, 40f));

        while (true)
        {


            GameObject lava = Instantiate(lavawave, new Vector3(101, -99.5f, -71.1999969f), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(30f, 40f));


        }
    }
}