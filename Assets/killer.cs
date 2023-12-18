using System.Collections;
using System.Collections.Generic;
using Unity.LEGO.Game;
using Unity.LEGO.Minifig;
using UnityEngine;

public class killer : MonoBehaviour
{
    Rigidbody m_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();

    }

 

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            var minifigController = other.GetComponent<MinifigController>();
            if (minifigController)
            {
                minifigController.Explode();
            }

            GameOverEvent evt = Events.GameOverEvent;
            evt.Win = false;
            EventManager.Broadcast(evt);
        }
    }
}
