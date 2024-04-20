using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class WinPanelShower : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            panel.SetActive(true);
            FirstPersonMovement fpm = other.gameObject.GetComponent<FirstPersonMovement>();
            fpm.speed = 0;
            fpm.canRun = false;
            UnityEngine.Cursor.lockState = CursorLockMode.None;
        }
    }
}
