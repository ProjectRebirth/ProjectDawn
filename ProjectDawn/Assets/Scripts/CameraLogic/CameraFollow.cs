using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    public Transform target;
    public float movementSmoothing = 5f;
    public float offsetX = 0;
    public float offsetY = 0;

    float zDistance; //zoom distance

    void Start()
    {
        zDistance = transform.position.z;
        GetComponent<Camera>().transparencySortMode = TransparencySortMode.Orthographic;
    }

    void Update()
    {
        updateCameraPosition();
    }

    void updateCameraPosition()
    {
        Vector3 goalVec = new Vector3(target.position.x + offsetX, target.position.y + offsetY, zDistance);
        transform.position = goalVec;

    }


    //These methods are created for debugging purposes. I assmue the player won't have 
    //access to the control of the camera....
    public void moveVertical(float vInput)
    {
        offsetX += vInput * Time.deltaTime;
    }

    public void moveHorizontal(float hInput)
    {
        offsetY += hInput;
    }

    public void zoomCamera(float zInput)
    {
        zDistance += zInput;
    }
}
