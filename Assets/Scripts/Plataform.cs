using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plataform : MonoBehaviour
{
    public int points = 0;
    [SerializeField] Text textPoint;
    [SerializeField] Text textLossPoints;
    [SerializeField] float Amplitude;
    float screenRatio;
    float idealRatio = 16f / 9f;

    public Slider slider;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        points++;
        TextPoints();
        AudioCollision();
    }

    // Start is called before the first frame update
    void Start()
    {
        screenRatio = Screen.height / Screen.width;
        TextPoints();
    }

    // Update is called once per frame
    void Update()
    {
        float sliderValue = slider.value;

        float x =  2.81f + Mathf.Cos(sliderValue) * (idealRatio / screenRatio) * Amplitude;
        float y =  5.8f + Mathf.Sin(ssliderValue) * (idealRatio / screenRatio) * Amplitude;


        transform.position = new Vector2(x, y);

        if(Mathf.Sin(sliderValue) < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, Mathf.Cos(sliderValue) * 90f);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, (2 + ( Mathf.Cos(sliderValue))) * (-90f));
        }

    }

    public void TextPoints()
    {
        textPoint.text = points.ToString();
        textLossPoints.text = points.ToString();
    }

    public int ReturnPoints()
    {
        return points;
    }

    public void AudioCollision()
    {
        if (points > 0)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
