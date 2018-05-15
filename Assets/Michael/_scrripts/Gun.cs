using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public float damage = 10f;
    public float range = 100f;
	public float bulletForce = 40f;
	public GameObject ammo;


    public Transform cannonEnd;

	private void Start()
	{
		
	}

    private void Update()
    {
         if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;

		if(Physics.Raycast(cannonEnd.position, cannonEnd.forward, out hit))
        {
			
		
            Debug.Log(hit.transform.name);
            Debug.DrawLine(cannonEnd.position, hit.transform.position);
        }
            
		GameObject bullet = Instantiate (ammo,cannonEnd.transform.position,cannonEnd.transform.rotation);
		Rigidbody rb = bullet.GetComponent<Rigidbody> ();
		rb.AddForce (-transform.up * bulletForce, ForceMode.Impulse);
    }
}
