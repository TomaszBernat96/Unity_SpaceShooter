using UnityEngine;
using System.Collections;

public class EnemyShooting : MonoBehaviour {

    Vector2 pozycja_przeciwnika;
    public Vector3 bulletOFfset = new Vector3(0, 3.5f, 0);
    public GameObject bulletPrefab;
    public float fireDelay = 0.5f;
    float shoot_holdTimer = 0;

    // Update is called once per frame
    void Update()
    {
        pozycja_przeciwnika = transform.position;
        shoot_holdTimer -= Time.deltaTime;
        if ( shoot_holdTimer <= 0 && pozycja_przeciwnika.y<=5)
        {
            GetComponent<AudioSource>().Play();
            shoot_holdTimer = fireDelay;
            Vector3 offset = transform.rotation * bulletOFfset;
            GameObject bulletRun = (GameObject)Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
            bulletRun.layer = gameObject.layer;
        }
    }
}
