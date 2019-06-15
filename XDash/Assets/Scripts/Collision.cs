using UnityEngine;

public class Collision : MonoBehaviour {

    public int potion;
    public bool particiel;
    public GameObject player;
    public GameObject playerDeath;
    public Rigidbody2D rb2;

    void OnCollisionEnter2D(Collision2D collisionInfo) {
        
        if (collisionInfo.collider.tag == "Bug") {
            Debug.Log(collisionInfo.collider.tag);
            GameObject d = Instantiate(playerDeath) as GameObject;
            d.transform.position = transform.position;
            Destroy(this.gameObject);
            this.gameObject.SetActive(false);
        }
        else if (collisionInfo.collider.tag == "Particiel") {
            Debug.Log(collisionInfo.collider.tag);
            Vector3 theScale = transform.localScale;
            theScale.y *= -1;
            transform.localScale = theScale;
            rb2.gravityScale = -rb2.gravityScale;
            particiel = !particiel;
        }
        else if (collisionInfo.collider.tag == "Potion") {
            Debug.Log(collisionInfo.collider.tag);
            potion += 1;
        }
    }

}
