using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Il2CppInterop.Runtime.Injection;
using MelonLoader;
using UnityAnalyticsBlocker.Modules;
using UnityEngine;

namespace UnityAnalyticsBlocker
{
    public class Boot : MelonPlugin
    {
        public override void OnLateInitializeMelon()
        {
            ClassInjector.RegisterTypeInIl2Cpp<BlockingHandler>();
            GameObject InjectionObject = new GameObject();
            InjectionObject.AddComponent<BlockingHandler>();
            UnityEngine.Object.DontDestroyOnLoad(InjectionObject);
            Util.Logger.Instance.Log("Initialized!", Util.Enums.LogType.Log);
        }
    }
}
