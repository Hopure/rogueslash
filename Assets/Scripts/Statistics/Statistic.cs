using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Statistic
{
    // EVENTS ---------------------------------------------------------------------------
    public event Action<Statistic> OnValueChange;
    public event Action<Statistic> OnCurrentValueChange;
    public void ValueChangeTrigger(Statistic stat)
    {
        OnValueChange?.Invoke(stat);
    }
    public void CurrentValueChangeTrigger(Statistic stat)
    {
        OnCurrentValueChange?.Invoke(stat);
    }

    // PRIVATES PROPERTIES --------------------------------------------------------------
    private float value;
    private float flatModifiers;
    private float increasedModifiers;
    private float currentValue;
    private float baseValue;
    [SerializeField] private Statistic parent;
    [SerializeField] private float rate;
    [SerializeField] private List<StatModifier> modifiers;

    // PUBLICS PROPERTIES ---------------------------------------------------------------
    [HideInInspector]
    public StatID ID;

    [HideInInspector]
    public string Name;

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
            ValueChangeTrigger(this);
        }
    }

    [ShowInInspector]
    public float CurrentValue
    {
        get
        {
            return currentValue;
        }
        private set
        {
            currentValue = value;

            if (currentValue < 0)
                currentValue = 0;
            else if (currentValue > Value)
                currentValue = Value;

            CurrentValueChangeTrigger(this);
        }
    }

    // CONSTRUCTORS ---------------------------------------------------------------------
    public Statistic() { }

    public Statistic(StatID id, string name, float baseValue)
    {
        ID = id;
        Name = name;
        this.baseValue = baseValue;
        modifiers = new List<StatModifier>();

        UpdateValue(this);
    }

    public Statistic(StatID id, string name, float baseValue, Statistic parent, float rate)
    {
        ID = id;
        Name = name;
        this.baseValue = baseValue;
        modifiers = new List<StatModifier>();
        this.parent = parent;
        this.rate = rate;
        this.parent.OnValueChange += UpdateValue;

        UpdateValue(this);
    }

    // PUBLICS METHODS ------------------------------------------------------------------
    public void AddModifier(StatModifier mod)
    {
        mod.OnValueChange += UpdateStat;
        modifiers.Add(mod);
        UpdateStat(mod.Type);
    }

    public void RemoveModifier(StatModifier mod)
    {
        mod.OnValueChange -= UpdateStat;
        modifiers.Remove(mod);
        UpdateStat(mod.Type);
    }

    public void UpdateCurrentValue(float value)
    {
        CurrentValue += value;
    }
    public void UpdateStat()
    {
        float _flat = 0;
        float _increase = 0;

        foreach (StatModifier modifier in modifiers)
        {
            if (modifier.Type == ModifierType.Flat)
                _flat += modifier.Value;
            if (modifier.Type == ModifierType.Increased)
                _increase += modifier.Value;
        }

        flatModifiers = 0;
        increasedModifiers = 0;
        flatModifiers += _flat;
        increasedModifiers += _increase;

        UpdateValue(this);
    }

    // PRIVATES METHODS -----------------------------------------------------------------
    private void UpdateStat(ModifierType modType)
    {
        UpdateModifiers(modType);
        UpdateValue(this);
    }

    private void UpdateModifiers(ModifierType modType)
    {
        float result = 0;

        foreach (StatModifier modifier in modifiers)
        {
            if (modifier.Type == modType)
                result += modifier.Value;
        }

        if (modType == ModifierType.Flat)
        {
            flatModifiers = 0;
            flatModifiers = result;
        }

        if (modType == ModifierType.Increased)
        {
            increasedModifiers = 0;
            increasedModifiers = result;
        }
    }

    private void UpdateValue(Statistic stat)
    {
        float _result = Value - CurrentValue;

        if (parent == null)
        {
            Value = (baseValue + flatModifiers) * (1 + (increasedModifiers / 100));
        }
        else
        {
            Value = (baseValue + flatModifiers + (parent.Value * rate)) * (1 + (increasedModifiers / 100));
        }

        CurrentValue = Value - _result;
    }
}
