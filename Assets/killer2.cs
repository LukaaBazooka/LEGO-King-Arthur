using System.Collections;
using System.Collections.Generic;
using Unity.LEGO.Game;
using Unity.LEGO.Minifig;
using UnityEngine;

public class killer2 : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public CollideHit hit;
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
            if (minifigController || hit.kills == true )
            {
                Debug.Log(hit.kills);
                minifigController.Explode();
            }

            GameOverEvent evt = Events.GameOverEvent;
            evt.Win = false;
            EventManager.Broadcast(evt);
        }
    }

}
