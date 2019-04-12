using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Needs
{
    public static float Hunger = 100;
    public static float Sleep = 100;
    public static float Hygiene = 100;
    public static float Bladder = 100;
    public static float Happiness = 100;
}

public class NeedsManager : MonoBehaviour
{
    public float HungerDecay = 0.01f;
    public float SleepDecay = 0.01f;
    public float HygieneDecay = 0.01f;
    public float BladderDecay = 0.01f;
    public float HappinessDecay = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Needs.Hunger -= HungerDecay;
        Needs.Sleep -= SleepDecay;
        Needs.Hygiene -= HygieneDecay;
        Needs.Bladder -= BladderDecay;
        Needs.Happiness -= HappinessDecay;


        if (Needs.Hunger > 100) { Needs.Hunger = 100; }
        else if (Needs.Hunger < 0) { Needs.Hunger = 0; }

        if (Needs.Sleep > 100) { Needs.Sleep = 100; }
        else if (Needs.Sleep < 0) { Needs.Sleep = 0; }

        if (Needs.Hygiene > 100) { Needs.Hygiene = 100; }
        else if (Needs.Hygiene < 0) { Needs.Hygiene = 0; }

        if (Needs.Bladder > 100) { Needs.Bladder = 100; }
        else if (Needs.Bladder < 0) { Needs.Bladder = 0; }

        if (Needs.Happiness > 100) { Needs.Happiness = 100; }
        else if (Needs.Happiness < 0) { Needs.Happiness = 0; }

    }

    public void ChangeNeeds(string parameters)
    {
        string[] split = parameters.Split(","[0]);

        float creditcost = float.Parse(split[0]);
        int crystalcost = int.Parse(split[1]);
    
        Needs.Hunger = int.Parse(split[0]) + Needs.Hunger;
        Needs.Sleep += int.Parse(split[1]);
        Needs.Hygiene = int.Parse(split[3]) + Needs.Hygiene;
        Needs.Bladder += int.Parse(split[4]);
        Needs.Happiness += int.Parse(split[5]);
    }

}
