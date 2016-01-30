using UnityEngine;
using System.Collections;

public class keyPressed : MonoBehaviour {

	public string key;
	public int pos;

	void Update () {
		isPressed (ControlaSequencia.posSequencia);
	}

	void isPressed(int index){
		if(Input.GetKey(key) && pos == index){
			transform.localScale = new Vector2 (1.1f, 1.1f);
		} else {
			transform.localScale = new Vector2 (1, 1);
		}
	}
}
