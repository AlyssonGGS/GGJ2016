using UnityEngine;
using System.Collections;

public class ControleJogo : MonoBehaviour {
    string sequence;
    static GameObject prox;
    public Sprite[] imagensInimigos;
    public RuntimeAnimatorController controller;

    void Start ()
    {
        StartCoroutine(criarInimigo(0.2f));
    }

    void Update () {
	
	}

    public string pegaSequencia()
    {
        return sequence;
    }

    public void inimigoDestruido(GameObject destruido)
    {
        Destroy(destruido);
        StartCoroutine(criarInimigo(0.2f));
    }

    IEnumerator criarInimigo(float tempo)
    {
        transform.position = Vector3.zero;
        yield return new WaitForSeconds(tempo);
        sequence = GameObject.FindWithTag("Spawner").GetComponent<createString>().generateSequence();
        prox = new GameObject("enemy", typeof(Enemy));
        prox.transform.position = Vector3.right * Camera.main.orthographicSize * Camera.main.aspect;
        prox.AddComponent<SpriteRenderer>();
        prox.GetComponent<SpriteRenderer>().sprite = imagensInimigos[0];
        prox.AddComponent<Animator>();
        prox.GetComponent<Animator>().runtimeAnimatorController = controller;
        prox.transform.parent = gameObject.transform;
    }
}
