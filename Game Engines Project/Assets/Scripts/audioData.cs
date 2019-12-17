using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class audioData : MonoBehaviour
{
    AudioSource audioSource;
    public static float[] samples = new float[512];
    public static float[] freqBand = new float[8];
    public static float[] bandBuffer = new float[8];
    float[] bufferDecrease = new float[8];

      void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

   
    void Update()
    {
        getSpectrumAudioSource();
        makeFreqBand();
        makeBandBuffer();
    }

    void getSpectrumAudioSource()
    {
        audioSource.GetSpectrumData(samples, 0, FFTWindow.Blackman);
    }

    void makeBandBuffer()
    {
        for(int g = 0; g < 8; g++)
        {
            if(freqBand [g] > bandBuffer [g] )
            {
                bandBuffer[g] = freqBand[g];
                bufferDecrease[g] = 0.010f;

            }
            if (freqBand[g] < bandBuffer[g])
            {
                bandBuffer[g] -= bufferDecrease[g];
                bufferDecrease[g] *= 1.5f;
            }
        }
    }

    void makeFreqBand()
    {
        int count = 0;

        for (int i = 0; i < 8; i++)
        {
            float average = 0;
            int samplecount = (int)Mathf.Pow (2, i) * 2;

            if (i == 7)
            {
                samplecount += 2;
            }

            for (int j = 0; j < samplecount; j++)
            {
                average += samples [count] * (count + 1);
                    count++;
            }

            average /= count;

            freqBand[i] = average * 10;
        }
    }
}
