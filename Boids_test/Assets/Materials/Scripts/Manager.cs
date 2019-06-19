using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public int number = 30;
    public GameObject boid;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        for (var i = 0; i < number; i++)
        {
            var position = new Vector3(Random.Range(min.x, max.x), Random.Range(min.y, max.y), 0);
            var angle = Random.Range(0, 360.0f);

            Instantiate(boid, position, Quaternion.AngleAxis(angle, Vector3.forward), transform);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
