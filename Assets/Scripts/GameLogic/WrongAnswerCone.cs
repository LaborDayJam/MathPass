using UnityEngine;
using System.Collections;

public class WrongAnswerCone : MonoBehaviour
{
	public Transform receiver;
	public Transform target;
	
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
		//this is the wrong answer
		PassMechanics.instance.curTarget = target;
		PassMechanics.instance.isPassThrown = true;
	}
}
