using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luz : MonoBehaviour
{
    public GameObject linterna;
    private bool activo;
    public GameObject sonidoEncendedor;
    
    // Start is called before the first frame update
    void Start()
    {
        linterna.SetActive(false);
        activo = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            if (activo)
            {
                Instantiate(sonidoEncendedor);
                linterna.SetActive(false);
                activo = false;
               
            }
            else
            {
                 Instantiate(sonidoEncendedor);
                linterna.SetActive(true);
                activo = true;
               
            }
        }
    }
}
