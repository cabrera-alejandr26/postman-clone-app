namespace PostmanCloneUI
{
    partial class Dashboards
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            formHeader = new Label();
            apiLabel = new Label();
            apiText = new TextBox();
            callApi = new Button();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            httpVerbSelection = new ComboBox();
            callData = new TabControl();
            bodyTab = new TabPage();
            bodyText = new TextBox();
            outputTab = new TabPage();
            resultText = new TextBox();
            headerTab = new TabPage();
            headerText = new TextBox();
            apiKeyTab = new TabPage();
            apiKeyTextBox = new TextBox();
            statusStrip.SuspendLayout();
            callData.SuspendLayout();
            bodyTab.SuspendLayout();
            outputTab.SuspendLayout();
            headerTab.SuspendLayout();
            apiKeyTab.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.BackColor = Color.White;
            formHeader.Font = new Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            formHeader.Location = new Point(632, 9);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(281, 42);
            formHeader.TabIndex = 0;
            formHeader.Text = "Postman Clone";
            formHeader.Click += formHeader_Click;
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Location = new Point(89, 80);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(53, 32);
            apiLabel.TabIndex = 1;
            apiLabel.Text = "API:";
            apiLabel.Click += apiLabel_Click;
            // 
            // apiText
            // 
            apiText.BackColor = SystemColors.InactiveCaption;
            apiText.BorderStyle = BorderStyle.FixedSingle;
            apiText.Location = new Point(225, 115);
            apiText.Name = "apiText";
            apiText.Size = new Size(483, 39);
            apiText.TabIndex = 2;
            // 
            // callApi
            // 
            callApi.Location = new Point(705, 116);
            callApi.Name = "callApi";
            callApi.Size = new Size(123, 42);
            callApi.TabIndex = 3;
            callApi.Text = "Go";
            callApi.UseVisualStyleBackColor = true;
            callApi.Click += callApi_Click;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 562);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(933, 35);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip1";
            statusStrip.ItemClicked += statusStrip_ItemClicked;
            // 
            // systemStatus
            // 
            systemStatus.BackColor = SystemColors.ControlLight;
            systemStatus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(69, 30);
            systemStatus.Text = "Ready";
            // 
            // httpVerbSelection
            // 
            httpVerbSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            httpVerbSelection.FormattingEnabled = true;
            httpVerbSelection.Items.AddRange(new object[] { "GET", "POST", "PATCH", "PUT", "DELETE" });
            httpVerbSelection.Location = new Point(89, 115);
            httpVerbSelection.Name = "httpVerbSelection";
            httpVerbSelection.Size = new Size(121, 40);
            httpVerbSelection.TabIndex = 7;
            httpVerbSelection.SelectedIndexChanged += httpVerbSelection_SelectedIndexChanged;
            // 
            // callData
            // 
            callData.Controls.Add(bodyTab);
            callData.Controls.Add(outputTab);
            callData.Controls.Add(headerTab);
            callData.Controls.Add(apiKeyTab);
            callData.Location = new Point(89, 195);
            callData.Name = "callData";
            callData.SelectedIndex = 0;
            callData.Size = new Size(739, 352);
            callData.TabIndex = 8;
            // 
            // bodyTab
            // 
            bodyTab.Controls.Add(bodyText);
            bodyTab.Location = new Point(4, 41);
            bodyTab.Name = "bodyTab";
            bodyTab.Padding = new Padding(3);
            bodyTab.Size = new Size(731, 307);
            bodyTab.TabIndex = 0;
            bodyTab.Text = "Body";
            bodyTab.UseVisualStyleBackColor = true;
            // 
            // bodyText
            // 
            bodyText.BackColor = SystemColors.InactiveCaption;
            bodyText.BorderStyle = BorderStyle.FixedSingle;
            bodyText.Dock = DockStyle.Fill;
            bodyText.Location = new Point(3, 3);
            bodyText.Multiline = true;
            bodyText.Name = "bodyText";
            bodyText.ScrollBars = ScrollBars.Both;
            bodyText.Size = new Size(725, 301);
            bodyText.TabIndex = 5;
            // 
            // outputTab
            // 
            outputTab.Controls.Add(resultText);
            outputTab.Location = new Point(4, 41);
            outputTab.Name = "outputTab";
            outputTab.Padding = new Padding(3);
            outputTab.Size = new Size(731, 307);
            outputTab.TabIndex = 1;
            outputTab.Text = "Output";
            outputTab.UseVisualStyleBackColor = true;
            // 
            // resultText
            // 
            resultText.BackColor = SystemColors.InactiveCaption;
            resultText.BorderStyle = BorderStyle.FixedSingle;
            resultText.Dock = DockStyle.Fill;
            resultText.Location = new Point(3, 3);
            resultText.Multiline = true;
            resultText.Name = "resultText";
            resultText.ReadOnly = true;
            resultText.ScrollBars = ScrollBars.Both;
            resultText.Size = new Size(725, 301);
            resultText.TabIndex = 5;
            resultText.TextChanged += resultText_TextChanged_1;
            // 
            // headerTab
            // 
            headerTab.Controls.Add(headerText);
            headerTab.Location = new Point(4, 41);
            headerTab.Name = "headerTab";
            headerTab.Size = new Size(731, 307);
            headerTab.TabIndex = 2;
            headerTab.Text = "Headers";
            headerTab.UseVisualStyleBackColor = true;
            // 
            // headerText
            // 
            headerText.BackColor = SystemColors.InactiveCaption;
            headerText.BorderStyle = BorderStyle.FixedSingle;
            headerText.Dock = DockStyle.Fill;
            headerText.Location = new Point(0, 0);
            headerText.Multiline = true;
            headerText.Name = "headerText";
            headerText.ScrollBars = ScrollBars.Both;
            headerText.Size = new Size(731, 307);
            headerText.TabIndex = 6;
            // 
            // apiKeyTab
            // 
            apiKeyTab.Controls.Add(apiKeyTextBox);
            apiKeyTab.Location = new Point(4, 41);
            apiKeyTab.Name = "apiKeyTab";
            apiKeyTab.Size = new Size(731, 307);
            apiKeyTab.TabIndex = 3;
            apiKeyTab.Text = "API Key";
            apiKeyTab.UseVisualStyleBackColor = true;
            // 
            // apiKeyTextBox
            // 
            apiKeyTextBox.BackColor = SystemColors.InactiveCaption;
            apiKeyTextBox.BorderStyle = BorderStyle.FixedSingle;
            apiKeyTextBox.Dock = DockStyle.Fill;
            apiKeyTextBox.Location = new Point(0, 0);
            apiKeyTextBox.Multiline = true;
            apiKeyTextBox.Name = "apiKeyTextBox";
            apiKeyTextBox.ScrollBars = ScrollBars.Both;
            apiKeyTextBox.Size = new Size(731, 307);
            apiKeyTextBox.TabIndex = 7;
            // 
            // Dashboards
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(933, 597);
            Controls.Add(callData);
            Controls.Add(httpVerbSelection);
            Controls.Add(statusStrip);
            Controls.Add(callApi);
            Controls.Add(apiText);
            Controls.Add(apiLabel);
            Controls.Add(formHeader);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Dashboards";
            Text = "Postman Clone by Alejandro Cabrera";
            Load += Dashboards_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            callData.ResumeLayout(false);
            bodyTab.ResumeLayout(false);
            bodyTab.PerformLayout();
            outputTab.ResumeLayout(false);
            outputTab.PerformLayout();
            headerTab.ResumeLayout(false);
            headerTab.PerformLayout();
            apiKeyTab.ResumeLayout(false);
            apiKeyTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeader;
        private Label apiLabel;
        private TextBox apiText;
        private Button callApi;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel systemStatus;
        private ComboBox httpVerbSelection;
        private TabControl callData;
        private TabPage bodyTab;
        private TabPage outputTab;
        private TextBox resultText;
        private TextBox bodyText;
        private TabPage headerTab;
        private TextBox headerText;
        private TabPage apiKeyTab;
        private TextBox apiKeyTextBox;
    }
}
