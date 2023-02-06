using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S5_CambiaColor : MonoBehaviour
{
    [SerializeField] List<Material> materials;
    int cont;

    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        cont = 0;
        rend.material = materials[cont++];
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.G))
        {
            rend.material = materials[cont++];
            cont = cont % 3;
        }

    }
}
