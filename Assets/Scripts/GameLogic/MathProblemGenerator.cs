using UnityEngine;
using System.Collections;

public class MathProblemGenerator : MonoBehaviour
{
	public static MathProblemGenerator instance;

	[HideInInspector]
	public bool isPlayStarted = true;

	public int[] mathAnswers;

	public TextMesh[] mathProblems;

	[HideInInspector]
	public int curMathAnsr = 0;

	public TextMesh curMathProblem;

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
		if (isPlayStarted)
		{
			//randomize the answer to determine which problem is displayed
			//display the math problem
			int rnd = Random.Range(0, 3);

			switch (rnd)
			{
			case 0:
				curMathAnsr = mathAnswers[0];
				curMathProblem.text = mathProblems[0].text;
				break;
			case 1:
				curMathAnsr = mathAnswers[1];
				curMathProblem.text = mathProblems[1].text;
				break;
			case 2:
				curMathAnsr = mathAnswers[2];
				curMathProblem.text = mathProblems[2].text;
				break;
			}
			isPlayStarted = false;
		}
	}

	void Reset()
	{
		//TEMPORARY RESET SYSTEM!!

		//reset play
		if (Input.GetButtonDown("Jump"))
		{
			isPlayStarted = true;
			PassMechanics.instance.isPassThrown = false;
		}
	}
}
