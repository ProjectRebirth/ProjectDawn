using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]

public class ConjurerAnimation : MonoBehaviour {
    Animator anim;
    WalkMechanics walkMechanics;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        walkMechanics = GetComponent<WalkMechanics>();
	}
	
	// Update is called once per frame
	void Update () {
        anim.SetFloat("speed", Mathf.Abs(walkMechanics.getHInput()));
	}
}
