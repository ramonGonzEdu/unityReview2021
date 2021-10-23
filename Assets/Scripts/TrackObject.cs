using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackObject : MonoBehaviour
{
	public Transform target;

	public bool copyRotationX = false;
	public bool copyRotationY = false;
	public bool copyRotationZ = false;

	public bool copyPositionX = false;
	public bool copyPositionY = false;
	public bool copyPositionZ = false;

	public float interpolate = 0.7f;
	// Start is called before the first frame update
	void Start()
	{
		var rot = transform.rotation.eulerAngles;
		initialXRot = rot.x;
		initialYRot = rot.y;
		initialZRot = rot.z;
	}

	float initialXRot;
	float initialYRot;
	float initialZRot;

	// Update is called once per frame
	void Update()
	{
		if (target != null)
		{
			var rot = Quaternion.Slerp(transform.rotation, target.rotation, interpolate).eulerAngles;
			if (!copyRotationX)
				rot.x = initialXRot;
			if (!copyRotationY)
				rot.y = initialYRot;
			if (!copyRotationZ)
				rot.z = initialZRot;

			transform.rotation = Quaternion.Euler(rot);

			// Vector3 newPos = transform.position;



			// if (copyPositionX)
			// 	newPos.x = Mathf.Lerp(transform.position.x, target.position.x, interpolate);
			// if (copyPositionY)
			// 	newPos.y = Mathf.Lerp(transform.position.y, target.position.y, interpolate);
			// if (copyPositionZ)
			// 	newPos.z = Mathf.Lerp(transform.position.z, target.position.z, interpolate);

			// transform.position = newPos;
			transform.position = Vector3.Lerp(transform.position, target.position, interpolate);
		}
	}
}
