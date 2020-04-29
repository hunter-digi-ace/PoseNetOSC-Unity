using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Manager : MonoBehaviour
{
    public static Manager instance;
    int counter = 0;
    public Text CountText;
    public GameObject cube;
    public GameObject lefthand;
    public GameObject righthand;
    float scaleX;
    float heighthands;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }


    void Update()
    {
        if (counter == 4)
        {
            cube.SetActive(true);
            scaleX = righthand.transform.position.x - lefthand.transform.position.x;
            cube.gameObject.transform.localScale = new Vector3(scaleX, scaleX, scaleX);
            var aux = cube.GetComponent<Renderer>();
            heighthands = (lefthand.transform.position.y + 250)/420;

            //Call SetColor using the shader property name "_Color" and setting the color to red
            aux.material.color = Color.Lerp(Color.blue, Color.red, heighthands);
            Debug.Log("Text: " + heighthands.ToString());



        }
    }
    // Update is called once per frame
    public void setCounter()
    {
        counter++;
        setCountText();

    }

    public int getCounter()
    {
        return counter;
    }

    void setCountText()
    {
        if (counter == 4)
        {
            CountText.text = "Completado!" ;
        }
        else
        {
            CountText.text = "Puntos: " + counter.ToString();
        }
    }

}
