using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S3_Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        string nombre = collision.gameObject.name;
        //Debug.Log(nombre);

        //CLASE 31 ENERO

        GameObject obj;
        obj = GameObject.Find(nombre);

        //Clase 1 Feb

        string color_material = obj.GetComponent<Renderer>().material.name;
        Debug.Log(nombre + "  " + color_material);

        Destroy(obj);

    }


}
