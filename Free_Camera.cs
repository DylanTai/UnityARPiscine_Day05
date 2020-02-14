using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Free_Camera : MonoBehaviour
{
    [SerializeField] GameObject obj_camera;
    [SerializeField] GameObject obj_free_camera;
    private bool enabled;

    // Start is called before the first frame update
    void Start()
    {
        enabled = false;
        obj_free_camera.SetActive(false);
        obj_camera.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            if (enabled)
            {
                enabled = false;
                obj_free_camera.SetActive(false);
                obj_camera.SetActive(true);
            }
            else
            {
                enabled = true;
                obj_free_camera.SetActive(true);
                obj_camera.SetActive(false);
            }
        }
        if (enabled)
        {
            if (Input.GetKey("up"))
                this.transform.position = new Vector3(this.transform.position.x + 1, this.transform.position.y, this.transform.position.z);
            if (Input.GetKey("down"))
                this.transform.position = new Vector3(this.transform.position.x - 1, this.transform.position.y, this.transform.position.z);
            if (Input.GetKey("left"))
                this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - 1);
            if (Input.GetKey("right"))
                this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + 1);
        }
    }
}
