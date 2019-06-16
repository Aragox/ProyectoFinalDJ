using UnityEngine;

public class Collision : MonoBehaviour {

    public int potion;
    public bool particiel;
    public GameObject death;
    public GameObject ripped;
    public Rigidbody2D rb2;
    public Canvas canvas;

    void OnCollisionEnter2D(Collision2D collisionInfo) {
        
        if ((collisionInfo.collider.tag == "Bug") && (this.tag == "Player")){
            Debug.Log(collisionInfo.collider.tag);
            Instantiate(death, transform.position, transform.rotation);
            Destroy(ripped);
            ripped.SetActive(false);
            canvas.gameObject.SetActive(true); 
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
        else if (collisionInfo.collider.tag == "Floor")
        {
            if (particiel)
            {
                ripped.gameObject.GetComponent<Animator>().SetBool("onFloor", false);
                ripped.gameObject.GetComponent<Animator>().SetBool("onDash", false);
            }
            else
            {
                ripped.gameObject.GetComponent<Animator>().SetBool("onFloor", true);
            }
        }
        else if (collisionInfo.collider.tag == "Roof")
        {
            if (particiel)
            {
                ripped.gameObject.GetComponent<Animator>().SetBool("onFloor", true);
            }
            else
            {
                ripped.gameObject.GetComponent<Animator>().SetBool("onFloor", false);
                ripped.gameObject.GetComponent<Animator>().SetBool("onDash", false);
            }
        }
    }
}
