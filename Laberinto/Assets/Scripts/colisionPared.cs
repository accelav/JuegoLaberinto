using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionPared : MonoBehaviour
{
    [SerializeField]
    Material MaterialPorDefecto;
    [SerializeField]
    Material MaterialParedTocada;

    bool paredRoja = false;

    float tiempoEnRojo = 1f;
    private void Update()
    {
        if (paredRoja == true)
        {
            
            tiempoEnRojo = tiempoEnRojo - Time.deltaTime;
            if (tiempoEnRojo < 0.0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = MaterialPorDefecto;
                paredRoja = false;
                tiempoEnRojo = 1f;
            }
            
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log(col.gameObject.name);
            gameObject.GetComponent<MeshRenderer>().material = MaterialParedTocada;
            paredRoja = true;

        }
    }
}
