using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDataContainer : MonoBehaviour
{
    public const double MYLTIPLY_VALUE = 1.07;

    [Header("Sprites")]
     public SpriteRenderer catSprite;

     [Header("GameObjects")]
     public GameObject apple;
     public Transform spawnPoint;

     [Header("Score")]
     public double clickPower = 1;
     public double memeCoins = 0;
     public Text[] scoreTexts;

//     [Header("Texts")]
 //     public Text[] scoreTexts;

    [Header("Shop Controller")]
//    [Tooltip("ціна за лвлап бонуса")]
    public double[] costs;
 //   [Tooltip("бонус за клік")]
    public double[] clickPowers;

    [Space]
    public Text[] costTexts;
    public Text[] clickPowerTexts;


    [Header("Levels")]
    public int[] clickUpgradeLevels;
    public Text[] clickUpgradeLevelsTexts;

}
