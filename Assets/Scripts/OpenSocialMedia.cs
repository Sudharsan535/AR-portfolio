using UnityEngine;

public class OpenSocialMedia : MonoBehaviour
{
    // Add your profile URLs here
    [SerializeField] private string instagramURL = "https://www.instagram.com/sudharsan.__s";
    [SerializeField] private string linkedinURL = "https://www.linkedin.com/in/sudharsanxr";
    [SerializeField] private string githubURL = "https://github.com/Sudharsan535";
    [SerializeField] private string xURL = "https://x.com/itsmessudharsan";
    [SerializeField] private string behanceURL = "https://behance.net/sudharsans15";
    [SerializeField] private string discordURL = "https://discord.com/channels/sudharsan5305";

    public void OpenInstagram()
    {
        Application.OpenURL(instagramURL);
    }

    public void OpenLinkedIn()
    {
        Application.OpenURL(linkedinURL);
    }

    public void OpenGitHub()
    {
        Application.OpenURL(githubURL);
    }

    public void OpenX()
    {
        Application.OpenURL(xURL);
    }

    public void OpenBehance()
    {
        Application.OpenURL(behanceURL);
    }

    public void OpenDiscord()
    {
        Application.OpenURL(discordURL);
    }
}
