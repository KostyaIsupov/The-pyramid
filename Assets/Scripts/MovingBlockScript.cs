using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class MovingBlockScript : MonoBehaviour
{
    public float moveDuration = 1;
    public float waitBeforeMove = 1;
    public float waitAfterMove = 1;

    public Transform pointB;

    private Vector3 startPosition;
    private Vector3 endPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        endPosition = pointB.position;

        StartCoroutine("Animate");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Animate()
    {
        while (true)
        {
            float steps = moveDuration * 24;

            yield return new WaitForSeconds(waitBeforeMove);

            for (int i = 0; i < steps; i++)
            {
                transform.position = Vector3.Lerp(startPosition, endPosition, (float)i / steps);
                yield return new WaitForSeconds(1/24.0f);
            }

            yield return new WaitForSeconds(waitAfterMove);

            for (int i = 0; i < steps; i++)
            {
                transform.position = Vector3.Lerp(endPosition, startPosition, (float)i / steps);
                yield return new WaitForSeconds(1 / 24.0f);
            }
        }
    }
}
