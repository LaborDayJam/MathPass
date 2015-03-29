using UnityEngine;
using System.Collections;

public class CorrectAnswerCone : MonoBehaviour
{
	public Material[] mats;

	public Transform receiver;

	private bool isPassBlocked = false;

	private Renderer rend;

	private GameObject blocker;

	// Use this for initialization
	void Start ()
	{
		blocker = GameObject.FindWithTag("Opponent Blocker");

		rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		WatchReceiver();
	}

	void WatchReceiver()
	{
		//always face towards the corrosponding receiver.
		transform.parent.LookAt(receiver);
		
		//place resize code here
	}

	//using click for now until swipe controls are placed in
	void OnMouseDown()
	{
		//this is the right answer.

		//check if pass is blocked or not
		if (isPassBlocked)
		{
			//set for interception
			PassMechanics.instance.curTarget = blocker.transform;
		}
		else
		{
			//set for complete pass
			PassMechanics.instance.curTarget = receiver;
		}
		PassMechanics.instance.isPassThrown = true;
	}

	//this can be a temporary method for blocking
	//unless we don't have any other good way to do it
	void OnTriggerEnter(Collider col)
	{
		//receiver is blocked
		if (col.tag == "Opponent Blocker")
		{
			rend.material = mats[1];
			isPassBlocked = true;
		}
	}
	
	void OnTriggerExit(Collider col)
	{
		//receiver is open
		if (col.tag == "Opponent Blocker")
		{
			rend.material = mats[0];
			isPassBlocked = false;
		}
	}
}
