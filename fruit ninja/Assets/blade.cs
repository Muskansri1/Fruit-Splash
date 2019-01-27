﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blade : MonoBehaviour
{
    public GameObject bladetrailPrefab;
    public float mincuttingvelocity = 0.001f;

    bool isCutting = false;

    Vector2 previousPosition;
    GameObject currentbladetrail;
    Rigidbody2D rb;
    Camera cam;
    CircleCollider2D circleCollider;

    private void Start()
    {
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        circleCollider = GetComponent<CircleCollider2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCutting();
        }else if (Input.GetMouseButtonUp(0))
        {
            StopCutting();
        }
        if (isCutting)
        {
            UpdateCut();
        }
            
    }
    void UpdateCut()
    {
        Vector2 newPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        rb.position = newPosition;
        float velocity = (newPosition- previousPosition).magnitude * Time.deltaTime;
        if(velocity > mincuttingvelocity)
        {
            circleCollider.enabled = true;
        }
        else
        {
            circleCollider.enabled = false;

        }

        previousPosition = newPosition;

    }
    void StartCutting()
    {
        isCutting = true;
        currentbladetrail = Instantiate(bladetrailPrefab, transform);
        previousPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        circleCollider.enabled = false;
    }
    void StopCutting()
    {
        isCutting = false;
        currentbladetrail.transform.SetParent(null);
        Destroy(currentbladetrail, 2f);
        circleCollider.enabled = false;
    }
}
