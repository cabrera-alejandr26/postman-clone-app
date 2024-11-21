using PostmanCloneLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PostmanCloneUI;

public partial class Dashboards : Form
{
    private readonly IApiAccess api = new ApiAccess();
    public Dashboards()
    {
        InitializeComponent();
        httpVerbSelection.SelectedItem = "GET";
    }

    private void Dashboards_Load(object sender, EventArgs e)
    {

    }

    private void formHeader_Click(object sender, EventArgs e)
    {

    }

    private async void callApi_Click(object sender, EventArgs e)
    {
        systemStatus.Text = "Calling API...";
        resultText.Text = "";


        // Validate the API URL 
        if (api.IsValidUrl(apiText.Text) == false)
        {
            systemStatus.Text = "Invalid URL...";
            return;
        }

        HttpAction action;
        if (Enum.TryParse(httpVerbSelection.SelectedItem!.ToString(), out action) == false)
        {
            systemStatus.Text = "Invalid HTTP Verb";
            return;
        }

        // Parse headers
        var headers = ParseHeaders(headerText.Text);
        
        // Extract API key if provided
        string apiKey = apiKeyTextBox.Text.Trim();
        if (!string.IsNullOrEmpty(apiKey))
        {
            headers["Authorization"] = $"Bearer {apiKey}";
        }

        try
        {
            resultText.Text = await api.CallApiAsync(apiText.Text, bodyText.Text, action, true, headers);
            callData.SelectedTab = outputTab; // Switches to Output tab once we press the Go button
            outputTab.Focus();
            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            resultText.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }
    }

    private Dictionary<string, string> ParseHeaders(string headersText)
    {
        var headers = new Dictionary<string, string>();
        var lines = headersText.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        
        foreach (var line in lines)
        {
            var parts = line.Split(':');
            if (parts.Length == 2)
            {
                headers.Add(parts[0].Trim(), parts[1].Trim());
            }
        }

        return headers;
    }

    private void resultText_TextChanged(object sender, EventArgs e)
    {

    }

    private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void resultsLabel_Click(object sender, EventArgs e)
    {

    }

    private void apiLabel_Click(object sender, EventArgs e)
    {

    }

    private void httpVerbSelection_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void resultText_TextChanged_1(object sender, EventArgs e)
    {

    }
}