using UnityEngine;
using System.Collections;

public class KolizjaUlepszenia : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    void OnTriggerEnter2D(Collider2D kolizja)
    {
        if ((kolizja.tag == "StatekGracza"))
        {
            GetComponent<AudioSource>().Play();
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update ()
    {


    }
}
