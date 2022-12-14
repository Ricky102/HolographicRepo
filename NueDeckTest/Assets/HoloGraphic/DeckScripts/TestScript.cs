using NueGames.NueDeck.Scripts.Card;
using NueGames.NueDeck.Scripts.Data.Collection;
using NueGames.NueDeck.Scripts.Data.Containers;
using NueGames.NueDeck.Scripts.Data.Settings;
using NueGames.NueDeck.Scripts.Managers;
using NueGames.NueDeck.Scripts.EnemyBehaviour;
using NueGames.NueDeck.Scripts.NueExtentions;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{

    [SerializeField] private DeckSelectionWindow myDeckSelectionWindow;
    [SerializeField] private Image myScreenBlocker;

    [SerializeField] public GameplayData gameplayData;
    [SerializeField] public DeckData whitehatData;
    [SerializeField] public DeckData greyhatData;
    [SerializeField] public DeckData blackhatData;

    protected GameManager GameManager => GameManager.Instance;

    private string userDeckSelection;
    private bool gameStart;
    private int count = 1;

    // Start is called before the first frame update
    void Start()
    {

        if (GameManager.deckSelectorCount==1)
        {
            gameStart = true;
            if (gameStart == true)
            {
                OpenDeckSelectionWindow("Choose Your Starter Deck");
                myScreenBlocker.enabled = true;
            }
            /*else
                {
                    myScreenBlocker.enabled = false;
                }*/
        }
        else
        {
            myScreenBlocker.enabled = false;
        }
    }

    private void OpenDeckSelectionWindow(string message)
    {
        myDeckSelectionWindow.gameObject.SetActive(true);
        myDeckSelectionWindow.whitehatButton.onClick.AddListener(whitehatClicked);
        myDeckSelectionWindow.greyhatButton.onClick.AddListener(greyhatClicked);
        myDeckSelectionWindow.blackhatButton.onClick.AddListener(blackhatClicked);
        myDeckSelectionWindow.messageText.text = message;
    }

    private void whitehatClicked()
    {
        myDeckSelectionWindow.gameObject.SetActive(false);
        myScreenBlocker.enabled = false;
        userDeckSelection = "whitehat";
        gameplayData.initalDeck = whitehatData;
        Debug.Log(userDeckSelection);
        gameStart = false;
        count -= 1;
        GameManager.deckSelectorCount = -1;
        GameManager.SetInitalHand();
    }

    private void greyhatClicked()
    {
        myDeckSelectionWindow.gameObject.SetActive(false);
        myScreenBlocker.enabled = false;
        userDeckSelection = "greyhat";
        gameplayData.initalDeck = greyhatData;
        Debug.Log(userDeckSelection);
        gameStart = false;
        count -= 1;
        GameManager.deckSelectorCount = -1;
        GameManager.SetInitalHand();
    }

    private void blackhatClicked()
    {
        myDeckSelectionWindow.gameObject.SetActive(false);
        myScreenBlocker.enabled = false;
        userDeckSelection = "blackhat";
        gameplayData.initalDeck = blackhatData;
        Debug.Log(userDeckSelection);
        gameStart = false;
        count -= 1;
        GameManager.deckSelectorCount = -1;
        GameManager.SetInitalHand();
    }
}
