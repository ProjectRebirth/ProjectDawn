using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
    public int maxHealth = 100;
    public int currentHealth;
    public float timeToRemove = 5;//The amount of the time the player will be active before being deleted from the game

    private float removeTimer;
    private bool isDead;




    void Start()
    {
        if (currentHealth <= 0)
        {
            currentHealth = maxHealth;
        }
    }

    void Update()
    {
        if (isDead)
        {
            removeTimer -= Time.deltaTime;
            if (removeTimer < 0f)
            {
                Destroy(this.gameObject);
            }
        }
    }

    public void takeDamage(int damageApplied)
    {
        currentHealth -= damageApplied;
        checkIsDead();
    }

    void checkIsDead()
    {
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            isDeadCleanUp();
        }
    }


    protected virtual void isDeadCleanUp() 
    {
        isDead = true;
    }


    public bool getIsDead()
    {
        return isDead;
    }
}
