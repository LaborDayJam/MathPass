using UnityEngine;
using System.Collections;

public class CorrectAnswerTeamAI : BaseAI
{
	public GameObject gameMaster;

	public TextMesh answerText;

	private MathProblemGenerator mathPblmGenScript;

	void Start ()
	{
		mathPblmGenScript = gameMaster.GetComponent<MathProblemGenerator>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		DisplayAnswer();
		Movement();
	}

	void DisplayAnswer()
	{
		//display the answer
		if (mathPblmGenScript.isPlayStarted)
		{
			answerText.text = mathPblmGenScript.curMathAnsr.ToString();
		}
	}
}
