using UnityEngine;
using System.Collections;

public class BallBounce : MonoBehaviour {

	public float ballInitialVelocity = 400f;
	private bool ballInPlay;

	private Rigidbody rb;

	// Use this for initialization
	void Awake () {
		rb = GetComponent<Rigidbody>();	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Jump") && ballInPlay == false) {
			transform.parent = null;
			ballInPlay = true;
			rb.isKinematic = false;
			rb.AddForce (new Vector3(ballInitialVelocity, ballInitialVelocity, 0));
		}
		//float cvel = Rigidbody.velocity;
		//float tvel = cvel.normalized * cSpeed;
		//rigidbody.velocity = Vector3.Lerp(cvel,tvel,Time.deltaTime * sFactor);
		//Vector3 curr = transform.position;
		//transform.position = new Vector3 (curr.x, curr.y-, curr.z);

	
	}

	/*void ResetBall() {
		float x = GameObject.Find ("Racket").transform.position.x;
		transform.position = new Vector3(x, -2.6f, 0);
	}
	//-2.6*/
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "Racket") 
		{
			float x = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.x);
			Vector3 direction = new Vector3(x, 1, 0).normalized;
			GetComponent<Rigidbody>().velocity = direction;
			//Debug.Log ("Collided steve ");
		}
		/*if (collision.gameObject.name == "Wall (top)")
		{
			//float x = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.x);
			//Vector3 direction = new Vector3(x, 1, 0).normalized;
			//float x = GetComponent<Rigidbody>().velocity.magnitude;
			//transform.position = new Vector3(curr.x+.24f, curr.y, curr.z);
			//Debug.Log ("Fuck");
			transform.Translate (0, Input.GetAxis ("Horizontal") * speed, 0);
			float x = GetComponent<Rigidbody>().velocity.x;
			GetComponent<Rigidbody>().velocity = new Vector3(x, -10, 0);
		}
		if (collision.gameObject.CompareTag ("Block")) 
		{
			Debug.Log ("Fuck");
			float x = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.x);
			Vector3 direction = new Vector3(x, -1, 0).normalized;
			GetComponent<Rigidbody>().velocity = direction * speed;
			collision.gameObject.SetActive (false); 
		}*/
	}

	float hitFactor(Vector3 ballPos, Vector3 racketPos, float racketHeight)
	{
		return (ballPos.x - racketPos.x) / racketHeight;
	}

	/*void OnTriggerEnter(Collision other)
	{
		if (other.gameObject.CompareTag ("Block")) 
		{
			//yield new WaitForSeconds(1);
			float x = hitFactor(transform.position, other.transform.position, other.collider.bounds.size.x);
			Vector3 direction = new Vector3(x, 1, 0).normalized;
			GetComponent<Rigidbody>().velocity = direction * speed;
			other.gameObject.SetActive (false);
		}
	}*/
	
}