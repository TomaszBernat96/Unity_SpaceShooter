using UnityEngine;
using System.Collections;

public class PociskBossa : MonoBehaviour
{
    public float predkosc;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 pozycja_pocisku = transform.position;
        Vector3 polozenie = new Vector3(0, predkosc * Time.deltaTime, 0);
        pozycja_pocisku += transform.rotation * polozenie;
        transform.position = pozycja_pocisku;
	}
}
