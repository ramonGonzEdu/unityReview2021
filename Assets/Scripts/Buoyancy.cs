using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buoyancy : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnTriggerStay(Collider other)
	{
		other.gameObject.GetComponentInParent<Rigidbody>().AddForce(Vector3.up * (transform.position.y - other.transform.position.y) * 3, ForceMode.Acceleration);
	}
}
