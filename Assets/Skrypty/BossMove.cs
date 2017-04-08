using UnityEngine;
using System.Collections;

public class BossMove : MonoBehaviour
{
    public float predkosc_bossa;
    public float predkosc_obrotu;
   
    bool rusz=true, rusz1=false;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector2 pozycja_przeciwnika = transform.position;
        Ruch();
        transform.Rotate(0, 0, 5 * predkosc_obrotu * Time.deltaTime);
        if((pozycja_przeciwnika.x>=4.8) || (pozycja_przeciwnika.x>=-4.5))
        {
            Ruch2();
        }
        if((pozycja_przeciwnika.x <= -4.5) || (pozycja_przeciwnika.x <= 4.8))
        {
            Ruch3();
        }

    }
    void Ruch()
    {
        Vector2 pozycja_przeciwnika = transform.position;

        if (pozycja_przeciwnika.y >= 2.6f)
        {
        
            pozycja_przeciwnika = new Vector2(pozycja_przeciwnika.x, (pozycja_przeciwnika.y - (predkosc_bossa * Time.deltaTime)));
            transform.position = pozycja_przeciwnika;
        }
    }
    void Ruch2()
    {
        if(rusz==true)
        {

            Vector2 pozycja_przeciwnika = transform.position;
           
            pozycja_przeciwnika = new Vector2((pozycja_przeciwnika.x- (predkosc_bossa * Time.deltaTime)),pozycja_przeciwnika.y);
            transform.position = pozycja_przeciwnika;
            if(pozycja_przeciwnika.x <= -4.5)
            {
                rusz = false;
                rusz1 = true;
            }
        }
             
    }
    void Ruch3()
    {
        if (rusz1 == true)
        {
            Vector2 pozycja_przeciwnika = transform.position;
            
            pozycja_przeciwnika = new Vector2((pozycja_przeciwnika.x + (predkosc_bossa * Time.deltaTime)), pozycja_przeciwnika.y);
            transform.position = pozycja_przeciwnika;
            if(pozycja_przeciwnika.x >= 4.8)
            {
                rusz = true;
                rusz1 = false;
            }
        }

        
    }

}
