using System;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public enum WeaponsList
    {
        pistol,
        shotgun,
        sniper,
        assault_rifle,
        knife,
        grenade
    }

    public WeaponsList currentWeapon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentWeapon)
        {
            case WeaponsList.pistol:
                break;
            case WeaponsList.shotgun:
                break;
            case WeaponsList.sniper:
                break;
            case WeaponsList.assault_rifle:
                break;
            case WeaponsList.knife:
                break;
            case WeaponsList.grenade:
                break;
            default:
                break;
        }
    }
}
