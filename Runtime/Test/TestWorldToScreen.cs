using System.Collections;
using System.Collections.Generic;
using MyLib.Ext;
using UnityEngine;

public class TestWorldToScreen : MonoBehaviour
{
    public Vector2 world;
    public Camera cam;
    public Vector2 screen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        world = transform.position;
        screen = cam.WorldToScreenPoint2D(world);
    }
}
