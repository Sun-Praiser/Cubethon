using UnityEngine;

/*
public class Destructible : MonoBehaviour
{
    public GameObject PlayerCubed;

    void OnCollisionEnter(Collider other)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Instantiate(PlayerCubed, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
*/

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter (Collision collisionInfo )
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            GetComponent<AudioSource>().Play();
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }


}
