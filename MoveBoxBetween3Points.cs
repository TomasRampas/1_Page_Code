/*
 * Move cube between three set points by pressing A and D keys.
 * Cube moves smoothly.
 * Inspired by endless runner games, where player just changes
 * paths by swiping from left to right.
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PujdeTo : MonoBehaviour {

    public bool moveBox = false;
    private float objectSpeed = 4;

    [SerializeField] Vector3 Point0;
    [SerializeField] Vector3 Point1;
    [SerializeField] Vector3 Point2;

    Vector3[] PointList = new Vector3[3];

    private int selectedPoint = 1;

    private Vector3 movementDirection;
    private Vector3 pointPosition;

    void Start ()
    {
        PointList[0] = Point0;
        PointList[1] = Point1;
        PointList[2] = Point2;
    }
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            AKeyClicked();
            Debug.Log("A key pressed");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            DKeyClicked();
            Debug.Log("D key pressed");
        }

        if (!moveBox)
        {
            return;
        }

        transform.Translate(movementDirection * (objectSpeed * Time.deltaTime));

        if (Mathf.Abs((pointPosition - transform.localPosition).x) <= 0.20f)
        {
            moveBox = false;
        }
    }

    void AKeyClicked()
    {
        if (selectedPoint == 0)
        {
            return;
        }

        if (selectedPoint >= 1)
        {
            movementDirection = Vector3.left;
            selectedPoint -= 1;
            pointPosition = PointList[selectedPoint];
            moveBox = true;
            Debug.Log("selectedPoint" + selectedPoint);
        }
    }

    void DKeyClicked()
    {
        if (selectedPoint == 2)
        {
            return;
        }

        if (selectedPoint <= 1)
        {
            movementDirection = Vector3.right;
            selectedPoint += 1;
            pointPosition = PointList[selectedPoint];
            moveBox = true;
            Debug.Log("selectedPoint" + selectedPoint);
        }
    }

}
