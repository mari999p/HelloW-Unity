using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
    #region Variables

    [SerializeField] private int _max = 1000;
    [SerializeField] private int _min = 500;

    private int _guess;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        Debug.Log("Привет в Magic Numbers. Загадай число от {_min} до {_max}");
        Debug.Log("Test");

        CalculateGuessAndLong();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _guess = _max;
            CalculateGuessAndLong();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _min = _guess;
            CalculateGuessAndLong();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log($"УРА! Твое число отгадано и равно {_guess}!");
        }
    }

    #endregion

    #region Private methods

    private void CalculateGuessAndLong()
    {
        _guess = (_max + _min) / 2;
        Debug.Log($"Твое число равно {_guess}?");
    }

    #endregion
}