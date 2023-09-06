using UnityEngine;

public class InputManager : MonoBehaviour
{
    #region Fields

    [SerializeField] private KeyCode _leftJoystickButton1;
    [SerializeField] private KeyCode _leftJoystickButton2;
    [SerializeField] private KeyCode _rightJoystickButton1;
    [SerializeField] private KeyCode _rightJoystickButton2;
    [SerializeField] private KeyCode _middleButton;
    [SerializeField] private KeyCode _upArrow;
    [SerializeField] private KeyCode _bottomArrow;
    [SerializeField] private KeyCode _leftArrow;
    [SerializeField] private KeyCode _rightArrow;
    [SerializeField] private KeyCode _redButton;
    [SerializeField] private KeyCode _blueButton;
    [SerializeField] private KeyCode _button1_1;
    [SerializeField] private KeyCode _button1_2;
    [SerializeField] private KeyCode _button1_3;
    [SerializeField] private KeyCode _button2_1;
    [SerializeField] private KeyCode _button2_2;
    [SerializeField] private KeyCode _button2_3;
    
    private static InputManager _instance;

    #endregion

    #region Properties

    public static InputManager Instance => _instance;
    
    public KeyCode LeftJoystickButton1 => _leftJoystickButton1;
    
    public KeyCode LeftJoystickButton2 => _leftJoystickButton2;
    
    public KeyCode RightJoystickButton1 => _rightJoystickButton1;
    
    public KeyCode RightJoystickButton2 => _rightJoystickButton2;
    
    public KeyCode MiddleButton => _middleButton;

    public KeyCode UpArrow => _upArrow;

    public KeyCode BottomArrow => _bottomArrow;

    public KeyCode LeftArrow => _leftArrow;

    public KeyCode RightArrow => _rightArrow;

    public KeyCode RedButton => _redButton;

    public KeyCode BlueButton => _blueButton;

    public KeyCode Button1_1 => _button1_1;
    
    public KeyCode Button1_2 => _button1_2;
    
    public KeyCode Button1_3 => _button1_3;
    
    public KeyCode Button2_1 => _button2_1;
    
    public KeyCode Button2_2 => _button2_2;
    
    public KeyCode Button2_3 => _button2_3;

    #endregion

    #region Unity Event Functions

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);   
        }

        _instance = this;
    }

    #endregion
}
