using UnityEngine;
using System.Collections;

public class PassMechanics : MonoBehaviour
{
	public static PassMechanics instance;

	public float throwSpeed = 10.0f;

	public Transform incompletePassTarget;
	public Transform footBall;
//	[HideInInspector]
	public Transform curTarget;

//	[HideInInspector]
	public bool isPassThrown = false;

	private Vector3 footBallStartPos;

	void Awake()
	{
		instance = this;
	}

	void Start()
	{
		footBallStartPos = footBall.position;
	}

	// Update is called once per frame
	void Update ()
	{
		ThrowPass();
	}

	void ThrowPass()
	{
		//pass ball to the target
		if (isPassThrown)
		{
			footBall.LookAt(curTarget);
			footBall.position = Vector3.MoveTowards(footBall.position, curTarget.position, throwSpeed * Time.deltaTime);
		}
		//reset ball for next play
		else
		{
			footBall.position = footBallStartPos;
		}
	}

	void OnMouseDown()
	{
		//player has swiped outside cone
		curTarget = incompletePassTarget;
		isPassThrown = true;
	}
}
