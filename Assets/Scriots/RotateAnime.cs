using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAnime : MonoBehaviour
{
	// Start is called before the first frame update
	public Quaternion endRotation;
	private Quaternion startRotation;
	private Quaternion offsetRotation;
	private Vector3 initVector;
	private float startTime;
	public float journeyTime = 2.0f;
	void Start()
	{
		initVector = transform.position;
		offsetRotation = transform.rotation;
		startRotation = Quaternion.Euler(0, 0, 0);
		endRotation = Quaternion.Euler(0, 180, 0);
		startTime = Time.time;
	}

	// Update is called once per frame
	void Update()
	{
		float time = (Time.time - startTime) / journeyTime;
		if (time >= journeyTime)
		{
			startTime = Time.time;
		}

		Quaternion rot = Quaternion.Slerp(startRotation, endRotation, time);
		transform.rotation = rot * offsetRotation;
		transform.position = rot * initVector;
		Debug.Log("position: " + transform.position);
	}
	public void ChangeEndRotationString(string endRotation)
	{
		string[] rotation = endRotation.Split(',');
		if (rotation.Length != 4)
		{
			Debug.LogError("Invalid rotation string");
			return;
		}
		this.endRotation = new Quaternion(float.Parse(rotation[0]), float.Parse(rotation[1]), float.Parse(rotation[2]), float.Parse(rotation[3]));
	}
}
