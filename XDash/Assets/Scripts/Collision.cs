using UnityEngine;

public class Collision : MonoBehaviour {

    public int potion;
    public bool particiel;
    public GameObject death;
    public GameObject ripped;
    public Rigidbody2D rb2;

    void OnCollisionEnter2D(Collision2D collisionInfo) {
        
        if ((collisionInfo.collider.tag == "Bug") && (this.tag == "Player")){
            Debug.Log(collisionInfo.collider.tag);
            Instantiate(death, transform.position, transform.rotation);
            Destroy(ripped);
            ripped.SetActive(false);
        }
        else if ((collisionInfo.collider.tag == "Flame") && (this.tag == "Bug"))
        {
            Debug.Log(collisionInfo.collider.tag);
            Instantiate(death, transform.position, transform.rotation);
            Destroy(ripped);
            ripped.SetActive(false);

        }
        else if ((collisionInfo.collider.tag == "Particiel") && (this.tag == "Player")) {
            Debug.Log(collisionInfo.collider.tag);
            Vector3 theScale = transform.localScale;
            theScale.y *= -1;
            transform.localScale = theScale;
            rb2.gravityScale = -rb2.gravityScale;
            particiel = !particiel;
        }
        else if ((collisionInfo.collider.tag == "Potion") && (this.tag == "Player")) {
            Debug.Log(collisionInfo.collider.tag);
            potion += 1;
        }
    }
}
