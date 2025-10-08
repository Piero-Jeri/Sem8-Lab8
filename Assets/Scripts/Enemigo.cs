using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public string nombre;
    public int vida;
    public int energia;
    public int da�oAtaque = 10;

    void Start()
    {
        nombre = "Enemigo1";
        vida = 100;
        energia = 50;

        try
        {
            Atacar();
            Atacar();
            RecibirDa�o(120);
            Atacar();
        }
        catch (System.Exception e)
        {
            Debug.LogWarning("Error: " + e.Message);
        }
    }

    public void Atacar()
    {
        if (vida <= 0)
        {
            throw new System.Exception(nombre + " no puede atacar porque est� muerto.");
        }

        if (energia < 10)
        {
            throw new System.Exception(nombre + " no tiene suficiente energ�a para atacar.");
        }

        energia -= 10;
        Debug.Log(nombre + " ataca y gasta 10 de energ�a. Energ�a restante: " + energia);
    }

    public void RecibirDa�o(int cantidad)
    {
        vida -= cantidad;
        if (vida < 0) vida = 0;
        Debug.Log(nombre + " ha recibido " + cantidad + " de da�o. Vida restante: " + vida);
    }
}