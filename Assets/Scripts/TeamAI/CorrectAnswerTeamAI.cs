using UnityEngine;
using System.Collections;

public class CorrectAnswerTeamAI : BaseAI
{
	public GameObject gameMaster;

	public TextMesh answerText;

	private MathProblemGenerator mathPblmGenScript;

	void Awake ()
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
		answerText.text = mathPblmGenScript.curMathAnsr.ToString();
	}
}
