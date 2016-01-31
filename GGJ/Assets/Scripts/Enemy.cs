using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	void Start () {
        string sequence = GameObject.Find("Começar").GetComponent<ControleJogo>().pegaSequencia();
        GameObject.Find("SpawnManager").GetComponent<ControlaSequencia>().darSequencia(sequence);
        GameObject.FindWithTag("Spawner").GetComponent<spawnSequence>().spawn(sequence, gameObject);
        //estava muito grande
        transform.localScale *= 0.5f;
    }
}
