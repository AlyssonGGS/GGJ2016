using UnityEngine;
using System.Collections;

public class AndarComSom : MonoBehaviour
{
    AudioSource audio;
    float[] spectrum = new float[128];

    //variavel usada para acrescentar dificuldade ao jogo(inimigo andando mais rapido)
    float speed = 1;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        StartCoroutine(aumentarVelocidade());
    }

    void Update()
    {
        andarComSom();
    }

    void andarComSom()
    {
        audio.GetSpectrumData(spectrum, 0, FFTWindow.BlackmanHarris);
        for (int j = 0; j < spectrum.Length; j++)
        {
            if (spectrum[j] > 0.000792f && spectrum[j] < 0.001584)
            {
                transform.Translate(Vector3.left * Time.deltaTime * spectrum[j] * 100 * speed);
            }
        }
    }

    IEnumerator aumentarVelocidade() {
        float q = 1.00069876f;
        speed *= q;
        yield return new WaitForSeconds(0.1f);
        StartCoroutine(aumentarVelocidade());
    }
}