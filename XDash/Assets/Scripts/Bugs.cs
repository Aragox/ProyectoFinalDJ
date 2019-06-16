using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bugs : MonoBehaviour {

    public int health = 1;
    public float speed;
    public GameObject bugDeath;

    private Rigidbody2D rb2;
    private Vector2 screenBounds;

	// Use this for initialization
	void Start () {
        rb2 = this.GetComponent<Rigidbody2D>();
        rb2.velocity = new Vector2(-speed * 2, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < -11.3f) {
            Destroy(this.gameObject);
        }
        else if (transform.position.x > 11.52f)
        {
            Destroy(this.gameObject);
        }
    }

    public void takeDamage(int damage) {
        health -= damage;

        if(health <= 0) {
            death();
        }
    }

    void death() {
        Instantiate(bugDeath, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
