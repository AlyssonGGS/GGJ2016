using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	void Start () {
        string sequence = GameObject.Find("Controle").GetComponent<ControleJogo>().pegaSequencia();
        GameObject.Find("SpawnManager").GetComponent<ControlaSequencia>().darSequencia(sequence);
        GameObject.FindWithTag("Spawner").GetComponent<spawnSequence>().spawn(sequence, gameObject);
    }

}
