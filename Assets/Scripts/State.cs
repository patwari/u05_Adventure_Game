﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "StateManager", menuName = "State")]
public class State : ScriptableObject {
	[TextArea (10, 14)][SerializeField] string storyText;
	[SerializeField] State[] nextStates;

	public string GetStoryText () {
		return storyText;
	}

	public State[] GetNextStates () {
		return nextStates;
	}
}
