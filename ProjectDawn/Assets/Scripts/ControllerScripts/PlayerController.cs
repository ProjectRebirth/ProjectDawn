using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    WalkMechanics walkMechanics;
    JumpMechanics jumpMechanics;
    AttackMechanics attackMechanics;


    void Awake()
    {
        walkMechanics = GetComponent<WalkMechanics>();
        jumpMechanics = GetComponent<JumpMechanics>();
        attackMechanics = GetComponent<AttackMechanics>();
    }

    void Update()
    {
        walkMechanics.moveHorizontal(Input.GetAxisRaw("Horizontal"));
        jumpMechanics.jump(Input.GetButtonDown("Jump"));
        attackMechanics.attack(Input.GetButtonDown("pAttack"));
        
    }
}
