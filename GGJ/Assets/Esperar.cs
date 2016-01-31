using UnityEngine;
using System.Collections;

public class Esperar : MonoBehaviour
{

	void Start ()
    {
        GetComponent<AudioSource>().Play();
        StartCoroutine(tocaMusiquinha());
	}
	
    IEnumerator tocaMusiquinha()
    {
        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
        StartCoroutine(GetComponent<ControleJogo>().criarInimigo(0));
        GameObject.Find("AndarComSom").GetComponent<AudioSource>().Play();
    }
}
