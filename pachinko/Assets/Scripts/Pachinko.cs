using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pachinko : MonoBehaviour
{
    private int counter;
    private float delay;

    public GameObject prefabBall;
    public GameObject BallparentRoot;

    void Update()
    {
        if (counter < 20)
        {
            delay += Time.deltaTime;
            if (delay >= 0.5f)
            {
                delay = 0;
                counter++;
                var ball = Instantiate(prefabBall, BallparentRoot.transform);
                ball.transform.localPosition = new Vector3(Random.Range(-2.8f, 2.8f), 6, 0);
            }
        }
    }
}
