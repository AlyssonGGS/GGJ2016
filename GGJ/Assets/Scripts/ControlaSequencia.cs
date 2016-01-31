using UnityEngine;

public class ControlaSequencia : MonoBehaviour {
    Personagem atual = new Monge();
    //sequencia à ser realizada pelos jogadores
    string sequencia;
    //usado para dizer em qual parte da sequencia os jogadores estão
    public static int posSequencia;
    public GameObject raio;

    void Update()
    {
        verificaSequencia();
    }

    public void verificaSequencia()
    {
        if (sequencia != null)
        {
            char c = sequencia[posSequencia];
            if (Input.anyKeyDown)
            {
                string estado = atual.testaInput(c);
                if (estado == "certo")
                {
                    posSequencia++;

                    if (acabouSequencia())
                    {
						restauraSequencia();
                        GameObject enemy = GameObject.Find("enemy");
                        GameObject.Find("Raio").GetComponent<LaserController>().chamarRaio(new Vector3(enemy.transform.position.x*0.87f, -Camera.main.orthographicSize * 1.1f));
                        //vai na classe de controle de jogo para informar que um inimigo precisa ser destruido e, consequentemente, outro precisa ser instanciado
                        GetComponent<AudioSource>().Play();
                    }
					else
					{
						vezDeQuem();
					}
                }
                else
                {
					if(estado == "errado")
                    	restauraSequencia();
                    //quebrou a sequencia
                }
            }
        }
    }
    //sem criatividade pra nome de metodo
    private void vezDeQuem()
    {
        switch (sequencia[posSequencia])
        {
            case 'u':
            case 'd':
            case 'l':
            case 'r':
                atual = Monge.getInstance();
                break;

            case 'w':
            case 's':
            case 'a':
            case 'x':
                atual = Necromante.getInstance();
                break;
        }
    }
    
    //atribui uma nova sequencia ao controlador
    public void darSequencia(string sq)
    {
        sequencia = sq;
        posSequencia = 0;
        vezDeQuem();//verifica se a primeira letra da sequencia é do monge ou necromante
    }

    //testa se a sequencia foi completada
    private bool acabouSequencia()
    {
        return posSequencia == sequencia.Length;
    }
    //restaura a sequencia ao estado inicial
    private void restauraSequencia()
    {
        posSequencia = 0;
		vezDeQuem ();
    }
    //verifica se a proxima sequencia(por aquivo)
}
