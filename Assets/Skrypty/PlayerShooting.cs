using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

    public Vector3 bulletOFfset = new Vector3(0, 3.5f, 0);
    public GameObject bulletPrefab;
    public float fireDelay = 0.25f;
    float shoot_holdTimer = 0;
	
	// Update is called once per frame
	void Update () {
        shoot_holdTimer -= Time.deltaTime;
        if (Input.GetButton("Fire1") && shoot_holdTimer <= 0)
        {
            GetComponent<AudioSource>().Play();
            shoot_holdTimer = fireDelay;
            Vector3 offset = transform.rotation*bulletOFfset;
            Instantiate(bulletPrefab,transform.position +offset,transform.rotation);
        }
    }
}
