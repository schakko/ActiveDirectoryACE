namespace ACEGenerator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAdUsername = new System.Windows.Forms.TextBox();
            this.tbADPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalResults = new System.Windows.Forms.Label();
            this.lbResults = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearchFor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.gbSid = new System.Windows.Forms.GroupBox();
            this.rbWellKnownTrustees = new System.Windows.Forms.RadioButton();
            this.lbWellKnownTrustees = new System.Windows.Forms.ComboBox();
            this.tbAccountSid = new System.Windows.Forms.TextBox();
            this.rbObjectSid = new System.Windows.Forms.RadioButton();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbInheritObjectGuid = new System.Windows.Forms.TextBox();
            this.tbOjectGuid = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.gbFlags = new System.Windows.Forms.GroupBox();
            this.cbFailedAccessFlag = new System.Windows.Forms.CheckBox();
            this.cbSuccessfulAccessAceFlag = new System.Windows.Forms.CheckBox();
            this.cbInheritedAce = new System.Windows.Forms.CheckBox();
            this.cbInheritOnlyAce = new System.Windows.Forms.CheckBox();
            this.cbNoPropagateInherticAce = new System.Windows.Forms.CheckBox();
            this.cbObjectInheritAce = new System.Windows.Forms.CheckBox();
            this.cbContainerInheritAce = new System.Windows.Forms.CheckBox();
            this.gbRights = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbAdsRightActrlDsList = new System.Windows.Forms.CheckBox();
            this.cbAdsRightDsReadProp = new System.Windows.Forms.CheckBox();
            this.cbAdsRightDsWriteProp = new System.Windows.Forms.CheckBox();
            this.cbAdsRightDsCreateChild = new System.Windows.Forms.CheckBox();
            this.cbAdsRightDsDeleteChild = new System.Windows.Forms.CheckBox();
            this.cbAdsRightDsControlAccess = new System.Windows.Forms.CheckBox();
            this.cbAdsRightDsSelf = new System.Windows.Forms.CheckBox();
            this.cbAdsRightDsDeleteTree = new System.Windows.Forms.CheckBox();
            this.cbAdsRightDsListObject = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbKeyAllAccess = new System.Windows.Forms.CheckBox();
            this.cbKeyRead = new System.Windows.Forms.CheckBox();
            this.cbKeyWrite = new System.Windows.Forms.CheckBox();
            this.cbKeyExecute = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbSystemMandatoryLabelNoReadUp = new System.Windows.Forms.CheckBox();
            this.cbSystemMandatoryLabelNoWriteUp = new System.Windows.Forms.CheckBox();
            this.cbSystemMandatoryLabelNoExecuteUp = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbFileGenericWrite = new System.Windows.Forms.CheckBox();
            this.cbFileAllAcess = new System.Windows.Forms.CheckBox();
            this.cbFileGenericRead = new System.Windows.Forms.CheckBox();
            this.cbFileGenericExecute = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.cbReadControl = new System.Windows.Forms.CheckBox();
            this.cbWriteDac = new System.Windows.Forms.CheckBox();
            this.cbWriteOwner = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbGenericWrite = new System.Windows.Forms.CheckBox();
            this.cbGenericAll = new System.Windows.Forms.CheckBox();
            this.cbGenericRead = new System.Windows.Forms.CheckBox();
            this.cbGenericExecute = new System.Windows.Forms.CheckBox();
            this.lbAceType = new System.Windows.Forms.ComboBox();
            this.lblGuid = new System.Windows.Forms.Label();
            this.lblSid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbSettings.SuspendLayout();
            this.gbSid.SuspendLayout();
            this.gbFlags.SuspendLayout();
            this.gbRights.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // tbAdUsername
            // 
            this.tbAdUsername.Location = new System.Drawing.Point(76, 50);
            this.tbAdUsername.Name = "tbAdUsername";
            this.tbAdUsername.Size = new System.Drawing.Size(160, 20);
            this.tbAdUsername.TabIndex = 2;
            this.tbAdUsername.Text = "Administrator";
            // 
            // tbADPassword
            // 
            this.tbADPassword.Location = new System.Drawing.Point(76, 81);
            this.tbADPassword.Name = "tbADPassword";
            this.tbADPassword.PasswordChar = '*';
            this.tbADPassword.Size = new System.Drawing.Size(160, 20);
            this.tbADPassword.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbServer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbAdUsername);
            this.groupBox1.Controls.Add(this.tbADPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 126);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Active Directory";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(76, 19);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(262, 20);
            this.tbServer.TabIndex = 1;
            this.tbServer.Text = "LDAP://dc=<your-domain>,dc=<your-tld>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "LDAP path";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalResults);
            this.groupBox2.Controls.Add(this.lbResults);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.tbSearchFor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(419, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 125);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search for...";
            // 
            // lblTotalResults
            // 
            this.lblTotalResults.AutoSize = true;
            this.lblTotalResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalResults.Location = new System.Drawing.Point(247, 87);
            this.lblTotalResults.Name = "lblTotalResults";
            this.lblTotalResults.Size = new System.Drawing.Size(13, 13);
            this.lblTotalResults.TabIndex = 9;
            this.lblTotalResults.Text = "0";
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(83, 87);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(163, 21);
            this.lbResults.TabIndex = 6;
            this.lbResults.SelectedIndexChanged += new System.EventHandler(this.lbResults_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Results";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(134, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearchFor
            // 
            this.tbSearchFor.Location = new System.Drawing.Point(83, 22);
            this.tbSearchFor.Name = "tbSearchFor";
            this.tbSearchFor.Size = new System.Drawing.Size(177, 20);
            this.tbSearchFor.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Any name ";
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.gbSid);
            this.gbSettings.Controls.Add(this.tbResult);
            this.gbSettings.Controls.Add(this.label20);
            this.gbSettings.Controls.Add(this.tbInheritObjectGuid);
            this.gbSettings.Controls.Add(this.tbOjectGuid);
            this.gbSettings.Controls.Add(this.label19);
            this.gbSettings.Controls.Add(this.label17);
            this.gbSettings.Controls.Add(this.gbFlags);
            this.gbSettings.Controls.Add(this.gbRights);
            this.gbSettings.Controls.Add(this.lbAceType);
            this.gbSettings.Controls.Add(this.lblGuid);
            this.gbSettings.Controls.Add(this.lblSid);
            this.gbSettings.Controls.Add(this.label8);
            this.gbSettings.Controls.Add(this.label7);
            this.gbSettings.Controls.Add(this.label6);
            this.gbSettings.Enabled = false;
            this.gbSettings.Location = new System.Drawing.Point(12, 144);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(686, 658);
            this.gbSettings.TabIndex = 6;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "ACE";
            // 
            // gbSid
            // 
            this.gbSid.Controls.Add(this.rbWellKnownTrustees);
            this.gbSid.Controls.Add(this.lbWellKnownTrustees);
            this.gbSid.Controls.Add(this.tbAccountSid);
            this.gbSid.Controls.Add(this.rbObjectSid);
            this.gbSid.Location = new System.Drawing.Point(6, 188);
            this.gbSid.Name = "gbSid";
            this.gbSid.Size = new System.Drawing.Size(397, 84);
            this.gbSid.TabIndex = 18;
            this.gbSid.TabStop = false;
            this.gbSid.Text = "SID";
            // 
            // rbWellKnownTrustees
            // 
            this.rbWellKnownTrustees.AutoSize = true;
            this.rbWellKnownTrustees.Location = new System.Drawing.Point(12, 47);
            this.rbWellKnownTrustees.Name = "rbWellKnownTrustees";
            this.rbWellKnownTrustees.Size = new System.Drawing.Size(116, 17);
            this.rbWellKnownTrustees.TabIndex = 16;
            this.rbWellKnownTrustees.Text = "Well known trustee";
            this.rbWellKnownTrustees.UseVisualStyleBackColor = true;
            // 
            // lbWellKnownTrustees
            // 
            this.lbWellKnownTrustees.Enabled = false;
            this.lbWellKnownTrustees.FormattingEnabled = true;
            this.lbWellKnownTrustees.Location = new System.Drawing.Point(127, 45);
            this.lbWellKnownTrustees.Name = "lbWellKnownTrustees";
            this.lbWellKnownTrustees.Size = new System.Drawing.Size(246, 21);
            this.lbWellKnownTrustees.TabIndex = 17;
            // 
            // tbAccountSid
            // 
            this.tbAccountSid.Location = new System.Drawing.Point(127, 21);
            this.tbAccountSid.Name = "tbAccountSid";
            this.tbAccountSid.Size = new System.Drawing.Size(246, 20);
            this.tbAccountSid.TabIndex = 12;
            // 
            // rbObjectSid
            // 
            this.rbObjectSid.AutoSize = true;
            this.rbObjectSid.Checked = true;
            this.rbObjectSid.Location = new System.Drawing.Point(12, 24);
            this.rbObjectSid.Name = "rbObjectSid";
            this.rbObjectSid.Size = new System.Drawing.Size(77, 17);
            this.rbObjectSid.TabIndex = 15;
            this.rbObjectSid.TabStop = true;
            this.rbObjectSid.Text = "Object SID";
            this.rbObjectSid.UseVisualStyleBackColor = true;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(136, 15);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(531, 20);
            this.tbResult.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(10, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 17);
            this.label20.TabIndex = 13;
            this.label20.Text = "Generated ACE";
            // 
            // tbInheritObjectGuid
            // 
            this.tbInheritObjectGuid.Location = new System.Drawing.Point(136, 162);
            this.tbInheritObjectGuid.Name = "tbInheritObjectGuid";
            this.tbInheritObjectGuid.Size = new System.Drawing.Size(246, 20);
            this.tbInheritObjectGuid.TabIndex = 11;
            // 
            // tbOjectGuid
            // 
            this.tbOjectGuid.Location = new System.Drawing.Point(87, 136);
            this.tbOjectGuid.Name = "tbOjectGuid";
            this.tbOjectGuid.Size = new System.Drawing.Size(294, 20);
            this.tbOjectGuid.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 167);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 13);
            this.label19.TabIndex = 10;
            this.label19.Text = "Inherit object GUID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 142);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Object GUID";
            // 
            // gbFlags
            // 
            this.gbFlags.Controls.Add(this.cbFailedAccessFlag);
            this.gbFlags.Controls.Add(this.cbSuccessfulAccessAceFlag);
            this.gbFlags.Controls.Add(this.cbInheritedAce);
            this.gbFlags.Controls.Add(this.cbInheritOnlyAce);
            this.gbFlags.Controls.Add(this.cbNoPropagateInherticAce);
            this.gbFlags.Controls.Add(this.cbObjectInheritAce);
            this.gbFlags.Controls.Add(this.cbContainerInheritAce);
            this.gbFlags.Location = new System.Drawing.Point(426, 50);
            this.gbFlags.Name = "gbFlags";
            this.gbFlags.Size = new System.Drawing.Size(241, 186);
            this.gbFlags.TabIndex = 7;
            this.gbFlags.TabStop = false;
            this.gbFlags.Text = "Flags";
            // 
            // cbFailedAccessFlag
            // 
            this.cbFailedAccessFlag.AutoSize = true;
            this.cbFailedAccessFlag.Location = new System.Drawing.Point(9, 161);
            this.cbFailedAccessFlag.Name = "cbFailedAccessFlag";
            this.cbFailedAccessFlag.Size = new System.Drawing.Size(171, 17);
            this.cbFailedAccessFlag.TabIndex = 8;
            this.cbFailedAccessFlag.Text = "FAILED_ACCESS_ACE_FLAG";
            this.cbFailedAccessFlag.UseVisualStyleBackColor = true;
            // 
            // cbSuccessfulAccessAceFlag
            // 
            this.cbSuccessfulAccessAceFlag.AutoSize = true;
            this.cbSuccessfulAccessAceFlag.Location = new System.Drawing.Point(9, 138);
            this.cbSuccessfulAccessAceFlag.Name = "cbSuccessfulAccessAceFlag";
            this.cbSuccessfulAccessAceFlag.Size = new System.Drawing.Size(204, 17);
            this.cbSuccessfulAccessAceFlag.TabIndex = 7;
            this.cbSuccessfulAccessAceFlag.Text = "SUCCESSFUL_ACCESS_ACE_FLAG";
            this.cbSuccessfulAccessAceFlag.UseVisualStyleBackColor = true;
            // 
            // cbInheritedAce
            // 
            this.cbInheritedAce.AutoSize = true;
            this.cbInheritedAce.Location = new System.Drawing.Point(9, 115);
            this.cbInheritedAce.Name = "cbInheritedAce";
            this.cbInheritedAce.Size = new System.Drawing.Size(112, 17);
            this.cbInheritedAce.TabIndex = 6;
            this.cbInheritedAce.Text = "INHERITED_ACE";
            this.cbInheritedAce.UseVisualStyleBackColor = true;
            // 
            // cbInheritOnlyAce
            // 
            this.cbInheritOnlyAce.AutoSize = true;
            this.cbInheritOnlyAce.Location = new System.Drawing.Point(9, 88);
            this.cbInheritOnlyAce.Name = "cbInheritOnlyAce";
            this.cbInheritOnlyAce.Size = new System.Drawing.Size(132, 17);
            this.cbInheritOnlyAce.TabIndex = 5;
            this.cbInheritOnlyAce.Text = "INHERIT_ONLY_ACE";
            this.cbInheritOnlyAce.UseVisualStyleBackColor = true;
            // 
            // cbNoPropagateInherticAce
            // 
            this.cbNoPropagateInherticAce.AutoSize = true;
            this.cbNoPropagateInherticAce.Location = new System.Drawing.Point(9, 65);
            this.cbNoPropagateInherticAce.Name = "cbNoPropagateInherticAce";
            this.cbNoPropagateInherticAce.Size = new System.Drawing.Size(191, 17);
            this.cbNoPropagateInherticAce.TabIndex = 4;
            this.cbNoPropagateInherticAce.Text = "NO_PROPAGATE_INHERIT_ACE";
            this.cbNoPropagateInherticAce.UseVisualStyleBackColor = true;
            // 
            // cbObjectInheritAce
            // 
            this.cbObjectInheritAce.AutoSize = true;
            this.cbObjectInheritAce.Location = new System.Drawing.Point(9, 42);
            this.cbObjectInheritAce.Name = "cbObjectInheritAce";
            this.cbObjectInheritAce.Size = new System.Drawing.Size(144, 17);
            this.cbObjectInheritAce.TabIndex = 3;
            this.cbObjectInheritAce.Text = "OBJECT_INHERIT_ACE";
            this.cbObjectInheritAce.UseVisualStyleBackColor = true;
            // 
            // cbContainerInheritAce
            // 
            this.cbContainerInheritAce.AutoSize = true;
            this.cbContainerInheritAce.Location = new System.Drawing.Point(9, 19);
            this.cbContainerInheritAce.Name = "cbContainerInheritAce";
            this.cbContainerInheritAce.Size = new System.Drawing.Size(166, 17);
            this.cbContainerInheritAce.TabIndex = 2;
            this.cbContainerInheritAce.Text = "CONTAINER_INHERIT_ACE";
            this.cbContainerInheritAce.UseVisualStyleBackColor = true;
            // 
            // gbRights
            // 
            this.gbRights.Controls.Add(this.groupBox8);
            this.gbRights.Controls.Add(this.groupBox7);
            this.gbRights.Controls.Add(this.groupBox6);
            this.gbRights.Controls.Add(this.groupBox5);
            this.gbRights.Controls.Add(this.groupBox4);
            this.gbRights.Controls.Add(this.groupBox3);
            this.gbRights.Location = new System.Drawing.Point(6, 288);
            this.gbRights.Name = "gbRights";
            this.gbRights.Size = new System.Drawing.Size(674, 362);
            this.gbRights.TabIndex = 6;
            this.gbRights.TabStop = false;
            this.gbRights.Text = "Rights";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cbAdsRightActrlDsList);
            this.groupBox8.Controls.Add(this.cbAdsRightDsReadProp);
            this.groupBox8.Controls.Add(this.cbAdsRightDsWriteProp);
            this.groupBox8.Controls.Add(this.cbAdsRightDsCreateChild);
            this.groupBox8.Controls.Add(this.cbAdsRightDsDeleteChild);
            this.groupBox8.Controls.Add(this.cbAdsRightDsControlAccess);
            this.groupBox8.Controls.Add(this.cbAdsRightDsSelf);
            this.groupBox8.Controls.Add(this.cbAdsRightDsDeleteTree);
            this.groupBox8.Controls.Add(this.cbAdsRightDsListObject);
            this.groupBox8.Location = new System.Drawing.Point(212, 16);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(217, 232);
            this.groupBox8.TabIndex = 38;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Directory service object access";
            // 
            // cbAdsRightActrlDsList
            // 
            this.cbAdsRightActrlDsList.AutoSize = true;
            this.cbAdsRightActrlDsList.Location = new System.Drawing.Point(5, 109);
            this.cbAdsRightActrlDsList.Name = "cbAdsRightActrlDsList";
            this.cbAdsRightActrlDsList.Size = new System.Drawing.Size(179, 17);
            this.cbAdsRightActrlDsList.TabIndex = 29;
            this.cbAdsRightActrlDsList.Text = "ADS_RIGHT_ACTRL_DS_LIST";
            this.cbAdsRightActrlDsList.UseVisualStyleBackColor = true;
            // 
            // cbAdsRightDsReadProp
            // 
            this.cbAdsRightDsReadProp.AutoSize = true;
            this.cbAdsRightDsReadProp.Location = new System.Drawing.Point(6, 17);
            this.cbAdsRightDsReadProp.Name = "cbAdsRightDsReadProp";
            this.cbAdsRightDsReadProp.Size = new System.Drawing.Size(181, 17);
            this.cbAdsRightDsReadProp.TabIndex = 25;
            this.cbAdsRightDsReadProp.Text = "ADS_RIGHT_DS_READ_PROP";
            this.cbAdsRightDsReadProp.UseVisualStyleBackColor = true;
            // 
            // cbAdsRightDsWriteProp
            // 
            this.cbAdsRightDsWriteProp.AutoSize = true;
            this.cbAdsRightDsWriteProp.Location = new System.Drawing.Point(6, 40);
            this.cbAdsRightDsWriteProp.Name = "cbAdsRightDsWriteProp";
            this.cbAdsRightDsWriteProp.Size = new System.Drawing.Size(187, 17);
            this.cbAdsRightDsWriteProp.TabIndex = 26;
            this.cbAdsRightDsWriteProp.Text = "ADS_RIGHT_DS_WRITE_PROP";
            this.cbAdsRightDsWriteProp.UseVisualStyleBackColor = true;
            // 
            // cbAdsRightDsCreateChild
            // 
            this.cbAdsRightDsCreateChild.AutoSize = true;
            this.cbAdsRightDsCreateChild.Location = new System.Drawing.Point(5, 63);
            this.cbAdsRightDsCreateChild.Name = "cbAdsRightDsCreateChild";
            this.cbAdsRightDsCreateChild.Size = new System.Drawing.Size(196, 17);
            this.cbAdsRightDsCreateChild.TabIndex = 27;
            this.cbAdsRightDsCreateChild.Text = "ADS_RIGHT_DS_CREATE_CHILD";
            this.cbAdsRightDsCreateChild.UseVisualStyleBackColor = true;
            // 
            // cbAdsRightDsDeleteChild
            // 
            this.cbAdsRightDsDeleteChild.AutoSize = true;
            this.cbAdsRightDsDeleteChild.Location = new System.Drawing.Point(5, 86);
            this.cbAdsRightDsDeleteChild.Name = "cbAdsRightDsDeleteChild";
            this.cbAdsRightDsDeleteChild.Size = new System.Drawing.Size(195, 17);
            this.cbAdsRightDsDeleteChild.TabIndex = 28;
            this.cbAdsRightDsDeleteChild.Text = "ADS_RIGHT_DS_DELETE_CHILD";
            this.cbAdsRightDsDeleteChild.UseVisualStyleBackColor = true;
            // 
            // cbAdsRightDsControlAccess
            // 
            this.cbAdsRightDsControlAccess.AutoSize = true;
            this.cbAdsRightDsControlAccess.Location = new System.Drawing.Point(5, 201);
            this.cbAdsRightDsControlAccess.Name = "cbAdsRightDsControlAccess";
            this.cbAdsRightDsControlAccess.Size = new System.Drawing.Size(215, 17);
            this.cbAdsRightDsControlAccess.TabIndex = 33;
            this.cbAdsRightDsControlAccess.Text = "ADS_RIGHT_DS_CONTROL_ACCESS";
            this.cbAdsRightDsControlAccess.UseVisualStyleBackColor = true;
            // 
            // cbAdsRightDsSelf
            // 
            this.cbAdsRightDsSelf.AutoSize = true;
            this.cbAdsRightDsSelf.Location = new System.Drawing.Point(6, 132);
            this.cbAdsRightDsSelf.Name = "cbAdsRightDsSelf";
            this.cbAdsRightDsSelf.Size = new System.Drawing.Size(141, 17);
            this.cbAdsRightDsSelf.TabIndex = 30;
            this.cbAdsRightDsSelf.Text = "ADS_RIGHT_DS_SELF";
            this.cbAdsRightDsSelf.UseVisualStyleBackColor = true;
            // 
            // cbAdsRightDsDeleteTree
            // 
            this.cbAdsRightDsDeleteTree.AutoSize = true;
            this.cbAdsRightDsDeleteTree.Location = new System.Drawing.Point(5, 178);
            this.cbAdsRightDsDeleteTree.Name = "cbAdsRightDsDeleteTree";
            this.cbAdsRightDsDeleteTree.Size = new System.Drawing.Size(192, 17);
            this.cbAdsRightDsDeleteTree.TabIndex = 32;
            this.cbAdsRightDsDeleteTree.Text = "ADS_RIGHT_DS_DELETE_TREE";
            this.cbAdsRightDsDeleteTree.UseVisualStyleBackColor = true;
            // 
            // cbAdsRightDsListObject
            // 
            this.cbAdsRightDsListObject.AutoSize = true;
            this.cbAdsRightDsListObject.Location = new System.Drawing.Point(6, 155);
            this.cbAdsRightDsListObject.Name = "cbAdsRightDsListObject";
            this.cbAdsRightDsListObject.Size = new System.Drawing.Size(185, 17);
            this.cbAdsRightDsListObject.TabIndex = 31;
            this.cbAdsRightDsListObject.Text = "ADS_RIGHT_DS_LIST_OBJECT";
            this.cbAdsRightDsListObject.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbKeyAllAccess);
            this.groupBox7.Controls.Add(this.cbKeyRead);
            this.groupBox7.Controls.Add(this.cbKeyWrite);
            this.groupBox7.Controls.Add(this.cbKeyExecute);
            this.groupBox7.Location = new System.Drawing.Point(449, 134);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(210, 114);
            this.groupBox7.TabIndex = 38;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Registry key access right";
            // 
            // cbKeyAllAccess
            // 
            this.cbKeyAllAccess.AutoSize = true;
            this.cbKeyAllAccess.Location = new System.Drawing.Point(6, 23);
            this.cbKeyAllAccess.Name = "cbKeyAllAccess";
            this.cbKeyAllAccess.Size = new System.Drawing.Size(120, 17);
            this.cbKeyAllAccess.TabIndex = 16;
            this.cbKeyAllAccess.Text = "KEY_ALL_ACCESS";
            this.cbKeyAllAccess.UseVisualStyleBackColor = true;
            // 
            // cbKeyRead
            // 
            this.cbKeyRead.AutoSize = true;
            this.cbKeyRead.Location = new System.Drawing.Point(6, 46);
            this.cbKeyRead.Name = "cbKeyRead";
            this.cbKeyRead.Size = new System.Drawing.Size(83, 17);
            this.cbKeyRead.TabIndex = 17;
            this.cbKeyRead.Text = "KEY_READ";
            this.cbKeyRead.UseVisualStyleBackColor = true;
            // 
            // cbKeyWrite
            // 
            this.cbKeyWrite.AutoSize = true;
            this.cbKeyWrite.Location = new System.Drawing.Point(6, 69);
            this.cbKeyWrite.Name = "cbKeyWrite";
            this.cbKeyWrite.Size = new System.Drawing.Size(89, 17);
            this.cbKeyWrite.TabIndex = 18;
            this.cbKeyWrite.Text = "KEY_WRITE";
            this.cbKeyWrite.UseVisualStyleBackColor = true;
            // 
            // cbKeyExecute
            // 
            this.cbKeyExecute.AutoSize = true;
            this.cbKeyExecute.Location = new System.Drawing.Point(7, 92);
            this.cbKeyExecute.Name = "cbKeyExecute";
            this.cbKeyExecute.Size = new System.Drawing.Size(103, 17);
            this.cbKeyExecute.TabIndex = 19;
            this.cbKeyExecute.Text = "KEY_EXECUTE";
            this.cbKeyExecute.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbSystemMandatoryLabelNoReadUp);
            this.groupBox6.Controls.Add(this.cbSystemMandatoryLabelNoWriteUp);
            this.groupBox6.Controls.Add(this.cbSystemMandatoryLabelNoExecuteUp);
            this.groupBox6.Location = new System.Drawing.Point(7, 254);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(422, 88);
            this.groupBox6.TabIndex = 37;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Mandatory label rights";
            // 
            // cbSystemMandatoryLabelNoReadUp
            // 
            this.cbSystemMandatoryLabelNoReadUp.AutoSize = true;
            this.cbSystemMandatoryLabelNoReadUp.Location = new System.Drawing.Point(6, 19);
            this.cbSystemMandatoryLabelNoReadUp.Name = "cbSystemMandatoryLabelNoReadUp";
            this.cbSystemMandatoryLabelNoReadUp.Size = new System.Drawing.Size(263, 17);
            this.cbSystemMandatoryLabelNoReadUp.TabIndex = 21;
            this.cbSystemMandatoryLabelNoReadUp.Text = "SYSTEM_MANDATORY_LABEL_NO_READ_UP";
            this.cbSystemMandatoryLabelNoReadUp.UseVisualStyleBackColor = true;
            // 
            // cbSystemMandatoryLabelNoWriteUp
            // 
            this.cbSystemMandatoryLabelNoWriteUp.AutoSize = true;
            this.cbSystemMandatoryLabelNoWriteUp.Location = new System.Drawing.Point(5, 42);
            this.cbSystemMandatoryLabelNoWriteUp.Name = "cbSystemMandatoryLabelNoWriteUp";
            this.cbSystemMandatoryLabelNoWriteUp.Size = new System.Drawing.Size(269, 17);
            this.cbSystemMandatoryLabelNoWriteUp.TabIndex = 22;
            this.cbSystemMandatoryLabelNoWriteUp.Text = "SYSTEM_MANDATORY_LABEL_NO_WRITE_UP";
            this.cbSystemMandatoryLabelNoWriteUp.UseVisualStyleBackColor = true;
            // 
            // cbSystemMandatoryLabelNoExecuteUp
            // 
            this.cbSystemMandatoryLabelNoExecuteUp.AutoSize = true;
            this.cbSystemMandatoryLabelNoExecuteUp.Location = new System.Drawing.Point(5, 65);
            this.cbSystemMandatoryLabelNoExecuteUp.Name = "cbSystemMandatoryLabelNoExecuteUp";
            this.cbSystemMandatoryLabelNoExecuteUp.Size = new System.Drawing.Size(283, 17);
            this.cbSystemMandatoryLabelNoExecuteUp.TabIndex = 23;
            this.cbSystemMandatoryLabelNoExecuteUp.Text = "SYSTEM_MANDATORY_LABEL_NO_EXECUTE_UP";
            this.cbSystemMandatoryLabelNoExecuteUp.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbFileGenericWrite);
            this.groupBox5.Controls.Add(this.cbFileAllAcess);
            this.groupBox5.Controls.Add(this.cbFileGenericRead);
            this.groupBox5.Controls.Add(this.cbFileGenericExecute);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(7, 134);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(189, 114);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "File access rights";
            // 
            // cbFileGenericWrite
            // 
            this.cbFileGenericWrite.AutoSize = true;
            this.cbFileGenericWrite.Location = new System.Drawing.Point(7, 65);
            this.cbFileGenericWrite.Name = "cbFileGenericWrite";
            this.cbFileGenericWrite.Size = new System.Drawing.Size(144, 17);
            this.cbFileGenericWrite.TabIndex = 13;
            this.cbFileGenericWrite.Text = "FILE_GENERIC_WRITE";
            this.cbFileGenericWrite.UseVisualStyleBackColor = true;
            // 
            // cbFileAllAcess
            // 
            this.cbFileAllAcess.AutoSize = true;
            this.cbFileAllAcess.Location = new System.Drawing.Point(7, 19);
            this.cbFileAllAcess.Name = "cbFileAllAcess";
            this.cbFileAllAcess.Size = new System.Drawing.Size(121, 17);
            this.cbFileAllAcess.TabIndex = 11;
            this.cbFileAllAcess.Text = "FILE_ALL_ACCESS";
            this.cbFileAllAcess.UseVisualStyleBackColor = true;
            // 
            // cbFileGenericRead
            // 
            this.cbFileGenericRead.AutoSize = true;
            this.cbFileGenericRead.Location = new System.Drawing.Point(7, 42);
            this.cbFileGenericRead.Name = "cbFileGenericRead";
            this.cbFileGenericRead.Size = new System.Drawing.Size(138, 17);
            this.cbFileGenericRead.TabIndex = 12;
            this.cbFileGenericRead.Text = "FILE_GENERIC_READ";
            this.cbFileGenericRead.UseVisualStyleBackColor = true;
            // 
            // cbFileGenericExecute
            // 
            this.cbFileGenericExecute.AutoSize = true;
            this.cbFileGenericExecute.Location = new System.Drawing.Point(8, 88);
            this.cbFileGenericExecute.Name = "cbFileGenericExecute";
            this.cbFileGenericExecute.Size = new System.Drawing.Size(158, 17);
            this.cbFileGenericExecute.TabIndex = 14;
            this.cbFileGenericExecute.Text = "FILE_GENERIC_EXECUTE";
            this.cbFileGenericExecute.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbDelete);
            this.groupBox4.Controls.Add(this.cbReadControl);
            this.groupBox4.Controls.Add(this.cbWriteDac);
            this.groupBox4.Controls.Add(this.cbWriteOwner);
            this.groupBox4.Location = new System.Drawing.Point(7, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(189, 112);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Standard access rights";
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Location = new System.Drawing.Point(6, 42);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(136, 17);
            this.cbDelete.TabIndex = 7;
            this.cbDelete.Text = "ADS_RIGHT_DELETE";
            this.cbDelete.UseVisualStyleBackColor = true;
            // 
            // cbReadControl
            // 
            this.cbReadControl.AutoSize = true;
            this.cbReadControl.Location = new System.Drawing.Point(6, 19);
            this.cbReadControl.Name = "cbReadControl";
            this.cbReadControl.Size = new System.Drawing.Size(182, 17);
            this.cbReadControl.TabIndex = 6;
            this.cbReadControl.Text = "ADS_RIGHT_READ_CONTROL";
            this.cbReadControl.UseVisualStyleBackColor = true;
            // 
            // cbWriteDac
            // 
            this.cbWriteDac.AutoSize = true;
            this.cbWriteDac.Location = new System.Drawing.Point(6, 65);
            this.cbWriteDac.Name = "cbWriteDac";
            this.cbWriteDac.Size = new System.Drawing.Size(158, 17);
            this.cbWriteDac.TabIndex = 8;
            this.cbWriteDac.Text = "ADS_RIGHT_WRITE_DAC";
            this.cbWriteDac.UseVisualStyleBackColor = true;
            // 
            // cbWriteOwner
            // 
            this.cbWriteOwner.AutoSize = true;
            this.cbWriteOwner.Location = new System.Drawing.Point(6, 88);
            this.cbWriteOwner.Name = "cbWriteOwner";
            this.cbWriteOwner.Size = new System.Drawing.Size(178, 17);
            this.cbWriteOwner.TabIndex = 9;
            this.cbWriteOwner.Text = "ADS_RIGHT_WRITE_OWNER";
            this.cbWriteOwner.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbGenericWrite);
            this.groupBox3.Controls.Add(this.cbGenericAll);
            this.groupBox3.Controls.Add(this.cbGenericRead);
            this.groupBox3.Controls.Add(this.cbGenericExecute);
            this.groupBox3.Location = new System.Drawing.Point(449, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 109);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Generic access rights";
            // 
            // cbGenericWrite
            // 
            this.cbGenericWrite.AutoSize = true;
            this.cbGenericWrite.Location = new System.Drawing.Point(6, 60);
            this.cbGenericWrite.Name = "cbGenericWrite";
            this.cbGenericWrite.Size = new System.Drawing.Size(184, 17);
            this.cbGenericWrite.TabIndex = 3;
            this.cbGenericWrite.Text = "ADS_RIGHT_GENERIC_WRITE";
            this.cbGenericWrite.UseVisualStyleBackColor = true;
            // 
            // cbGenericAll
            // 
            this.cbGenericAll.AutoSize = true;
            this.cbGenericAll.Location = new System.Drawing.Point(6, 14);
            this.cbGenericAll.Name = "cbGenericAll";
            this.cbGenericAll.Size = new System.Drawing.Size(167, 17);
            this.cbGenericAll.TabIndex = 1;
            this.cbGenericAll.Text = "ADS_RIGHT_GENERIC_ALL";
            this.cbGenericAll.UseVisualStyleBackColor = true;
            // 
            // cbGenericRead
            // 
            this.cbGenericRead.AutoSize = true;
            this.cbGenericRead.Location = new System.Drawing.Point(6, 37);
            this.cbGenericRead.Name = "cbGenericRead";
            this.cbGenericRead.Size = new System.Drawing.Size(178, 17);
            this.cbGenericRead.TabIndex = 2;
            this.cbGenericRead.Text = "ADS_RIGHT_GENERIC_READ";
            this.cbGenericRead.UseVisualStyleBackColor = true;
            // 
            // cbGenericExecute
            // 
            this.cbGenericExecute.AutoSize = true;
            this.cbGenericExecute.Location = new System.Drawing.Point(6, 83);
            this.cbGenericExecute.Name = "cbGenericExecute";
            this.cbGenericExecute.Size = new System.Drawing.Size(198, 17);
            this.cbGenericExecute.TabIndex = 4;
            this.cbGenericExecute.Text = "ADS_RIGHT_GENERIC_EXECUTE";
            this.cbGenericExecute.UseVisualStyleBackColor = true;
            // 
            // lbAceType
            // 
            this.lbAceType.FormattingEnabled = true;
            this.lbAceType.Location = new System.Drawing.Point(87, 113);
            this.lbAceType.Name = "lbAceType";
            this.lbAceType.Size = new System.Drawing.Size(295, 21);
            this.lbAceType.TabIndex = 5;
            // 
            // lblGuid
            // 
            this.lblGuid.AutoSize = true;
            this.lblGuid.Location = new System.Drawing.Point(84, 81);
            this.lblGuid.Name = "lblGuid";
            this.lblGuid.Size = new System.Drawing.Size(55, 13);
            this.lblGuid.TabIndex = 4;
            this.lblGuid.Text = "<GUID...>";
            // 
            // lblSid
            // 
            this.lblSid.AutoSize = true;
            this.lblSid.Location = new System.Drawing.Point(84, 50);
            this.lblSid.Name = "lblSid";
            this.lblSid.Size = new System.Drawing.Size(46, 13);
            this.lblSid.TabIndex = 3;
            this.lblSid.Text = "<SID...>";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "GUID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "SID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 811);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ACECreator";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.gbSid.ResumeLayout(false);
            this.gbSid.PerformLayout();
            this.gbFlags.ResumeLayout(false);
            this.gbFlags.PerformLayout();
            this.gbRights.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAdUsername;
        private System.Windows.Forms.TextBox tbADPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearchFor;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.ComboBox lbResults;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox lbAceType;
        private System.Windows.Forms.Label lblGuid;
        private System.Windows.Forms.Label lblSid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbRights;
        private System.Windows.Forms.CheckBox cbWriteOwner;
        private System.Windows.Forms.CheckBox cbWriteDac;
        private System.Windows.Forms.CheckBox cbDelete;
        private System.Windows.Forms.CheckBox cbReadControl;
        private System.Windows.Forms.CheckBox cbGenericExecute;
        private System.Windows.Forms.CheckBox cbGenericWrite;
        private System.Windows.Forms.CheckBox cbGenericRead;
        private System.Windows.Forms.CheckBox cbGenericAll;
        private System.Windows.Forms.CheckBox cbSystemMandatoryLabelNoExecuteUp;
        private System.Windows.Forms.CheckBox cbSystemMandatoryLabelNoWriteUp;
        private System.Windows.Forms.CheckBox cbSystemMandatoryLabelNoReadUp;
        private System.Windows.Forms.CheckBox cbKeyExecute;
        private System.Windows.Forms.CheckBox cbKeyWrite;
        private System.Windows.Forms.CheckBox cbKeyRead;
        private System.Windows.Forms.CheckBox cbKeyAllAccess;
        private System.Windows.Forms.CheckBox cbFileGenericExecute;
        private System.Windows.Forms.CheckBox cbFileGenericWrite;
        private System.Windows.Forms.CheckBox cbFileGenericRead;
        private System.Windows.Forms.CheckBox cbFileAllAcess;
        private System.Windows.Forms.CheckBox cbAdsRightDsControlAccess;
        private System.Windows.Forms.CheckBox cbAdsRightDsDeleteTree;
        private System.Windows.Forms.CheckBox cbAdsRightDsListObject;
        private System.Windows.Forms.CheckBox cbAdsRightDsSelf;
        private System.Windows.Forms.CheckBox cbAdsRightActrlDsList;
        private System.Windows.Forms.CheckBox cbAdsRightDsDeleteChild;
        private System.Windows.Forms.CheckBox cbAdsRightDsCreateChild;
        private System.Windows.Forms.CheckBox cbAdsRightDsWriteProp;
        private System.Windows.Forms.CheckBox cbAdsRightDsReadProp;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox gbFlags;
        private System.Windows.Forms.CheckBox cbFailedAccessFlag;
        private System.Windows.Forms.CheckBox cbSuccessfulAccessAceFlag;
        private System.Windows.Forms.CheckBox cbInheritedAce;
        private System.Windows.Forms.CheckBox cbInheritOnlyAce;
        private System.Windows.Forms.CheckBox cbNoPropagateInherticAce;
        private System.Windows.Forms.CheckBox cbObjectInheritAce;
        private System.Windows.Forms.CheckBox cbContainerInheritAce;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbAccountSid;
        private System.Windows.Forms.TextBox tbInheritObjectGuid;
        private System.Windows.Forms.TextBox tbOjectGuid;
        private System.Windows.Forms.Label lblTotalResults;
        private System.Windows.Forms.ComboBox lbWellKnownTrustees;
        private System.Windows.Forms.RadioButton rbWellKnownTrustees;
        private System.Windows.Forms.RadioButton rbObjectSid;
        private System.Windows.Forms.GroupBox gbSid;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}

