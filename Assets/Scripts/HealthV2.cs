using UnityEngine;

public class HealthV2 : MonoBehaviour
{
    public int maxHp = 100;
    public int accumDamage = 0;

    public void TakeDamage(int damage)
    {
        accumDamage += damage;
        if (accumDamage >= maxHp)
        {
            Destroy(gameObject);
        }
    
    }
}
