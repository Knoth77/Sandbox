using UnityEngine;
using System.Collections;

public class CirclePattern : MonoBehaviour {

	public int count;
	public float speed = 100.0f;
	// Use this for initialization
	void Start () {
		count = 0;
		transform.renderer.material.color = Color.green;
	}
	
	
	void FixedUpdate()
	{
		float moveHorizontal = 0.0f;
		float moveVertical = 0.0f;
		
		if (count > 100) {
			count = 0;
		}
		else if (count > 75) {
			moveHorizontal = 2.0f;
			moveVertical = 0.0f;
		}
		else if(count > 50)
		{
			moveHorizontal = 0.0f;
			moveVertical = -2.0f;
		}
		else if(count > 25){
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
