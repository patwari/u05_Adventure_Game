using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

	[SerializeField] Text textComponent;
	[SerializeField] State startingState;
	[SerializeField] State endState;

	State currentState;
	// Use this for initialization
	void Start () {
		currentState = startingState;
		textComponent.text = currentState.GetStoryText ();
	}

	// Update is called once per frame
	void Update () {
		JumpToNextState ();
		textComponent.text = currentState.GetStoryText ();
	}

	private void JumpToNextState () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			currentState = endState;
		} else if (Input.GetKeyDown (KeyCode.Return) || Input.GetKeyDown (KeyCode.KeypadEnter)) {
			currentState = startingState;
		} else if (Input.GetKeyDown (KeyCode.Keypad1) || Input.GetKeyDown (KeyCode.Alpha1) || Input.GetKeyDown (KeyCode.DownArrow) || Input.GetKeyDown (KeyCode.LeftArrow)) {
			currentState = currentState.GetNextStates () [0];
		} else if (Input.GetKeyDown (KeyCode.Keypad2) || Input.GetKeyDown (KeyCode.Alpha2) || Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.RightArrow)) {
			currentState = currentState.GetNextStates () [1];
		}
	}
}
