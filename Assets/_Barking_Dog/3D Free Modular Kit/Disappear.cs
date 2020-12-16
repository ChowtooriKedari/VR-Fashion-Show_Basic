using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    GameObject gos;
    public GameObject Model2;
    public GameObject Model3;
    public GameObject Model4;
    public GameObject Model5;
    public GameObject Model6;
    public GameObject Model7;
    public GameObject Model8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log("Do something here");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Model")
        {
            other.gameObject.SetActive(false);

            //Enables the pause menu UI.
            Model2.SetActive(true);
        }
        if (other.gameObject.tag == "Model2")
        {
            other.gameObject.SetActive(false);

            //Enables the pause menu UI.
            Model3.SetActive(true);
        }
        if (other.gameObject.tag == "Model3")
        {
            other.gameObject.SetActive(false);

            //Enables the pause menu UI.
            Model4.SetActive(true);
        }
        if (other.gameObject.tag == "Model4")
        {
            other.gameObject.SetActive(false);

            //Enables the pause menu UI.
            Model5.SetActive(true);
        }
        if (other.gameObject.tag == "Model5")
        {
            other.gameObject.SetActive(false);
            //Enables the pause menu UI.
            Model7.SetActive(true);
        }
    }
    
}


  