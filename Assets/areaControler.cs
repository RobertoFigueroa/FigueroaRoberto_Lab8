using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class areaControler : MonoBehaviour

{

    public Light ambientLight;
    // Start is called before the first frame update
    void Start()
    {
        ambientLight.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Entro");
        ambientLight.enabled = true;
        ambientLight.intensity = Mathf.Sin(5*Time.fixedTime);

    }

    private void OnTriggerExit(Collider other)
    {
        ambientLight.enabled = false;

    }
}
