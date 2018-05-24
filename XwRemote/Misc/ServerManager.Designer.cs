﻿namespace XwRemote
{
    partial class ServerManager
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.treeServers = new System.Windows.Forms.TreeView();
            this.tabStrip1 = new Messir.Windows.Forms.TabStrip();
            this.FilterGrouped = new Messir.Windows.Forms.TabStripButton();
            this.FilterOrdered = new Messir.Windows.Forms.TabStripButton();
            this.FilterFavorites = new Messir.Windows.Forms.TabStripButton();
            this.contextGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.newFTPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRDPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newVNCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSSHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newIEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.NewFTP = new System.Windows.Forms.Button();
            this.NewRDP = new System.Windows.Forms.Button();
            this.NewVNC = new System.Windows.Forms.Button();
            this.newSSH = new System.Windows.Forms.Button();
            this.EditServer = new System.Windows.Forms.Button();
            this.DeleteServer = new System.Windows.Forms.Button();
            this.contextServer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.makeCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAsFTP = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAsRDP = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAsVNC = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAsSSH = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAsIE = new System.Windows.Forms.ToolStripMenuItem();
            this.newIE = new System.Windows.Forms.Button();
            this.dialogHeader1 = new XwMaxLib.UI.DialogHeader();
            this.newSQL = new System.Windows.Forms.Button();
            this.NewSFTP = new System.Windows.Forms.Button();
            this.NewS3 = new System.Windows.Forms.Button();
            this.NewAzureFile = new System.Windows.Forms.Button();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabStrip1.SuspendLayout();
            this.contextGroup.SuspendLayout();
            this.contextServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.treeServers);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(358, 424);
            this.toolStripContainer1.Location = new System.Drawing.Point(12, 56);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(358, 449);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tabStrip1);
            this.toolStripContainer1.TopToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // treeServers
            // 
            this.treeServers.AllowDrop = true;
            this.treeServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeServers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeServers.HideSelection = false;
            this.treeServers.LineColor = System.Drawing.Color.SkyBlue;
            this.treeServers.Location = new System.Drawing.Point(0, 0);
            this.treeServers.Name = "treeServers";
            this.treeServers.ShowNodeToolTips = true;
            this.treeServers.Size = new System.Drawing.Size(358, 424);
            this.treeServers.TabIndex = 0;
            this.treeServers.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeServers_AfterLabelEdit);
            this.treeServers.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.treeServers_AfterCollapse);
            this.treeServers.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeServers_AfterExpand);
            this.treeServers.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeServers_ItemDrag);
            this.treeServers.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeServers_AfterSelect);
            this.treeServers.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeServers_DragDrop);
            this.treeServers.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeServers_DragEnter);
            this.treeServers.DragOver += new System.Windows.Forms.DragEventHandler(this.treeServers_DragOver);
            this.treeServers.DragLeave += new System.EventHandler(this.treeServers_DragLeave);
            this.treeServers.DoubleClick += new System.EventHandler(this.treeServers_DoubleClick);
            this.treeServers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeServers_MouseDown);
            this.treeServers.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeServers_MouseUp);
            // 
            // tabStrip1
            // 
            this.tabStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.tabStrip1.FlipButtons = false;
            this.tabStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.tabStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tabStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterGrouped,
            this.FilterOrdered,
            this.FilterFavorites});
            this.tabStrip1.Location = new System.Drawing.Point(3, 0);
            this.tabStrip1.Name = "tabStrip1";
            this.tabStrip1.RenderStyle = System.Windows.Forms.ToolStripRenderMode.System;
            this.tabStrip1.SelectedTab = this.FilterGrouped;
            this.tabStrip1.Size = new System.Drawing.Size(219, 25);
            this.tabStrip1.TabIndex = 0;
            this.tabStrip1.UseVisualStyles = false;
            // 
            // FilterGrouped
            // 
            this.FilterGrouped.AutoToolTip = false;
            this.FilterGrouped.Checked = true;
            this.FilterGrouped.HotTextColor = System.Drawing.SystemColors.ControlText;
            this.FilterGrouped.Image = global::XwRemote.Properties.Resources.group;
            this.FilterGrouped.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FilterGrouped.IsSelected = true;
            this.FilterGrouped.Margin = new System.Windows.Forms.Padding(0);
            this.FilterGrouped.Name = "FilterGrouped";
            this.FilterGrouped.Padding = new System.Windows.Forms.Padding(0);
            this.FilterGrouped.SelectedFont = new System.Drawing.Font("Segoe UI", 9F);
            this.FilterGrouped.SelectedTextColor = System.Drawing.SystemColors.ControlText;
            this.FilterGrouped.Size = new System.Drawing.Size(73, 25);
            this.FilterGrouped.Text = "Grouped";
            this.FilterGrouped.Click += new System.EventHandler(this.FilterGrouped_Click);
            // 
            // FilterOrdered
            // 
            this.FilterOrdered.AutoToolTip = false;
            this.FilterOrdered.HotTextColor = System.Drawing.SystemColors.ControlText;
            this.FilterOrdered.Image = global::XwRemote.Properties.Resources.nogroup;
            this.FilterOrdered.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FilterOrdered.IsSelected = false;
            this.FilterOrdered.Margin = new System.Windows.Forms.Padding(0);
            this.FilterOrdered.Name = "FilterOrdered";
            this.FilterOrdered.Padding = new System.Windows.Forms.Padding(0);
            this.FilterOrdered.SelectedFont = new System.Drawing.Font("Segoe UI", 9F);
            this.FilterOrdered.SelectedTextColor = System.Drawing.SystemColors.ControlText;
            this.FilterOrdered.Size = new System.Drawing.Size(70, 25);
            this.FilterOrdered.Text = "Ordered";
            this.FilterOrdered.Click += new System.EventHandler(this.FilterOrdered_Click);
            // 
            // FilterFavorites
            // 
            this.FilterFavorites.AutoToolTip = false;
            this.FilterFavorites.HotTextColor = System.Drawing.SystemColors.ControlText;
            this.FilterFavorites.Image = global::XwRemote.Properties.Resources.favs;
            this.FilterFavorites.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FilterFavorites.IsSelected = false;
            this.FilterFavorites.Margin = new System.Windows.Forms.Padding(0);
            this.FilterFavorites.Name = "FilterFavorites";
            this.FilterFavorites.Padding = new System.Windows.Forms.Padding(0);
            this.FilterFavorites.SelectedFont = new System.Drawing.Font("Segoe UI", 9F);
            this.FilterFavorites.SelectedTextColor = System.Drawing.SystemColors.ControlText;
            this.FilterFavorites.Size = new System.Drawing.Size(74, 25);
            this.FilterFavorites.Text = "Favorites";
            this.FilterFavorites.Click += new System.EventHandler(this.FilterFavorites_Click);
            // 
            // contextGroup
            // 
            this.contextGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGroupToolStripMenuItem,
            this.renameGroupToolStripMenuItem,
            this.deleteGroupToolStripMenuItem,
            this.toolStripSeparator2,
            this.newFTPToolStripMenuItem,
            this.newRDPToolStripMenuItem,
            this.newVNCToolStripMenuItem,
            this.newSSHToolStripMenuItem,
            this.newIEToolStripMenuItem});
            this.contextGroup.Name = "contextMenuStrip1";
            this.contextGroup.Size = new System.Drawing.Size(173, 186);
            // 
            // addGroupToolStripMenuItem
            // 
            this.addGroupToolStripMenuItem.Image = global::XwRemote.Properties.Resources.folder;
            this.addGroupToolStripMenuItem.Name = "addGroupToolStripMenuItem";
            this.addGroupToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.addGroupToolStripMenuItem.Text = "Add Group";
            this.addGroupToolStripMenuItem.Click += new System.EventHandler(this.AddGroup_Click);
            // 
            // renameGroupToolStripMenuItem
            // 
            this.renameGroupToolStripMenuItem.Image = global::XwRemote.Properties.Resources.pencil;
            this.renameGroupToolStripMenuItem.Name = "renameGroupToolStripMenuItem";
            this.renameGroupToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.renameGroupToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.renameGroupToolStripMenuItem.Text = "Rename Group";
            this.renameGroupToolStripMenuItem.Click += new System.EventHandler(this.RenameGroup_Click);
            // 
            // deleteGroupToolStripMenuItem
            // 
            this.deleteGroupToolStripMenuItem.Image = global::XwRemote.Properties.Resources.delete;
            this.deleteGroupToolStripMenuItem.Name = "deleteGroupToolStripMenuItem";
            this.deleteGroupToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.deleteGroupToolStripMenuItem.Text = "Delete Group";
            this.deleteGroupToolStripMenuItem.Click += new System.EventHandler(this.DeleteGroup_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            // 
            // newFTPToolStripMenuItem
            // 
            this.newFTPToolStripMenuItem.Image = global::XwRemote.Properties.Resources.ftp;
            this.newFTPToolStripMenuItem.Name = "newFTPToolStripMenuItem";
            this.newFTPToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.newFTPToolStripMenuItem.Text = "New FTP";
            this.newFTPToolStripMenuItem.Click += new System.EventHandler(this.NewFTP_Click);
            // 
            // newRDPToolStripMenuItem
            // 
            this.newRDPToolStripMenuItem.Image = global::XwRemote.Properties.Resources.rdp;
            this.newRDPToolStripMenuItem.Name = "newRDPToolStripMenuItem";
            this.newRDPToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.newRDPToolStripMenuItem.Text = "New RDP";
            this.newRDPToolStripMenuItem.Click += new System.EventHandler(this.NewRDP_Click);
            // 
            // newVNCToolStripMenuItem
            // 
            this.newVNCToolStripMenuItem.Image = global::XwRemote.Properties.Resources.vnc;
            this.newVNCToolStripMenuItem.Name = "newVNCToolStripMenuItem";
            this.newVNCToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.newVNCToolStripMenuItem.Text = "New VNC";
            this.newVNCToolStripMenuItem.Click += new System.EventHandler(this.NewVNC_Click);
            // 
            // newSSHToolStripMenuItem
            // 
            this.newSSHToolStripMenuItem.Image = global::XwRemote.Properties.Resources.ssh;
            this.newSSHToolStripMenuItem.Name = "newSSHToolStripMenuItem";
            this.newSSHToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.newSSHToolStripMenuItem.Text = "New SSH";
            this.newSSHToolStripMenuItem.Click += new System.EventHandler(this.newSSH_Click);
            // 
            // newIEToolStripMenuItem
            // 
            this.newIEToolStripMenuItem.Image = global::XwRemote.Properties.Resources.IE;
            this.newIEToolStripMenuItem.Name = "newIEToolStripMenuItem";
            this.newIEToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.newIEToolStripMenuItem.Text = "New IE";
            this.newIEToolStripMenuItem.Click += new System.EventHandler(this.newIE_Click);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectBtn.Image = global::XwRemote.Properties.Resources.connect;
            this.ConnectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConnectBtn.Location = new System.Drawing.Point(376, 448);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(141, 57);
            this.ConnectBtn.TabIndex = 0;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.Connect_Click);
            // 
            // NewFTP
            // 
            this.NewFTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewFTP.Image = global::XwRemote.Properties.Resources.ftp;
            this.NewFTP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewFTP.Location = new System.Drawing.Point(376, 139);
            this.NewFTP.Name = "NewFTP";
            this.NewFTP.Size = new System.Drawing.Size(141, 23);
            this.NewFTP.TabIndex = 1;
            this.NewFTP.Text = "New FTP";
            this.NewFTP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewFTP.UseVisualStyleBackColor = true;
            this.NewFTP.Click += new System.EventHandler(this.NewFTP_Click);
            // 
            // NewRDP
            // 
            this.NewRDP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewRDP.Image = global::XwRemote.Properties.Resources.rdp;
            this.NewRDP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewRDP.Location = new System.Drawing.Point(376, 81);
            this.NewRDP.Name = "NewRDP";
            this.NewRDP.Size = new System.Drawing.Size(141, 23);
            this.NewRDP.TabIndex = 3;
            this.NewRDP.Text = "New RDP";
            this.NewRDP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewRDP.UseVisualStyleBackColor = true;
            this.NewRDP.Click += new System.EventHandler(this.NewRDP_Click);
            // 
            // NewVNC
            // 
            this.NewVNC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewVNC.Image = global::XwRemote.Properties.Resources.vnc;
            this.NewVNC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewVNC.Location = new System.Drawing.Point(376, 255);
            this.NewVNC.Name = "NewVNC";
            this.NewVNC.Size = new System.Drawing.Size(141, 23);
            this.NewVNC.TabIndex = 4;
            this.NewVNC.Text = "New VNC";
            this.NewVNC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewVNC.UseVisualStyleBackColor = true;
            this.NewVNC.Click += new System.EventHandler(this.NewVNC_Click);
            // 
            // newSSH
            // 
            this.newSSH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newSSH.Image = global::XwRemote.Properties.Resources.ssh;
            this.newSSH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newSSH.Location = new System.Drawing.Point(376, 110);
            this.newSSH.Name = "newSSH";
            this.newSSH.Size = new System.Drawing.Size(141, 23);
            this.newSSH.TabIndex = 5;
            this.newSSH.Text = "New SSH";
            this.newSSH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.newSSH.UseVisualStyleBackColor = true;
            this.newSSH.Click += new System.EventHandler(this.newSSH_Click);
            // 
            // EditServer
            // 
            this.EditServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditServer.Image = global::XwRemote.Properties.Resources.pencil;
            this.EditServer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditServer.Location = new System.Drawing.Point(376, 419);
            this.EditServer.Name = "EditServer";
            this.EditServer.Size = new System.Drawing.Size(141, 23);
            this.EditServer.TabIndex = 6;
            this.EditServer.Text = "Edit Server";
            this.EditServer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditServer.UseVisualStyleBackColor = true;
            this.EditServer.Click += new System.EventHandler(this.EditServer_Click);
            // 
            // DeleteServer
            // 
            this.DeleteServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteServer.Image = global::XwRemote.Properties.Resources.delete;
            this.DeleteServer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteServer.Location = new System.Drawing.Point(376, 390);
            this.DeleteServer.Name = "DeleteServer";
            this.DeleteServer.Size = new System.Drawing.Size(141, 23);
            this.DeleteServer.TabIndex = 7;
            this.DeleteServer.Text = "Delete Server";
            this.DeleteServer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteServer.UseVisualStyleBackColor = true;
            this.DeleteServer.Click += new System.EventHandler(this.DeleteServer_Click);
            // 
            // contextServer
            // 
            this.contextServer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editServerToolStripMenuItem,
            this.deleteServerToolStripMenuItem,
            this.addToFavoritesToolStripMenuItem,
            this.toolStripSeparator3,
            this.makeCopyToolStripMenuItem});
            this.contextServer.Name = "contextServer";
            this.contextServer.Size = new System.Drawing.Size(161, 98);
            // 
            // editServerToolStripMenuItem
            // 
            this.editServerToolStripMenuItem.Image = global::XwRemote.Properties.Resources.pencil;
            this.editServerToolStripMenuItem.Name = "editServerToolStripMenuItem";
            this.editServerToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.editServerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.editServerToolStripMenuItem.Text = "Edit Server";
            this.editServerToolStripMenuItem.Click += new System.EventHandler(this.EditServer_Click);
            // 
            // deleteServerToolStripMenuItem
            // 
            this.deleteServerToolStripMenuItem.Image = global::XwRemote.Properties.Resources.delete;
            this.deleteServerToolStripMenuItem.Name = "deleteServerToolStripMenuItem";
            this.deleteServerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.deleteServerToolStripMenuItem.Text = "Delete Server";
            this.deleteServerToolStripMenuItem.Click += new System.EventHandler(this.DeleteServer_Click);
            // 
            // addToFavoritesToolStripMenuItem
            // 
            this.addToFavoritesToolStripMenuItem.Image = global::XwRemote.Properties.Resources.favs;
            this.addToFavoritesToolStripMenuItem.Name = "addToFavoritesToolStripMenuItem";
            this.addToFavoritesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addToFavoritesToolStripMenuItem.Text = "Add to Favorites";
            this.addToFavoritesToolStripMenuItem.Click += new System.EventHandler(this.addToFavoritesToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(157, 6);
            // 
            // makeCopyToolStripMenuItem
            // 
            this.makeCopyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyAsFTP,
            this.copyAsRDP,
            this.copyAsVNC,
            this.copyAsSSH,
            this.copyAsIE});
            this.makeCopyToolStripMenuItem.Image = global::XwRemote.Properties.Resources.copy;
            this.makeCopyToolStripMenuItem.Name = "makeCopyToolStripMenuItem";
            this.makeCopyToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.makeCopyToolStripMenuItem.Text = "Make Copy as...";
            // 
            // copyAsFTP
            // 
            this.copyAsFTP.Image = global::XwRemote.Properties.Resources.ftp;
            this.copyAsFTP.Name = "copyAsFTP";
            this.copyAsFTP.Size = new System.Drawing.Size(98, 22);
            this.copyAsFTP.Text = "FTP";
            this.copyAsFTP.Click += new System.EventHandler(this.copyAsFTP_Click);
            // 
            // copyAsRDP
            // 
            this.copyAsRDP.Image = global::XwRemote.Properties.Resources.rdp;
            this.copyAsRDP.Name = "copyAsRDP";
            this.copyAsRDP.Size = new System.Drawing.Size(98, 22);
            this.copyAsRDP.Text = "RDP";
            this.copyAsRDP.Click += new System.EventHandler(this.copyAsRDP_Click);
            // 
            // copyAsVNC
            // 
            this.copyAsVNC.Image = global::XwRemote.Properties.Resources.vnc;
            this.copyAsVNC.Name = "copyAsVNC";
            this.copyAsVNC.Size = new System.Drawing.Size(98, 22);
            this.copyAsVNC.Text = "VNC";
            this.copyAsVNC.Click += new System.EventHandler(this.copyAsVNC_Click);
            // 
            // copyAsSSH
            // 
            this.copyAsSSH.Image = global::XwRemote.Properties.Resources.ssh;
            this.copyAsSSH.Name = "copyAsSSH";
            this.copyAsSSH.Size = new System.Drawing.Size(98, 22);
            this.copyAsSSH.Text = "SSH";
            this.copyAsSSH.Click += new System.EventHandler(this.copyAsSSH_Click);
            // 
            // copyAsIE
            // 
            this.copyAsIE.Image = global::XwRemote.Properties.Resources.IE;
            this.copyAsIE.Name = "copyAsIE";
            this.copyAsIE.Size = new System.Drawing.Size(98, 22);
            this.copyAsIE.Text = "IE";
            this.copyAsIE.Click += new System.EventHandler(this.copyAsIE_Click);
            // 
            // newIE
            // 
            this.newIE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newIE.Image = global::XwRemote.Properties.Resources.IE;
            this.newIE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newIE.Location = new System.Drawing.Point(376, 284);
            this.newIE.Name = "newIE";
            this.newIE.Size = new System.Drawing.Size(141, 23);
            this.newIE.TabIndex = 5;
            this.newIE.Text = "New IE";
            this.newIE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.newIE.UseVisualStyleBackColor = true;
            this.newIE.Click += new System.EventHandler(this.newIE_Click);
            // 
            // dialogHeader1
            // 
            this.dialogHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogHeader1.Gradient1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient2 = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient3 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient4 = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dialogHeader1.HeaderDescription = "This is where is manage you server connections";
            this.dialogHeader1.HeaderImage = global::XwRemote.Properties.Resources.xwremote1;
            this.dialogHeader1.HeaderTitle = "Connections";
            this.dialogHeader1.Location = new System.Drawing.Point(0, 0);
            this.dialogHeader1.Name = "dialogHeader1";
            this.dialogHeader1.Size = new System.Drawing.Size(526, 50);
            this.dialogHeader1.TabIndex = 8;
            // 
            // newSQL
            // 
            this.newSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newSQL.Image = global::XwRemote.Properties.Resources.database;
            this.newSQL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newSQL.Location = new System.Drawing.Point(376, 313);
            this.newSQL.Name = "newSQL";
            this.newSQL.Size = new System.Drawing.Size(141, 23);
            this.newSQL.TabIndex = 9;
            this.newSQL.Text = "New SQL";
            this.newSQL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.newSQL.UseVisualStyleBackColor = true;
            this.newSQL.Click += new System.EventHandler(this.newSQL_Click);
            // 
            // NewSFTP
            // 
            this.NewSFTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewSFTP.Image = global::XwRemote.Properties.Resources.sftp;
            this.NewSFTP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewSFTP.Location = new System.Drawing.Point(376, 168);
            this.NewSFTP.Name = "NewSFTP";
            this.NewSFTP.Size = new System.Drawing.Size(141, 23);
            this.NewSFTP.TabIndex = 10;
            this.NewSFTP.Text = "New SFTP";
            this.NewSFTP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewSFTP.UseVisualStyleBackColor = true;
            this.NewSFTP.Click += new System.EventHandler(this.NewSFTP_Click);
            // 
            // NewS3
            // 
            this.NewS3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewS3.Image = global::XwRemote.Properties.Resources.s3;
            this.NewS3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewS3.Location = new System.Drawing.Point(376, 197);
            this.NewS3.Name = "NewS3";
            this.NewS3.Size = new System.Drawing.Size(141, 23);
            this.NewS3.TabIndex = 11;
            this.NewS3.Text = "New AWS S3";
            this.NewS3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewS3.UseVisualStyleBackColor = true;
            this.NewS3.Click += new System.EventHandler(this.NewS3_Click);
            // 
            // NewAzureFile
            // 
            this.NewAzureFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewAzureFile.Image = global::XwRemote.Properties.Resources.azure;
            this.NewAzureFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewAzureFile.Location = new System.Drawing.Point(376, 226);
            this.NewAzureFile.Name = "NewAzureFile";
            this.NewAzureFile.Size = new System.Drawing.Size(141, 23);
            this.NewAzureFile.TabIndex = 12;
            this.NewAzureFile.Text = "New Azure File";
            this.NewAzureFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewAzureFile.UseVisualStyleBackColor = true;
            this.NewAzureFile.Click += new System.EventHandler(this.NewAzureFile_Click);
            // 
            // ServerManager
            // 
            this.AcceptButton = this.ConnectBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 515);
            this.Controls.Add(this.NewAzureFile);
            this.Controls.Add(this.NewS3);
            this.Controls.Add(this.NewSFTP);
            this.Controls.Add(this.newSQL);
            this.Controls.Add(this.dialogHeader1);
            this.Controls.Add(this.NewRDP);
            this.Controls.Add(this.newSSH);
            this.Controls.Add(this.NewVNC);
            this.Controls.Add(this.NewFTP);
            this.Controls.Add(this.newIE);
            this.Controls.Add(this.DeleteServer);
            this.Controls.Add(this.EditServer);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.toolStripContainer1);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "ServerManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Server Manager";
            this.Activated += new System.EventHandler(this.ServerManager_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerManager_FormClosing);
            this.Load += new System.EventHandler(this.OnLoad);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabStrip1.ResumeLayout(false);
            this.tabStrip1.PerformLayout();
            this.contextGroup.ResumeLayout(false);
            this.contextServer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Button NewFTP;
        private System.Windows.Forms.Button NewRDP;
        private System.Windows.Forms.Button NewVNC;
        private System.Windows.Forms.Button newSSH;
        private System.Windows.Forms.Button EditServer;
        private System.Windows.Forms.Button DeleteServer;
        private Messir.Windows.Forms.TabStrip tabStrip1;
        private Messir.Windows.Forms.TabStripButton FilterGrouped;
        private Messir.Windows.Forms.TabStripButton FilterOrdered;
        private Messir.Windows.Forms.TabStripButton FilterFavorites;
        private System.Windows.Forms.TreeView treeServers;
        private XwMaxLib.UI.DialogHeader dialogHeader1;
        private System.Windows.Forms.ContextMenuStrip contextGroup;
        private System.Windows.Forms.ToolStripMenuItem addGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteGroupToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextServer;
        private System.Windows.Forms.ToolStripMenuItem deleteServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem newFTPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRDPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newVNCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSSHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToFavoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button newIE;
        private System.Windows.Forms.ToolStripMenuItem newIEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAsFTP;
        private System.Windows.Forms.ToolStripMenuItem copyAsRDP;
        private System.Windows.Forms.ToolStripMenuItem copyAsVNC;
        private System.Windows.Forms.ToolStripMenuItem copyAsSSH;
        private System.Windows.Forms.ToolStripMenuItem copyAsIE;
        private System.Windows.Forms.Button newSQL;
        private System.Windows.Forms.Button NewSFTP;
        private System.Windows.Forms.Button NewS3;
        private System.Windows.Forms.Button NewAzureFile;
    }
}