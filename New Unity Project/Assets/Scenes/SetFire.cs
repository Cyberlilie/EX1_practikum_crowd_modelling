﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class SetFire : MonoBehaviour
{
    private bool SETFIRE = false;
    Vector3 position;
    public Camera cam;
    public GameObject fire_pit;

    //public NavMeshSurface surfaces;

    // Update is called once per frame
    void Update()
    {
        if (SETFIRE)
        {
            if (Input.GetMouseButtonDown(1))
            {
                position = fire_pit.GetComponent<Transform>().position;

                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray,out hit)) 
                {
                    float x = hit.point[0];
                    float y = 3.1f;
                    float z = hit.point[2];
                    Vector3 new_pos = new Vector3(x, y, z);
                    // move the agent
                    fire_pit.GetComponent<Transform>().position = new_pos;
                }
                /*for (int i=0; i<surfaces.length; i++)
                {
                    surfaces[i].BuildNavMesh();
                }*/
                SETFIRE = false;
            }
        }
    }

    public void carryExplosion()
    {
        SETFIRE = true;
    }
}
