using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stun_Njinja : MonoBehaviour
{
    public Behaviour move;
    public GameObject missile;
    public float tempsStun = 1f;
    public float tempSecondes = 1f;
    public bool touche = false;
    public float duréeStun = 0f;



    // Use this for initialization
    void Start()
    {
        duréeStun = tempsStun;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "stun")
        {
            move.enabled = false;
            touche = true;
            Debug.Log("Il y a eu collision");

        }

    }
    void Update()
    {
        if (touche == true)
        {
            //Returnattente();
            Debug.Log("On est dans le if touche");
            touche = false;
            Debug.Log("Le move est retabli");
            move.enabled = true;
            tempsStun = duréeStun;
            tempSecondes = 0;
        }



    }

    ////Here is what my friend did, so I don't understand anything...

    //IEnumerator attente()
    //{
    //    yield return new WaitForSeconds(3);
    //}

    //private void Returnattente()
    //{
    //    yield return attente;
    //}
}
