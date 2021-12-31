using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ModifierType
{
    Flat,
    Increased
}

[System.Serializable]
public class StatModifier
{
    // EVENTS ---------------------------------------------------------------------------
    public event Action<ModifierType> OnValueChange;
    public void ValueChangeTrigger(ModifierType modType)
    {
        OnValueChange?.Invoke(modType);
    }

    // PRIVATES PROPERTIES --------------------------------------------------------------
    [SerializeField] private float value;

    // PUBLICS PROPERTIES ---------------------------------------------------------------
    public ModifierType Type;
    public bool IsPermanent;

    [ShowInInspector]
    public float Value
    {
        get
        {
            return value;
        }
        private set
        {
            this.value = value;
            ValueChangeTrigger(Type);
        }
    }

    // CONSTRUCTORS ---------------------------------------------------------------------
    public StatModifier(ModifierType type, float value, bool isPermanent)
    {
        Type = type;
        Value = value;
        IsPermanent = isPermanent;
    }

    // PUBLICS METHODS ------------------------------------------------------------------
    public void UpdateValue(float newValue)
    {
        Value = newValue;
    }

    // PRIVATES METHODS -----------------------------------------------------------------
}
