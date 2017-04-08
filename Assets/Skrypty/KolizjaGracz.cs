using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class KolizjaGracz : MonoBehaviour
{
   
    public GameObject ekspolozja;
    GameObject[] tab_obiektow;
    GameObject[] tarcza;
    public GameObject czy_koniec;
    public GameObject czy_przeciwnik;
    GameObject referencja_do_wyniku;
    GameObject[] koniec_tab;
    public Text punkciki;
    int zycie;
    const int max_zycie = 6;
    int warstwa;
    public int opoznienie;
    float czas_opoznienie_obrazen;
    public int opoznienie_tarczy;
    float czas_tarczy;

    public void Wyswietl_punkty()
    {
        zycie = max_zycie;
        punkciki.text = zycie.ToString();
    }

    // Use this for initialization
    void Start ()
    {
        Wyswietl_punkty();
        tab_obiektow = GameObject.FindGameObjectsWithTag("Dzialko");
        tarcza = GameObject.FindGameObjectsWithTag("Tarcza");
        koniec_tab = GameObject.FindGameObjectsWithTag("koniec");
        referencja_do_wyniku = GameObject.FindGameObjectWithTag("punkt");
        WylaczKoniec();
        WylaczDzialka();
        WylaczTarcze();
        warstwa = gameObject.layer;	
	}
	
	// Update is called once per frame
	void Update ()
    {
        czas_tarczy -= Time.deltaTime;
        if(czas_tarczy <= 0)
        {
            WylaczTarcze();
        }

        czas_opoznienie_obrazen -= Time.deltaTime;
        if (czas_opoznienie_obrazen <= 0)
        {
            gameObject.layer = warstwa;
        }
        if(zycie<=0)
        {
            Zniszcz();
        }

    }
    void OnTriggerEnter2D(Collider2D kolizja)
    {
        if ((kolizja.tag == "Skala") || (kolizja.tag == "PociskPrzeciwnika"))
        {
            zycie--;
            punkciki.text = zycie.ToString();
            gameObject.layer = 10;
            WylaczDzialka();
            Animacja();
          
            czas_opoznienie_obrazen = opoznienie;
        }
        if(kolizja.tag == "Ulepszenie_Czerwone_tarcza")
        {
            WlaczTarcze();
            czas_tarczy = opoznienie_tarczy;
        }
        if (kolizja.tag == "Ulepszenie_Czerwone_punkty")
        {
            referencja_do_wyniku.GetComponent<AktualizacjaWyniku>().Punkt += 200;
        }
        if (kolizja.tag == "Ulepszenie_Czerwone_ulepszenie")
        {
            WlaczDzialka();
        }
    }
    void Zniszcz()
    {
        czy_przeciwnik.GetComponent<EnemySpawn>().enabled = false;
        czy_koniec.GetComponent<KolejnaScena>().enabled = false;
        WlaczKoniec();
        Destroy(gameObject);
    }
    void Animacja()
    {
        GameObject wybuch = (GameObject)Instantiate(ekspolozja);
        wybuch.transform.position = transform.position;
    }

    void WlaczDzialka()
    {
        foreach (GameObject dzialko_kontener in tab_obiektow)
        {
            dzialko_kontener.SetActive(true);
        }
    }

     void WylaczDzialka()
    {
        foreach (GameObject dzialko_kontener in tab_obiektow)
        {
            dzialko_kontener.SetActive(false);
        }

    }
    void WlaczTarcze()
    {
        foreach (GameObject tarcza_kontener in tarcza)
        {
            tarcza_kontener.SetActive(true);
        }
    }

    void WylaczTarcze()
    {
        foreach (GameObject tarcza_kontener in tarcza)
        {
            tarcza_kontener.SetActive(false);
        }

    }
    void WlaczKoniec()
    {
        foreach (GameObject koniec_kontener in koniec_tab)
        {
            koniec_kontener.SetActive(true);
        }
    }

    void WylaczKoniec()
    {
        foreach (GameObject koniec_kontener in koniec_tab)
        {
            koniec_kontener.SetActive(false);
        }

    }

}
