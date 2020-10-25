using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class floorColor : MonoBehaviour
{
    public Renderer rend;
    Color color = new Color(0, 0, 0);
    public static float colorJuice = 0;
    public static float floorNum = 0;
    public Transform floorPrefab;

    float timeLeft;
    bool rainbow = false;
    void Start()
    {
        color = new Color(0, 0, 0);
        rend = GetComponent<Renderer>();
        rend.material.color = color;
        colorJuice++;
        floorNum++;
        print(colorJuice);
        timeLeft = .5f;
    }

    void Update()
    {
        if (timeLeft <= Time.deltaTime)
        {
            if (colorJuice < 255)
            {
                colorJuice += Time.deltaTime;

            }
            else if (colorJuice >= 255)
            {
                rainbow = true;
            }


            if (rainbow == false)
            {
                color = new Color(colorJuice, colorJuice, colorJuice);
                timeLeft = 1.0f;
            } else if (rainbow == true)
            {
                color = new Color(Random.value, Random.value, Random.value);
                timeLeft = 1.0f;
            }

            rend.material.color = color;
        }
        else
        {
            rend.material.color = Color.Lerp(rend.material.color, color, Time.deltaTime / timeLeft);
            timeLeft -= Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}
