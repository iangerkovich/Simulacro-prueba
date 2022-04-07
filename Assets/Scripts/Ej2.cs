//2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos 
// y un monto de dinero disponible.Comunicar si la suma de los mismos supera o no el monto de dinero disponible.
//Luego indicar cuánto dinero sobra o falta.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour
{
    public int prod1;
    public int prod2;
    public int prod3;
    public int dinero;
    // Start is called before the first frame update
    void Start()
    {
        int sum;
        int total;
        int sobra;
        sum = prod1 + prod2 + prod3;
        total = (sum - dinero);
        sobra = (dinero - sum);

        
       if (sum > dinero)
        {
            Debug.Log("Te faltan" + total + " para comprar los 3 productos");
        }
       else
        {
            Debug.Log("Te sobran " + sobra + "pesos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
