using PostmanCloneLibrary;

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


        //Validate the API URL 
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

        try
        {
            resultText.Text = await api.CallApiAsync(apiText.Text, bodyText.Text, action);
            callData.SelectedTab = outputTab;// Switches to Output tab once we press the Go button
            outputTab.Focus();
            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            resultText.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }
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
