using System;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float playerHp =1000;
    public Rigidbody rb;
    public int x;
    void Start()
    {
       // TestThrow();
        TestTry();

        x = 10;

    }
    public void TestThrow()
    {
        if (playerHp >= 999)
        {
            throw new Exception("Filthy cheater!!!!!");
        }
    }
    public void TestTry()
    {
        try
        {
            rb.AddForce(Vector2.one, ForceMode.Impulse);
        }
        catch (NullReferenceException ex)
        {
            print("se intento usar el rb " + ex);
        }
        catch (Exception ex)
        {
            print(ex);
        }
        finally
        {
            print("Se intento ejecutar el codigo");
        }
    }

 
}
