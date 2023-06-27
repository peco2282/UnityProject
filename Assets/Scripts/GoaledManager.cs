using UnityEngine;
using UnityEngine.SceneManagement;

public class GoaledManager : MonoBehaviour
{
  // Update is called once per frame
  void Update()
  {
    if (Input.anyKey)
    {
      SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }
  }
}