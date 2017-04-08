using UnityEngine;
using System.Collections;

public class StartGenerator : MonoBehaviour
{
    
    public GameObject obrazek_gwaizdy;
    public int max_ilosc_gwaizd;
    Color[] tablica_kolorow_gwiazdy =
    {
        //niebieski
         new Color (0.5f,0.5f,1f),
        //zielony
         new Color (0,1f,1f),
        //zolty
         new Color (1f,1f,0),
        //czerwony
         new Color (1f,0,0),    
    };

	// Use this for initialization
	void Start ()
    {
	 
        for(int i=0; i< max_ilosc_gwaizd; i++)
        {
            GameObject gwiazda = (GameObject)Instantiate(obrazek_gwaizdy);
            // ustawia kolor gwiazdy
            gwiazda.GetComponent<SpriteRenderer>().color = tablica_kolorow_gwiazdy[i % tablica_kolorow_gwiazdy.Length];
            // ustawienie pozycji gwiazdy
            //Vector2 pozycja = obrazek_gwaizdy.transform.position;
            gwiazda.transform.position = new Vector2(Random.Range(-8, 8), Random.Range(-8, 8));
            gwiazda.GetComponent<Star>().predkosc_gwiazdy = 1f * Random.value + 0.5f;
            gwiazda.transform.parent = transform;
            
        }

	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
