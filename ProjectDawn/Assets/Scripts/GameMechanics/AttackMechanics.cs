using UnityEngine;
using System.Collections;

public class AttackMechanics : MonoBehaviour {
    public float[] attackDuration = new float[3];//The amount of time that each attack needs complete
    public float[] attackDelay = new float[3];//A delay before the hitbox for this attack is set to active
    public Collider2D[] hitBoxes;//The hitboxes needed for each attack
    public float[] attackDamage = new float[3];


    private int currentAttack = -1;
    private bool isAttacking;
    private float[] attackDurationTimer;
    private float[] attackDelayTimer;

    void Start() 
    {
        attackDurationTimer = new float[attackDuration.Length];
        attackDelayTimer = new float[attackDelay.Length];
    }

    void Update()
    {
        updateTimers();
        updateAttackDelay();
        updateAttack();
    }

    void updateAttackDelay() 
    {

    }

    void updateAttack()
    {
        if (isAttacking && attackDurationTimer[(currentAttack + 1) % attackDuration.Length] <= 0) 
        {
            //print("I was here");
            currentAttack += 1;
            isAttacking = false;
            attackDurationTimer[currentAttack % attackDuration.Length] = attackDuration[currentAttack % attackDuration.Length];
        }
    }

    void updateTimers()
    {
        for (int i = 0; i < attackDelay.Length; i++)
        {
            attackDelayTimer[i] = Mathf.MoveTowards(attackDelayTimer[i], 0, Time.deltaTime);
        }
        for (int i = 0; i < attackDuration.Length; i++)
        {
            attackDurationTimer[i] = Mathf.MoveTowards(attackDurationTimer[i], 0, Time.deltaTime);
        }
    }


    public void attack(bool attackButton)
    {
        //print (currentAttack);
        if (attackButton) 
        {
            isAttacking = true;
            //currentAttack += 1;
        }
    }

    bool checkCanAttack() 
    {
        return true;
    }

    public bool getIsAttacking() 
    {
        if (currentAttack < 0)
        {
         return false;
        }
        //print(attackDuration[currentAttack]);
        //print(attackDurationTimer[currentAttack % attackDuration.Length]);

        return attackDurationTimer[currentAttack % attackDuration.Length] > 0;
    }

    public float getAttackRatio() 
    {
        //print(currentAttack % attackDuration.Length);
        return currentAttack % attackDuration.Length;
    }

    
}
