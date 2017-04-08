using UnityEngine;
using System.Collections;

public class KolizjaBoss : MonoBehaviour
{
    public int zycie;
    GameObject referencja_do_wyniku;
    public GameObject referencja_do_postaci;
    public GameObject ekspolozja;
    GameObject[] zwyciestwo_tab;

    // Use this for initialization
    void Start ()
    {
        referencja_do_wyniku = GameObject.FindGameObjectWithTag("punkt");
        referencja_do_postaci = GameObject.FindGameObjectWithTag("StatekGracza");
        zwyciestwo_tab = GameObject.FindGameObjectsWithTag("zwyciestwo");
        WylaczKoniec();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (zycie <= 0)
        {
            Zniszcz();
        }
    }
    void OnTriggerEnter2D(Collider2D kolizja)
    {
        if (kolizja.tag == "PociskGracza")
        {
            referencja_do_wyniku.GetComponent<AktualizacjaWyniku>().Punkt += 25;
            Animacja();
            zycie--;
        }
    }
    void Zniszcz()
    {
        Destroy(gameObject);
        referencja_do_postaci.GetComponent<PlayerMovement>().enabled = false;
        referencja_do_postaci.GetComponent<PlayerShooting>().enabled = false;
        referencja_do_postaci.GetComponent<RuchGraczaPrzody>().enabled = true;
        WlaczKoniec(); 
        referencja_do_wyniku.GetComponent<AktualizacjaWyniku>().Punkt += 5000;
    }
    void Animacja()
    {
        GameObject wybuch = (GameObject)Instantiate(ekspolozja);
        wybuch.transform.position = transform.position;
    }
    void WlaczKoniec()
    {
        foreach (GameObject zwyciestwo_kontener in zwyciestwo_tab)
        {
            zwyciestwo_kontener.SetActive(true);
        }
    }

    void WylaczKoniec()
    {
        foreach (GameObject zwyciestwo_kontener in zwyciestwo_tab)
        {
            zwyciestwo_kontener.SetActive(false);
        }

    }
}
