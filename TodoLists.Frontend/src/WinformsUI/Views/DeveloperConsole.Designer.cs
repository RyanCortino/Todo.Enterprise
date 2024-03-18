namespace WinformsUI.Views;

partial class DeveloperConsole
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        flowLayoutPanel1 = new FlowLayoutPanel();
        groupBox1 = new GroupBox();
        EmailActual = new TextBox();
        PasswordActual = new TextBox();
        LoginButton = new Button();
        label1 = new Label();
        label3 = new Label();
        flowLayoutPanel1.SuspendLayout();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Controls.Add(groupBox1);
        flowLayoutPanel1.Dock = DockStyle.Fill;
        flowLayoutPanel1.Location = new Point(0, 0);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(800, 450);
        flowLayoutPanel1.TabIndex = 5;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(EmailActual);
        groupBox1.Controls.Add(PasswordActual);
        groupBox1.Controls.Add(LoginButton);
        groupBox1.Location = new Point(3, 3);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(200, 111);
        groupBox1.TabIndex = 7;
        groupBox1.TabStop = false;
        groupBox1.Text = "groupBox1";
        // 
        // EmailActual
        // 
        EmailActual.Location = new Point(94, 22);
        EmailActual.Name = "EmailActual";
        EmailActual.Size = new Size(100, 23);
        EmailActual.TabIndex = 0;
        // 
        // PasswordActual
        // 
        PasswordActual.Location = new Point(94, 51);
        PasswordActual.Name = "PasswordActual";
        PasswordActual.Size = new Size(100, 23);
        PasswordActual.TabIndex = 1;
        PasswordActual.UseSystemPasswordChar = true;
        // 
        // LoginButton
        // 
        LoginButton.Location = new Point(119, 80);
        LoginButton.Name = "LoginButton";
        LoginButton.Size = new Size(75, 23);
        LoginButton.TabIndex = 2;
        LoginButton.Text = "Login";
        LoginButton.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(52, 25);
        label1.Name = "label1";
        label1.Size = new Size(36, 15);
        label1.TabIndex = 3;
        label1.Text = "Email";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(31, 54);
        label3.Name = "label3";
        label3.Size = new Size(57, 15);
        label3.TabIndex = 3;
        label3.Text = "Password";
        // 
        // DeveloperConsole
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(flowLayoutPanel1);
        Name = "DeveloperConsole";
        Text = "Dev Console";
        flowLayoutPanel1.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private FlowLayoutPanel flowLayoutPanel1;
    private GroupBox groupBox1;
    private Label label3;
    private Label label1;
    private TextBox EmailActual;
    private TextBox PasswordActual;
    private Button LoginButton;
}
