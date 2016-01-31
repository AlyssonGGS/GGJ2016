using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spawnSequence : MonoBehaviour {

	private int level;
	public List<GameObject> keys = new List<GameObject>();

	public void spawn(string spell, GameObject enemy){
		level = GetComponent<createString>().getLevel();
        GameObject obj = null;
		for (int i = 0; i < level; i++) {
			switch(spell.Substring(i, 1)){
			case "a":
				obj = keys[0];
				break;

			case "x":
				obj = keys[1];
				break;

			case "s":
				obj = keys[2];
				break;

			case "w":
				obj = keys[3];
				break;

			case "d":
				obj = keys[4];
				break;

			case "l":
				obj = keys[5];
				break;

			case "r":
				obj = keys[6];
				break;

			case "u":
				obj = keys[7];
				break;
			}

			GameObject temp = (GameObject)Instantiate(obj, new Vector2((i-level/4) * 2, 2.5f), Quaternion.identity);
			temp.GetComponent<keyPressed>().pos = i + 1;
            temp.transform.parent = enemy.transform;
        }

    }
	
}
