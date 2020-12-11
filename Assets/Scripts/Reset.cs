using UnityEngine;
using UnityEngine.SceneManagement;
public class Reset : MonoBehaviour
{
    //Метод перезапуска сцены
    public void ResetButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GM.Play = true;
    }
}