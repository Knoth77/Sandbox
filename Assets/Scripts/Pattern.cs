using UnityEngine;
using System.Collections;

public class Pattern : MonoBehaviour {
	public int count;
	public float speed = 100.0f;
	// Use this for initialization
	void Start () {
		count = 0;
		transform.renderer.material.color = Color.red;
	}


	void FixedUpdate()
	{
		float moveHorizontal = 0.0f;
		float moveVertical = 0.0f;

		if (count > 400) {
			count = 0;
				}
		else if (count > 300) {
			moveHorizontal = 2.0f;
			moveVertical = 0.0f;
				}
			else if(count > 200)
			{
				moveHorizontal = 0.0f;
				moveVertical = -2.0f;
			}
			else if(count > 100){
						moveHorizontal = -2.0f;
						moveVertical = 0.0f;
			}
		else {
						moveHorizontal = 0.0f;
						moveVertical = 2.0f;
				}
		count++;


		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		//rigidbody.AddForce(movement*speed * Time.deltaTime);
		//rigidbody.angularVelocity = movement;
		rigidbody.velocity = movement * speed * Time.deltaTime;
		//Physics.gravity = new Vector3(0.0f,temp, 0.0f);
	}

}
