using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimientoEjeX = Input.GetAxis("Horizontal") * Time.deltaTime;
        movimientoEjeZ = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(movimientoEjeX, movimientoEjeY, movimientoEjeZ);

    }
}
