﻿using UnityEngine;
using System.Collections;

public class ControleJogo : MonoBehaviour {
    string sequence;
    static GameObject prox;
    public Sprite[] imagensInimigos;//guarda os sprites dos inimigos
    public RuntimeAnimatorController[] controller;//guarda os controles de animação dos inimigos

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
        Destroy(destruido);//destroy o inimigo antigo
        StartCoroutine(criarInimigo(0.2f));//instancia um novo em x segundos
    }

    IEnumerator criarInimigo(float tempo)
    {
        //zera a posição do pivot dos inimigos
        transform.position = Vector3.zero;
        //espera o tempo
        yield return new WaitForSeconds(tempo);
        //escolhe qual inimigo instanciar
        int idInimigoAtual = Random.Range(0, imagensInimigos.Length);
        //pega a sequencia
        sequence = GameObject.FindWithTag("Spawner").GetComponent<createString>().generateSequence();
        //cria o inimigo
        prox = new GameObject("enemy", typeof(Enemy));
        //faz o inimigo ir parar no final da tela
        prox.transform.position = Vector3.right * Camera.main.orthographicSize * Camera.main.aspect;
        prox.AddComponent<SpriteRenderer>();
        prox.AddComponent<Animator>();
        prox.GetComponent<SpriteRenderer>().sprite = imagensInimigos[idInimigoAtual];
        prox.GetComponent<Animator>().runtimeAnimatorController = controller[idInimigoAtual];
        //prende o inimigo ao objeto atual(pivot)
        prox.transform.parent = gameObject.transform;
    }
}
