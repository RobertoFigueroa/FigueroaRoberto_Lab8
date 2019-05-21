using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashLight : MonoBehaviour
{
    public Light spotLight;
    public AudioSource audio;
    public Canvas canv;
    

    // Start is called before the first frame update
    void Start()
    {
        spotLight.enabled = false;



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           
            
            if (spotLight)
            {
                if (spotLight.enabled)
                {
                    spotLight.enabled = false;
                }
                else
                {
                    spotLight.enabled = true;
                }
            
            }

            if (audio)
            {
                audio.Play();
            }
          
        }
         //se crea un rayo en el centro de la camara para poder determinar el nombre de los objetos que se apuntan
         
        RaycastHit hitInfo;

        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(myRay,out hitInfo))
        {
            if (hitInfo.transform.gameObject.CompareTag("chair"))
            {
                canv.GetComponentInChildren<Text>().text = "Silla";
               
            }
            else if (hitInfo.transform.gameObject.CompareTag("table"))
            {
                canv.GetComponentInChildren<Text>().text = "Mesa";
            }
            else
            {

                canv.GetComponentInChildren<Text>().text = "";
            }
        }

      

    }

 

}
