using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    WalkMechanics walkMechanics;


    void Awake()
    {
        walkMechanics = GetComponent<WalkMechanics>();
    }

    void Update()
    {
        walkMechanics.moveHorizontal(Input.GetAxisRaw("Horizontal"));
    }
}
