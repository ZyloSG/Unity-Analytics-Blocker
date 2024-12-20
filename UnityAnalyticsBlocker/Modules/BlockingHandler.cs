using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UnityAnalyticsBlocker.Modules
{
    internal class BlockingHandler : MonoBehaviour
    {
        public void Start()
        {
            MelonCoroutines.Start(DestroyAnalytics());
            DisableUnityAnalytics();
            Util.Logger.Instance.Log("Successfully removed analytics", Util.Enums.LogType.Log);
        }

        private System.Collections.IEnumerator DestroyAnalytics()
        {
            while (GameObject.Find("GameAnalytics") == null) yield return null;
            DestroyImmediate(GameObject.Find("GameAnalytics"));

            while (GameObject.Find("AnalyticsContainer") == null) yield return null;
            DestroyImmediate(GameObject.Find("AnalyticsContainer"));
        }

        public void DisableUnityAnalytics()
        {
            UnityEngine.Analytics.Analytics.enabled = false;
            UnityEngine.Analytics.Analytics.enabledInternal = false;
            UnityEngine.Analytics.Analytics.initializeOnStartup = false;
            UnityEngine.Analytics.Analytics.initializeOnStartupInternal = false;
            UnityEngine.Analytics.Analytics.deviceStatsEnabled = false;
            UnityEngine.Analytics.Analytics.deviceStatsEnabledInternal = false;
            UnityEngine.Analytics.Analytics.limitUserTracking = true;
            UnityEngine.Analytics.Analytics.limitUserTrackingInternal = true;
            UnityEngine.Analytics.PerformanceReporting.enabled = false;
        }
    }
}

