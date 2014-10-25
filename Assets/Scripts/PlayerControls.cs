using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour 
{
	public float speed = 100;
	public float velocitya;
	private int count;
	public Vector3 pos = new Vector3(0.0f,1.0f,0.0f);

	void Start()
	{
		count = 0;
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

			rigidbody.AddForce(movement*speed * Time.deltaTime);

		if (rigidbody.position.y < -10.0f)
						rigidbody.MovePosition (pos);


	}

	void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag == "PickUp") {
						other.gameObject.SetActive (false);
						count++;
				} else if (other.gameObject.tag == "Enemy") {
						rigidbody.MovePosition (pos);
				} else if (other.gameObject.tag == "Bounce") {
			int nx = 0;
			int nz = 0;
			if(rigidbody.velocity.x < 0)
				nx = 1;
			else
				nx = -1;

			if(rigidbody.velocity.z < 0)
				nz = 1;
			else
				nz = -1;


			rigidbody.velocity = new Vector3(2*nx,10,2*nz);
				}

	}

	public int GetCount()
	{
				return count;
		}

}

