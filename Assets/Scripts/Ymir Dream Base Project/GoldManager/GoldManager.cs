using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldManager : SingletonDestroyMono<GoldManager>
{
    public event Action<int> OnGoldChanged; // Altýn miktarý deðiþtiðinde tetiklenecek olay

    private int _currentGold; // Geçerli altýn miktarý

    [SerializeField] private int _beginningGold;

    private void Start()
    {
        _currentGold = _beginningGold;
    }

    public int GetGoldAmount()
    {
        return _currentGold;
    }

    public void AddGold(int amount)
    {
        _currentGold += amount;

        OnGoldChanged?.Invoke(_currentGold);
    }

    public void SpendGold(int amount)
    {
        if (CanAfford(amount))
        {
            _currentGold -= amount;

            OnGoldChanged?.Invoke(_currentGold);
        }

    }

    public bool CanAfford(int amount)
    {
        return _currentGold >= amount;
    }

    public void ResetGold()
    {
        _currentGold = 0;

        OnGoldChanged?.Invoke(_currentGold);
    }
}
