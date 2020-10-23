using System.Collections;
using System.Collections.Generic;
using DDF.PCG.WEAPON;

using UnityEngine;

public class GiveMeItem : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(1, 3)]
    public int ItemType;

    public int ItemCount;
    void Start()
    {
        for (int i = 0; i < ItemCount; i++)
        {
            WeaponGenerator._instance.Generator(ItemType);
        }
    }

}
