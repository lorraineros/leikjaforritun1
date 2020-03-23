using UnityEngine;
using UnityEngine.UI;

public class EnemyAttack : MonoBehaviour
{
    public Transform player;
    public float moveSpeed;
    public float playerDistance;
    public GameObject Explosion;

    // Update is called once per frame
    void Update()
    {
        // Finnur fjarlæg milli enemy og player
        playerDistance = Vector3.Distance(player.position, this.transform.position);
        if (playerDistance < 5000f)
        {
            // Enemy horfa á player
            Vector3 direction = player.position - this.transform.position;
            direction.y = 0;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);
        }
        if (playerDistance < 100f)// ef player er nálægt
        {
            if (playerDistance > 0.5f)// ef player er mjög nálægt
            {
                // Kallar á föll chase
                chase();
            }
        }

        void chase()
        {
            // Enemy elta player
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.tag == "Bullet")// Ef hitt á bullet tag (ef player skaut á enemy)
            {
                // Kallar á föll Explo
                Explo();
                Destroy(gameObject);
                // hverfur Enemy
                gameObject.SetActive(false);
            }
        }

        void Explo()
        {
            // Explosion effect
            Instantiate(Explosion, transform.position, transform.rotation);
        }
    }
    
}
