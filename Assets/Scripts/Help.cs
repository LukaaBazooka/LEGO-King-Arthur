using System.Net;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class loadText : MonoBehaviour
{

    public GameObject txt;
    [SerializeField]


    public string weblink = "https://nathant531508.github.io/Lego/help.html";

    // Start is called before the first frame update
    void Update()
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


}