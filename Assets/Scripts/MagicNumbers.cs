using TMPro;
using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
    #region Variables

    [SerializeField] private int _max = 1000;
    [SerializeField] private int _min = 100;
    [SerializeField] private TextMeshProUGUI _outputText;
    private int _attempts;
    private int _guess;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        _attempts = 0;
        _outputText.text = $"Привет в Magi Numbers! Загадай число от {_min} до {_max} ";
        CalculateGuessAndLong();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _max = _guess;
            CalculateGuessAndLong();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _min = _guess;
            CalculateGuessAndLong();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _outputText.text = $"УРА! Твое число отгадано и равно {_guess}! Количество попыток: {_attempts}";
            RestartGame();
        }
    }

    #endregion

    #region Private methods

    private void CalculateGuessAndLong()
    {
        _guess = (_max + _min) / 2;
        _attempts++;
        _outputText.text = $"Твое число равно {_guess}?";
    }

    private void RestartGame()
    {
        _min = 100;
        _min = 1000;
        _attempts = 0;
        CalculateGuessAndLong();
    }

    #endregion
}