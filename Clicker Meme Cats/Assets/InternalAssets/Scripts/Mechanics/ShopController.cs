using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShopController : MonoBehaviour
{
    public GameDataContainer dataContainer;

    public void BuyCatShop(int id)
    {
        if (dataContainer.memeCoins <= 0)
        {
            dataContainer.memeCoins = 0;
            return;
        }
            if (dataContainer.memeCoins >= dataContainer.costs[id] && dataContainer.memeCoins != 0)
            {
                dataContainer.memeCoins -= dataContainer.costs[id];
                dataContainer.costs[id] *= GameDataContainer.MYLTIPLY_VALUE;
                dataContainer.clickPower += dataContainer.clickPowers[id]; 

                dataContainer.clickUpgradeLevels[id]++;
            }

        }
        public void BuyMax(int id) => BuyMax(dataContainer, id);

        private void BuyMax(GameDataContainer dataContainer, int id)
        {
            var currentCost = dataContainer.costs[id];
            var currentCoins = dataContainer.memeCoins;
            var myltiply = GameDataContainer.MYLTIPLY_VALUE;
            var currentLevel = dataContainer.clickUpgradeLevels[id];

            var buyCount = CalculateBuyCount();
            var cost = CalculateFinalPrice();

            if (dataContainer.memeCoins >= dataContainer.costs[id])
            {
                    dataContainer.clickUpgradeLevels[id] += (int)buyCount;
                    dataContainer.memeCoins -= cost;

                    CalculateCost(); 

                dataContainer.clickPower += dataContainer.clickPowers[id] * buyCount;

            }

            double CalculateBuyCount() =>
            
            Math.Floor(Math.Log(currentCoins * (myltiply - 1) / (currentCost * Math.Pow(myltiply, currentLevel)) + 1, myltiply));

            double CalculateFinalPrice() =>
                currentCost * (Math.Pow(myltiply, currentLevel) * (Math.Pow(myltiply, buyCount) - 1) / (myltiply - 1));


            void CalculateCost()
            {
                var currentCost = dataContainer.costs[id];

                for (int i = 0; i < (int)buyCount; i++)
                    currentCost += (currentCost * myltiply) - currentCost;

                dataContainer.costs[id] = currentCost;

                
            }

            
        }
    


    }

