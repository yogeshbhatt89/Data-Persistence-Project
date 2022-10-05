using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
  // Start is called before the first frame update
  public static MenuUIHandler Instance;
  public GameObject nameInputField;
  public string currentName;

  private void Awake()
  {
    // start of new code
    if (Instance != null)
    {
      Destroy(gameObject);
      return;
    }
    // end of new code

    Instance = this;
    DontDestroyOnLoad(gameObject);
  }
  public void SetNameAndStartGame()
  {
    currentName = nameInputField.GetComponent<Text>().text;
    Debug.Log(currentName);
    SceneManager.LoadScene(1);
  }
}
