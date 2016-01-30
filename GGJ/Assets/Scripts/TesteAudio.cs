using UnityEngine;
using System.Collections.Generic;

public class TesteAudio : MonoBehaviour
{
    AudioSource audio;
    float[] spectrum = new float[64];

    void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        direcaoAndandoComSom();
    }

    void direcaoAndandoComSom()
    {
        audio.GetSpectrumData(spectrum, 0, FFTWindow.BlackmanHarris);
        for (int j = 0; j < spectrum.Length; j++)
        {
            if (spectrum[j] > 0.000792f && spectrum[j] < 0.001584)
            {
                transform.Translate(Vector3.right * Time.deltaTime * spectrum[j] * 100);
            }
        }
    }
}