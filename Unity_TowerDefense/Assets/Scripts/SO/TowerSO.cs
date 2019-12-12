﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TowerType
{
    RANGED,
    MELEE,
    MAGIC,
    ARTILLERY
}

[CreateAssetMenu(fileName = "New Tower", menuName = "Tower/New Tower", order = 1)]
public class TowerSO : ScriptableObject
{
    public TowerType type;
    public Sprite towerImage;
    public string towerDescription;
    public int level;
    public int buildCost;
    public int damage;
    public float attackRate;
    public int range;
    public float speedMultiplayer;
    public GameObject towerPrefab;
    public GameObject[] projectiles;
    public TowerSO nextUpgrade;
}