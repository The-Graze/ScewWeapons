using BepInEx;
using System;
using UnityEngine;
using Random = System.Random;

namespace UpsidownWeapons
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        void Update()
        {
            if (GunControl.Instance.currentWeapon.GetComponent<Flipper>() == null)
            {
                GunControl.Instance.currentWeapon.AddComponent<Flipper>();
            }
        }
    }
    class Flipper : MonoBehaviour 
    {
        void Awake()
        {
            OnEnable();
        }
        void Start()
        {
            OnEnable();
        }
        void OnEnable()
        {
            var rand = new Random();
            Single rnd = rand.Next();
            Single rnd1 = rand.Next();
            Single rnd2 = rand.Next();
            transform.rotation = Quaternion.Euler(rnd, rnd1, rnd2);
        }
    }
}
