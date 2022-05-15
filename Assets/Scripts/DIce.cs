using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DIce : MonoBehaviour
{
    public Image dice;
    //player1
    public Text P1rollNo ;
    public Text P1score;
    public Image P1backgroundActive;
    public Button P1rollDiceBtn; 
    public Button P1SaveBtn; 
    //player2
    public Text P2rollNo ;
    public Text P2score;
    public Image P2backgroundActive;
    public Button P2rollDiceBtn; 
    public Button P2SaveBtn; 
    //dice images
    public Sprite dice1;
    public Sprite dice2;
    public Sprite dice3;
    public Sprite dice4;
    public Sprite dice5;
    public Sprite dice6;
    public Sprite roll;
    public Sprite win;

     int noRP1 = 0 ;
     int p1CurrentCount = 0;
     int p2CurrentCount = 0;
     int p1SavedCount = 0 ;
     int p2SavedCount = 0 ;


     int noRP2 = 0 ;

     int no ;
    void Start(){
        dice.sprite = roll;
        P1backgroundActive.color = UnityEngine.Color.green ; 
        P2rollDiceBtn.interactable = false;
        P2SaveBtn.interactable = false;
    }
        public void p1RolledDice (){
        no = UnityEngine.Random.Range(1,7);
        if(no != 1)
       { 
            if( no == 1 ) dice.sprite = dice1;
            else if (no == 2) dice.sprite = dice2;
            else if (no == 3) dice.sprite = dice3;
            else if (no == 4) dice.sprite = dice4;
            else if (no == 5) dice.sprite = dice5;
            else if (no == 6) dice.sprite = dice6;
            P1rollNo.text = no.ToString();
            p1CurrentCount += no;
            noRP1 += p1CurrentCount;
            P1score.text = noRP1.ToString();
            noRP1 = 0 + p1SavedCount;
    }
        else {
                P1backgroundActive.color = UnityEngine.Color.red;
                P1rollDiceBtn.interactable = false;
                p1CurrentCount = 0 ;
                P1score.text = noRP1.ToString() ;
        }
        
            
    }
    public void p2RolledDice (){
        no = UnityEngine.Random.Range(1,7);
        if(no != 1)
       { 
            if( no == 1 ) dice.sprite = dice1;
            else if (no == 2) dice.sprite = dice2;
            else if (no == 3) dice.sprite = dice3;
            else if (no == 4) dice.sprite = dice4;
            else if (no == 5) dice.sprite = dice5;
            else if (no == 6) dice.sprite = dice6;
            P2rollNo.text = no.ToString();
            p2CurrentCount += no;
            noRP2 += p2CurrentCount;
            P2score.text = noRP2.ToString() ;
            noRP2 = 0 + p2SavedCount;
    }
        else {
                P2backgroundActive.color = UnityEngine.Color.red;
                P2rollDiceBtn.interactable = false;
                p2CurrentCount = 0 ;
                P2score.text = noRP2.ToString() ;
        }
        
    }
    public void P1saveBtnPressed(){
        P1backgroundActive.color = UnityEngine.Color.white;
        P2backgroundActive.color = UnityEngine.Color.green;
        P1rollNo.text = "0";
        P1rollDiceBtn.interactable = false;
        P1SaveBtn.interactable = false;
        P2rollDiceBtn.interactable = true;
        P2SaveBtn.interactable = true;
        dice.sprite = roll;
        p1SavedCount += p1CurrentCount;
        p1CurrentCount = 0 ;
        
    }

    public void P2saveBtnPressed(){
        P2backgroundActive.color = UnityEngine.Color.white;
         P2rollDiceBtn.interactable = false;
        P2SaveBtn.interactable = false;
        P1backgroundActive.color = UnityEngine.Color.green;
        P2rollNo.text = "0";
        P1rollDiceBtn.interactable = true;
        P1SaveBtn.interactable = true;
        dice.sprite = roll;
        p2SavedCount += p2CurrentCount;
        p2CurrentCount = 0 ;
    }

    public void reset(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

