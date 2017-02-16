using UnityEngine;
using System.Collections;

public class KeyboardInput : MonoBehaviour {
	GameObject BallPrefab;
	//GameObject attachedBall = null;
	Rigidbody Ball;
	public float paddleSpeed = 10f;
	//float ballSpeed = 10f
	private Vector3 playerPos = new Vector3 (0, -5.1f, 0);

	// Update is called once per frame
	void Update () {
		if(Input.GetKey ("right")) {
			transform.position = new Vector3(Mathf.Clamp(transform.position.x+.24f, -4.19f, 4.17f), -5.1f, 0);
		}
		else if(Input.GetKey ("left")) {
			transform.position = new Vector3(Mathf.Clamp(transform.position.x-.24f, -4.19f, 4.17f), -5.1f, 0);
		}
		/*else if(Input.GetKey ("left") {
			xPos = transform.position.x - .24f;
		}
		playerPos = new Vector3 (Mathf.Clamp (xPos, -4.19f, 4.17f), -5.1f, 0);
		Vector3 curr = transform.position;
		transform.position = playerPos;*/
		/*if (Input.GetKey ("left")) {
		//	if(position != new Vector3(-.1f, curr.y, curr.z))
		//	{	
				transform.position = new Vector3(curr.x-.24f, curr.y, curr.z);
				//GetComponent<Rigidbody>().AddForce(new Vector3 (-1, 0, 0));
				//print ("left arrow key is held down");
		//	}
		}
		
		if (transform.position.x == 4.0f && Input.GetKey ("right")) {
		}
		else if (transform.position.x != 4.0f && Input.GetKey ("right"))
		{
			transform.position = new Vector3(curr.x+.24f, curr.y, curr.z);
		}
		//	GetComponent<Rigidbody>().AddForce(new Vector3 (1, 0, 0));

			//print ("right arrow key is held down");*/


		//if (attachedBall) {
			//ballRigidbody = attachedBall.GetComponent<Rigidbody>();
			//ballRigidbody.position = new Vector3 (transform.position.x, 5.5f, 0);

			//if (Input.GetButtonDown ("Jump")) {
			//	ballRigidbody.isKinematic = false;
			//	ballRigidbody.AddForce (0, ballSpeed, 0);
			//	attachedBall = null;
			//}
		//}*/

	}

	//void ResetBall() {
	//	attachedBall = Instantiate (BallPrefab, new Vector3 (transform.position.x, -2.6f, 0), Quaternion.identity) as GameObject;
	//}

}