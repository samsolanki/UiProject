using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HeroUpgradeUI : MonoBehaviour
{
    [SerializeField] private Image img_HeroImage;
    [SerializeField] private TextMeshProUGUI txt_HeroName;
    [SerializeField] private TextMeshProUGUI txt_CurrentHeroLevel;
    [SerializeField] private TextMeshProUGUI txt_CurrentHeroCards;
    [SerializeField] private TextMeshProUGUI txt_RequireCardsToUpgrade;
    [SerializeField] private TextMeshProUGUI txt_DescriptionHeading;
    [SerializeField] private TextMeshProUGUI txt_Desctioptin;
    [SerializeField] private TextMeshProUGUI txt_CoinsForUpgrade;
}
