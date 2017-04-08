using UnityEngine;
using System.Collections;

public class SpawnUpgradeRandomly : MonoBehaviour
{
    public GameObject obrazek_tarczy;
    public GameObject obrazek_punktow;
    public GameObject obrazek_ulepszenia;
    public int max_ilosc_tarcz;
    public int max_ilosc_punktow;
    public int max_ilosc_ulepszen;

    // Use this for initialization
    void Start ()
    {
        for (int i = 0; i < max_ilosc_tarcz; i++)
        {
            GameObject tarcza = (GameObject)Instantiate(obrazek_tarczy);
            // ustawienie pozycji gwiazdy
            //Vector2 pozycja = obrazek_gwaizdy.transform.position;
            tarcza.transform.position = new Vector2(Random.Range(-8, 8), Random.Range(50, 80));
            tarcza.GetComponent<UprodageMove>().predkosc_spadania = 1f * Random.Range(2, 3) + 0.5f;
            tarcza.transform.parent = transform;

        }
        for (int i = 0; i < max_ilosc_punktow; i++)
        {
            GameObject pkt = (GameObject)Instantiate(obrazek_punktow);
            //Vector2 pozycja = obrazek_gwaizdy.transform.position;
            pkt.transform.position = new Vector2(Random.Range(-8, 8), Random.Range(56, 80)); 
            pkt.GetComponent<UprodageMove>().predkosc_spadania = 1f * Random.Range(2, 3) + 0.5f;
            pkt.transform.parent = transform;

        }
        for (int i = 0; i < max_ilosc_ulepszen; i++)
        {
            GameObject ulepszenie = (GameObject)Instantiate(obrazek_ulepszenia);
            //Vector2 pozycja = obrazek_gwaizdy.transform.position;
            ulepszenie.transform.position = new Vector2(Random.Range(-8, 8), Random.Range(55, 80));
            ulepszenie.GetComponent<UprodageMove>().predkosc_spadania = 1f * Random.Range(2,3) + 0.5f;
            ulepszenie.transform.parent = transform;

        }



    }
	
	// Update is called once per frame
	void Update ()
    {

    }
}
