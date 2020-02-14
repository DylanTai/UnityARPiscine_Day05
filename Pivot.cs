using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivot : MonoBehaviour
{
    public float rotate_speed;
    [SerializeField] GameObject obj_ball;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = obj_ball.transform.position;
        this.transform.Rotate(0, -Input.GetAxis("Horizontal") * Time.deltaTime * rotate_speed, 0);
    }
}
