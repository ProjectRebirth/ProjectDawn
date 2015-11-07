using UnityEngine;
using System.Collections;

public class StumpAnimations : MonoBehaviour {
    Animator anim;
    WalkMechanics walkMechanics;

    void Start()
    {
        anim = GetComponent<Animator>();
        walkMechanics = GetComponent<WalkMechanics>();
    }

    void Update()
    {
        anim.SetFloat("speed", Mathf.Abs(walkMechanics.getHInput()));
    }
}
