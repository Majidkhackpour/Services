using EntityCache.Sync;
using Services;
using System;
using System.Collections.Concurrent;
using System.Windows.Forms;

namespace WindowsSerivces.Sync
{
    public partial class FrmConnectionSyncStatus : Form
    {
        private static ConcurrentDictionary<string, FrmConnectionSyncStatus> _instances = new ConcurrentDictionary<string, FrmConnectionSyncStatus>();
        public SendData2ServerAggregator SendData2ServerInstance { get; private set; } = null;
        public FrmConnectionSyncStatus()
        {
            try
            {
                InitializeComponent();
                SendData2ServerInstance = new SendData2ServerAggregator(ucBuilding, ucBuildingAccountType, ucBuildingOptions
                    , ucBuildingRequest, ucBuildingType, ucBuildingView, ucBuildingReview, ucBuildingWindow, ucBuildingZoncan
                    , ucCities, ucRegions, ucDocumentType, ucFloorCover, ucKitchenService, ucPeopleGroup, ucPeoples
                    , ucRental, ucStates, ucUsers, ucBuildingCondition);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public static FrmConnectionSyncStatus GetInstance(string contextGuid)
        {
            try
            {
                if (_instances.TryGetValue(contextGuid, out var instance))
                    return instance;
                instance = new FrmConnectionSyncStatus();
                _instances.TryAdd(contextGuid, instance);
                return instance;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        private void FrmConnectionSyncStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }
    }
}
