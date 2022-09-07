using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{

    public Camera mainCamera;
    float rightMax = 595;
    float leftMax = 100;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = FindObjectOfType<Camera>();   
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float maxMovement = Mathf.Clamp(Input.mousePosition.x, leftMax, rightMax);
        float WorldXPos = mainCamera.ScreenToWorldPoint(new Vector3(maxMovement, 0, 0)).x;
        this.transform.position = new Vector3(WorldXPos, -4.5f, 0);
    }

}
