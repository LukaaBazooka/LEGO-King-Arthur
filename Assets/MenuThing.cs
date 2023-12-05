using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.Security.Cryptography.X509Certificates;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Net;
using System.Text.RegularExpressions;

public class MenuThing : MonoBehaviour
{
    


    public TextMeshProUGUI Startbutton;
    public Image img;

    public GameObject Play;
    public GameObject Options;
    public GameObject Controls;
    public GameObject Updates;


    public GameObject txt;
    public string weblink = "https://lukaabazooka.github.io/lego/help.html";

    public void Update()
    {

        string html = new WebClient().DownloadString(weblink);
        html = StripHtml(html);

        txt.GetComponent<TMPro.TextMeshProUGUI>().text = html;


    }
    public string StripHtml(string input)
    {
        // Will this simple expression replace all tags???
        var tagsExpression = new Regex(@"</?.+?>");
        return tagsExpression.Replace(input, " ");
    }
    public void Runs()
    {
        StartCoroutine(initalize());

    }
    public IEnumerator initalize()
    {
        Debug.Log("PSFSDFGSDF");

        float num = 1f;
        LeanTween.alpha(img.rectTransform, 0f, 1f);
        for (int i = 0; i < 10; i++)
        {
            num -= 0.1f;
            yield return new WaitForSeconds(0.1f);
            Startbutton.alpha = num;

        }

        yield return new WaitForSeconds(0.2f);
        LeanTween.moveLocalX(Play, -276.6f, 2f).setEaseInOutQuad();
        yield return new WaitForSeconds(0.25f);
        LeanTween.moveLocalX(Options,-276.6f, 2f).setEaseInOutQuad();
        yield return new WaitForSeconds(0.25f);
        LeanTween.moveLocalX(Controls,-276.6f, 2f).setEaseInOutQuad();
        yield return new WaitForSeconds(0.25f);
        LeanTween.moveLocalX(Updates,249.2f, 2f).setEaseInOutQuad();



 
    }



}
