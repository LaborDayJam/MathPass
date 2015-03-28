using UnityEngine;
using System.Collections;

public class MathProblemGenerator : MonoBehaviour
{
	public static MathProblemGenerator instance;

	[HideInInspector]
	public bool isHiked = false;

	public int[] mathAnswers;

//	[HideInInspector]
	public int curMathAnsr = 0;

	void Awake ()
	{
		instance = this;
	}
	
	// Update is called once per frame
	void Update ()
	{
		CalculateCurrentMathProblem();
		Reset();
	}

	void CalculateCurrentMathProblem()
	{
		//press key to hike ball
		if (!isHiked)
		{
			//randomize the answer to determine which problem is displayed
			int rnd = Random.Range(0, 3);

			switch (rnd)
			{
			case 0:
				curMathAnsr = mathAnswers[0];
				break;
			case 1:
				curMathAnsr = mathAnswers[1];
				break;
			case 2:
				curMathAnsr = mathAnswers[2];
				break;
			}
			isHiked = true;
		}
	}

	void Reset()
	{
		if (Input.GetButtonDown("Jump"))
		{
			isHiked = false;
		}
	}
}
