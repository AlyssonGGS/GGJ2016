using UnityEngine;

public class AndarComSom : MonoBehaviour
{
    AudioSource audio;
    float[] spectrum = new float[128];

    void Start()
    {
        audio = GetComponent<AudioSource>();
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
                transform.Translate(Vector3.left * Time.deltaTime * spectrum[j] * 100);
            }
        }
    }
}