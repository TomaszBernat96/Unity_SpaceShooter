using UnityEngine;
using System.Collections;

public class Planet : MonoBehaviour
{
    public float predkosc_planety;
    public float odleglosc_planety;
    public bool ruch=false;

	// Use this for initialization
	void Start ()
    {	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
        if(!ruch)
        {
            Vector2 pozycja_planety = transform.position;

            pozycja_planety = new Vector2(pozycja_planety.x, (pozycja_planety.y - (predkosc_planety * Time.deltaTime)));

            transform.position = pozycja_planety;

            if(pozycja_planety.y < -8)
            {
                ZresetujPozycjePlanety();
            }
        }
	}
    public void ZresetujPozycjePlanety()
    {
        transform.position = new Vector2(Random.Range(-8, 8), odleglosc_planety);
    }

}
