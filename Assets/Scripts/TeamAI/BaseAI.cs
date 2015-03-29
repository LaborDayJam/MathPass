using UnityEngine;
using System.Collections;

public class BaseAI : MonoBehaviour
{
	public float speed = 10.0f;
	public float zigZagDistance = 10.0f;

	public void Movement()
	{
		//zig zag
		if (!PassMechanics.instance.isPassThrown)
		{
			transform.localPosition = new Vector3(Mathf.SmoothStep(transform.localPosition.x, Mathf.PingPong(Time.time * zigZagDistance, zigZagDistance), speed * Time.deltaTime),
			                                      transform.localPosition.y, transform.localPosition.z);
		}
	}
}
