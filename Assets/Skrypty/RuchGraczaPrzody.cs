using UnityEngine;
using System.Collections;

public class RuchGraczaPrzody : MonoBehaviour
{
     float predkosc_gracza = 1.2f;
    bool rusz = true, rusz1 = true, rusz2 = false;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector2 pozycja = transform.position;
        if (pozycja.x >= 0)
        {
            Ruch2();
            Ruch3();
        }
        else if (pozycja.x <=0)
        {
            Ruch();
            Ruch3();
        } 
	}

    void Ruch()
    {
        if (rusz == true)
        {
        Vector2 pozycja = transform.position;
        Quaternion rotacja = transform.rotation;
        rotacja.z = 0;
        transform.rotation = rotacja;
        pozycja = new Vector2 (pozycja.x+(predkosc_gracza*Time.deltaTime), pozycja.y);
        transform.position = pozycja;
            if(pozycja.x >= 0)
            {
                rusz = false;
                rusz2 = true;
            }
        }

    }
    void Ruch2()
    {
        if (rusz1 == true)
        {
            Vector2 pozycja = transform.position;
            Quaternion rotacja = transform.rotation;
            rotacja.z = 0;
            transform.rotation = rotacja;
            pozycja = new Vector2(pozycja.x - (predkosc_gracza * Time.deltaTime), pozycja.y);
            transform.position = pozycja;
            if (pozycja.x <= 0)
            {
                rusz1 = false;
                rusz2 = true;
            }
        }

    }

    void Ruch3()
    {
        if (rusz2 == true)
        {
            Vector2 pozycja = transform.position;

            pozycja = new Vector2(pozycja.x, pozycja.y + (predkosc_gracza * Time.deltaTime));
            transform.position = pozycja;
            if(pozycja.y>=4.2)
            {
                rusz2 = false;
            }
           
        }

    }

}
