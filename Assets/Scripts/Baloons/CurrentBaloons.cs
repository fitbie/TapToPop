using System.Collections.Generic;
using UnityEngine;

public class CurrentBaloons
{
    public static List<BaloonBase> currentBaloons = new List<BaloonBase>();


    public static void AddBaloon(BaloonBase baloon)
    {
        currentBaloons.Add(baloon);
    }

    public static void RemoveBaloon(BaloonBase baloon)
    {
        currentBaloons.Remove(baloon);
    }


    public static void ResetBaloons()
    {
        for (int i = currentBaloons.Count-1; i >= 0; i--)
        {
            GameObject.Destroy(currentBaloons[i].gameObject);
        }

        currentBaloons.Clear();
    }
}
