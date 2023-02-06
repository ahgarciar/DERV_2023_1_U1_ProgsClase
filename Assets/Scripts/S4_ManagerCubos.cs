using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S4_ManagerCubos : MonoBehaviour
{
    public List<GameObject> cubos;
    public GameObject ubi_spawn;
    public GameObject obj_a_crear;    

    // Start is called before the first frame update
    void Start()
    {        
        int i = 0;
        for (; i < 100; i++) {
            GameObject obj = Instantiate(
               obj_a_crear               
               );

            obj.transform.position = ubi_spawn.transform.position;
            obj.transform.rotation = ubi_spawn.transform.rotation;

            obj.name = "obj_" + i.ToString();
            obj.SetActive(false);
            cubos.Add(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
