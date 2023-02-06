using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S2_CrearObjeto : MonoBehaviour
{
    public GameObject ubi_spawn;
    public GameObject obj_a_crear;
    int contador = 0;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            GameObject obj = Instantiate(
                obj_a_crear,
                ubi_spawn.transform.position,
                ubi_spawn.transform.rotation
                );
            //Destroy(obj,2);
            obj.name = "obj_" + contador.ToString();
            contador++;

            //Martes 31 de enero

            Destroy(obj, 5); //el objeto va a ser destruido 5 segundo despues de su creacion

        }
    }

}
