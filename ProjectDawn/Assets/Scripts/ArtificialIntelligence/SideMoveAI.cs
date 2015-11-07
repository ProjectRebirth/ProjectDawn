using UnityEngine;
using System.Collections;

[RequireComponent(typeof(WalkMechanics))]

public class SideMoveAI : MonoBehaviour {
    public Transform[] positions;

    int currentDestination;
    Vector3 lastPosition;
    Vector3[] positionVectors;
    WalkMechanics walkMechanics;
    float moveDirection;
    
    void Start()
    {
        
        walkMechanics = GetComponent<WalkMechanics>();
        setDestinations();
        moveDirection = calculateMoveDirection();
    }

    void Update()
    {
        print(currentDestination);
        updateMovement();
        updatePosition();
    }

    void updateMovement()
    {

        if (passedDestination())
        {
            currentDestination = (currentDestination + 1) % positionVectors.Length;
            moveDirection = calculateMoveDirection();
        }
        walkMechanics.moveHorizontal(moveDirection);
    }

    bool passedDestination()
    {
        float check1 = lastPosition.x - positionVectors[currentDestination].x;
        float check2 = transform.position.x - positionVectors[currentDestination].x;

        if (check1 < 0 && check2 < 0)
        {
            return false;
        }
        if (check1 > 0 && check2 > 0)
        {
            return false;
        }
        return true;
    }

    float calculateMoveDirection()
    {
        float distance = positionVectors[currentDestination].x - transform.position.x;
        if (distance < 0)
        {
            return -1;
        }
        return 1;
    }

    void updatePosition()
    {
        lastPosition = transform.position;
    }

    void setDestinations()
    {
        positionVectors = new Vector3[positions.Length];
        int i = 0;
        foreach(Transform t in positions)
        {
            positionVectors[i] = positions[i].position;
            i++;
        }
    }
}
