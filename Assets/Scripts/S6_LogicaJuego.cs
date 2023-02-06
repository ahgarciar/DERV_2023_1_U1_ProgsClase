using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S6_LogicaJuego : MonoBehaviour
{
    List<string> nombre_colores;
    List<string> nombre_materiales;

    [SerializeField] TextMeshProUGUI texto_color;

    // Start is called before the first frame update
    void Start()
    {
        nombre_colores = new List<string>();
        nombre_colores.Add("Azul");
        nombre_colores.Add("Amarillo");
        nombre_colores.Add("Rojo");

        nombre_materiales = new List<string>();
        nombre_materiales.Add("color1");
        nombre_materiales.Add("color2");
        nombre_materiales.Add("color3");

        int indice = Random.Range(0, nombre_colores.Count); //1;

        texto_color.text = nombre_colores[indice];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
