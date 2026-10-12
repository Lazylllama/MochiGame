using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    // Variabel för att hålla reda på poängen
    private int score = 0;

    // Referens till texten som visar poängen i spelet
    public TextMeshProUGUI scoreText;

    // Denna funktion körs varje gång du klickar på knappen
    public void IncreaseScore()
    {
        // Öka poängen med 1
        score++;

        // Uppdatera texten på skärmen
        scoreText.text = "Poäng: " + score;
    }
}



