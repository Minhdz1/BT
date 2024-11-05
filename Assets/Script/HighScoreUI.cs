using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreUI : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] GameObject highscoreUIElementPrefab;
    [SerializeField] Transform elementWrapper;
    List<GameObject> uiElements = new List<GameObject>();
    private void OnEnable()
    {
        Bird.onHighScoreListChanged += UpdateUI;

    }
    private void OnDisable()
    {
        Bird.onHighScoreListChanged -= UpdateUI;

    }
    public void ShowlPanel()
    {
        panel.SetActive(true);
    }
     public void ClosePanel()
    {
        panel.SetActive(false);
    }
    private void UpdateUI(List<HighSocreElement> list)
    {
        for(int i =0; i < list.Count; i++)
        {
            
            HighSocreElement el = list[i];
            if(el.point > 0) { 
              if( i >= uiElements.Count)
                {
                    var inst = Instantiate(highscoreUIElementPrefab, Vector3.zero, Quaternion.identity);
                    inst.transform.SetParent(elementWrapper);

                    uiElements.Add(inst);
                }
               

            
                }
            var texts = uiElements[i].GetComponentsInChildren<Text>();
            texts[0].text = el.playerName;
            texts[1].text = el.point.ToString();

        }
    }
}
