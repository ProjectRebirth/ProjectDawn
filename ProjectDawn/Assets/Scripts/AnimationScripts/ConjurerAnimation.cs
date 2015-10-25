using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]

public class ConjurerAnimation : MonoBehaviour {
    Animator anim;
    WalkMechanics walkMechanics;
    JumpMechanics jumpMechanics;
    AttackMechanics attackMechanics;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        walkMechanics = GetComponent<WalkMechanics>();
        jumpMechanics = GetComponent<JumpMechanics>();
        attackMechanics = GetComponent<AttackMechanics>();
	}
	
	// Update is called once per frame
	void Update () {
        anim.SetFloat("speed", Mathf.Abs(walkMechanics.getHInput()));
        anim.SetBool("inAir", jumpMechanics.getInAir());
        anim.SetBool("isAttacking", attackMechanics.getIsAttacking());
        anim.SetFloat("attack", attackMechanics.getAttackRatio());
	}
}
