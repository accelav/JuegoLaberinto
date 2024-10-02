using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotador : MonoBehaviour
{
    [SerializeField]
    float rotacionY = 10f;
    void Update()
    {
        transform.Rotate(0.00f, rotacionY * Time.deltaTime, 0f);
    }
}
