using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlanetGenerator : MonoBehaviour
{
    public GameObject[] planety;
    Queue<GameObject> dostepne_planety = new Queue<GameObject>();

	// Use this for initialization
	void Start ()
    {

        dostepne_planety.Enqueue(planety[0]);
        dostepne_planety.Enqueue(planety[1]);
        dostepne_planety.Enqueue(planety[2]);
        dostepne_planety.Enqueue(planety[3]);

        InvokeRepeating("RuchPlanety_W_Dol", 0, 20f);


    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void RuchPlanety_W_Dol()
    {
        KoniecKolejkiPlanet();
        if(dostepne_planety.Count==0)
        {
            return;
        }
        GameObject _planeta = dostepne_planety.Dequeue();

        _planeta.GetComponent<Planet>().ruch = true;
    }

    void KoniecKolejkiPlanet()
    {
        foreach(GameObject planety_kontener in planety)
        {
            if((planety_kontener.transform.position.y < -6)&&(!planety_kontener.GetComponent<Planet>().ruch))
            {
                planety_kontener.GetComponent<Planet>().ZresetujPozycjePlanety();
                dostepne_planety.Enqueue(planety_kontener);
            }
        }
    }
}
