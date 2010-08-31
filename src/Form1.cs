using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;
using System.Security.Principal;

namespace ACEGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lbAceType.DataSource = ACEContainer.retrieveACETYpes();
            lbWellKnownTrustees.DataSource = ACEContainer.retrieveACEWellKnownTrustees();

            EventHandler ev = new System.EventHandler(this.eventChanged);
            EventHandler evRadioChanged = new System.EventHandler(this.event_CheckedChanged);

            appendListenerToCheckboxesInGroupBox(gbFlags, ev);
            appendListenerToCheckboxesInGroupBox(gbRights, ev);
            tbAccountSid.LostFocus += ev;
            rbWellKnownTrustees.CheckedChanged += ev;
            rbObjectSid.CheckedChanged += ev;
            lbWellKnownTrustees.SelectedValueChanged += ev;
            tbInheritObjectGuid.LostFocus += ev;
            tbOjectGuid.LostFocus += ev;
            lbAceType.SelectedValueChanged += ev;
            rbObjectSid.CheckedChanged += evRadioChanged;
            rbWellKnownTrustees.CheckedChanged += evRadioChanged;
        }

        // Wird bei jedem Event aufgerufen, dass dafür sorgt, dass die ACE neu erstellt wird.
        // Delegiert an updateACE()
        private void eventChanged(object sender, System.EventArgs e)
        {
            updateACE();
        }


        // Erzeugt die ACE und schreibt das Ergebnis in die TextBox
        public void updateACE()
        {
            String r = "(";
            r += generateType();
            r += ";";
            r += generateFlags();
            r += ";";
            r += generateRights();
            r += ";";
            r += tbOjectGuid.Text;
            r += ";";
            r += tbInheritObjectGuid.Text;
            r += ";";
            r += generateSid();
            r += ")";

            tbResult.Text = r;
        }

        // Liefert entweder die SID zurück oder aber das Well-Known Trustee-Kürzel
        public String generateSid()
        {
            if (rbWellKnownTrustees.Checked)
            {
                return ((AceValuePair)lbWellKnownTrustees.SelectedItem).stringId;
            }

            return tbAccountSid.Text;
        }

        // Fügt den EventHandler zu allen Checkboxen bzw. GroupBoxen mit Checkboxen hinzu
        public void appendListenerToCheckboxesInGroupBox(GroupBox gb, EventHandler ev)
        {
            Control.ControlCollection checkboxes = gb.Controls;

            foreach (Control c in checkboxes)
            {
                if (typeof(GroupBox) == c.GetType())
                {
                    GroupBox gbInt = (GroupBox)c;
                    appendListenerToCheckboxesInGroupBox(gbInt, ev); 
                }
                else if (typeof(CheckBox) == c.GetType())
                {
                    CheckBox cb = (CheckBox)c;
                    cb.CheckedChanged += ev;
                }
            }
        }

        // Liefert den Typ zurück
        public String generateType()
        {
            String value = lbAceType.SelectedItem.ToString();

            AceValuePair avp = ACEContainer.findByValue(ACEContainer.retrieveACETYpes(), value);

            if (avp != null)
            {
                return avp.stringId;
            }

            return "";
        }

        // Erzeugt aus den Checkboxen bzw. Gruppen von Checkboxen einen zusammengebundenen String
        public String generateStringFromGroupBoxWithCheckBoxes(GroupBox gb, List<AceValuePair> _list)
        {
            Control.ControlCollection checkboxes = gb.Controls;
            String r = "";

            foreach (Control c in checkboxes)
            {
                if (typeof(GroupBox) == c.GetType()) 
                {
                    r += generateStringFromGroupBoxWithCheckBoxes((GroupBox)c, _list);
                }
                else if (typeof(CheckBox) == c.GetType())
                {
                    CheckBox cb = (CheckBox)c;

                    AceValuePair avo = ACEContainer.findByValue(_list, cb.Text);

                    if (avo != null && cb.Checked)
                    {
                        r += avo.stringId;
                    }
                }
            }

            return r;
        }

        // Erzeugt die Rechte
        public String generateRights()
        {
            return generateStringFromGroupBoxWithCheckBoxes(gbRights, ACEContainer.retrieveACERights());
        }

        // Erzeugt die Flags
        public String generateFlags()
        {
            return generateStringFromGroupBoxWithCheckBoxes(gbFlags, ACEContainer.retrieveACEFlags());
        }

        // Wird aufgerufen, sobald nach einem Benutzer gesucht werden soll
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbADPassword.Text.Length == 0 || tbAdUsername.Text.Length == 0 || tbServer.Text.Length == 0)
            {
                MessageBox.Show("You have to enter username, password and server for Active Directory");
                return;
            }

            if (tbSearchFor.Text.Length == 0)
            {
                MessageBox.Show("Enter at least one character for object searching");
                return;
            }

            try
            {
                DirectoryEntry de = new DirectoryEntry(tbServer.Text, tbAdUsername.Text, tbADPassword.Text);
                de.AuthenticationType = AuthenticationTypes.Secure;

                DirectorySearcher ds = new DirectorySearcher();
                ds.SearchRoot = de;
                // ANR power!
                ds.Filter = "(anr=" + tbSearchFor.Text + ")";

                SearchResultCollection results = ds.FindAll();

                lbResults.DataSource = null;
                lblTotalResults.Text = results.Count.ToString();
                List<ActiveDirectoryUser> list = ActiveDirectoryUser.toList(results);
                ActiveDirectoryUser dummyUser = new ActiveDirectoryUser(SELECT_DUMMY, "", "", "");

                list.Add(dummyUser);

                lbResults.DataSource = list;
                lbResults.SelectedItem = dummyUser;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Active Directory query failed: " + ex.Message);
            }
        }

        private void lbResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActiveDirectoryUser selected = (ActiveDirectoryUser)lbResults.SelectedItem;

            if (selected.name != SELECT_DUMMY)
            {
                tbAccountSid.Text = selected.sid;
                tbOjectGuid.Text = selected.guid;
                lblSid.Text = selected.sid;
                lblGuid.Text = selected.guid;
                gbSettings.Enabled = true;
                updateACE();
            }
            else
            {
                gbSettings.Enabled = false;
            }
        }

        public static String SELECT_DUMMY = "--- Select ---";

        private void event_CheckedChanged(object sender, EventArgs e)
        {
            bool bSidEnabled  = rbObjectSid.Checked;

            tbAccountSid.Enabled = bSidEnabled;
            rbObjectSid.Checked = bSidEnabled;
            rbWellKnownTrustees.Checked = !bSidEnabled;
            lbWellKnownTrustees.Enabled = !bSidEnabled;
        }

    }

    public class ActiveDirectoryUser
    {
        public String name;
        public String sid;
        public String guid;
        public String path;

        public ActiveDirectoryUser(String _name, String _guid, String _sid, String _path)
        {
            name = _name;
            sid = _sid;
            guid = _guid;
            path = _path;
        }

        public override String ToString()
        {
            return name;
        }

        public static List<ActiveDirectoryUser> toList(SearchResultCollection _src)
        {
            List<ActiveDirectoryUser> r = new List<ActiveDirectoryUser>();

            foreach (SearchResult sr in _src)
            {
                ResultPropertyValueCollection rpcObjectSid = sr.Properties["objectSid"];
                ResultPropertyValueCollection rpcDisplayName = sr.Properties["displayName"];
                ResultPropertyValueCollection rpcObjectGuid = sr.Properties["objectGUID"];

                String sid = "<unknown>";
                String displayName = "<unknown>";
                String guid = "<unknown>";

                if (rpcObjectSid.Count > 0)
                {
                    byte[] val = (byte[])rpcObjectSid[0];

                    sid = new SecurityIdentifier(val, 0).Value;
                }

                if (rpcDisplayName.Count > 0) {
                    displayName = rpcDisplayName[0].ToString();
                }

                if (rpcObjectGuid.Count > 0)
                {
                    byte[] val = (byte[])rpcObjectGuid[0];

                    guid = new Guid(val).ToString();
                }


                ActiveDirectoryUser adu = new ActiveDirectoryUser(displayName, guid, sid, sr.Path);
                r.Add(adu);
            }

            return r;
        }
    }

    public class AceValuePair
    {
        public String stringId;
        public String value;

        public AceValuePair(String _stringId, String _value)
        {
           stringId = _stringId;
           value = _value;
        }

        public override String ToString()
        {
            return value;
        }

    }

    public class ACEContainer
    {
        private static List<AceValuePair> listTypes;

        private static List<AceValuePair> listFlags;

        private static List<AceValuePair> listRights;

        private static List<AceValuePair> listWellKnownTrustees;

        public static AceValuePair findByValue(List<AceValuePair> _list, String _value)
        {
            foreach (AceValuePair avp in _list)
            {
                if (avp.value == _value)
                {
                    return avp;
                }
            }

            return null;
        }

        public static List<AceValuePair> retrieveACETYpes()
        {
            if (listTypes == null)
            {
                listTypes = new List<AceValuePair>();
                listTypes.Add(new AceValuePair("A", "ACCESS_ALLOWED_ACE_TYPE"));
                listTypes.Add(new AceValuePair("D", "ACCCESS_DENIED_ACE_TYPE"));
                listTypes.Add(new AceValuePair("OA", "ACCSESS_ALLOWED_OBJECT_ACE_TYPE"));
                listTypes.Add(new AceValuePair("OD", "ACCESS_DENIED_OBJECT_ACE_TYPE"));
                listTypes.Add(new AceValuePair("AU", "SYSTEM_AUDIT_ACE_TYPE"));
                listTypes.Add(new AceValuePair("AL", "SYSTEM_ALARM_ACE_TYPE"));
                listTypes.Add(new AceValuePair("OU", "SYSTEM_AUDIT_OBJECT_ACE_TYPE"));
                listTypes.Add(new AceValuePair("OL", "SYSTEM_ALARM_OBJECT_ACE_TYPE"));
                listTypes.Add(new AceValuePair("ML", "SYSTEM_MANDATORY_LABEL_ACE"));
            }

            return listTypes;
        }

        public static List<AceValuePair> retrieveACEFlags()
        {
            if (listFlags == null)
            {
                listFlags = new List<AceValuePair>();
                listFlags.Add(new AceValuePair("CI", "CONTAINER_INHERIT_ACE"));
                listFlags.Add(new AceValuePair("OI", "OBJECT_INHERIT_ACE"));
                listFlags.Add(new AceValuePair("NP", "NO_PROPAGATE_INHERIT_ACE"));
                listFlags.Add(new AceValuePair("IO", "INHERIT_ONLY_ACE"));
                listFlags.Add(new AceValuePair("ID", "INHERITED_ACE"));
                listFlags.Add(new AceValuePair("SA", "SUCCESSFUL_ACCESS_ACE_FLAG"));
                listFlags.Add(new AceValuePair("FA", "FAILED_ACCESS_ACE_FLAG"));
            }

            return listFlags;
        }

        public static List<AceValuePair> retrieveACERights()
        {
            if (listRights == null)
            {
                listRights = new List<AceValuePair>();
                listRights.Add(new AceValuePair("GA", "ADS_RIGHT_GENERIC_ALL"));
                listRights.Add(new AceValuePair("GR", "ADS_RIGHT_GENERIC_READ"));
                listRights.Add(new AceValuePair("GW", "ADS_RIGHT_GENERIC_WRITE"));
                listRights.Add(new AceValuePair("GX", "ADS_RIGHT_GENERIC_EXECUTE"));
                listRights.Add(new AceValuePair("RC", "ADS_RIGHT_READ_CONTROL"));
                listRights.Add(new AceValuePair("SD", "ADS_RIGHT_DELETE"));
                listRights.Add(new AceValuePair("WD", "ADS_RIGHT_WRITE_DAC"));
                listRights.Add(new AceValuePair("WO", "ADS_RIGHT_WRITE_OWNER"));
                listRights.Add(new AceValuePair("RP", "ADS_RIGHT_DS_READ_PROP"));
                listRights.Add(new AceValuePair("WP", "ADS_RIGHT_DS_WRITE_PROP"));
                listRights.Add(new AceValuePair("CC", "ADS_RIGHT_DS_CREATE_CHILD"));
                listRights.Add(new AceValuePair("DC", "ADS_RIGHT_DS_DELETE_CHILD"));
                listRights.Add(new AceValuePair("LC", "ADS_RIGHT_ACTRL_DS_LIST"));
                listRights.Add(new AceValuePair("SW", "ADS_RIGHT_DS_SELF"));
                listRights.Add(new AceValuePair("LO", "ADS_RIGHT_DS_LIST_OBJECT"));
                listRights.Add(new AceValuePair("DT", "ADS_RIGHT_DS_DELETE_TREE"));
                listRights.Add(new AceValuePair("CR", "ADS_RIGHT_DS_CONTROL_ACCESS"));
                listRights.Add(new AceValuePair("FA", "FILE_ALL_ACCESS"));
                listRights.Add(new AceValuePair("FR", "FILE_GENERIC_READ"));
                listRights.Add(new AceValuePair("FW", "FILE_GENERIC_WRITE"));
                listRights.Add(new AceValuePair("FX", "FILE_GENERIC_EXECUTE"));
                listRights.Add(new AceValuePair("KA", "KEY_ALL_ACCESS"));
                listRights.Add(new AceValuePair("KR", "KEY_READ"));
                listRights.Add(new AceValuePair("KW", "KEY_WRITE"));
                listRights.Add(new AceValuePair("KX", "KEY_EXECUTE"));
                listRights.Add(new AceValuePair("NR", "SYSTEM_MANDATORY_LABEL_NO_READ_UP"));
                listRights.Add(new AceValuePair("NW", "SYSTEM_MANDATORY_LABEL_NO_WRITE_UP"));
                listRights.Add(new AceValuePair("NX", "SYSTEM_MANDATORY_LABEL_NO_EXECUTE_UP"));
            }

            return listRights;
        }

        public static List<AceValuePair> retrieveACEWellKnownTrustees()
        {
            if (listWellKnownTrustees == null)
            {
                listWellKnownTrustees = new List<AceValuePair>();
                listWellKnownTrustees.Add(new AceValuePair("AO", "Account operators"));
                listWellKnownTrustees.Add(new AceValuePair("RU", "Alias to allow previos Windows 2000"));
                listWellKnownTrustees.Add(new AceValuePair("AN", "Anonymous logon"));
                listWellKnownTrustees.Add(new AceValuePair("AU", "Authenticated users"));
                listWellKnownTrustees.Add(new AceValuePair("BA", "Built-in administrators"));
                listWellKnownTrustees.Add(new AceValuePair("BG", "Built-in guests"));
                listWellKnownTrustees.Add(new AceValuePair("BO", "Backup operators"));
                listWellKnownTrustees.Add(new AceValuePair("BU", "Built-in users"));
                listWellKnownTrustees.Add(new AceValuePair("CA", "Certificate server administrators"));
                listWellKnownTrustees.Add(new AceValuePair("CG", "Creator group"));
                listWellKnownTrustees.Add(new AceValuePair("CO", "Creator owner"));
                listWellKnownTrustees.Add(new AceValuePair("DA", "Domain administrators"));
                listWellKnownTrustees.Add(new AceValuePair("DC", "Domain computers"));
                listWellKnownTrustees.Add(new AceValuePair("DD", "Domain controllers"));
                listWellKnownTrustees.Add(new AceValuePair("DG", "Domain guests"));
                listWellKnownTrustees.Add(new AceValuePair("DU", "Domain users"));
                listWellKnownTrustees.Add(new AceValuePair("EA", "Enterprise administrators"));
                listWellKnownTrustees.Add(new AceValuePair("ED", "Enterprise domain controllers"));
                listWellKnownTrustees.Add(new AceValuePair("WD", "Everyone"));
                listWellKnownTrustees.Add(new AceValuePair("PA", "Group Policy administrators"));
                listWellKnownTrustees.Add(new AceValuePair("IU", "Interactively logged-on user"));
                listWellKnownTrustees.Add(new AceValuePair("LA", "Local administrator"));
                listWellKnownTrustees.Add(new AceValuePair("LG", "Local guest"));
                listWellKnownTrustees.Add(new AceValuePair("LS", "Local service account"));
                listWellKnownTrustees.Add(new AceValuePair("SY", "Local system"));
                listWellKnownTrustees.Add(new AceValuePair("NU", "Network logon user"));
                listWellKnownTrustees.Add(new AceValuePair("NO", "Network configuration operators"));
                listWellKnownTrustees.Add(new AceValuePair("NS", "Network service account"));
                listWellKnownTrustees.Add(new AceValuePair("PO", "Printer operators"));
                listWellKnownTrustees.Add(new AceValuePair("PS", "Personal self"));
                listWellKnownTrustees.Add(new AceValuePair("PU", "Power users"));
                listWellKnownTrustees.Add(new AceValuePair("RS", "RAS servers group"));
                listWellKnownTrustees.Add(new AceValuePair("RD", "Terminal server users"));
                listWellKnownTrustees.Add(new AceValuePair("RE", "Replicator"));
                listWellKnownTrustees.Add(new AceValuePair("RC", "Restricted code"));
                listWellKnownTrustees.Add(new AceValuePair("SA", "Schema administrators"));
                listWellKnownTrustees.Add(new AceValuePair("SO", "Server operators"));
                listWellKnownTrustees.Add(new AceValuePair("SU", "Service logon user"));
            }

            return listWellKnownTrustees;
        }
    }
}