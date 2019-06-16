using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast : MonoBehaviour {

    public float speed = 10f;
    public int damage = 5;
    public Rigidbody2D rb2;
    public GameObject explosion;

	// Use this for initialization
	void Start () {
        rb2.velocity = transform.right * speed;
	}

    void Update()
    {
        if (transform.position.x > 11.52f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D hitInfo) {
        
        Bugs b = hitInfo.GetComponent<Bugs>();
        if (b != null) {
            b.takeDamage(damage);
        }
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
        
    }
}
