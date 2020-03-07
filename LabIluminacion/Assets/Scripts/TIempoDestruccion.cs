using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIempoDestruccion : MonoBehaviour
{

    public float tiempoDestruccion = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,tiempoDestruccion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
