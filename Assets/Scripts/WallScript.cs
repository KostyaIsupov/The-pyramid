using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            FirstPersonMovement fpm = collision.gameObject.GetComponent<FirstPersonMovement>();
            fpm.speed = 0;
            fpm.canRun = false;
            Invoke("giveSpeed", 1);
        }
    }
    void giveSpeed(FirstPersonMovement fpm)
    {
        fpm.speed = 0;
        fpm.canRun = false;
    }
}
