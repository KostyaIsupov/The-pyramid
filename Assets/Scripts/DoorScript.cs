using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DoorScript : MonoBehaviour
{ 
    FadeScript fadeScript;
    // Start is called before the first frame update
    void Start()
    {
        fadeScript = GameObject.FindWithTag("FadePanel").GetComponent<FadeScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            fadeScript.FadeScreen();
        }
    }
}
