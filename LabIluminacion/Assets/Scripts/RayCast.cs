using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RayCast : MonoBehaviour
{
    private Camera camara;
    public GameObject texto;
    
    // Start is called before the first frame update
    void Start()
    {
        camara = GetComponent<Camera>();
        texto.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        
        Ray ray = camara.ScreenPointToRay(Input.mousePosition);
        
        
        if (Physics.Raycast(ray, out hit)) {
            if (hit.transform.tag.Equals("objeto")){
                texto.SetActive(true);
                texto.GetComponent<Text>().text = hit.transform.name;
               
            }else{
                texto.SetActive(false);
            }
            
        }
    }
}
