using PostmanCloneLibrary;

namespace PostmanCloneUI;

public partial class Dashboards : Form
{
    private readonly IApiAccess api = new ApiAccess();
    public Dashboards()
    {
        InitializeComponent();
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

        try
        {
            

            resultText.Text = await api.CallApiAsync(apiText.Text);

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
}
