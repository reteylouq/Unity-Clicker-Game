using UnityEngine;
using UnityEngine.UI;

    public class UIHandler : MonoBehaviour
    {
       [SerializeField] private GameDataContainer dataContainer;

        // public Text scoreText;
        // public ClickHandler _clickHandler;

        private void Awake()
        {
            if(dataContainer == null)
                dataContainer = GameObject.FindObjectOfType<GameDataContainer>();
           // if (_clickHandler == null)
             //   _clickHandler = GameObject.FindObjectOfType<ClickHandler>();
        }
        private void Update()
        {
            UpdateMemeCoinsTexts();
            UpdateCostsTextCatShop();
            UpdateClickPowerTextsCatShop();
            UpdateLevelText();
        }

        private void UpdateLevelText()
        {
            for (int i = 0; i < dataContainer.clickUpgradeLevelsTexts.Length; i++)
            {
                dataContainer.clickUpgradeLevelsTexts[i].text = $"Level: {(int)dataContainer.clickUpgradeLevels[i]}";
            }
        }

        private void UpdateMemeCoinsTexts() 
        { 
            for (int index = 0; index < dataContainer.scoreTexts.Length; index++)
            {
                dataContainer.scoreTexts[index].text = $"MCoin: {(int)dataContainer.memeCoins}";
            }
        }
        private void UpdateCostsTextCatShop()
        {
            for (int i = 0; i < dataContainer.costTexts.Length; i++)
            {
                dataContainer.costTexts[i].text = $"Cost:{(int)dataContainer.costs[i]}";
            }
        }
        private void UpdateClickPowerTextsCatShop()
            {
                for (int i = 0; i < dataContainer.clickPowerTexts.Length; i++)
                {
                    dataContainer.clickPowerTexts[i].text = $"Click:{(int)dataContainer.clickPowers[i]}";
                }
            }
    }
