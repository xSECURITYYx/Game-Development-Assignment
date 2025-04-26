using UnityEngine;
using TMPro;

public class BallCounter : MonoBehaviour
{
    public TMP_Text ballCountText; 
    private int count = 0;

    public void IncrementCount()
    {
        count++;
        ballCountText.text = count.ToString();
    }
}
