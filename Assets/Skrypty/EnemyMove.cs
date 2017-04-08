using UnityEngine;
using System.Collections;
using System.Threading;

public class EnemyMove : MonoBehaviour
{
    
    float predkosc_przeciwnika= 0.6f;
    float opoznienie_ruchu = 25f;
    float opoznienie_ruchu1 = 38f;
    float opoznienie_ruchu2 = 48f;
    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

        Ruch();
     
        Ruch2();
     
        Ruch3();

        Ruch4();  
        
        


    }

    void Ruch()
    {
        Vector2 pozycja_przeciwnika = transform.position;

        if (pozycja_przeciwnika.y >= 3f)
        {
            pozycja_przeciwnika = new Vector2(pozycja_przeciwnika.x, (pozycja_przeciwnika.y - (predkosc_przeciwnika * Time.deltaTime)));
            transform.position = pozycja_przeciwnika;
        }
    }
  void Ruch2()
    {
            opoznienie_ruchu -= Time.deltaTime;
            if (opoznienie_ruchu <= 0)
            {
           
                Vector2 pozycja_przeciwnika = transform.position;
                if (pozycja_przeciwnika.x >= 5)
                {
                    if (pozycja_przeciwnika.y >= 1f || pozycja_przeciwnika.x <= 5)
                    {
                        pozycja_przeciwnika = new Vector2(pozycja_przeciwnika.x + (predkosc_przeciwnika * Time.deltaTime), (pozycja_przeciwnika.y - (predkosc_przeciwnika * Time.deltaTime)));
                        transform.position = pozycja_przeciwnika;
                       

                    }
                }
                else if (pozycja_przeciwnika.y >= 1f && pozycja_przeciwnika.x <= 6.8)
                {
                    pozycja_przeciwnika = new Vector2(pozycja_przeciwnika.x + (predkosc_przeciwnika * Time.deltaTime), (pozycja_przeciwnika.y - (predkosc_przeciwnika * Time.deltaTime)));
                    transform.position = pozycja_przeciwnika;
                    

                }

            

            }

    
        
    }
    void Ruch3()
    {
        
            opoznienie_ruchu1 -= Time.deltaTime;
            if (opoznienie_ruchu1 <= 0)
            {
                 
                     Vector2 pozycja_przeciwnika = transform.position;
                     if (pozycja_przeciwnika.y >= -1f && pozycja_przeciwnika.x >= -8.5)
                     {
                         pozycja_przeciwnika = new Vector2(pozycja_przeciwnika.x - (predkosc_przeciwnika * Time.deltaTime), (pozycja_przeciwnika.y - (predkosc_przeciwnika * Time.deltaTime)));
                         transform.position = pozycja_przeciwnika;
                 
                     }
                            

            }
        
    }
    void Ruch4()
    {

        
        opoznienie_ruchu2 -= Time.deltaTime;
        if (opoznienie_ruchu2 <= 0)
        {
            predkosc_przeciwnika = 4;
            GetComponent<EnemyShooting>().enabled = false;
            Vector2 pozycja_przeciwnika = transform.position;
            if (pozycja_przeciwnika.y >= -9f )
            {
                pozycja_przeciwnika = new Vector2(pozycja_przeciwnika.x, (pozycja_przeciwnika.y - (predkosc_przeciwnika * Time.deltaTime)));
                transform.position = pozycja_przeciwnika;
                if(pozycja_przeciwnika.y<= -9f)
                {

                    Destroy(gameObject);
                }

            }


        }

    }

}

