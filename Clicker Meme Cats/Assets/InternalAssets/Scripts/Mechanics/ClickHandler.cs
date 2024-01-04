using UnityEngine;


    public class ClickHandler : MonoBehaviour
    {
       [SerializeField] private GameDataContainer dataContainer;

      //  public SpriteRenderer catSprite;

        // public GameObject apple;
         // public Transform spawnPoint;

        // public double score = 0;


        private void Awake()
        {
            if (dataContainer == null)
            dataContainer = GameObject.FindObjectOfType<GameDataContainer>();

        }

        public void OnClick()
        {
            dataContainer.memeCoins += dataContainer.clickPower;

            dataContainer.catSprite.flipX = !dataContainer.catSprite.flipX;

            Instantiate(dataContainer.apple, dataContainer.spawnPoint.position, Quaternion.identity);

        }
    }
