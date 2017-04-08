using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {

   public float speed = 7f;
	
	// Update is called once per frame
	void Update ()
   {

        Vector3 pos = transform.position;
        Vector3 move = new Vector3(0, speed * Time.deltaTime, 0);
        pos += move;
        transform.position = pos;

    }
}
