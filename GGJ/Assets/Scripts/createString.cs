using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class createString : MonoBehaviour {
	
	private int currentLevel = 4;
	List<string> keys = new List<string>();

	void fillList() {
		keys.Add ("w"); keys.Add ("r");
		keys.Add ("a"); keys.Add ("l");
		keys.Add ("s"); keys.Add ("u");
		keys.Add ("x"); keys.Add ("d");
	}

	public string generateSequence(){
		fillList ();
		string combination = "";
		for (int i = 0; i < currentLevel; i++) {
			int index = Random.Range(0, keys.Count);
			combination += keys[index];
			keys.Remove(keys[index]);
			Debug.Log(keys.Count);
		}
		keys.Clear ();
		return combination;
	}

	void increaseLevel(){
		currentLevel++;
	}

	public int getLevel(){
		return currentLevel;
	}
}
