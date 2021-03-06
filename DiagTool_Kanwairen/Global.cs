﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagTool_Kanwairen
{
    public enum retstate
    { 
        OK, NOT_OK,
    }

    class Global
    {
        public static PassThruWrapper passThruWrapper = new PassThruWrapper();

        public static DiagUserControl diagUsercontrol = new DiagUserControl();
        public static FlashUserControl flashUsercontrol = new FlashUserControl();

        public static ImportForm importForm = new ImportForm();
        public static SetupForm setupForm = new SetupForm();
        public static TxPanelForm txPanelForm = new TxPanelForm();
        public static HexASCIIForm hexAsciiForm = new HexASCIIForm();
        public static NRCTableForm nrcTableForm = new NRCTableForm();
        public static ScriptForm scriptForm = new ScriptForm();
        public static DTCTestForm dtcTestForm = new DTCTestForm();
        public static ReadDTCForm readDTCForm = new ReadDTCForm();
        public static AboutForm aboutForm = new AboutForm();
        public static LicenseManagement licenseManagement = new LicenseManagement();

        public static Diag diag = new Diag();

        //public static MMTimer mmTimer = new MMTimer(txPanelForm.MMTimerCBFunc);
    }
}
