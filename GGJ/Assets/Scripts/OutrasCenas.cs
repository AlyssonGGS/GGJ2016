using UnityEngine;
using System.Collections;

public class OutrasCenas : MonoBehaviour {

	void Start ()
    {
	
	}
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            GetComponent<AudioSource>().Play();
            StartCoroutine(troca());
        }
	}

    IEnumerator troca()
    {
        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
        SceneManager.changeScene("Menu");
    }
}
