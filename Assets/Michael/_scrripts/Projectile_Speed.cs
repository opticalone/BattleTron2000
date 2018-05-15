using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Speed : MonoBehaviour
{
	public float projectileForce;
	Rigidbody rb;


	public void OnObjectSpawn()
	{
		float xForce = projectileForce;

		Vector3 force = new Vector3 (xForce, 0, 0);
		rb = GetComponent<Rigidbody> ();



	}

	private void FixedUpdate()
	{
		rb.AddForce (1000,0,0);
	}
}
