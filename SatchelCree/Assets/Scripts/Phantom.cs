﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Phantom
{
	public string name;
	public string nickName;

	public Type type;
	public Rarity rarity;

	public Texture image;


	public float baseHealth;
	public float currentHealth;

	public float baseStamina;
	public float currentStamina;

	public float basePower;
	public float currentPower;

	public float baseDefense;
	public float currentDefense;

	public float baseAgility;
	public float currentAgility;

	public List<Learnables> learnableAbilities;
	public List<Ability> knownAbilities;
	public List<Ability> equippedAbilities;

	public string GetName()
	{
		if (nickName != "")
		{
			return nickName;
		}
		return name;
	}

}

/// <summary>
/// Learnable class, lists all abilities that can be learnt and at what level
/// </summary>
[System.Serializable]
public class Learnables
{
	public int learnAtLevel;
	public Ability toLearn;
}

public enum Type
{
	Null,
	Earth,
	Wind,
	Fire,
	Water
}

public enum Rarity
{
	Common,
	Uncommon,
	Rare,
	UltraRare,
	Legendary
}