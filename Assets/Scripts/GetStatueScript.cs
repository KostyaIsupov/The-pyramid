using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetStatueScript : MonoBehaviour
{
    private int statues;
    private int statuesCount = 0;
    public Text statuesText;
    // Start is called before the first frame update
    void Start()
    {
        statues = GameObject.FindGameObjectsWithTag("Statue").Length;
        statuesText.text = "0/" + statues.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Statue")
        {
            Destroy(other.gameObject);
            statuesCount++;
            statuesText.text = statuesCount.ToString() + "/" + statues.ToString();  
        }
    }
}
