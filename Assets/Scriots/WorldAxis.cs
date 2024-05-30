using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldAxis : MonoBehaviour
{
	public float size = 1f;
	public void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawLine(Vector3.right * size, Vector3.zero);

		Gizmos.color = Color.green;
		Gizmos.DrawLine(Vector3.up * size, Vector3.zero);

		Gizmos.color = Color.blue;
		Gizmos.DrawLine(Vector3.forward * size, Vector3.zero);

		Gizmos.color = Color.white;
	}
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}
}
