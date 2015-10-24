using UnityEngine;
using System.Collections;

public class AttackMechanics : MonoBehaviour {
    public float[] attackDuration;//The amount of time that each attack needs complete
    public float[] attackDelay;//A delay before the hitbox for this attack is set to active
    public Collider2D[] hitBoxes;//The hitboxes needed for each attack
    public float[] attackDamage;


    private int currentAttack;

    void Update()
    {
        updateTimers();
    }

    void updateTimers()
    {
        for (int i = 0; i < attackDelay.Length; i++)
        {
            attackDelay[i] = Mathf.MoveTowards(attackDelay[i], 0, Time.deltaTime);
        }
        for (int i = 0; i < attackDuration.Length; i++)
        {
            attackDuration[i] = Mathf.MoveTowards(attackDuration[i], 0, Time.deltaTime);
        }
    }


    public void attack(bool attackButton)
    {

    }

    
}
