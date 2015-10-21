using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]

public class ConjurerAnimation : MonoBehaviour {
    Animator anim;
    WalkMechanics walkMechanics;
    JumpMechanics jumpMechanics;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        walkMechanics = GetComponent<WalkMechanics>();
        jumpMechanics = GetComponent<JumpMechanics>();
	}
	
	// Update is called once per frame
	void Update () {
        anim.SetFloat("speed", Mathf.Abs(walkMechanics.getHInput()));
        anim.SetBool("inAir", jumpMechanics.getInAir());
	}
}
