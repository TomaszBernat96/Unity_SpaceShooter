using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AktualizacjaWyniku : MonoBehaviour
{
    Text tekst_wyniku;
    int wynik;

    public int Punkt
    {
        get
        {
            return this.wynik;
        }
        set
        {
            this.wynik = value;
            OdswiezWynik();
        }
    }
	// Use this for initialization
	void Start ()
    {
        tekst_wyniku = GetComponent<Text>();
	}

    void OdswiezWynik()
    {
        string napis_punktow = string.Format("{0:000000}", wynik);
        tekst_wyniku.text = napis_punktow;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
