using UnityEngine;
using System.Collections;

public class ConeMechanics : MonoBehaviour
{
	public Material[] mats;

	public Transform reciever;

	private Renderer rend;

	// Use this for initialization
	void Start ()
	{
		rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		WatchReciever();
	}

	void WatchReciever()
	{
		transform.parent.LookAt(reciever);
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Opponent Blocker")
		{
			rend.material = mats[1];
		}
	}

	void OnTriggerExit(Collider col)
	{
		if (col.tag == "Opponent Blocker")
		{
			rend.material = mats[0];
		}
	}
}
