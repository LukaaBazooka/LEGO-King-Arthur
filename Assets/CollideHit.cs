using System.Collections;
using System.Collections.Generic;
using Unity.LEGO.Game;
using UnityEngine;


namespace Unity.LEGO.Minifig
{
    public class CollideHit : MonoBehaviour
    {
        public AudioSource audioSource;
        Rigidbody m_Rigidbody;

        public GameObject myPrefab;
        public GameObject Spinner;
        public GameObject sphere;
        public GameObject lava;
        public bool kills = true;
        void Start()
        {
            m_Rigidbody = GetComponent<Rigidbody>();

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Floor")
            {
                StartCoroutine(poosock());



            }
        }
   
        public IEnumerator poosock()
        {
            kills = true;
            m_Rigidbody.constraints = RigidbodyConstraints.FreezePosition;
            audioSource.Play();
            sphere = Instantiate(myPrefab, gameObject.transform.position - new Vector3(0, 5, 0), Quaternion.identity);
            GameObject Impact = Instantiate(Spinner, gameObject.transform.position + new Vector3(0, -1, 0), Quaternion.identity);
            gameObject.transform.position += new Vector3(0, 10000, 0);

            LeanTween.scale(Impact, new Vector3(28, 5, 28), 1.5f).setEaseOutQuart(); LeanTween.scale(sphere, new Vector3(30, 30, 30), 1.5f).setEaseOutQuart();
            LeanTween.alpha(sphere, 0f, 1.5f);
            LeanTween.alpha(Impact, 0f, 2f).setEaseInOutQuad();
            yield return new WaitForSeconds(1.6f);
            kills = false;

            DestroyImmediate(sphere);
            yield return new WaitForSeconds(.7f);
            DestroyImmediate(Impact);
            DestroyImmediate(sphere);

            yield return new WaitForSeconds(.5f);
            DestroyImmediate(sphere);

            DestroyImmediate(gameObject);
        }
    

    }
}



