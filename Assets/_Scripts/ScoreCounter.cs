using UnityEngine;
using UnityEngine.UI;

/// <summary>
///     Shows the player's score in the top-left corner of the screen.
///     It builds its own Canvas and Text at runtime, so nothing has to be
///     set up in the scene. The score resets when the scene restarts.
/// </summary>
public class ScoreCounter : MonoBehaviour
{
    static private ScoreCounter S;

    [Header("Set in Inspector")]
    public int   fontSize = 36;
    public Color textColor = Color.white;

    [Header("Set Dynamically")]
    public int score = 0;

    private Text scoreText;

    /// <summary>Adds points to the score, creating the counter if needed.</summary>
    static public void AddPoints(int points)
    {
        if (S == null) Create();
        S.score += points;
        S.UpdateText();
    }

    /// <summary>Makes sure the counter exists and is showing on screen.</summary>
    static public void Create()
    {
        if (S != null) return;
        new GameObject("ScoreCounter").AddComponent<ScoreCounter>();
    }

    private void Awake()
    {
        S = this;
        BuildUI();
        UpdateText();
    }

    private void OnDestroy()
    {
        if (S == this) S = null;
    }

    private void BuildUI()
    {
        // Canvas that draws on top of the game
        Canvas canvas = gameObject.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        canvas.sortingOrder = 100;

        CanvasScaler scaler = gameObject.AddComponent<CanvasScaler>();
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scaler.referenceResolution = new Vector2(1280, 720);

        // Text anchored to the top-left corner
        GameObject textGO = new GameObject("ScoreText");
        textGO.transform.SetParent(transform, false);

        scoreText = textGO.AddComponent<Text>();
        scoreText.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        scoreText.fontSize = fontSize;
        scoreText.fontStyle = FontStyle.Bold;
        scoreText.color = textColor;
        scoreText.alignment = TextAnchor.UpperLeft;
        scoreText.horizontalOverflow = HorizontalWrapMode.Overflow;
        scoreText.verticalOverflow = VerticalWrapMode.Overflow;

        RectTransform rt = scoreText.rectTransform;
        rt.anchorMin = new Vector2(0, 1);
        rt.anchorMax = new Vector2(0, 1);
        rt.pivot = new Vector2(0, 1);
        rt.anchoredPosition = new Vector2(20, -20);
        rt.sizeDelta = new Vector2(400, 60);
    }

    private void UpdateText()
    {
        if (scoreText != null) scoreText.text = "Score: " + score;
    }
}
