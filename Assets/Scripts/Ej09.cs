//9. Realizá un programa que resuelva el siguiente problema:  
//Tres personas aportan diferente capital a una sociedad.
//Se desea saber qué porcentaje del total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del 
//total aportado  por las tres.
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego  mostrar lo pedido 
//en el siguiente formato:  
//Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ …. 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej09 : MonoBehaviour
{
    public string nombre1, nombre2, nombre3;
    public float capital1, capital2, capital3;
    float porcentaje1, porcentaje2, porcentaje3;
    float total;

    void Start()
    {
        total = capital1 + capital2 + capital3;
        porcentaje1 = (capital1 * 100) / total;
        porcentaje2 = (capital2 * 100) / total;
        porcentaje3 = (capital3 * 100) / total;

        Debug.Log("Nombre: " + nombre1 + " capital aportado: $" + capital1 + " Porcentaje del capital: %" + porcentaje1 + " Monto total aportado: $" +total);
        Debug.Log("Nombre: " + nombre2 + " capital aportado: $" + capital2 + " Porcentaje del capital: %" + porcentaje2 + " Monto total aportado: $" + total);
        Debug.Log("Nombre: " + nombre3 + " capital aportado: $" + capital3 + " Porcentaje del capital: %" + porcentaje3 + " Monto total aportado: $" + total);
    }

   
    void Update()
    {
        
    }
}
