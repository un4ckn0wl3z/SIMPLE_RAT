﻿namespace Server.UI.Forms
{
    partial class ClientManager
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
            this.components = new System.ComponentModel.Container();
            this.listClients = new System.Windows.Forms.ListView();
            this.columnIdentification = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnWAN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnComputer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOperatingSystem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRAM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientManagerMenuStrip = new System.Windows.Forms.MenuStrip();
            this.catFile = new System.Windows.Forms.ToolStripMenuItem();
            this.catServer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnServerSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.contextClient = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.catConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClientDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.clientManagerMenuStrip.SuspendLayout();
            this.contextClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // listClients
            // 
            this.listClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIdentification,
            this.columnWAN,
            this.columnComputer,
            this.columnOperatingSystem,
            this.columnRAM,
            this.columnVersion});
            this.listClients.ContextMenuStrip = this.contextClient;
            this.listClients.FullRowSelect = true;
            this.listClients.GridLines = true;
            this.listClients.Location = new System.Drawing.Point(60, 32);
            this.listClients.Margin = new System.Windows.Forms.Padding(4);
            this.listClients.Name = "listClients";
            this.listClients.Size = new System.Drawing.Size(805, 320);
            this.listClients.TabIndex = 2;
            this.listClients.UseCompatibleStateImageBehavior = false;
            this.listClients.View = System.Windows.Forms.View.Details;
            // 
            // columnIdentification
            // 
            this.columnIdentification.Text = "Identification";
            this.columnIdentification.Width = 89;
            // 
            // columnWAN
            // 
            this.columnWAN.Text = "WAN Address";
            this.columnWAN.Width = 106;
            // 
            // columnComputer
            // 
            this.columnComputer.Text = "Computer";
            this.columnComputer.Width = 96;
            // 
            // columnOperatingSystem
            // 
            this.columnOperatingSystem.Text = "Operating System";
            this.columnOperatingSystem.Width = 127;
            // 
            // columnRAM
            // 
            this.columnRAM.Text = "RAM";
            this.columnRAM.Width = 65;
            // 
            // columnVersion
            // 
            this.columnVersion.Text = "Version";
            this.columnVersion.Width = 79;
            // 
            // clientManagerMenuStrip
            // 
            this.clientManagerMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.clientManagerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catFile,
            this.catServer});
            this.clientManagerMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.clientManagerMenuStrip.Name = "clientManagerMenuStrip";
            this.clientManagerMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.clientManagerMenuStrip.Size = new System.Drawing.Size(965, 28);
            this.clientManagerMenuStrip.TabIndex = 3;
            this.clientManagerMenuStrip.Text = "menuStrip1";
            // 
            // catFile
            // 
            this.catFile.Name = "catFile";
            this.catFile.Size = new System.Drawing.Size(44, 24);
            this.catFile.Text = "File";
            // 
            // catServer
            // 
            this.catServer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnServerSettings});
            this.catServer.Name = "catServer";
            this.catServer.Size = new System.Drawing.Size(62, 24);
            this.catServer.Text = "Server";
            // 
            // btnServerSettings
            // 
            this.btnServerSettings.Name = "btnServerSettings";
            this.btnServerSettings.Size = new System.Drawing.Size(216, 26);
            this.btnServerSettings.Text = "Settings";
            this.btnServerSettings.Click += new System.EventHandler(this.btnServerSettings_Click_1);
            // 
            // contextClient
            // 
            this.contextClient.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catConnection});
            this.contextClient.Name = "contextClient";
            this.contextClient.Size = new System.Drawing.Size(154, 28);
            // 
            // catConnection
            // 
            this.catConnection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClientDisconnect});
            this.catConnection.Name = "catConnection";
            this.catConnection.Size = new System.Drawing.Size(210, 24);
            this.catConnection.Text = "Connection";
            // 
            // btnClientDisconnect
            // 
            this.btnClientDisconnect.Name = "btnClientDisconnect";
            this.btnClientDisconnect.Size = new System.Drawing.Size(157, 26);
            this.btnClientDisconnect.Text = "Disconnect";
            // 
            // ClientManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 407);
            this.Controls.Add(this.listClients);
            this.Controls.Add(this.clientManagerMenuStrip);
            this.Name = "ClientManager";
            this.Text = "ClientManager";
            this.Load += new System.EventHandler(this.ClientManager_Load);
            this.clientManagerMenuStrip.ResumeLayout(false);
            this.clientManagerMenuStrip.PerformLayout();
            this.contextClient.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listClients;
        private System.Windows.Forms.ColumnHeader columnIdentification;
        private System.Windows.Forms.ColumnHeader columnWAN;
        private System.Windows.Forms.ColumnHeader columnComputer;
        private System.Windows.Forms.ColumnHeader columnOperatingSystem;
        private System.Windows.Forms.ColumnHeader columnRAM;
        private System.Windows.Forms.ColumnHeader columnVersion;
        private System.Windows.Forms.MenuStrip clientManagerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem catFile;
        private System.Windows.Forms.ToolStripMenuItem catServer;
        private System.Windows.Forms.ToolStripMenuItem btnServerSettings;
        private System.Windows.Forms.ContextMenuStrip contextClient;
        private System.Windows.Forms.ToolStripMenuItem catConnection;
        private System.Windows.Forms.ToolStripMenuItem btnClientDisconnect;
    }
}