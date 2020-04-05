using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;

	void FixedUpdate ()
	{
		// fer áfram
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

		if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
		{
			// Fer til hægri
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a")) // ef ýtt er á takkan "a"
		{
			// fer til vinstri
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (rb.position.y < -1f)
		{
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
