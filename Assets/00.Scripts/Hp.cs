using UnityEngine;

public abstract class Hp : MonoBehaviour
{
    public float currentHp, maxHp;
    void Start()
    {
        currentHp = maxHp;
    }

    public virtual void Damage(float damage)
    {
        currentHp -= damage;
        currentHp = Mathf.Clamp(currentHp, 0, maxHp);

        if(currentHp <= 0)
        {
            Die();
        }
    }

    public abstract void Die();

}
