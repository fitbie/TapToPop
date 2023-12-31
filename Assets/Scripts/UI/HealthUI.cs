using System.Collections.Generic;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private GameObject heartPrefab;
    [SerializeField] private List<GameObject> hearts = new List<GameObject>();



    public void ResetHealthUI()
    {
        foreach (GameObject go in hearts)
        {
            GameObject.Destroy(go);
        }

        Initialize();
    }


    public void Initialize()
    {
        int health = GameHealth.MaxHealth;

        for (int i = 0; i < health; i++)
        {
            GameObject newHeart = GameObject.Instantiate(heartPrefab, transform); 
            hearts.Add(newHeart);
        }
    }


    public void ChangeHearts(int amount)
    {
       if (amount <= 0 || amount > hearts.Count)
        {
            Debug.LogWarning("Invalid amount of hearts to remove.");
            return;
        }

        for (int i = 0; i < amount; i++)
        {
            int lastIndex = hearts.Count - 1;
            GameObject heartToRemove = hearts[lastIndex];
            hearts.RemoveAt(lastIndex);
            Destroy(heartToRemove);
        }
    }

}
