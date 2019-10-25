
/*
----------------------------------------------------------------------------------------------------------------
Unity3D Code Bank
----------------------------------------------------------------------------------------------------------------
 * This script has been downloaded from Unity3D Code Bank GITHUB repository. 
 * Repository Link : https://github.com/javidshaikhf/Unity3D-Code-Bank
 * If you want contribute your script to this repository, please send your script to below email.
 * EMAIL : unity3dcodebank@gmail.com
----------------------------------------------------------------------------------------------------------------
Developer
----------------------------------------------------------------------------------------------------------------
* Name : Javid Shaikh
* Website : www.javidshaikh.com
* Youtube Channel : https://www.youtube.com/channel/UC60Ydgl3n-OsmZ_hB3PlhUQ
----------------------------------------------------------------------------------------------------------------
*/

public static class HealthManager
{
    private static float maxHealth = 100;


    /// <summary>
    /// Initial set max. default value is 100.
    /// </summary>

    public static float MaxHealth
    {
        get => maxHealth;
        set
        {
            maxHealth = value;
            CurrentHealth = maxHealth;
        }
    }

    /// <summary>
    /// Get current health.
    /// </summary>

    public static float CurrentHealth { get; private set; }
    
    /// <summary>
    /// Applied Damage will be deducted in current health
    /// </summary>
    /// <param name="damage"></param>
    /// <returns>
    /// Returns Current Health
    /// </returns>

    public static float ApplyDamage(float damage)
    {
        CurrentHealth -= damage;

        if (CurrentHealth <= 0)
        {
            CurrentHealth = 0;
        }
        return CurrentHealth;
    }
}
