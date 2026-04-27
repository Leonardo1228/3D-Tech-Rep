using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtomReset : MonoBehaviour
{
public void Restart (int Nescena)
    {
        SceneManager.LoadScene(Nescena);
    }
}
