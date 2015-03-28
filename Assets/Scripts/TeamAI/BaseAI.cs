using UnityEngine;
using System.Collections;

public class BaseAI : MonoBehaviour
{
	public float speed = 10.0f;
	public float zigZagDistance = 10.0f;

	// Update is called once per frame
	void Update ()
	{

	}

	public void Movement()
	{
		//zig zag
		transform.localPosition = new Vector3(Mathf.SmoothStep(transform.localPosition.x, Mathf.PingPong(Time.time * zigZagDistance, zigZagDistance), speed * Time.deltaTime),
		                                      transform.localPosition.y, transform.localPosition.z);
	}
}
