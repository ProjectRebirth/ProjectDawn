using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    WalkMechanics walkMechanics;
    JumpMechanics jumpMechanics;


    void Awake()
    {
        walkMechanics = GetComponent<WalkMechanics>();
        jumpMechanics = GetComponent<JumpMechanics>();
    }

    void Update()
    {
        walkMechanics.moveHorizontal(Input.GetAxisRaw("Horizontal"));
        jumpMechanics.jump(Input.GetButtonDown("Jump"));
    }
}
