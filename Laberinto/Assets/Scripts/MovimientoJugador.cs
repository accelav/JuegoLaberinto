using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MovimientoJugador : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI textContadorColision;
    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;
    public float velocidadMovimiento = 1.5f;
    int vecesTocada = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimientoEjeX = Input.GetAxis("Horizontal") * Time.deltaTime * velocidadMovimiento;
        movimientoEjeZ = Input.GetAxis("Vertical") * Time.deltaTime * velocidadMovimiento;

        transform.Translate(movimientoEjeX, movimientoEjeY, movimientoEjeZ);

    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Paredes")
        {
            vecesTocada += 1;
            textContadorColision.text = vecesTocada.ToString();

        }
    }
}
