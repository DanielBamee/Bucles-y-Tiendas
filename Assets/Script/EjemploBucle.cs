using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploBucle : MonoBehaviour
{
    public int[] arrayNumeros;

    // Start is called before the first frame update
    void Start()
    {
        float min = 10.0f;
        float max = 0.0f;
        int sumaDeNotas = 0;
        for (int i = 0; i < arrayNumeros.Length; i++)
        {
            //Debug.Log("Nota en el ejercicio" + i + " = " + arrayNumeros[i]);
            //Debug.Log (arrayNumeros.Length);
            Debug.Log("Esta es la nota máxima: " + max + "y esta es la nota minima: " + min);
            sumaDeNotas += arrayNumeros[i];

            if (arrayNumeros[i] > max)
            {
                max = arrayNumeros[i];
            }
            if (arrayNumeros[i] < min)
            {
                min = arrayNumeros[i];
            }
        }
        int notaMedia = sumaDeNotas / arrayNumeros.Length;
        Debug.Log("Nota Media: " + notaMedia);
    }
}
