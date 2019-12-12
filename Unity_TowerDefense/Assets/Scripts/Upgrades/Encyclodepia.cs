﻿using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Encyclodepia : MonoBehaviour
{
    [SerializeField] private Image enemyImage;
    [SerializeField] private Image enemyImageShade;
    [SerializeField] private TextMeshProUGUI enemyDescription;

    [SerializeField] private Button[] enemyButtons;
    private EnemySO _currentEnemyDisplayed;
    
    private void Start()
    {
        enemyImage.enabled = false;
        enemyImageShade.enabled = false;
        enemyDescription.text = null;

        foreach (var button in enemyButtons)
        {
            button.onClick.AddListener(()=> ShowDescription(button.GetComponent<EncyclopediaButton>().enemySo));   
        }
    }

    private void ShowDescription(EnemySO enemyData)
    {
        enemyImage.enabled = true;
        enemyImageShade.enabled = true;
        
        enemyImage.sprite = enemyData.enemyIcon;
        enemyImageShade.sprite = enemyData.enemyIcon;
        enemyDescription.text = enemyData.enemyDescription;
    }
}