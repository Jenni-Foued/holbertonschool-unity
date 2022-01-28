using UnityEngine;

public class goUrl : MonoBehaviour
{
    public void ToGithub() {
        Application.OpenURL ("https://github.com/Jenni-Foued");
    }
    public void ToTwitter() {
        Application.OpenURL ("https://twitter.com/jenni_foued");
    }
    public void ToMail() {
        Application.OpenURL ("mailto:medfouedjenni@gmail.com");
    }
    public void ToLinkedin() {
        Application.OpenURL ("https://www.linkedin.com/in/med-foued-jenni/");
    }
}
